using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HR_Management
{
    public partial class CreateUserForm : Form
    {
        private FileHelper<List<User>> _fileHelper = new FileHelper<List<User>>(Program.pathUsers);
        private int _userId;
        private List<AccountLevel> _accountLevels;
        
        public CreateUserForm(int id = 0)
        {
            InitializeComponent();
            _userId = id;
            _accountLevels = AccountLevel.GetAccountLevel();
            InitAccountLevels();
        }

        private void InitAccountLevels()
        {
            cmbAccountLevel.DataSource = _accountLevels;
            cmbAccountLevel.DisplayMember = "Name";
            cmbAccountLevel.ValueMember = "Id";
        }

        private bool CreateUser()
        {
            var users = _fileHelper.DeserializeFromFileXML();
            if (CheckIfUserIsNotRegistered(users))
            {
                AssignIdToNewUser(users);
                AddNewUserToList(users);
                _fileHelper.SerializeToFileXML(users);
                return true;
            }
            return false;
        }

        private bool CheckIfUserIsNotRegistered(List<User> users)
        {
            if (users.Any(x => x.Name == txbLoginName.Text))
            {
                MessageBox.Show("User with that login already exist, please pick another one.", "User login error");
                return false;
            }
            else
                return true;
        }

        private void AddNewUserToList(List<User> users)
        {
            var user = new User
            {
                Id = _userId,
                Name = txbLoginName.Text,
                Password = StringCipher.Encrypt(txbPassword.Text, Program.passwordHashKey),
                IdAccountLevel = (cmbAccountLevel.SelectedItem as AccountLevel).Id,
            };

            users.Add(user);
        }
        private void AssignIdToNewUser(List<User> users)
        {
            var userWithHighestId = users.OrderByDescending(x => x.Id).FirstOrDefault();
            if (userWithHighestId == null)
                _userId = 1;
            else
                _userId = userWithHighestId.Id + 1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValuesChecker())
                return;

            if (CreateUser())
                Close();
        }

        private bool ValuesChecker ()
        {
            if (string.IsNullOrWhiteSpace(txbLoginName.Text) || string.IsNullOrWhiteSpace(txbPassword.Text) || string.IsNullOrWhiteSpace(txbPasswordAgain.Text))
            {
                MessageBox.Show("Please enter proper values in every text box.", "Text boxes nulls");
                return false;
            }
            else if (!(txbPassword.Text == txbPasswordAgain.Text))
            {
                MessageBox.Show("Password dosn't mach! Please correct and continue.", "Creating password error");
                return false;
            }
            else
                return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
