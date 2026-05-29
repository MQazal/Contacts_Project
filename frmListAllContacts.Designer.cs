namespace ContactProject_PresentationLayer
{
    partial class frmListAllContacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_AllContacts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ContextMenu = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowContact = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllContacts)).BeginInit();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_AllContacts
            // 
            this.DGV_AllContacts.AllowUserToAddRows = false;
            this.DGV_AllContacts.AllowUserToDeleteRows = false;
            this.DGV_AllContacts.AllowUserToOrderColumns = true;
            this.DGV_AllContacts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGV_AllContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_AllContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_AllContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_AllContacts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGV_AllContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_AllContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_AllContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_AllContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_AllContacts.ColumnHeadersHeight = 30;
            this.DGV_AllContacts.ContextMenuStrip = this.ContextMenu;
            this.DGV_AllContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_AllContacts.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_AllContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_AllContacts.EnableHeadersVisualStyles = false;
            this.DGV_AllContacts.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGV_AllContacts.Location = new System.Drawing.Point(0, 0);
            this.DGV_AllContacts.MultiSelect = false;
            this.DGV_AllContacts.Name = "DGV_AllContacts";
            this.DGV_AllContacts.ReadOnly = true;
            this.DGV_AllContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_AllContacts.RowHeadersVisible = false;
            this.DGV_AllContacts.RowHeadersWidth = 51;
            this.DGV_AllContacts.RowTemplate.Height = 30;
            this.DGV_AllContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AllContacts.Size = new System.Drawing.Size(1447, 473);
            this.DGV_AllContacts.TabIndex = 0;
            this.DGV_AllContacts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGV_AllContacts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_AllContacts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_AllContacts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV_AllContacts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV_AllContacts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV_AllContacts.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGV_AllContacts.ThemeStyle.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGV_AllContacts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGV_AllContacts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_AllContacts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_AllContacts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_AllContacts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV_AllContacts.ThemeStyle.HeaderStyle.Height = 30;
            this.DGV_AllContacts.ThemeStyle.ReadOnly = true;
            this.DGV_AllContacts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_AllContacts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_AllContacts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_AllContacts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_AllContacts.ThemeStyle.RowsStyle.Height = 30;
            this.DGV_AllContacts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_AllContacts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenu.RenderStyle.ColorTable = null;
            this.ContextMenu.RenderStyle.RoundedEdges = true;
            this.ContextMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenu.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.ContextMenu.Size = new System.Drawing.Size(211, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 22;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(55, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(229, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New Contact";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowContact
            // 
            this.btnShowContact.AutoRoundedCorners = true;
            this.btnShowContact.BorderRadius = 21;
            this.btnShowContact.CheckedState.Parent = this.btnShowContact;
            this.btnShowContact.CustomImages.Parent = this.btnShowContact;
            this.btnShowContact.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowContact.ForeColor = System.Drawing.Color.Black;
            this.btnShowContact.HoverState.Parent = this.btnShowContact;
            this.btnShowContact.Location = new System.Drawing.Point(338, 518);
            this.btnShowContact.Name = "btnShowContact";
            this.btnShowContact.ShadowDecoration.Parent = this.btnShowContact;
            this.btnShowContact.Size = new System.Drawing.Size(321, 45);
            this.btnShowContact.TabIndex = 2;
            this.btnShowContact.Text = "Show Selected Contact";
            this.btnShowContact.Click += new System.EventHandler(this.btnShowContact_Click);
            // 
            // frmListAllContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1447, 576);
            this.Controls.Add(this.btnShowContact);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DGV_AllContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListAllContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List All Contacts";
            this.Load += new System.EventHandler(this.frmListAllContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllContacts)).EndInit();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnShowContact;
        internal Guna.UI2.WinForms.Guna2DataGridView DGV_AllContacts;
    }
}

