namespace BarbersApp.UI
{
    partial class SettingsForm
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
            btnRestoreItems = new Button();
            SuspendLayout();
            // 
            // btnRestoreItems
            // 
            btnRestoreItems.BackColor = Color.Moccasin;
            btnRestoreItems.FlatAppearance.BorderSize = 0;
            btnRestoreItems.FlatStyle = FlatStyle.Popup;
            btnRestoreItems.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestoreItems.Location = new Point(42, 96);
            btnRestoreItems.Name = "btnRestoreItems";
            btnRestoreItems.Size = new Size(247, 88);
            btnRestoreItems.TabIndex = 8;
            btnRestoreItems.Text = "Ver Archivos Eliminados";
            btnRestoreItems.UseVisualStyleBackColor = false;
            btnRestoreItems.Click += btnRestoreItems_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1022, 662);
            Controls.Add(btnRestoreItems);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRestoreItems;
    }
}