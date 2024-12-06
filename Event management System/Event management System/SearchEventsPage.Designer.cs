namespace Event_management_System
{
    partial class SearchEventsPage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProfileButton = new System.Windows.Forms.Label();
            this.FeedbackButton = new System.Windows.Forms.Label();
            this.SearchEventsButton = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EventDashboardButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eVENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPROJECTDataSet = new Event_management_System.DBPROJECTDataSet();
            this.eVENTSTableAdapter = new Event_management_System.DBPROJECTDataSetTableAdapters.EVENTSTableAdapter();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPROJECTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 26);
            this.textBox1.TabIndex = 72;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProfileButton
            // 
            this.ProfileButton.AutoSize = true;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.Location = new System.Drawing.Point(706, 45);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(68, 22);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // FeedbackButton
            // 
            this.FeedbackButton.AutoSize = true;
            this.FeedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedbackButton.Location = new System.Drawing.Point(572, 45);
            this.FeedbackButton.Name = "FeedbackButton";
            this.FeedbackButton.Size = new System.Drawing.Size(97, 22);
            this.FeedbackButton.TabIndex = 1;
            this.FeedbackButton.Text = "Feedback";
            this.FeedbackButton.Click += new System.EventHandler(this.FeedbackButton_Click);
            // 
            // SearchEventsButton
            // 
            this.SearchEventsButton.AutoSize = true;
            this.SearchEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEventsButton.Location = new System.Drawing.Point(397, 45);
            this.SearchEventsButton.Name = "SearchEventsButton";
            this.SearchEventsButton.Size = new System.Drawing.Size(140, 22);
            this.SearchEventsButton.TabIndex = 2;
            this.SearchEventsButton.Text = "Search Events";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EventDashboardButton);
            this.groupBox1.Controls.Add(this.ProfileButton);
            this.groupBox1.Controls.Add(this.FeedbackButton);
            this.groupBox1.Controls.Add(this.SearchEventsButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-6, -28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 89);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "EventDashboard";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EventDashboardButton
            // 
            this.EventDashboardButton.Location = new System.Drawing.Point(0, 0);
            this.EventDashboardButton.Name = "EventDashboardButton";
            this.EventDashboardButton.Size = new System.Drawing.Size(100, 23);
            this.EventDashboardButton.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "EventVerse";
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.Location = new System.Drawing.Point(305, 94);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(180, 29);
            this.ProfileLabel.TabIndex = 69;
            this.ProfileLabel.Text = "Search Events";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Catery,
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eVENTSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(712, 214);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eVENTSBindingSource
            // 
            this.eVENTSBindingSource.DataMember = "EVENTS";
            this.eVENTSBindingSource.DataSource = this.dBPROJECTDataSet;
            // 
            // dBPROJECTDataSet
            // 
            this.dBPROJECTDataSet.DataSetName = "DBPROJECTDataSet";
            this.dBPROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eVENTSTableAdapter
            // 
            this.eVENTSTableAdapter.ClearBeforeFill = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // Catery
            // 
            this.Catery.DataPropertyName = "Catery";
            this.Catery.HeaderText = "Catery";
            this.Catery.MinimumWidth = 8;
            this.Catery.Name = "Catery";
            this.Catery.ReadOnly = true;
            this.Catery.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 150;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // SearchEventsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProfileLabel);
            this.Name = "SearchEventsPage";
            this.Text = "SearchEventsPage";
            this.Load += new System.EventHandler(this.SearchEventsPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPROJECTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ProfileButton;
        private System.Windows.Forms.Label FeedbackButton;
        private System.Windows.Forms.Label SearchEventsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label EventDashboardButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBPROJECTDataSet dBPROJECTDataSet;
        private System.Windows.Forms.BindingSource eVENTSBindingSource;
        private DBPROJECTDataSetTableAdapters.EVENTSTableAdapter eVENTSTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catery;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    }
}