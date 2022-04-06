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
            ValuesChecker();

            var users = _fileHelper.DeserializeFromFileXML();
            var userLoginFinded = users.FirstOrDefault(x => x.Name == txbLoginName.Text);

            if (userLoginFinded == null)
                throw new Exception("There is no such user with that login. Create one.");
            if (userLoginFinded.Name == txbLoginName.Text && StringCipher.Decrypt(userLoginFinded.Password, Program.passwordHashKey) == txbPassword.Text)
            {
                _userLogedId = userLoginFinded.Id;
                return true;
            }
            else
                throw new Exception("No user or wrong login or password. Try again.");
        }
        private void ValuesChecker()
        {
            if (txbLoginName.Text == "" || txbPassword.Text == "")
                throw new Exception("Please enter proper values in every text box.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
                var hrManager = new HrManagerForm(_userLogedId);
                hrManager.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error loging in");
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
