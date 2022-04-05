using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HR_Management
{
    public partial class LoginWindowForm : Form
    {
        private FileHelper<List<User>> _fileHelper = new FileHelper<List<User>>(Program.pathUsers);
        private int _userLogedId;
        public LoginWindowForm()
        {
            InitializeComponent();
        }

        private bool Login()
        {
            var users = _fileHelper.DeserializeFromFileXML();
            if (!ValuesChecker())
                return false;
            var userLoginFinded = users.FirstOrDefault(x => x.Name == txbLoginName.Text);
            if (userLoginFinded == null)
            {
                MessageBox.Show("There is no such user with that login. Create one.", "No user error");
                return false;
            }
            if (userLoginFinded.Name == txbLoginName.Text && StringCipher.Decrypt(userLoginFinded.Password, Program.passwordHashKey) == txbPassword.Text)
            {
                _userLogedId = userLoginFinded.Id;
                return true;
            }
            else
            {
                MessageBox.Show("No user or wrong login or password. Try again.", "Login/password error");
                return false;
            }
        }
        private bool ValuesChecker()
        {
            if (txbLoginName.Text == "" || txbPassword.Text == "")
            {
                MessageBox.Show("Please enter proper values in every text box.", "Text boxes nulls");
                return false;
            }
            else
                return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                var hrManager = new HrManagerForm(_userLogedId);
                hrManager.ShowDialog();
            }

        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            var createUser = new CreateUserForm();
            createUser.ShowDialog();
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            txbPassword.Clear();
        }
    }
}
