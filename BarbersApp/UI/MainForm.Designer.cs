namespace BarbersApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            leftPanel = new Panel();
            btnHome = new Button();
            btnExit = new Button();
            btnSettings = new Button();
            btnHistory = new Button();
            btnServices = new Button();
            btnClients = new Button();
            btnWorkers = new Button();
            btnUploadJob = new Button();
            mainPanel = new Panel();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.Moccasin;
            leftPanel.Controls.Add(btnHome);
            leftPanel.Controls.Add(btnExit);
            leftPanel.Controls.Add(btnSettings);
            leftPanel.Controls.Add(btnHistory);
            leftPanel.Controls.Add(btnServices);
            leftPanel.Controls.Add(btnClients);
            leftPanel.Controls.Add(btnWorkers);
            leftPanel.Controls.Add(btnUploadJob);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(289, 608);
            leftPanel.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top;
            btnHome.BackColor = Color.Moccasin;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Center;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Location = new Point(90, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 90);
            btnHome.TabIndex = 7;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom;
            btnExit.BackColor = Color.Moccasin;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(90, 536);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 60);
            btnExit.TabIndex = 6;
            btnExit.Text = "SALIR";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top;
            btnSettings.BackColor = Color.Moccasin;
            btnSettings.BackgroundImageLayout = ImageLayout.Zoom;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(3, 438);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(280, 60);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "AJUSTES";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnHistory
            // 
            btnHistory.Anchor = AnchorStyles.Top;
            btnHistory.BackColor = Color.Moccasin;
            btnHistory.BackgroundImageLayout = ImageLayout.Zoom;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(3, 372);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(280, 60);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "HISTORIAL";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnServices
            // 
            btnServices.Anchor = AnchorStyles.Top;
            btnServices.BackColor = Color.Moccasin;
            btnServices.BackgroundImageLayout = ImageLayout.Zoom;
            btnServices.Cursor = Cursors.Hand;
            btnServices.FlatAppearance.BorderSize = 0;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServices.Image = (Image)resources.GetObject("btnServices.Image");
            btnServices.ImageAlign = ContentAlignment.MiddleLeft;
            btnServices.Location = new Point(3, 306);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(280, 60);
            btnServices.TabIndex = 3;
            btnServices.Text = "SERVICIOS Y METODOS";
            btnServices.UseVisualStyleBackColor = false;
            btnServices.Click += btnServices_Click;
            // 
            // btnClients
            // 
            btnClients.Anchor = AnchorStyles.Top;
            btnClients.BackColor = Color.Moccasin;
            btnClients.BackgroundImageLayout = ImageLayout.Zoom;
            btnClients.Cursor = Cursors.Hand;
            btnClients.FlatAppearance.BorderSize = 0;
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClients.Image = (Image)resources.GetObject("btnClients.Image");
            btnClients.ImageAlign = ContentAlignment.MiddleLeft;
            btnClients.Location = new Point(3, 240);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(280, 60);
            btnClients.TabIndex = 2;
            btnClients.Text = "CLIENTES";
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += btnClients_Click;
            // 
            // btnWorkers
            // 
            btnWorkers.Anchor = AnchorStyles.Top;
            btnWorkers.BackColor = Color.Moccasin;
            btnWorkers.BackgroundImageLayout = ImageLayout.Zoom;
            btnWorkers.Cursor = Cursors.Hand;
            btnWorkers.FlatAppearance.BorderSize = 0;
            btnWorkers.FlatStyle = FlatStyle.Flat;
            btnWorkers.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWorkers.Image = (Image)resources.GetObject("btnWorkers.Image");
            btnWorkers.ImageAlign = ContentAlignment.MiddleLeft;
            btnWorkers.Location = new Point(3, 174);
            btnWorkers.Name = "btnWorkers";
            btnWorkers.Size = new Size(280, 60);
            btnWorkers.TabIndex = 1;
            btnWorkers.Text = "TRABAJADORES";
            btnWorkers.UseVisualStyleBackColor = false;
            btnWorkers.Click += btnWorkers_Click;
            // 
            // btnUploadJob
            // 
            btnUploadJob.Anchor = AnchorStyles.Top;
            btnUploadJob.BackColor = Color.Moccasin;
            btnUploadJob.BackgroundImageLayout = ImageLayout.Zoom;
            btnUploadJob.Cursor = Cursors.Hand;
            btnUploadJob.FlatAppearance.BorderSize = 0;
            btnUploadJob.FlatStyle = FlatStyle.Flat;
            btnUploadJob.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadJob.Image = (Image)resources.GetObject("btnUploadJob.Image");
            btnUploadJob.ImageAlign = ContentAlignment.MiddleLeft;
            btnUploadJob.Location = new Point(3, 108);
            btnUploadJob.Name = "btnUploadJob";
            btnUploadJob.Size = new Size(280, 60);
            btnUploadJob.TabIndex = 0;
            btnUploadJob.Text = "CARGAR TRABAJO";
            btnUploadJob.UseVisualStyleBackColor = false;
            btnUploadJob.Click += btnUploadJob_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Black;
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.BackgroundImageLayout = ImageLayout.Center;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(289, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(841, 608);
            mainPanel.TabIndex = 1;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 608);
            Controls.Add(mainPanel);
            Controls.Add(leftPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "mainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            Text = "PeluApp";
            Load += Form1_Load;
            Shown += mainForm_Shown;
            leftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel mainPanel;
        private Button btnUploadJob;
        private Button btnSettings;
        private Button btnHistory;
        private Button btnServices;
        private Button btnClients;
        private Button btnWorkers;
        private Button btnExit;
        private Button btnHome;
    }
}
