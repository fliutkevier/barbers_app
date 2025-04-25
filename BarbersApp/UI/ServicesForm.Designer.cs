namespace BarbersApp.UI
{
    partial class ServicesForm
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
            dgvServices = new DataGridView();
            dgvPaymentMethod = new DataGridView();
            btnRemove = new Button();
            btnUpdate = new Button();
            lblFilter = new Label();
            txtFilter = new TextBox();
            btnAdd = new Button();
            btnRemovePM = new Button();
            lblNewPM = new Label();
            txtAddPM = new TextBox();
            btnAddPM = new Button();
            txtPercentage = new TextBox();
            lblPercentage = new Label();
            btnUpdatePayment = new Button();
            lblDgvEmpty = new Label();
            lblDgvEmptyPM = new Label();
            lblTitleInfo = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentMethod).BeginInit();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dgvServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BorderStyle = BorderStyle.None;
            dgvServices.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Calibri", 11.25F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvServices.DefaultCellStyle = dataGridViewCellStyle3;
            dgvServices.EnableHeadersVisualStyles = false;
            dgvServices.Location = new Point(12, 169);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(417, 442);
            dgvServices.TabIndex = 9;
            // 
            // dgvPaymentMethod
            // 
            dgvPaymentMethod.AllowUserToAddRows = false;
            dgvPaymentMethod.AllowUserToDeleteRows = false;
            dgvPaymentMethod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvPaymentMethod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymentMethod.BorderStyle = BorderStyle.None;
            dgvPaymentMethod.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPaymentMethod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPaymentMethod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaymentMethod.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPaymentMethod.EnableHeadersVisualStyles = false;
            dgvPaymentMethod.Location = new Point(633, 169);
            dgvPaymentMethod.MultiSelect = false;
            dgvPaymentMethod.Name = "dgvPaymentMethod";
            dgvPaymentMethod.ReadOnly = true;
            dgvPaymentMethod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymentMethod.Size = new Size(409, 442);
            dgvPaymentMethod.TabIndex = 10;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Moccasin;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(295, 132);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(134, 31);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Eliminar";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Moccasin;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(160, 132);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 31);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.White;
            lblFilter.Location = new Point(12, 64);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(158, 23);
            lblFilter.TabIndex = 14;
            lblFilter.Text = "Filtro por Nombre:";
            // 
            // txtFilter
            // 
            txtFilter.BackColor = Color.PeachPuff;
            txtFilter.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(12, 100);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(268, 26);
            txtFilter.TabIndex = 1;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Moccasin;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(12, 132);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Registrar Nuevo";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemovePM
            // 
            btnRemovePM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemovePM.BackColor = Color.Moccasin;
            btnRemovePM.FlatAppearance.BorderSize = 0;
            btnRemovePM.FlatStyle = FlatStyle.Popup;
            btnRemovePM.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemovePM.Location = new Point(960, 132);
            btnRemovePM.Name = "btnRemovePM";
            btnRemovePM.Size = new Size(82, 31);
            btnRemovePM.TabIndex = 9;
            btnRemovePM.Text = "Eliminar";
            btnRemovePM.UseVisualStyleBackColor = false;
            btnRemovePM.Click += btnRemovePM_Click;
            // 
            // lblNewPM
            // 
            lblNewPM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblNewPM.AutoSize = true;
            lblNewPM.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPM.ForeColor = Color.White;
            lblNewPM.Location = new Point(613, 68);
            lblNewPM.Name = "lblNewPM";
            lblNewPM.Size = new Size(133, 23);
            lblNewPM.TabIndex = 19;
            lblNewPM.Text = "Ingresar nuevo:";
            // 
            // txtAddPM
            // 
            txtAddPM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtAddPM.BackColor = Color.PeachPuff;
            txtAddPM.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddPM.Location = new Point(752, 65);
            txtAddPM.MaxLength = 30;
            txtAddPM.Name = "txtAddPM";
            txtAddPM.Size = new Size(290, 26);
            txtAddPM.TabIndex = 5;
            // 
            // btnAddPM
            // 
            btnAddPM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPM.BackColor = Color.Moccasin;
            btnAddPM.FlatAppearance.BorderSize = 0;
            btnAddPM.FlatStyle = FlatStyle.Popup;
            btnAddPM.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPM.Location = new Point(752, 132);
            btnAddPM.Name = "btnAddPM";
            btnAddPM.Size = new Size(98, 31);
            btnAddPM.TabIndex = 7;
            btnAddPM.Text = "Agregar";
            btnAddPM.UseVisualStyleBackColor = false;
            btnAddPM.Click += btnAddPM_Click;
            // 
            // txtPercentage
            // 
            txtPercentage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtPercentage.BackColor = Color.PeachPuff;
            txtPercentage.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPercentage.Location = new Point(752, 100);
            txtPercentage.MaxLength = 10;
            txtPercentage.Name = "txtPercentage";
            txtPercentage.Size = new Size(98, 26);
            txtPercentage.TabIndex = 6;
            // 
            // lblPercentage
            // 
            lblPercentage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentage.ForeColor = Color.White;
            lblPercentage.Location = new Point(548, 103);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(198, 23);
            lblPercentage.TabIndex = 23;
            lblPercentage.Text = "Descuento / Recargo: %";
            // 
            // btnUpdatePayment
            // 
            btnUpdatePayment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdatePayment.BackColor = Color.Moccasin;
            btnUpdatePayment.FlatAppearance.BorderSize = 0;
            btnUpdatePayment.FlatStyle = FlatStyle.Popup;
            btnUpdatePayment.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdatePayment.Location = new Point(856, 132);
            btnUpdatePayment.Name = "btnUpdatePayment";
            btnUpdatePayment.Size = new Size(98, 31);
            btnUpdatePayment.TabIndex = 8;
            btnUpdatePayment.Text = "Modificar";
            btnUpdatePayment.UseVisualStyleBackColor = false;
            btnUpdatePayment.Click += btnUpdatePayment_Click;
            // 
            // lblDgvEmpty
            // 
            lblDgvEmpty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDgvEmpty.AutoSize = true;
            lblDgvEmpty.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDgvEmpty.ForeColor = Color.White;
            lblDgvEmpty.Location = new Point(77, 344);
            lblDgvEmpty.Name = "lblDgvEmpty";
            lblDgvEmpty.Size = new Size(276, 39);
            lblDgvEmpty.TabIndex = 24;
            lblDgvEmpty.Text = "NO HAY REGISTROS";
            lblDgvEmpty.TextAlign = ContentAlignment.MiddleCenter;
            lblDgvEmpty.Visible = false;
            // 
            // lblDgvEmptyPM
            // 
            lblDgvEmptyPM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDgvEmptyPM.AutoSize = true;
            lblDgvEmptyPM.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDgvEmptyPM.ForeColor = Color.White;
            lblDgvEmptyPM.Location = new Point(717, 344);
            lblDgvEmptyPM.Name = "lblDgvEmptyPM";
            lblDgvEmptyPM.Size = new Size(276, 39);
            lblDgvEmptyPM.TabIndex = 25;
            lblDgvEmptyPM.Text = "NO HAY REGISTROS";
            lblDgvEmptyPM.TextAlign = ContentAlignment.MiddleCenter;
            lblDgvEmptyPM.Visible = false;
            // 
            // lblTitleInfo
            // 
            lblTitleInfo.AutoSize = true;
            lblTitleInfo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleInfo.ForeColor = Color.White;
            lblTitleInfo.Location = new Point(12, 25);
            lblTitleInfo.Name = "lblTitleInfo";
            lblTitleInfo.Size = new Size(92, 23);
            lblTitleInfo.TabIndex = 30;
            lblTitleInfo.Text = "SERVICIOS";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(876, 25);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 31;
            label1.Text = "METODOS DE PAGO";
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1054, 623);
            Controls.Add(label1);
            Controls.Add(lblTitleInfo);
            Controls.Add(lblDgvEmptyPM);
            Controls.Add(lblDgvEmpty);
            Controls.Add(btnUpdatePayment);
            Controls.Add(lblPercentage);
            Controls.Add(txtPercentage);
            Controls.Add(btnRemovePM);
            Controls.Add(lblNewPM);
            Controls.Add(txtAddPM);
            Controls.Add(btnAddPM);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(lblFilter);
            Controls.Add(txtFilter);
            Controls.Add(btnAdd);
            Controls.Add(dgvPaymentMethod);
            Controls.Add(dgvServices);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServicesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServicesForm";
            Load += ServicesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentMethod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServices;
        private DataGridView dgvPaymentMethod;
        private Button btnRemove;
        private Button btnUpdate;
        private Label lblFilter;
        private TextBox txtFilter;
        private Button btnAdd;
        private Button btnRemovePM;
        private Label lblNewPM;
        private TextBox txtAddPM;
        private Button btnAddPM;
        private TextBox txtPercentage;
        private Label lblPercentage;
        private Button btnUpdatePayment;
        private Label lblDgvEmpty;
        private Label lblDgvEmptyPM;
        private Label lblTitleInfo;
        private Label label1;
    }
}