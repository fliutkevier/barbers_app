namespace BarbersApp.UI
{
    partial class DetailsForm
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
            btnExit = new Button();
            lblClientDni = new Label();
            lblWorkerName = new Label();
            lblClientName = new Label();
            lblTotal = new Label();
            lblPaymentMethod = new Label();
            lblTitleInfo = new Label();
            lblDate = new Label();
            lblTitleServices = new Label();
            dgvServices = new DataGridView();
            lblClientNameSold = new Label();
            lblDateSold = new Label();
            lblWorkerNameSold = new Label();
            lblClientDniSold = new Label();
            lblTotalSold = new Label();
            lblPaymentMethodSold = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
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
            btnExit.Location = new Point(221, 689);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(258, 31);
            btnExit.TabIndex = 6;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // lblClientDni
            // 
            lblClientDni.AutoSize = true;
            lblClientDni.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientDni.Location = new Point(153, 128);
            lblClientDni.Name = "lblClientDni";
            lblClientDni.Size = new Size(126, 23);
            lblClientDni.TabIndex = 20;
            lblClientDni.Text = "DNI del cliente:";
            // 
            // lblWorkerName
            // 
            lblWorkerName.AutoSize = true;
            lblWorkerName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWorkerName.Location = new Point(12, 181);
            lblWorkerName.Name = "lblWorkerName";
            lblWorkerName.Size = new Size(267, 23);
            lblWorkerName.TabIndex = 19;
            lblWorkerName.Text = "Nombre completo del trabajador:";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientName.Location = new Point(42, 75);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(237, 23);
            lblClientName.TabIndex = 17;
            lblClientName.Text = "Nombre Completo del cliente:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(228, 343);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 23);
            lblTotal.TabIndex = 21;
            lblTotal.Text = "Total:";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(138, 290);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(141, 23);
            lblPaymentMethod.TabIndex = 22;
            lblPaymentMethod.Text = "Método de pago:";
            // 
            // lblTitleInfo
            // 
            lblTitleInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitleInfo.AutoSize = true;
            lblTitleInfo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleInfo.Location = new Point(237, 9);
            lblTitleInfo.Name = "lblTitleInfo";
            lblTitleInfo.Size = new Size(237, 23);
            lblTitleInfo.TabIndex = 23;
            lblTitleInfo.Text = "INFORMACIÓN DE LA VENTA";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(219, 235);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(60, 23);
            lblDate.TabIndex = 24;
            lblDate.Text = "Fecha:";
            // 
            // lblTitleServices
            // 
            lblTitleServices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitleServices.AutoSize = true;
            lblTitleServices.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleServices.Location = new Point(42, 410);
            lblTitleServices.Name = "lblTitleServices";
            lblTitleServices.Size = new Size(180, 23);
            lblTitleServices.TabIndex = 25;
            lblTitleServices.Text = "SERVICIOS VENDIDOS";
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dgvServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvServices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvServices.Location = new Point(12, 452);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(675, 212);
            dgvServices.TabIndex = 26;
            // 
            // lblClientNameSold
            // 
            lblClientNameSold.AutoSize = true;
            lblClientNameSold.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientNameSold.ForeColor = Color.DimGray;
            lblClientNameSold.Location = new Point(306, 75);
            lblClientNameSold.Name = "lblClientNameSold";
            lblClientNameSold.Size = new Size(51, 23);
            lblClientNameSold.TabIndex = 27;
            lblClientNameSold.Text = "vacío";
            // 
            // lblDateSold
            // 
            lblDateSold.AutoSize = true;
            lblDateSold.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateSold.ForeColor = Color.DimGray;
            lblDateSold.Location = new Point(306, 235);
            lblDateSold.Name = "lblDateSold";
            lblDateSold.Size = new Size(51, 23);
            lblDateSold.TabIndex = 28;
            lblDateSold.Text = "vacío";
            // 
            // lblWorkerNameSold
            // 
            lblWorkerNameSold.AutoSize = true;
            lblWorkerNameSold.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWorkerNameSold.ForeColor = Color.DimGray;
            lblWorkerNameSold.Location = new Point(306, 181);
            lblWorkerNameSold.Name = "lblWorkerNameSold";
            lblWorkerNameSold.Size = new Size(51, 23);
            lblWorkerNameSold.TabIndex = 29;
            lblWorkerNameSold.Text = "vacío";
            // 
            // lblClientDniSold
            // 
            lblClientDniSold.AutoSize = true;
            lblClientDniSold.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientDniSold.ForeColor = Color.DimGray;
            lblClientDniSold.Location = new Point(306, 128);
            lblClientDniSold.Name = "lblClientDniSold";
            lblClientDniSold.Size = new Size(51, 23);
            lblClientDniSold.TabIndex = 30;
            lblClientDniSold.Text = "vacío";
            // 
            // lblTotalSold
            // 
            lblTotalSold.AutoSize = true;
            lblTotalSold.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSold.ForeColor = Color.DimGray;
            lblTotalSold.Location = new Point(306, 343);
            lblTotalSold.Name = "lblTotalSold";
            lblTotalSold.Size = new Size(51, 23);
            lblTotalSold.TabIndex = 31;
            lblTotalSold.Text = "vacío";
            // 
            // lblPaymentMethodSold
            // 
            lblPaymentMethodSold.AutoSize = true;
            lblPaymentMethodSold.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentMethodSold.ForeColor = Color.DimGray;
            lblPaymentMethodSold.Location = new Point(306, 290);
            lblPaymentMethodSold.Name = "lblPaymentMethodSold";
            lblPaymentMethodSold.Size = new Size(51, 23);
            lblPaymentMethodSold.TabIndex = 32;
            lblPaymentMethodSold.Text = "vacío";
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            CancelButton = btnExit;
            ClientSize = new Size(699, 732);
            Controls.Add(lblPaymentMethodSold);
            Controls.Add(lblTotalSold);
            Controls.Add(lblClientDniSold);
            Controls.Add(lblWorkerNameSold);
            Controls.Add(lblDateSold);
            Controls.Add(lblClientNameSold);
            Controls.Add(dgvServices);
            Controls.Add(lblTitleServices);
            Controls.Add(lblDate);
            Controls.Add(lblTitleInfo);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblTotal);
            Controls.Add(lblClientDni);
            Controls.Add(lblWorkerName);
            Controls.Add(lblClientName);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailsForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailsForm";
            Load += DetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label lblClientDni;
        private Label lblWorkerName;
        private Label lblClientName;
        private Label lblTotal;
        private Label lblPaymentMethod;
        private Label lblTitleInfo;
        private Label lblDate;
        private Label lblTitleServices;
        private DataGridView dgvServices;
        private Label lblClientNameSold;
        private Label lblDateSold;
        private Label lblWorkerNameSold;
        private Label lblClientDniSold;
        private Label lblTotalSold;
        private Label lblPaymentMethodSold;
    }
}