namespace BarbersApp.UI
{
    partial class AddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddService));
            lblName = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtPrice = new TextBox();
            btnAccept = new Button();
            btnCancel = new Button();
            lblTitleInfo = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 14.25F);
            lblName.Location = new Point(24, 97);
            lblName.Name = "lblName";
            lblName.Size = new Size(168, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre del servicio:";
            // 
            // txtName
            // 
            txtName.Location = new Point(209, 97);
            txtName.MaxLength = 30;
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F);
            label1.Location = new Point(129, 167);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 2;
            label1.Text = "Precio:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(209, 167);
            txtPrice.MaxLength = 10;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(160, 23);
            txtPrice.TabIndex = 2;
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
            btnAccept.Location = new Point(293, 254);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(107, 31);
            btnAccept.TabIndex = 3;
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
            btnCancel.Location = new Point(85, 254);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblTitleInfo
            // 
            lblTitleInfo.Anchor = AnchorStyles.Top;
            lblTitleInfo.AutoSize = true;
            lblTitleInfo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleInfo.Location = new Point(164, 30);
            lblTitleInfo.Name = "lblTitleInfo";
            lblTitleInfo.Size = new Size(166, 23);
            lblTitleInfo.TabIndex = 30;
            lblTitleInfo.Text = "AGREGAR SERVICIO";
            // 
            // AddService
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            CancelButton = btnCancel;
            ClientSize = new Size(498, 313);
            Controls.Add(lblTitleInfo);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Servicio";
            Load += AddService_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label label1;
        private TextBox txtPrice;
        private Button btnAccept;
        private Button btnCancel;
        private Label lblTitleInfo;
    }
}