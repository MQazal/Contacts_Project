using ContactsProject_BusinessLogicLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace ContactProject_PresentationLayer
{
    public partial class frmAdd_UpdateContact : Form
    {
        enum enMode { AddNew = 1, Update }

        enMode _Mode;

        clsContact _Contact;

        private enMode _SelectMode(int ContactID)
        {
            return ContactID == -1 ? enMode.AddNew : enMode.Update;
        }

        private void _LoadCountriesList()
        {
            DataTable DT = clsCountry.GetCountriesList();
            foreach (DataRow Row in DT.Rows)
            {
                cbxCountry.Items.Add(Row["CountryName"]);
            }
            cbxCountry.SelectedIndex = cbxCountry.Items.Count - 1;
        }

        public frmAdd_UpdateContact(int ContactID)
        {
            InitializeComponent();

            _Mode = _SelectMode(ContactID);

            if (_Mode == enMode.Update)
            {
                _Contact = clsContact.Find(ContactID);
                if (_Contact == null)
                {
                    MessageBox.Show($"This form will be closed because there is no Contact with ID = {ContactID}");
                    _CloseForm();
                }
            }

            else
            {
                _Contact = new clsContact();
                lblRemoveImage.Visible = false;
            }
        }

        private void _HandleImageStatus(string Path)
        {
            if (Path == "")
            {
                lblRemoveImage.Visible = false;
                pbxImage.Visible = false;

                if (!lblSetImage.Visible)
                    lblSetImage.Visible = true;
            }

            else
            {
                lblSetImage.Visible = false;
                pbxImage.Load(Path);
                pbxImage.Tag = Path;

                if (!lblRemoveImage.Visible)
                {
                    lblRemoveImage.Visible = true;
                    pbxImage.Visible = true;
                }
            }
        }

        private void _LoadData(clsContact Contact)
        {
            lblTitle.Text = $"Edit Contact ID = {_Contact.ContactID}";
            lbl_ID.Text = _Contact.ContactID.ToString();
            tbxFirstName.Text = _Contact.FirstName;
            tbxLastName.Text = _Contact.LastName;
            tbxEmail.Text = _Contact.Email;
            tbxPhone.Text = _Contact.Phone;
            dtb_DateOfBirth.Value = _Contact.DateOfBirth;
            cbxCountry.SelectedIndex = cbxCountry.FindString(clsCountry.FindCountry(_Contact.CountryID).CountryName);
            tbxAddress.Text = _Contact.Address;
            _HandleImageStatus(_Contact.ImagePath);
        }

        private void frmAdd_UpdateContact_Load(object sender, EventArgs e)
        {
            _LoadCountriesList();
            dtb_DateOfBirth.CustomFormat = "yyyy/MM/dd";
            if (_Mode == enMode.Update)
                _LoadData(_Contact);
        }

        private void _CloseForm()
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }

        private void _FillContactByInputData()
        {
            _Contact.FirstName = tbxFirstName.Text;
            _Contact.LastName = tbxLastName.Text;
            _Contact.Email = tbxEmail.Text;
            _Contact.Phone = tbxPhone.Text;
            _Contact.DateOfBirth = (DateTime)dtb_DateOfBirth.Value;
            _Contact.CountryID = clsCountry.FindCountry(cbxCountry.Text).CountryID;
            _Contact.Address = tbxAddress.Text;
            if (String.Equals(OFImage.FileName, pbxImage.Tag))
                _Contact.ImagePath = pbxImage.Tag.ToString();
            else
                _Contact.ImagePath = "";
        }

        private void _AddDataToTableByAddMode()
        {
            _FillContactByInputData();
            if (_Contact.Save())
            {
                MessageBox.Show("New contact is addedd sucessfully (:", "Add Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblTitle.Text = $"Edit Contact ID = {_Contact.ContactID}";
                lbl_ID.Text = _Contact.ContactID.ToString();
            }
            else
                MessageBox.Show("Failed to add new contact ):", "Faild Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _AddDataToTableByUpdateMode()
        {
            _FillContactByInputData();
            if (_Contact.Save())
                MessageBox.Show("Contact is updated sucessfully (:", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to update contact ):", "Faild Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _AddDataToTableByAddMode();
                return;
            }
            _AddDataToTableByUpdateMode();
        }

        private void lblSetImage_Click(object sender, EventArgs e)
        {
            OFImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            OFImage.FilterIndex = 1;
            OFImage.RestoreDirectory = true;

            if (OFImage.ShowDialog() == DialogResult.OK)
                _HandleImageStatus(OFImage.FileName);
        }

        private void lblRemoveImage_Click(object sender, EventArgs e)
        {
            pbxImage.Image = null;
            _HandleImageStatus("");
        }
    }
}