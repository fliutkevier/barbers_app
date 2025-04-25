namespace BarbersApp.UI
{
    partial class DeletedEntities
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvDeletedEntities = new DataGridView();
            lblTitleInfo = new Label();
            btnExit = new Button();
            cbxEntityType = new ComboBox();
            lblType = new Label();
            btnRestore = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedEntities).BeginInit();
            SuspendLayout();
            // 
            // dgvDeletedEntities
            // 
            dgvDeletedEntities.AllowUserToAddRows = false;
            dgvDeletedEntities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dgvDeletedEntities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDeletedEntities.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDeletedEntities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeletedEntities.BorderStyle = BorderStyle.None;
            dgvDeletedEntities.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDeletedEntities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDeletedEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Calibri", 11.25F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDeletedEntities.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDeletedEntities.Location = new Point(12, 172);
            dgvDeletedEntities.MultiSelect = false;
            dgvDeletedEntities.Name = "dgvDeletedEntities";
            dgvDeletedEntities.ReadOnly = true;
            dgvDeletedEntities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeletedEntities.Size = new Size(790, 389);
            dgvDeletedEntities.TabIndex = 29;
            // 
            // lblTitleInfo
            // 
            lblTitleInfo.Anchor = AnchorStyles.Top;
            lblTitleInfo.AutoSize = true;
            lblTitleInfo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleInfo.Location = new Point(293, 9);
            lblTitleInfo.Name = "lblTitleInfo";
            lblTitleInfo.Size = new Size(213, 23);
            lblTitleInfo.TabIndex = 28;
            lblTitleInfo.Text = "RESTAURACIÓN DE ITEMS";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.BackColor = Color.Black;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Moccasin;
            btnExit.Location = new Point(82, 583);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(295, 31);
            btnExit.TabIndex = 27;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // cbxEntityType
            // 
            cbxEntityType.Anchor = AnchorStyles.Top;
            cbxEntityType.BackColor = Color.White;
            cbxEntityType.FormattingEnabled = true;
            cbxEntityType.Location = new Point(402, 77);
            cbxEntityType.Name = "cbxEntityType";
            cbxEntityType.Size = new Size(196, 23);
            cbxEntityType.TabIndex = 30;
            cbxEntityType.SelectedIndexChanged += cbxEntityType_SelectedIndexChanged;
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Top;
            lblType.AutoSize = true;
            lblType.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.ForeColor = Color.Black;
            lblType.Location = new Point(236, 77);
            lblType.Name = "lblType";
            lblType.Size = new Size(141, 23);
            lblType.TabIndex = 31;
            lblType.Text = "Seleccionar tipo:";
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestore.BackColor = Color.Black;
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Popup;
            btnRestore.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestore.ForeColor = Color.Moccasin;
            btnRestore.Location = new Point(497, 123);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(295, 31);
            btnRestore.TabIndex = 32;
            btnRestore.Text = "RESTAURAR";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // DeletedEntities
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            CancelButton = btnExit;
            ClientSize = new Size(814, 626);
            Controls.Add(btnRestore);
            Controls.Add(lblType);
            Controls.Add(cbxEntityType);
            Controls.Add(dgvDeletedEntities);
            Controls.Add(lblTitleInfo);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeletedEntities";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeletedEntities";
            Load += DeletedEntities_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeletedEntities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDeletedEntities;
        private Label lblTitleInfo;
        private Button btnExit;
        private ComboBox cbxEntityType;
        private Label lblType;
        private Button btnRestore;
    }
}