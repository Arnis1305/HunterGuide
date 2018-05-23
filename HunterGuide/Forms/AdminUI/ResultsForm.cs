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
using AutoMapper;
using HunterGuide.Singletons;
using System.Collections.ObjectModel;
using HunterGuide.Models;
using HunterGuide.EF.Entities;

namespace HunterGuide.Forms.AdminUI
{
    public partial class ResultsForm : MetroForm
    {
        private readonly IMapper mapper;
        private readonly EF.ApplicationContext context;

        public ResultsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            mapper = AutoMapperProvider.GetIMapper();
            context = ContextProvider.GetApplicationContext();

            FillUserResultsGrid(string.Empty);
        }

        private void FillUserResultsGrid(string searchString) 
        {
            var userResults = context.UserTestsResults.Where(u => u.ApplicationUser.Username.Contains(searchString)).ToList();

            var mappedResults = MapUserResults(userResults);

            UsersResultsDataGrid.DataSource = new ObservableCollection<UserResultModel>(mappedResults);
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

        private void SearchButton_Click(object sender, EventArgs e) 
        {
            var searchString = SearchBox.Text;
            if (!string.IsNullOrEmpty(searchString)) 
            {
                FillUserResultsGrid(searchString);
            }
        }
    }
}
