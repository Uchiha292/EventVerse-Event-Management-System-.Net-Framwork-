namespace Event_management_System
{
    partial class Admin3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUserActivityReport;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnSystemLogs;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUserActivityReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnSystemLogs = new System.Windows.Forms.Button();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports Section";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnUserActivityReport);
            this.panel2.Controls.Add(this.btnSalesReport);
            this.panel2.Controls.Add(this.btnSystemLogs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 440);
            this.panel2.TabIndex = 1;
            // 
            // btnUserActivityReport
            // 
            this.btnUserActivityReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserActivityReport.Location = new System.Drawing.Point(0, 80);
            this.btnUserActivityReport.Name = "btnUserActivityReport";
            this.btnUserActivityReport.Size = new System.Drawing.Size(200, 40);
            this.btnUserActivityReport.TabIndex = 0;
            this.btnUserActivityReport.Text = "User Activity Report";
            this.btnUserActivityReport.UseVisualStyleBackColor = true;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesReport.Location = new System.Drawing.Point(0, 40);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(200, 40);
            this.btnSalesReport.TabIndex = 1;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnSystemLogs
            // 
            this.btnSystemLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemLogs.Location = new System.Drawing.Point(0, 0);
            this.btnSystemLogs.Name = "btnSystemLogs";
            this.btnSystemLogs.Size = new System.Drawing.Size(200, 40);
            this.btnSystemLogs.TabIndex = 2;
            this.btnSystemLogs.Text = "System Logs";
            this.btnSystemLogs.UseVisualStyleBackColor = true;
            this.btnSystemLogs.Click += new System.EventHandler(this.btnSystemLogs_Click);
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] {
            "User Activity",
            "Sales",
            "System Logs"});
            this.comboBoxReportType.Location = new System.Drawing.Point(398, 282);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(200, 33);
            this.comboBoxReportType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Report";
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.ColumnHeadersHeight = 46;
            this.dataGridViewReports.Location = new System.Drawing.Point(250, 60);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowHeadersWidth = 82;
            this.dataGridViewReports.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewReports.TabIndex = 3;
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.comboBoxReportType);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewReports;
    }
}
