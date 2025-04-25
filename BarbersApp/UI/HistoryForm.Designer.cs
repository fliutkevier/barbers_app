namespace BarbersApp.UI
{
    partial class HistoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblFilter = new Label();
            dgvSales = new DataGridView();
            txtFilter = new TextBox();
            btnDetails = new Button();
            rbAZClient = new RadioButton();
            rbTotal = new RadioButton();
            rbDate = new RadioButton();
            gbxFilters = new GroupBox();
            rbLastSales = new RadioButton();
            btnRemove = new Button();
            lblDgvEmpty = new Label();
            lblFilterWorker = new Label();
            txtFilterWorker = new TextBox();
            dtpFrom = new DateTimePicker();
            btnGenerateSummary = new Button();
            lblFrom = new Label();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnClean = new Button();
            lblTotal = new Label();
            btnTotal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            gbxFilters.SuspendLayout();
            SuspendLayout();
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.White;
            lblFilter.Location = new Point(12, 12);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(241, 23);
            lblFilter.TabIndex = 12;
            lblFilter.Text = "Filtro Cliente - Nombre o DNI";
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(238, 239, 249);
            dgvSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.BorderStyle = BorderStyle.None;
            dgvSales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Calibri", 11.25F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSales.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSales.EnableHeadersVisualStyles = false;
            dgvSales.Location = new Point(332, 12);
            dgvSales.MultiSelect = false;
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(795, 774);
            dgvSales.TabIndex = 11;
            // 
            // txtFilter
            // 
            txtFilter.BackColor = Color.PeachPuff;
            txtFilter.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(12, 48);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(268, 26);
            txtFilter.TabIndex = 1;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnDetails
            // 
            btnDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDetails.BackColor = Color.Moccasin;
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.FlatStyle = FlatStyle.Popup;
            btnDetails.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetails.Location = new Point(12, 755);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(161, 31);
            btnDetails.TabIndex = 9;
            btnDetails.Text = "VER DETALLES";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // rbAZClient
            // 
            rbAZClient.AutoSize = true;
            rbAZClient.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbAZClient.ForeColor = Color.White;
            rbAZClient.Location = new Point(21, 22);
            rbAZClient.Name = "rbAZClient";
            rbAZClient.Size = new Size(216, 22);
            rbAZClient.TabIndex = 14;
            rbAZClient.Text = "Ordenar Por Nombre de Cliente";
            rbAZClient.UseVisualStyleBackColor = true;
            rbAZClient.CheckedChanged += rbAZClient_CheckedChanged;
            // 
            // rbTotal
            // 
            rbTotal.AutoSize = true;
            rbTotal.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbTotal.ForeColor = Color.White;
            rbTotal.Location = new Point(21, 50);
            rbTotal.Name = "rbTotal";
            rbTotal.Size = new Size(134, 22);
            rbTotal.TabIndex = 15;
            rbTotal.Text = "Ordenar Por Total";
            rbTotal.UseVisualStyleBackColor = true;
            rbTotal.CheckedChanged += rbTotal_CheckedChanged;
            // 
            // rbDate
            // 
            rbDate.AutoSize = true;
            rbDate.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbDate.ForeColor = Color.White;
            rbDate.Location = new Point(21, 78);
            rbDate.Name = "rbDate";
            rbDate.Size = new Size(140, 22);
            rbDate.TabIndex = 16;
            rbDate.Text = "Ordenar Por Fecha";
            rbDate.UseVisualStyleBackColor = true;
            rbDate.CheckedChanged += rbDate_CheckedChanged;
            // 
            // gbxFilters
            // 
            gbxFilters.Controls.Add(rbLastSales);
            gbxFilters.Controls.Add(rbAZClient);
            gbxFilters.Controls.Add(rbDate);
            gbxFilters.Controls.Add(rbTotal);
            gbxFilters.Location = new Point(12, 190);
            gbxFilters.Name = "gbxFilters";
            gbxFilters.Size = new Size(280, 144);
            gbxFilters.TabIndex = 17;
            gbxFilters.TabStop = false;
            // 
            // rbLastSales
            // 
            rbLastSales.AutoSize = true;
            rbLastSales.Checked = true;
            rbLastSales.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbLastSales.ForeColor = Color.White;
            rbLastSales.Location = new Point(21, 106);
            rbLastSales.Name = "rbLastSales";
            rbLastSales.Size = new Size(201, 22);
            rbLastSales.TabIndex = 17;
            rbLastSales.TabStop = true;
            rbLastSales.Text = "Por Defecto (Últimas ventas)";
            rbLastSales.UseVisualStyleBackColor = true;
            rbLastSales.CheckedChanged += rbLastSales_CheckedChanged;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Moccasin;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(12, 352);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(161, 31);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "ELIMINAR VENTA";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblDgvEmpty
            // 
            lblDgvEmpty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDgvEmpty.AutoSize = true;
            lblDgvEmpty.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDgvEmpty.ForeColor = Color.White;
            lblDgvEmpty.Location = new Point(561, 253);
            lblDgvEmpty.Name = "lblDgvEmpty";
            lblDgvEmpty.Size = new Size(276, 39);
            lblDgvEmpty.TabIndex = 19;
            lblDgvEmpty.Text = "NO HAY REGISTROS";
            lblDgvEmpty.TextAlign = ContentAlignment.MiddleCenter;
            lblDgvEmpty.Visible = false;
            // 
            // lblFilterWorker
            // 
            lblFilterWorker.AutoSize = true;
            lblFilterWorker.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterWorker.ForeColor = Color.White;
            lblFilterWorker.Location = new Point(12, 96);
            lblFilterWorker.Name = "lblFilterWorker";
            lblFilterWorker.Size = new Size(220, 23);
            lblFilterWorker.TabIndex = 21;
            lblFilterWorker.Text = "Filtro Trabajador - Nombre";
            // 
            // txtFilterWorker
            // 
            txtFilterWorker.BackColor = Color.PeachPuff;
            txtFilterWorker.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterWorker.Location = new Point(12, 132);
            txtFilterWorker.Name = "txtFilterWorker";
            txtFilterWorker.Size = new Size(268, 26);
            txtFilterWorker.TabIndex = 2;
            txtFilterWorker.TextChanged += txtFilterWorker_TextChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(12, 478);
            dtpFrom.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpFrom.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(155, 26);
            dtpFrom.TabIndex = 4;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.BackColor = Color.Moccasin;
            btnGenerateSummary.FlatAppearance.BorderSize = 0;
            btnGenerateSummary.FlatStyle = FlatStyle.Popup;
            btnGenerateSummary.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateSummary.Location = new Point(12, 580);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(161, 31);
            btnGenerateSummary.TabIndex = 6;
            btnGenerateSummary.Text = "VER VENTAS";
            btnGenerateSummary.UseVisualStyleBackColor = false;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrom.ForeColor = Color.White;
            lblFrom.Location = new Point(12, 452);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(65, 23);
            lblFrom.TabIndex = 25;
            lblFrom.Text = "Desde:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTo.ForeColor = Color.White;
            lblTo.Location = new Point(12, 512);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(60, 23);
            lblTo.TabIndex = 26;
            lblTo.Text = "Hasta:";
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(12, 538);
            dtpTo.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTo.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(155, 26);
            dtpTo.TabIndex = 5;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.Moccasin;
            btnClean.FlatAppearance.BorderSize = 0;
            btnClean.FlatStyle = FlatStyle.Popup;
            btnClean.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClean.Location = new Point(179, 580);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(87, 31);
            btnClean.TabIndex = 7;
            btnClean.Text = "LIMPIAR";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(12, 692);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 23);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total:";
            lblTotal.Visible = false;
            // 
            // btnTotal
            // 
            btnTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTotal.BackColor = Color.Moccasin;
            btnTotal.FlatAppearance.BorderSize = 0;
            btnTotal.FlatStyle = FlatStyle.Popup;
            btnTotal.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotal.Location = new Point(12, 718);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(161, 31);
            btnTotal.TabIndex = 8;
            btnTotal.Text = "CALCULAR TOTAL";
            btnTotal.UseVisualStyleBackColor = false;
            btnTotal.Click += btnTotal_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1139, 798);
            Controls.Add(btnTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnClean);
            Controls.Add(dtpTo);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            Controls.Add(btnGenerateSummary);
            Controls.Add(dtpFrom);
            Controls.Add(lblFilterWorker);
            Controls.Add(txtFilterWorker);
            Controls.Add(lblDgvEmpty);
            Controls.Add(btnRemove);
            Controls.Add(gbxFilters);
            Controls.Add(btnDetails);
            Controls.Add(lblFilter);
            Controls.Add(dgvSales);
            Controls.Add(txtFilter);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HistoryForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += HistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            gbxFilters.ResumeLayout(false);
            gbxFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFilter;
        private DataGridView dgvSales;
        private TextBox txtFilter;
        private Button btnDetails;
        private RadioButton rbAZClient;
        private RadioButton rbTotal;
        private RadioButton rbDate;
        private GroupBox gbxFilters;
        private RadioButton rbLastSales;
        private Button btnRemove;
        private Label lblDgvEmpty;
        private Label lblFilterWorker;
        private TextBox txtFilterWorker;
        private DateTimePicker dtpFrom;
        private DateTimePicker dateTimePicker2;
        private Button btnGenerateSummary;
        private Label lblFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnClean;
        private Label lblTotal;
        private Button btnTotal;
    }
}