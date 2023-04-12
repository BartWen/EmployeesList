using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace EmployeesList
{
    public partial class Main : Form
    {
        private FIleUpload<List<Employees>> fileUpload =
            new FIleUpload<List<Employees>>(Program.filePath);

        public Employees _employees;
        public Main()
        {
            InitializeComponent();
            RefreshDiary();
            GetColumnHeader();
            StatusList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var AddEditList = new AddEditList();

            AddEditList.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz pracownika");
                return;
            }

            var addEditList = new AddEditList
                (Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));

            addEditList.FormClosing += AddEditList_FormClosing;

            addEditList.ShowDialog();
        }

        private void AddEditList_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshDiary();
        }
        private void RefreshDiary()
        {
            var employees = fileUpload.DeserializeToFile();

            dgvDiary.DataSource = employees;
        }

        private void GetColumnHeader()
        {

            dgvDiary.Columns[0].HeaderText = "Numer";
            dgvDiary.Columns[1].HeaderText = "Imię";
            dgvDiary.Columns[2].HeaderText = "Nazwisko";
            dgvDiary.Columns[3].HeaderText = "Data rozpoczęcia";
            dgvDiary.Columns[4].HeaderText = "Data zakończenia";
            dgvDiary.Columns[5].HeaderText = "Status";
            dgvDiary.Columns[6].HeaderText = "Pensja";
            dgvDiary.Columns[7].HeaderText = "Komentarz";

        }
        private void StatusList()
        {
            var statusList = new List<string>();

            statusList.Add("Zwolniony");
            statusList.Add("Wszyscy");

            comBoxStatus.Items.AddRange(statusList.ToArray());
        }

        private void comBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxStatus.SelectedItem != null &&
                !string.IsNullOrEmpty(comBoxStatus.SelectedItem.ToString()) &&
                comBoxStatus.SelectedItem != "Wszyscy")
            {
                var employees = fileUpload.DeserializeToFile();
                dgvDiary.DataSource = employees.Where(x => x.WorkStatus == comBoxStatus.SelectedItem.ToString()).ToArray();
            }
            else
            {
                var employees = fileUpload.DeserializeToFile();
                dgvDiary.DataSource = employees;
            }
        }

        private void btnDismissEmployee_Click(object sender, EventArgs e)
        {
            //var messageFaired = MessageBox.Show("Zwolnienie",);


            var employees = fileUpload.DeserializeToFile();

            _employees = employees.FirstOrDefault
                (x => x.ID == Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));

            var messageFaired = MessageBox.Show(
                    $"Czy na pewno chcesz zwolnić pracownika{_employees.FirstName} {_employees.LastName}",
                    "Zwolnienie", MessageBoxButtons.YesNo);

            if (messageFaired == DialogResult.Yes)
            {
                var messageFairedConfirm = MessageBox.Show(
                    $"Potwierdzenie", "Potwierdż zwolnienie", MessageBoxButtons.OKCancel);
                if (messageFairedConfirm == DialogResult.OK)
                {
                    var firedDate = DateTime.Now;
                    _employees.DateEndWork = firedDate.ToShortDateString();
                    _employees.WorkStatus = "Zwolniony";
                    employees.Remove(_employees);
                    employees.Add(_employees);
                    fileUpload.SerializeToFile(employees);
                }
            }
        }
    }
}
