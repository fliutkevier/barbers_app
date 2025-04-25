using BarbersApp.UI;

namespace BarbersApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            loadForm(new WorkersForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            loadForm(new ClientsForm());
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            loadForm(new ServicesForm());
        }

        private void btnUploadJob_Click(object sender, EventArgs e)
        {
            loadForm(new RegisterWorkForm());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            loadForm(new HistoryForm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            loadForm(new SettingsForm());
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
    }
}
