namespace BarbersApp.UI
{
    partial class WorkersForm
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
            btnAddWorker = new Button();
            txtFilter = new TextBox();
            dgvWorkers = new DataGridView();
            lblFilter = new Label();
            btnUpdate = new Button();
            btnRemove = new Button();
            lblDgvEmpty = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvWorkers).BeginInit();
            SuspendLayout();
            // 
            // btnAddWorker
            // 
            btnAddWorker.Anchor = AnchorStyles.Top;
            btnAddWorker.BackColor = Color.Moccasin;
            btnAddWorker.FlatAppearance.BorderSize = 0;
            btnAddWorker.FlatStyle = FlatStyle.Popup;
            btnAddWorker.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddWorker.Location = new Point(433, 120);
            btnAddWorker.Name = "btnAddWorker";
            btnAddWorker.Size = new Size(161, 31);
            btnAddWorker.TabIndex = 0;
            btnAddWorker.Text = "Registrar Nuevo";
            btnAddWorker.UseVisualStyleBackColor = false;
            btnAddWorker.Click += btnAddWorker_Click;
            // 
            // txtFilter
            // 
            txtFilter.BackColor = Color.PeachPuff;
            txtFilter.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(50, 125);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(268, 26);
            txtFilter.TabIndex = 1;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // dgvWorkers
            // 
            dgvWorkers.AllowUserToAddRows = false;
            dgvWorkers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dgvWorkers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvWorkers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvWorkers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkers.BorderStyle = BorderStyle.None;
            dgvWorkers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvWorkers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvWorkers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Calibri", 11.25F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvWorkers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvWorkers.EnableHeadersVisualStyles = false;
            dgvWorkers.Location = new Point(50, 189);
            dgvWorkers.MultiSelect = false;
            dgvWorkers.Name = "dgvWorkers";
            dgvWorkers.ReadOnly = true;
            dgvWorkers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWorkers.Size = new Size(951, 390);
            dgvWorkers.TabIndex = 2;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.White;
            lblFilter.Location = new Point(50, 89);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(206, 23);
            lblFilter.TabIndex = 3;
            lblFilter.Text = "Filtro por Nombre o DNI:";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.BackColor = Color.Moccasin;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(637, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(161, 31);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Modificar Fila";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top;
            btnRemove.BackColor = Color.Moccasin;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(840, 120);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(161, 31);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Eliminar Fila";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblDgvEmpty
            // 
            lblDgvEmpty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDgvEmpty.AutoSize = true;
            lblDgvEmpty.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDgvEmpty.ForeColor = Color.White;
            lblDgvEmpty.Location = new Point(389, 292);
            lblDgvEmpty.Name = "lblDgvEmpty";
            lblDgvEmpty.Size = new Size(276, 39);
            lblDgvEmpty.TabIndex = 13;
            lblDgvEmpty.Text = "NO HAY REGISTROS";
            lblDgvEmpty.TextAlign = ContentAlignment.MiddleCenter;
            lblDgvEmpty.Visible = false;
            // 
            // WorkersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1054, 623);
            Controls.Add(lblDgvEmpty);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(lblFilter);
            Controls.Add(dgvWorkers);
            Controls.Add(txtFilter);
            Controls.Add(btnAddWorker);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WorkersForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "workerForm";
            Load += workerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWorkers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddWorker;
        private TextBox txtFilter;
        private DataGridView dgvWorkers;
        private Label lblFilter;
        private Button btnUpdate;
        private Button btnRemove;
        private Label lblDgvEmpty;
    }
}