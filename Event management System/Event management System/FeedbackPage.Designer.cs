namespace Event_management_System
{
    partial class FeedbackPage
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
            this.ProfileButton = new System.Windows.Forms.Label();
            this.FeedbackButton = new System.Windows.Forms.Label();
            this.SearchEventsButton = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EventDashboardButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.AttendedEventsList = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.SearchEventsButton.Click += new System.EventHandler(this.SearchEventsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.EventDashboardButton);
            this.groupBox1.Controls.Add(this.ProfileButton);
            this.groupBox1.Controls.Add(this.FeedbackButton);
            this.groupBox1.Controls.Add(this.SearchEventsButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-6, -28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 89);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // EventDashboardButton
            // 
            this.EventDashboardButton.AutoSize = true;
            this.EventDashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDashboardButton.Location = new System.Drawing.Point(207, 45);
            this.EventDashboardButton.Name = "EventDashboardButton";
            this.EventDashboardButton.Size = new System.Drawing.Size(158, 22);
            this.EventDashboardButton.TabIndex = 20;
            this.EventDashboardButton.Text = "EventDashboard";
            this.EventDashboardButton.Click += new System.EventHandler(this.EventDashboardButton_Click);
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
            this.ProfileLabel.Location = new System.Drawing.Point(332, 90);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(129, 29);
            this.ProfileLabel.TabIndex = 76;
            this.ProfileLabel.Text = "Feedback";
            // 
            // AttendedEventsList
            // 
            this.AttendedEventsList.ForeColor = System.Drawing.SystemColors.GrayText;
            this.AttendedEventsList.FormattingEnabled = true;
            this.AttendedEventsList.ItemHeight = 20;
            this.AttendedEventsList.Location = new System.Drawing.Point(244, 149);
            this.AttendedEventsList.Name = "AttendedEventsList";
            this.AttendedEventsList.Size = new System.Drawing.Size(303, 24);
            this.AttendedEventsList.TabIndex = 81;
            this.AttendedEventsList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.richTextBox1.Location = new System.Drawing.Point(190, 234);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(412, 96);
            this.richTextBox1.TabIndex = 82;
            this.richTextBox1.Text = "Feedback";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 83;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FeedbackPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AttendedEventsList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProfileLabel);
            this.Name = "FeedbackPage";
            this.Text = "FeedbackPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProfileButton;
        private System.Windows.Forms.Label FeedbackButton;
        private System.Windows.Forms.Label SearchEventsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label EventDashboardButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.ListBox AttendedEventsList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}