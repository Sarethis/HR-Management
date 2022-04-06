using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HR_Management
{
    public partial class AddEditEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelperE = new FileHelper<List<Employee>>(Program.pathEmployes);
        private FileHelper<List<User>> _fileHelperU = new FileHelper<List<User>>(Program.pathUsers);
        private List<Position> _positions;
        private Employee _employee;
        private int _employeeId;
        public AddEditEmployee(int employeeId = 0)
        {
            InitializeComponent();
            _employeeId = employeeId;
            ckbFireEmployee.Hide();
            dtpEmploymentEnd.Hide();
            lbEndDate.Hide();

            _positions = Position.GetPosition();
            InitPositionComboBox();

            GetEmployeeData();

            if (_employeeId != 0 && _employee.Dissmised)
            {
                dtpEmploymentEnd.Show();
                lbEndDate.Show();
            }

            txbFName.Select();
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                this.Text = "Editing Employee";
                var employes = _fileHelperE.DeserializeFromFile();
                _employee = employes.FirstOrDefault(x => x.Id == _employeeId);
                if (_employee == null)
                    throw new Exception("No such Employee");
                FillTextBox();
            }
        }

        private void InitPositionComboBox()
        {
            cmbPosition.DataSource = _positions;
            cmbPosition.DisplayMember = "Name";
            cmbPosition.ValueMember = "Id";
        }

        private void AssignIdToNewEmployee (List<Employee> employes)
        {
            var employeWithHighestId = employes.OrderByDescending(x => x.Id).FirstOrDefault();
            if (employeWithHighestId == null)
                _employeeId = 1;
            else
                _employeeId = employeWithHighestId.Id + 1;
        }

        private bool AddEmployee(List<Employee> employes)
        {
            if (!double.TryParse(txbSalary.Text, out double salary))
                throw new Exception("Please enter numeric value in Salary text box.");
            else
            {
                var employee = new Employee
                {
                    Id = _employeeId,
                    FName = txbFName.Text,
                    SName = txbSName.Text,
                    Salary = salary,
                    IdPosition = (cmbPosition.SelectedItem as Position).Id,
                    EmploymentStartDate = dtpEmploymentStart.Value,
                    EmploymentEndDate = dtpEmploymentEnd.Value,
                    Dissmised = ckbFireEmployee.Checked,
                    Comments = rtbComments.Text
                };
                if (!ckbFireEmployee.Checked)
                    employee.EmploymentEndDate = Convert.ToDateTime(null);

                employes.Add(employee);
                return true;
            }
        }

        private void FillTextBox()
        {
            txbID.Text = _employeeId.ToString();
            txbFName.Text = _employee.FName;
            txbSName.Text = _employee.SName;
            txbSalary.Text = _employee.Salary.ToString();
            rtbComments.Text = _employee.Comments;
            cmbPosition.SelectedItem = _positions.FirstOrDefault(x => x.Id == _employee.IdPosition);
            dtpEmploymentStart.Value = _employee.EmploymentStartDate;
            ckbFireEmployee.Checked = _employee.Dissmised;
            if(_employee.Dissmised)
                dtpEmploymentEnd.Value = _employee.EmploymentEndDate;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var employes = _fileHelperE.DeserializeFromFile();

            if (_employeeId != 0)
                employes.RemoveAll(x => x.Id == _employeeId);
            else
                AssignIdToNewEmployee(employes);
            try
            {
                AddEmployee(employes);
                _fileHelperE.SerializeToFile(employes);
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error input data");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
