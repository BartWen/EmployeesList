using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesList
{
    public partial class AddEditList : Form
    {
        private int _employeesID;

        public Employees _employees;

        private FIleUpload<List<Employees>> _fIleUpload = new FIleUpload<List<Employees>>(Program.filePath);

        public AddEditList(int Id = 0)
        {
            InitializeComponent();
            _employeesID = Id;
            GetEmployeesData();
        }

        public void FillTextBoxes()
        {
            IdEmployee.Text = _employeesID.ToString();
            lblFirstName.Text = _employees.FirstName;
            lbLastName.Text = _employees.LastName;
            dtpDateStartWork.Text = _employees.DateStartWork;
            lbSallary.Text = _employees.Sallary;
            rtbComentBox.Text = _employees.Comments;
        }

        private void GetEmployeesData()
        {
            if (_employeesID != 0)
            {
                var employees = _fIleUpload.DeserializeToFile();
                _employees = employees.FirstOrDefault(x => x.ID == _employeesID);
                if (_employees == null)
                    throw new Exception("brak pracownika o podany ID");
                FillTextBoxes();
            }
        }
        private void AssignNewIdToNewEmployee(List<Employees> employees)
        {
            var employeeWithHightestID = employees.
                OrderByDescending(x => x.ID).FirstOrDefault();

            _employeesID = employeeWithHightestID == null ?
                1 : employeeWithHightestID.ID + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            var employees = _fIleUpload.DeserializeToFile();

            if (_employeesID != 0)
            {
                employees.RemoveAll(x => x.ID == _employeesID);
            }
            else
            {
                AssignNewIdToNewEmployee(employees);
            }

            AddNewEmployeeToList(employees);

            _fIleUpload.SerializeToFile(employees);

            Close();

        }
        private void AddNewEmployeeToList(List<Employees> employees)
        {
            var employee = new Employees
            {
                ID = _employeesID,
                FirstName = lblFirstName.Text,
                LastName = lbLastName.Text,
                DateStartWork = dtpDateStartWork.Text,
                Sallary = lbSallary.Text,
                Comments = rtbComentBox.Text,
            };
            employees.Add(employee);
        }
    }
}

