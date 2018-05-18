using HunterGuide.EF.Entities;
using HunterGuide.Helpers.Emums;
using HunterGuide.Singletons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace HunterGuide.Forms.AdminUI 
{
    public partial class ManageUsersForm : Form
    {
        private readonly EF.ApplicationContext context;

        private Func<string, List<ApplicationUser>> updateFunc;
        private List<ApplicationUser> users;
        private ManageUsersFormType formType;

        public ManageUsersForm(ManageUsersFormType formType)
        {
            InitializeComponent();
            context = ContextProvider.GetApplicationContext();

            this.formType = formType;
            ChangeFormType(formType);

            users = updateFunc(string.Empty);
            RenderListView();
        }

        private void ChangeFormType(ManageUsersFormType formType) 
        {
            if (formType == ManageUsersFormType.ManageNotActivatedUsers) 
            {
                updateFunc = (searchString) => context.Users.Where(u => 
                        !u.IsActivated &&
                        u.Username.Contains(searchString) &&
                        u.FirstName.Contains(searchString) &&
                        u.LastName.Contains(searchString)
                    ).ToList();
                ActivateButton.Visible = true;
                NotActivatedUsersRadioButton.Checked = true;
                return;
            }
            if (formType == ManageUsersFormType.ManageActivatedUsers) 
            {
                updateFunc = (searchString) => {
                    var adminRoleId = context.Roles.FirstOrDefault(r => r.RoleName.Equals("Admin")).Id;
                    return context.Users.Where(u => 
                        u.IsActivated && 
                        u.RoleId != adminRoleId &&
                        u.Username.Contains(searchString) &&
                        u.FirstName.Contains(searchString) &&
                        u.LastName.Contains(searchString)
                    ).ToList();
                };
                ActivateButton.Visible = false;
                ActivatedUsersRadioButton.Checked = true;
                return;
            }
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            List<ApplicationUser> selectedItems = GetSelectedItems();

            selectedItems = UpdateQueryThroughUsers(selectedItems, u => { u.IsActivated = true; u.IsRejected = false; return u; });

            UpdateUsersInDatabase(selectedItems);

            users = updateFunc(SearchBox.Text);

            RenderListView();
        }

        private void RejectButton_Click(object sender, EventArgs e) 
        {
            List<ApplicationUser> selectedItems = GetSelectedItems();

            selectedItems = UpdateQueryThroughUsers(selectedItems, u => { u.IsActivated = false; u.IsRejected = true; return u; });

            UpdateUsersInDatabase(selectedItems);

            users = updateFunc(SearchBox.Text);

            RenderListView();
        }

        private List<ApplicationUser> GetSelectedItems()
        {
            List<ApplicationUser> selectedItems = new List<ApplicationUser>();

            foreach (var item in UsersListBox.CheckedItems) 
            {
                string itemText = item as string;
                var user = users.FirstOrDefault(u => itemText.Contains(string.Format("Username: {0}", u.Username)));
                if (user != null) 
                {
                    selectedItems.Add(user);
                }
            }
            return selectedItems;
        }

        private void UpdateUsersInDatabase(List<ApplicationUser> users) 
        {
            foreach (var user in users) 
            {
                context.Users.AddOrUpdate(user);
            }
            context.SaveChanges();
        }

        private List<ApplicationUser> UpdateQueryThroughUsers(List<ApplicationUser> itemsToUpdate, Func<ApplicationUser, ApplicationUser> updateFunc) 
        {
            return itemsToUpdate.Select(u => updateFunc(u)).ToList();
        }

        private void RenderListView() 
        {
            UsersListBox.Items.Clear();

            foreach (var user in users) 
            {
                var rejectedMessage = string.Empty;
                if (user.IsRejected) 
                {
                    rejectedMessage = " --- Rejected!";
                }
                UsersListBox.Items.Insert(0, string.Format("Username: {0}; FullName: {1}, {2} {3}", user.Username, user.LastName, user.FirstName, rejectedMessage));
            }
        }

        private void CloseButton_Click(object sender, EventArgs e) 
        {
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                return;
            }
            users = updateFunc(SearchBox.Text);
            RenderListView();
        }

        private void DropButton_Click(object sender, EventArgs e) 
        {
            SearchBox.Text = string.Empty;
            users = updateFunc(string.Empty);
            RenderListView();
        }

        private void NotActivatedUsersRadioButton_CheckedChanged(object sender, EventArgs e) 
        {
            if (NotActivatedUsersRadioButton.Checked) 
            {
                formType = ManageUsersFormType.ManageNotActivatedUsers;
                this.Text = "Manage not activated or rejected users";
                ChangeFormType(formType);
                SearchBox.Text = string.Empty;
                users = updateFunc(string.Empty);
                RenderListView();
            }
        }

        private void ActivatedUsersRadioButton_CheckedChanged(object sender, EventArgs e) 
        {
            if (ActivatedUsersRadioButton.Checked) {
                formType = ManageUsersFormType.ManageActivatedUsers;
                this.Text = "Manage users";
                ChangeFormType(formType);
                SearchBox.Text = string.Empty;
                users = updateFunc(string.Empty);
                RenderListView();
            }
        }
    }
}
