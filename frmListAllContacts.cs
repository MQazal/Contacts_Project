using System;
using System.Data;
using System.Windows.Forms;
using ContactsProject_BusinessLogicLayer;

namespace ContactProject_PresentationLayer
{
    public partial class frmListAllContacts : Form
    {
        public frmListAllContacts()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable(DataTable DT)
        {
            DT.Columns.Add("ContactID", typeof(int));
            DT.Columns.Add("FirstName", typeof(string));
            DT.Columns.Add("LastName", typeof(string));
            DT.Columns.Add("Email", typeof(string));
            DT.Columns.Add("Phone", typeof(string));
            DT.Columns.Add("Address", typeof(string));
            DT.Columns.Add("DateOfBirth", typeof(DateTime));
            DT.Columns.Add("CountryID", typeof(int));
            DT.Columns.Add("ImagePath", typeof(string));
        }

        private void _AddRowsToTable(DataTable ContactsDT)
        {
            DataTable Database = clsContact.GetContactsList();
            foreach (DataRow Row in Database.Rows)
            {
                ContactsDT.Rows.Add(Row["ContactID"], Row["FirstName"], Row["LastName"], Row["Email"], Row["Phone"], Row["Address"], Row["DateOfBirth"], Row["CountryID"], Row["ImagePath"]);
            }
        }

        private void _GenerateDataTable()
        {
            DataTable DT = new DataTable();
            _AddColumnsToTable(DT);
            _AddRowsToTable(DT);
            DGV_AllContacts.DataSource = DT;
        }

        private void frmListAllContacts_Load(object sender, EventArgs e)
        {
            _GenerateDataTable();
            DGV_AllContacts.ClearSelection();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Are you sure you want to delete this contact" + DGV_AllContacts.CurrentRow.Cells[0].Value, "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
                if (clsContact.DeleteContact((int)DGV_AllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact updated sucessfully");
                    _GenerateDataTable();
                }
                else
                    MessageBox.Show("Contact is not updated sucessfully");
           }
        }

        private void _ShowSelectedContact()
        {
            frmShowContacts CurrentRow = new frmShowContacts(this);
            CurrentRow.Show();
            this.Hide();
        }

        private void btnShowContact_Click(object sender, EventArgs e)
        {
            _ShowSelectedContact();
        }

        private void _OpenFormByAdd()
        {
            frmAdd_UpdateContact Add = new frmAdd_UpdateContact(-1);
            Add.ShowDialog();
            _GenerateDataTable();
        }

        private void _OpenFormByUpdate()
        {
            frmAdd_UpdateContact Update = new frmAdd_UpdateContact((int)DGV_AllContacts.CurrentRow.Cells[0].Value);
            Update.ShowDialog();
            _GenerateDataTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _OpenFormByAdd();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenFormByUpdate();
        }
    }
}