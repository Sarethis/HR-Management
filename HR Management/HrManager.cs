using HR_Management.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HR_Management
{
    public partial class HrManagerForm : Form
    {
        private FileHelper<List<Employee>> _fileHelperE = new FileHelper<List<Employee>>(Program.pathEmployes);
        private FileHelper<List<User>> _fileHelperU = new FileHelper<List<User>>(Program.pathUsers);
        private List<Position> _positions;
        private List<AccountLevel> _accountLevels;
        private int _userLogedId;
        private User _user;
        private int _userLevel;

        public bool IsMaximized 
        {
            get
            {
                return Settings.Default.IsMainWindowMaximize;
            }
            set
            {
                Settings.Default.IsMainWindowMaximize = value;
            }
        }

        public HrManagerForm(int userLogedId)
        {
            InitializeComponent();
            _userLogedId = userLogedId;
            _user = InitUserLogged();
            _userLevel = _user.IdAccountLevel;
            _accountLevels = AccountLevel.GetAccountLevel();
            InitAccountLevelTextBox(_user);
            
            RefreshHrManager();
            SetColumnsHeaders();

            if (_userLevel == 0)
            {
                btnFireEmploye.Hide();
                btnAddEmploye.Hide();
                btnEditEmploye.Hide();
            }
                
            _positions = Position.GetPosition("All Employes");
            InitPositionsComboBox();

            if (IsMaximized)
            WindowState = FormWindowState.Maximized;
        }

        private User InitUserLogged()
        {
            var users = _fileHelperU.DeserializeFromFileXML();
            return users.First(x => x.Id == _userLogedId);
        }

        private void InitAccountLevelTextBox(User user)
        {
            txbAccountLevel.Text = _accountLevels.First(x => x.Id == _userLevel).Name;
            txbLoggedUser.Text = user.Name;
        }

        private void SetColumnsHeaders()
        {
            dgvEmployes.Columns[nameof(Employee.Id)].HeaderText = "Employee ID";
            dgvEmployes.Columns[nameof(Employee.FName)].HeaderText = "First Name";
            dgvEmployes.Columns[nameof(Employee.SName)].HeaderText = "Second Name";
            dgvEmployes.Columns[nameof(Employee.Salary)].HeaderText = "Salary[EUR]";
            dgvEmployes.Columns[nameof(Employee.EmploymentStartDate)].HeaderText = "Employment start date";
            dgvEmployes.Columns[nameof(Employee.EmploymentEndDate)].HeaderText = "Employment end date";
            dgvEmployes.Columns[nameof(Employee.Dissmised)].HeaderText = "Employee dissmised";
            dgvEmployes.Columns[nameof(Employee.Comments)].HeaderText = "Comments";
            dgvEmployes.Columns[nameof(Employee.IdPosition)].Visible = false;
        }

        private void InitPositionsComboBox()
        {
            cmbEmployePosition.DataSource = _positions;
            cmbEmployePosition.DisplayMember = "Name";
            cmbEmployePosition.ValueMember = "Id";
        }
        private void RefreshHrManager()
        {
            var employes = _fileHelperE.DeserializeFromFile();
            employes = employes.OrderBy(x => x.Id).ToList();
            dgvEmployes.DataSource = employes;
        }

        private void AddEditEmployee_FormClosing(object Sender, EventArgs e)
        {
            RefreshHrManager();
            RefreshHrManagerPositions();
        }

        private void RefreshHrManagerPositions()
        {
            var employes = _fileHelperE.DeserializeFromFile();
            var selectedPosition = (cmbEmployePosition.SelectedItem as Position).Id;

            if (selectedPosition == 0)
                employes = employes.OrderBy(x => x.Id).ToList();
            else
                employes = employes.FindAll(x => x.IdPosition == selectedPosition);

            dgvEmployes.DataSource = employes;
        }

        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void btnEditEmploye_Click(object sender, EventArgs e)
        {
            if (dgvEmployes.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Employee has been selected.", "Unknown employee");
                return;
            }
            var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvEmployes.SelectedRows[0].Cells[0].Value));
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();

        }

        private void btnFireEmploye_Click(object sender, EventArgs e)
        {
            if (dgvEmployes.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Employee has been selected.", "Unknown employee");
                return;
            }
            if (Convert.ToBoolean(dgvEmployes.SelectedRows[0].Cells[6].Value))
            {
                MessageBox.Show("This Employee is already dismissed.", "Dismissing error");
                return;
            }

            var employes = _fileHelperE.DeserializeFromFile();
            var employeeSelected = dgvEmployes.SelectedRows[0];
            var confirmFire = MessageBox.Show($"Are you sure that you want to dissmis {employeeSelected.Cells[1].Value.ToString().Trim()} " +
                $"{employeeSelected.Cells[2].Value.ToString().Trim()}?", "Dissmising Employee", MessageBoxButtons.OKCancel);
            if (confirmFire == DialogResult.OK)
            {
                FireEmploye(Convert.ToInt32(employeeSelected.Cells[0].Value));
            }
            RefreshHrManager();
        }

        private void FireEmploye(int id)
        {
            var employes = _fileHelperE.DeserializeFromFile();
            var employe = employes.FirstOrDefault(x => x.Id == id);
            employe.Dissmised = true;
            employe.EmploymentEndDate = DateTime.Now;
            _fileHelperE.SerializeToFile(employes);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshHrManagerPositions();
        }

        private void HrManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximized = true;
            else
                IsMaximized = false;
            Settings.Default.Save();
        }
    }
}
