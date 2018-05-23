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
using HunterGuide.EF.Entities;

namespace HunterGuide.Forms.ClientUI
{
    public partial class TimeResultForm : MetroForm
    {
        private readonly IMapper mapper;
        private readonly EF.ApplicationContext context;

        public TimeResultForm(Guid testResultId)
        {
            mapper = AutoMapperProvider.GetIMapper();
            context = ContextProvider.GetApplicationContext();

            InitializeComponent();

            SetFields(testResultId);
        }

        private void SetFields(Guid testResultId) 
        {
            var testResult = context.UserTestsResults.FirstOrDefault(r => r.Id == testResultId);

            var mappedResult = MapModel(testResult);

            TestNameLable.Text = mappedResult.TestName;
            TestTypeLable.Text = mappedResult.TestType;
            MarkLabel.Text = mappedResult.Mark.ToString();
            
        }

        private UserResultModel MapModel(UserTestResult result) 
        {
            var mappedResult = mapper.Map<UserResultModel>(result);
            var test = context.Tests.FirstOrDefault(t => t.Id == result.TestId);

            mappedResult.Username = context.Users.FirstOrDefault(u => u.Id == result.ApplicationUserId).Username;
            mappedResult.TestName = test.Name;
            mappedResult.TestType = context.TestTypes.FirstOrDefault(t => t.Id == test.TestTypeId).TypeName;

            return mappedResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
