namespace BarbersApp.UI
{
    partial class UpdPaymentMethodForm
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
            btnAccept = new Button();
            btnCancel = new Button();
            txtPercentage = new TextBox();
            lblPercentage = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblTitleInfo = new Label();
            SuspendLayout();
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
            btnAccept.Location = new Point(292, 219);
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
            btnCancel.Location = new Point(84, 219);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtPercentage
            // 
            txtPercentage.Location = new Point(208, 132);
            txtPercentage.MaxLength = 7;
            txtPercentage.Name = "txtPercentage";
            txtPercentage.Size = new Size(160, 23);
            txtPercentage.TabIndex = 2;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Calibri", 14.25F);
            lblPercentage.Location = new Point(40, 132);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(152, 23);
            lblPercentage.TabIndex = 8;
            lblPercentage.Text = "Nuevo Porcentaje:";
            // 
            // txtName
            // 
            txtName.Location = new Point(208, 62);
            txtName.MaxLength = 30;
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 23);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 14.25F);
            lblName.Location = new Point(23, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(169, 23);
            lblName.TabIndex = 6;
            lblName.Text = "Nombre del método:";
            // 
            // lblTitleInfo
            // 
            lblTitleInfo.Anchor = AnchorStyles.Top;
            lblTitleInfo.AutoSize = true;
            lblTitleInfo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleInfo.Location = new Point(153, 9);
            lblTitleInfo.Name = "lblTitleInfo";
            lblTitleInfo.Size = new Size(180, 23);
            lblTitleInfo.TabIndex = 30;
            lblTitleInfo.Text = "MODIFICAR METODO";
            // 
            // UpdPaymentMethodForm
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
            Controls.Add(txtPercentage);
            Controls.Add(lblPercentage);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdPaymentMethodForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdPaymentMethod";
            Load += UpdPaymentMethodForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccept;
        private Button btnCancel;
        private TextBox txtPercentage;
        private Label lblPercentage;
        private TextBox txtName;
        private Label lblName;
        private Label lblTitleInfo;
    }
}