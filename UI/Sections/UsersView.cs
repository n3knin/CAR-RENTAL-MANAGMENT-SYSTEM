using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RentalApp.Data.Repositories;
using RentalApp.Models.Users;
using RentalApp.UI.Popups;

namespace RentalApp.UI.Sections
{
    public partial class UsersView : UserControl
    {
        private UserRepository _userRepository;
        private List<User> _allUsers;

        public UsersView()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            
            // Layout
            usersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            filterComboBox.SelectedIndex = 0;
            
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                _allUsers = _userRepository.GetAll();
                UpdateGrid(_allUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void UpdateGrid(List<User> list)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = list;

            usersGrid.DataSource = null;
            usersGrid.AutoGenerateColumns = true;
            usersGrid.DataSource = bindingSource;
            usersGrid.ReadOnly = true;

            // Hide sensitive columns
            if (usersGrid.Columns["PasswordHash"] != null) usersGrid.Columns["PasswordHash"].Visible = false;
            
            if (usersGrid.Columns["Id"] != null) usersGrid.Columns["Id"].Visible = false;
            if (usersGrid.Columns["Firstname"] != null) usersGrid.Columns["Firstname"].HeaderText = "First Name";
            if (usersGrid.Columns["Lastname"] != null) usersGrid.Columns["Lastname"].HeaderText = "Last Name";
            if (usersGrid.Columns["Role"] != null) usersGrid.Columns["Role"].HeaderText = "Role";
            if (usersGrid.Columns["Status"] != null) usersGrid.Columns["Status"].HeaderText = "Status";
            
            usersGrid.Refresh();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_allUsers == null) return;

            string filter = filterComboBox.SelectedItem?.ToString();
            List<User> filteredList = new List<User>();

            switch (filter)
            {
                case "Admin":
                case "Manager":
                case "RentalAgent":
                    filteredList = _allUsers.FindAll(u => u.GetRoleName() == filter);
                    break;
                case "All Users":
                default:
                    filteredList = _allUsers;
                    break;
            }

            UpdateGrid(filteredList);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddUserSimple())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (usersGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var selectedUser = (User)usersGrid.CurrentRow.DataBoundItem;
            
            var confirmResult = MessageBox.Show($"Are you sure you want to deactivate user '{selectedUser.Username}'?",
                                     "Confirm Deactivation",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _userRepository.Delete(selectedUser.Id);
                    LoadUsers();
                    MessageBox.Show("User deactivated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        private void UsersView_Load(object sender, EventArgs e)
        {

        }
    }
}
