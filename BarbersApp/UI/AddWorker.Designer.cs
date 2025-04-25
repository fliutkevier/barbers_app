namespace BarbersApp.UI
{
    partial class AddWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorker));
            btnCancel = new Button();
            btnAccept = new Button();
            lblName = new Label();
            lblPhone = new Label();
            lblLastname = new Label();
            lblDni = new Label();
            lblAddress = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtDni = new TextBox();
            txtLastname = new TextBox();
            lblTitleInfo = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = Color.Black;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Moccasin;
            btnCancel.Location = new Point(70, 480);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAccept.BackColor = Color.Black;
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Popup;
            btnAccept.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = Color.Moccasin;
            btnAccept.Location = new Point(278, 480);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(107, 31);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "ACEPTAR";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(85, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Nombre:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(83, 304);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(80, 23);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Telefono:";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastname.Location = new Point(86, 163);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(77, 23);
            lblLastname.TabIndex = 4;
            lblLastname.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(118, 233);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(45, 23);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(76, 377);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 23);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Dirección:";
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 103);
            txtName.MaxLength = 25;
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 23);
            txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(190, 307);
            txtPhone.MaxLength = 15;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(195, 23);
            txtPhone.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(190, 380);
            txtAddress.MaxLength = 50;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(195, 23);
            txtAddress.TabIndex = 5;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(190, 236);
            txtDni.MaxLength = 10;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(195, 23);
            txtDni.TabIndex = 3;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(190, 166);
            txtLastname.MaxLength = 25;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(195, 23);
            txtLastname.TabIndex = 2;
            // 
            // lblTitleInfo
            // 
            lblTitleInfo.Anchor = AnchorStyles.Top;
            lblTitleInfo.AutoSize = true;
            lblTitleInfo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleInfo.Location = new Point(140, 32);
            lblTitleInfo.Name = "lblTitleInfo";
            lblTitleInfo.Size = new Size(171, 23);
            lblTitleInfo.TabIndex = 30;
            lblTitleInfo.Text = "AGREGAR BARBERO";
            // 
            // AddWorker
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            CancelButton = btnCancel;
            ClientSize = new Size(454, 557);
            Controls.Add(lblTitleInfo);
            Controls.Add(txtLastname);
            Controls.Add(txtDni);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(lblDni);
            Controls.Add(lblLastname);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddWorker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cliente";
            Load += AddPerson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAccept;
        private Label lblName;
        private Label lblPhone;
        private Label lblLastname;
        private Label lblDni;
        private Label lblAddress;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtDni;
        private TextBox txtLastname;
        private Label lblTitleInfo;
    }
}