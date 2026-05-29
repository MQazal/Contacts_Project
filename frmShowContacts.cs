using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ContactProject_PresentationLayer
{
    public partial class frmShowContacts : Form
    {
        private DataGridViewRow _SelectedRow = new DataGridViewRow();

        private frmListAllContacts _List = new frmListAllContacts();

        public frmShowContacts(frmListAllContacts List)
        {
            InitializeComponent();
            _List = List;
            _SelectedRow = _List.DGV_AllContacts.CurrentRow;
        }

        private TextBox _FindBoxByTag(string Tag)
        {
            foreach(TextBox box in this.Controls.OfType<TextBox>())
            {
                if (String.Equals(box.Tag, Tag))
                    return box;
            }
            return null;
        }

        private void _FillBoxesByData()
        {
            for (byte i = 0; i <= 7; i++)
            {
                _FindBoxByTag((i + 1).ToString()).Text = (_SelectedRow.Cells[i].Value.ToString());
            }

            if (_List.DGV_AllContacts.CurrentRow.Cells[8].Value.ToString() != "")
            {
                pbxImage.Image = Image.FromFile(_List.DGV_AllContacts.CurrentRow.Cells[8].Value.ToString());
            }
        }

        private void frmShowContactcs_Load(object sender, EventArgs e)
        {
            _FillBoxesByData();
        }

        private void _CloseForm()
        {
            _List.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }
    }
}