using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using HunterGuide.Singletons;
using AutoMapper;
using HunterGuide.Models;
using System.Collections.ObjectModel;
using HunterGuide.EF.Entities;

namespace HunterGuide.Forms.ClientUI
{
    public partial class UserResultsForm : MetroForm
    {
        private readonly IMapper mapper;
        private readonly EF.ApplicationContext context;

        public UserResultsForm(Guid userId)
        {
            InitializeComponent();

            mapper = AutoMapperProvider.GetIMapper();
            context = ContextProvider.GetApplicationContext();

            FillUserResultsGrid(userId);
        }

        private void FillUserResultsGrid(Guid userId) 
        {
            var userResults = context.UserTestsResults.Where(u => u.ApplicationUserId == userId).ToList();

            var mappedResults = MapUserResults(userResults);

            UserResultsDataGrid.DataSource = new ObservableCollection<UserResultModel>(mappedResults);
        }

        private List<UserResultModel> MapUserResults(List<UserTestResult> results)
        {
            return results.Select(r => {
                var mappedResult = mapper.Map<UserResultModel>(r);
                var test = context.Tests.FirstOrDefault(t => t.Id == r.TestId);

                mappedResult.Username = context.Users.FirstOrDefault(u => u.Id == r.ApplicationUserId).Username;
                mappedResult.TestName = test.Name;
                mappedResult.TestType = context.TestTypes.FirstOrDefault(t => t.Id == test.TestTypeId).TypeName;

                return mappedResult;
            }).ToList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
