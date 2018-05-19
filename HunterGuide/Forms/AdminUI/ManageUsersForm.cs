using HunterGuide.EF.Entities;
using HunterGuide.Helpers.Emums;
using HunterGuide.Singletons;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace HunterGuide.Forms.AdminUI 
{
    public partial class ManageUsersForm : MetroForm
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
        }

        private void ChangeFormType(ManageUsersFormType formType) 
        {
            if (formType == ManageUsersFormType.ManageNotActivatedUsers) 
            {
                updateFunc = GetUpdateFuncForManagingNotActivatedUsers();

                SetDefaultValueToUserRolesComboBox();
                UserRolesComboBox.Enabled = false;

                ActivateButton.Visible = true;
                ChangeRoleButton.Visible = false;
                RejectButton.Visible = true;
                NotActivatedUsersRadioButton.Checked = true;
                TargetRoleLable.Visible = false;
                TargetRoleComboBox.Visible = false;
                return;
            }
            if (formType == ManageUsersFormType.ManageActivatedUsers) 
            {
                updateFunc = GetUpdateFuncForManagingActivatedUsers();

                SetDefaultValueToUserRolesComboBox();
                UserRolesComboBox.Enabled = false;

                ActivateButton.Visible = false;
                ChangeRoleButton.Visible = false;
                RejectButton.Visible = true;
                TargetRoleComboBox.Visible = false;
                TargetRoleLable.Visible = false;
                ActivatedUsersRadioButton.Checked = true;
                return;
            }
            if (formType == ManageUsersFormType.ManageUserRoles) 
            {
                updateFunc = GetUpdateFuncForManagingUserRoles();

                SetItemsInUserRolesComboBox();

                UserRolesComboBox.Enabled = true;
                ActivateButton.Visible = false;
                ChangeRoleButton.Visible = true;
                RejectButton.Visible = false;
                TargetRoleComboBox.Visible = true;
                TargetRoleLable.Visible = true;
                UserRolesRadioButton.Checked = true;
                return;
            }
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            List<ApplicationUser> selectedItems = GetSelectedItems();

            selectedItems = UpdateQueryThroughUsers(selectedItems, u => { u.StatusType = (int)UserStatusType.Activated; return u; });

            UpdateUsersInDatabase(selectedItems);

            users = updateFunc(SearchBox.Text);

            RenderListView();
        }

        private void RejectButton_Click(object sender, EventArgs e) 
        {
            List<ApplicationUser> selectedItems = GetSelectedItems();

            selectedItems = UpdateQueryThroughUsers(selectedItems, u => { u.StatusType = (int)UserStatusType.Rejected; return u; });

            UpdateUsersInDatabase(selectedItems);

            users = updateFunc(SearchBox.Text);

            RenderListView();
        }

        private void ChangeRoleButton_Click(object sender, EventArgs e) 
        {
            List<ApplicationUser> selectedItems = GetSelectedItems();

            string roleName = TargetRoleComboBox.SelectedItem as string;

            var role = context.Roles.FirstOrDefault(r => r.RoleName.Equals(roleName));

            selectedItems = UpdateQueryThroughUsers(selectedItems, u => { u.RoleId = role.Id; return u; });

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
                if (user.StatusType == (int)UserStatusType.Rejected) 
                {
                    rejectedMessage = " --- Rejected!";
                }
                UsersListBox.Items.Insert(0, string.Format("Username: {0}; FullName: {1}, {2} {3}", user.Username, user.LastName, user.FirstName, rejectedMessage));
            }
        }

        private void SetDefaultValueToUserRolesComboBox() 
        {
            UserRolesComboBox.Items.Clear();
            UserRolesComboBox.Items.Add("Only users");
            UserRolesComboBox.SelectedIndex = 0;
        }

        private void SetItemsInUserRolesComboBox() 
        {
            var roles = context.Roles.ToList();
            UserRolesComboBox.Items.Clear();
            UserRolesComboBox.Items.AddRange(roles.Select(r => r.RoleName).ToArray());
            UserRolesComboBox.SelectedIndex = 0;
        }

        private void UpdateTargetRoleComboBox() 
        {
            var roles = context.Roles.ToList();
            string currentRoleName = UserRolesComboBox.SelectedItem as string;
            TargetRoleComboBox.Items.Clear();
            TargetRoleComboBox.Items.AddRange(roles.Select(r => r.RoleName).Where(n => !n.Equals(currentRoleName)).ToArray());
            TargetRoleComboBox.SelectedIndex = 0;
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
            if (ActivatedUsersRadioButton.Checked) 
            {
                formType = ManageUsersFormType.ManageActivatedUsers;
                this.Text = "Manage users";
                ChangeFormType(formType);
                SearchBox.Text = string.Empty;
                users = updateFunc(string.Empty);
                RenderListView();
            }
        }

        private void UserRolesRadioButton_CheckedChanged(object sender, EventArgs e) 
        {
            if (UserRolesRadioButton.Checked) {
                formType = ManageUsersFormType.ManageUserRoles;
                this.Text = "Manage user roles";
                ChangeFormType(formType);
                SearchBox.Text = string.Empty;
                users = updateFunc(string.Empty);
                RenderListView();
            }
        }

        private void UserRolesComboBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            SearchBox.Text = string.Empty;
            users = updateFunc(string.Empty);
            UpdateTargetRoleComboBox();
            RenderListView();
        }

        private Func<string, List<ApplicationUser>> GetUpdateFuncForManagingNotActivatedUsers() 
        {
            return (searchString) => context.Users.Where(u =>
                u.StatusType != (int)UserStatusType.Activated &&
                u.Username.Contains(searchString) &&
                u.FirstName.Contains(searchString) &&
                u.LastName.Contains(searchString)
            ).ToList();
        }

        private Func<string, List<ApplicationUser>> GetUpdateFuncForManagingActivatedUsers() 
        {
            return (searchString) => {
                var adminRoleId = context.Roles.FirstOrDefault(r => r.RoleName.Equals("Admin")).Id;

                return context.Users.Where(u =>
                    u.StatusType == (int)UserStatusType.Activated &&
                    u.RoleId != adminRoleId &&
                    u.Username.Contains(searchString) &&
                    u.FirstName.Contains(searchString) &&
                    u.LastName.Contains(searchString)
                ).ToList();
            };
        }

        private Func<string, List<ApplicationUser>> GetUpdateFuncForManagingUserRoles() 
        {
            return (searchString) => {
                string roleName = UserRolesComboBox.SelectedItem as string;
                var role = context.Roles.FirstOrDefault(r => r.RoleName.Equals(roleName));

                return context.Users.Where(u =>
                    u.RoleId == role.Id &&
                    u.StatusType == (int)UserStatusType.Activated &&
                    u.Username.Contains(searchString) &&
                    u.FirstName.Contains(searchString) &&
                    u.LastName.Contains(searchString)
                ).ToList();
            };
        }
    }
}
