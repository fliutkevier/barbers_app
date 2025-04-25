namespace BarbersApp.UI
{
    partial class RegisterWorkForm
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
            lblTitle = new Label();
            lblClient = new Label();
            lblWorker = new Label();
            checkTodayNow = new CheckBox();
            cbxClients = new ComboBox();
            cbxWorkers = new ComboBox();
            lblService = new Label();
            cbxServices = new ComboBox();
            btnAddService = new Button();
            dgvServicesAdded = new DataGridView();
            btnReduce = new Button();
            btnAddJob = new Button();
            lblTotal = new Label();
            lblPaymentMethod = new Label();
            cbxPaymentMethod = new ComboBox();
            dtpTime = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvServicesAdded).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(552, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(216, 33);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CARGAR TRABAJO";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClient.ForeColor = Color.White;
            lblClient.Location = new Point(119, 96);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(77, 26);
            lblClient.TabIndex = 1;
            lblClient.Text = "Cliente:";
            // 
            // lblWorker
            // 
            lblWorker.AutoSize = true;
            lblWorker.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWorker.ForeColor = Color.White;
            lblWorker.Location = new Point(87, 171);
            lblWorker.Name = "lblWorker";
            lblWorker.Size = new Size(109, 26);
            lblWorker.TabIndex = 2;
            lblWorker.Text = "Trabajador:";
            // 
            // checkTodayNow
            // 
            checkTodayNow.AutoSize = true;
            checkTodayNow.Checked = true;
            checkTodayNow.CheckState = CheckState.Checked;
            checkTodayNow.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkTodayNow.ForeColor = Color.White;
            checkTodayNow.Location = new Point(262, 235);
            checkTodayNow.Name = "checkTodayNow";
            checkTodayNow.Size = new Size(146, 25);
            checkTodayNow.TabIndex = 4;
            checkTodayNow.Text = "Atendido Ahora";
            checkTodayNow.UseVisualStyleBackColor = true;
            checkTodayNow.CheckedChanged += checkTodayNow_CheckedChanged;
            // 
            // cbxClients
            // 
            cbxClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxClients.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxClients.BackColor = Color.Moccasin;
            cbxClients.FormattingEnabled = true;
            cbxClients.Location = new Point(239, 99);
            cbxClients.Name = "cbxClients";
            cbxClients.Size = new Size(196, 23);
            cbxClients.TabIndex = 5;
            // 
            // cbxWorkers
            // 
            cbxWorkers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxWorkers.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxWorkers.BackColor = Color.Moccasin;
            cbxWorkers.FormattingEnabled = true;
            cbxWorkers.Location = new Point(239, 174);
            cbxWorkers.Name = "cbxWorkers";
            cbxWorkers.Size = new Size(196, 23);
            cbxWorkers.TabIndex = 6;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblService.ForeColor = Color.White;
            lblService.Location = new Point(112, 298);
            lblService.Name = "lblService";
            lblService.Size = new Size(84, 26);
            lblService.TabIndex = 8;
            lblService.Text = "Servicio:";
            // 
            // cbxServices
            // 
            cbxServices.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxServices.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxServices.BackColor = Color.Moccasin;
            cbxServices.FormattingEnabled = true;
            cbxServices.Location = new Point(239, 301);
            cbxServices.Name = "cbxServices";
            cbxServices.Size = new Size(196, 23);
            cbxServices.TabIndex = 9;
            // 
            // btnAddService
            // 
            btnAddService.FlatStyle = FlatStyle.System;
            btnAddService.Location = new Point(441, 301);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(39, 23);
            btnAddService.TabIndex = 10;
            btnAddService.Text = "+";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // dgvServicesAdded
            // 
            dgvServicesAdded.AllowUserToAddRows = false;
            dgvServicesAdded.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dgvServicesAdded.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvServicesAdded.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvServicesAdded.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicesAdded.BorderStyle = BorderStyle.None;
            dgvServicesAdded.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvServicesAdded.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvServicesAdded.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Calibri", 11.25F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvServicesAdded.DefaultCellStyle = dataGridViewCellStyle3;
            dgvServicesAdded.EnableHeadersVisualStyles = false;
            dgvServicesAdded.Location = new Point(139, 357);
            dgvServicesAdded.MultiSelect = false;
            dgvServicesAdded.Name = "dgvServicesAdded";
            dgvServicesAdded.ReadOnly = true;
            dgvServicesAdded.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicesAdded.Size = new Size(296, 174);
            dgvServicesAdded.TabIndex = 11;
            // 
            // btnReduce
            // 
            btnReduce.FlatStyle = FlatStyle.System;
            btnReduce.Location = new Point(486, 301);
            btnReduce.Name = "btnReduce";
            btnReduce.Size = new Size(88, 23);
            btnReduce.TabIndex = 12;
            btnReduce.Text = "Borrar lista";
            btnReduce.UseVisualStyleBackColor = true;
            btnReduce.Click += btnReduce_Click;
            // 
            // btnAddJob
            // 
            btnAddJob.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddJob.BackColor = Color.Moccasin;
            btnAddJob.FlatAppearance.BorderSize = 0;
            btnAddJob.FlatStyle = FlatStyle.Popup;
            btnAddJob.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddJob.Location = new Point(963, 474);
            btnAddJob.Name = "btnAddJob";
            btnAddJob.Size = new Size(223, 57);
            btnAddJob.TabIndex = 13;
            btnAddJob.Text = "Cargar Trabajo";
            btnAddJob.UseVisualStyleBackColor = false;
            btnAddJob.Click += btnAddJob_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(983, 425);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(83, 30);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Total: $";
            lblTotal.Visible = false;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.ForeColor = Color.White;
            lblPaymentMethod.Location = new Point(518, 352);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(159, 26);
            lblPaymentMethod.TabIndex = 15;
            lblPaymentMethod.Text = "Método de Pago:";
            // 
            // cbxPaymentMethod
            // 
            cbxPaymentMethod.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPaymentMethod.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxPaymentMethod.BackColor = Color.Moccasin;
            cbxPaymentMethod.FormattingEnabled = true;
            cbxPaymentMethod.Location = new Point(707, 357);
            cbxPaymentMethod.Name = "cbxPaymentMethod";
            cbxPaymentMethod.Size = new Size(224, 23);
            cbxPaymentMethod.TabIndex = 16;
            cbxPaymentMethod.SelectedIndexChanged += cbxPaymentMethod_SelectedIndexChanged;
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.Location = new Point(441, 235);
            dtpTime.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTime.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpTime.Name = "dtpTime";
            dtpTime.RightToLeft = RightToLeft.No;
            dtpTime.Size = new Size(84, 23);
            dtpTime.TabIndex = 18;
            dtpTime.Visible = false;
            // 
            // RegisterWorkForm
            // 
            AcceptButton = btnAddJob;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1234, 623);
            Controls.Add(dtpTime);
            Controls.Add(cbxPaymentMethod);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblTotal);
            Controls.Add(btnAddJob);
            Controls.Add(btnReduce);
            Controls.Add(dgvServicesAdded);
            Controls.Add(btnAddService);
            Controls.Add(cbxServices);
            Controls.Add(lblService);
            Controls.Add(cbxWorkers);
            Controls.Add(cbxClients);
            Controls.Add(checkTodayNow);
            Controls.Add(lblWorker);
            Controls.Add(lblClient);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterWorkForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterWorkForm";
            Load += RegisterWorkForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicesAdded).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblClient;
        private Label lblWorker;
        private CheckBox checkTodayNow;
        private ComboBox cbxClients;
        private ComboBox cbxWorkers;
        private Label lblService;
        private ComboBox cbxServices;
        private Button btnAddService;
        private DataGridView dgvServicesAdded;
        private Button btnReduce;
        private Button btnAddJob;
        private Label lblTotal;
        private Label lblPaymentMethod;
        private ComboBox cbxPaymentMethod;
        private DateTimePicker dtpTime;
    }
}