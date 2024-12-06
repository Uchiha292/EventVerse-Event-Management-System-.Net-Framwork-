namespace Event_management_System
{
    partial class AttendeeMainPage
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
            this.components = new System.ComponentModel.Container();
            this.EventDashboardLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProfileButton = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBPROJECTDataSet1 = new Event_management_System.DBPROJECTDataSet1();
            this.aTTENDEEEVENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTTENDEE_EVENTTableAdapter = new Event_management_System.DBPROJECTDataSet1TableAdapters.ATTENDEE_EVENTTableAdapter();
            this.attendeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPROJECTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDEEEVENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EventDashboardLabel
            // 
            this.EventDashboardLabel.AutoSize = true;
            this.EventDashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDashboardLabel.Location = new System.Drawing.Point(283, 134);
            this.EventDashboardLabel.Name = "EventDashboardLabel";
            this.EventDashboardLabel.Size = new System.Drawing.Size(225, 29);
            this.EventDashboardLabel.TabIndex = 20;
            this.EventDashboardLabel.Text = "Events Dashboard";
            this.EventDashboardLabel.Click += new System.EventHandler(this.EventDashboardLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "EventVerse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ProfileButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-8, -27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 89);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(209, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "EventDashboard";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.AutoSize = true;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.Location = new System.Drawing.Point(708, 44);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(68, 22);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(574, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Feedback";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Search Events";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendeeIDDataGridViewTextBoxColumn,
            this.eventIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aTTENDEEEVENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(720, 240);
            this.dataGridView1.TabIndex = 32;
            // 
            // dBPROJECTDataSet1
            // 
            this.dBPROJECTDataSet1.DataSetName = "DBPROJECTDataSet1";
            this.dBPROJECTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTTENDEEEVENTBindingSource
            // 
            this.aTTENDEEEVENTBindingSource.DataMember = "ATTENDEE_EVENT";
            this.aTTENDEEEVENTBindingSource.DataSource = this.dBPROJECTDataSet1;
            // 
            // aTTENDEE_EVENTTableAdapter
            // 
            this.aTTENDEE_EVENTTableAdapter.ClearBeforeFill = true;
            // 
            // attendeeIDDataGridViewTextBoxColumn
            // 
            this.attendeeIDDataGridViewTextBoxColumn.DataPropertyName = "AttendeeID";
            this.attendeeIDDataGridViewTextBoxColumn.HeaderText = "AttendeeID";
            this.attendeeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attendeeIDDataGridViewTextBoxColumn.Name = "attendeeIDDataGridViewTextBoxColumn";
            this.attendeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendeeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            this.eventIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // AttendeeMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EventDashboardLabel);
            this.Name = "AttendeeMainPage";
            this.Text = "AttendeeMainPage";
            this.Load += new System.EventHandler(this.AttendeeMainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPROJECTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDEEEVENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EventDashboardLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ProfileButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBPROJECTDataSet1 dBPROJECTDataSet1;
        private System.Windows.Forms.BindingSource aTTENDEEEVENTBindingSource;
        private DBPROJECTDataSet1TableAdapters.ATTENDEE_EVENTTableAdapter aTTENDEE_EVENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
    }
}