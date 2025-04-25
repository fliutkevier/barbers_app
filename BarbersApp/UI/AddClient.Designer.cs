namespace BarbersApp.UI
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            txtLastname = new TextBox();
            txtDni = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            lblDni = new Label();
            lblLastname = new Label();
            lblPhone = new Label();
            lblName = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            lblTitleInfo = new Label();
            SuspendLayout();
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(190, 139);
            txtLastname.MaxLength = 25;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(195, 23);
            txtLastname.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(190, 209);
            txtDni.MaxLength = 10;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(195, 23);
            txtDni.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(190, 280);
            txtPhone.MaxLength = 15;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(195, 23);
            txtPhone.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 76);
            txtName.MaxLength = 25;
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 23);
            txtName.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(118, 206);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(45, 23);
            lblDni.TabIndex = 16;
            lblDni.Text = "DNI:";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastname.Location = new Point(86, 136);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(77, 23);
            lblLastname.TabIndex = 14;
            lblLastname.Text = "Apellido:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(83, 277);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(80, 23);
            lblPhone.TabIndex = 12;
            lblPhone.Text = "Telefono:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(85, 73);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 23);
            lblName.TabIndex = 10;
            lblName.Text = "Nombre:";
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
            btnAccept.Location = new Point(278, 352);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(107, 31);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "ACEPTAR";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
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
            btnCancel.Location = new Point(70, 352);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblTitleInfo
            // 
            lblTitleInfo.Anchor = AnchorStyles.Top;
            lblTitleInfo.AutoSize = true;
            lblTitleInfo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleInfo.Location = new Point(152, 19);
            lblTitleInfo.Name = "lblTitleInfo";
            lblTitleInfo.Size = new Size(156, 23);
            lblTitleInfo.TabIndex = 29;
            lblTitleInfo.Text = "AGREGAR CLIENTE";
            // 
            // AddClient
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            CancelButton = btnCancel;
            ClientSize = new Size(454, 456);
            Controls.Add(lblTitleInfo);
            Controls.Add(txtLastname);
            Controls.Add(txtDni);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblDni);
            Controls.Add(lblLastname);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddClient";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddClient";
            Load += AddClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLastname;
        private TextBox txtDni;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label lblDni;
        private Label lblLastname;
        private Label lblPhone;
        private Label lblName;
        private Button btnAccept;
        private Button btnCancel;
        private Label lblTitleInfo;
    }
}