namespace WindowsFormsApp1
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewAllNotifications;
        private System.Windows.Forms.Button btnSendNotification;
        private System.Windows.Forms.Button btnNotificationSettings;
        private System.Windows.Forms.TextBox textBoxNotificationContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUserSelection;
        private System.Windows.Forms.Button btnSend;

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
            this.btnViewAllNotifications = new System.Windows.Forms.Button();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.btnNotificationSettings = new System.Windows.Forms.Button();
            this.textBoxNotificationContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUserSelection = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(341, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Notifications";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnViewAllNotifications);
            this.panel2.Controls.Add(this.btnSendNotification);
            this.panel2.Controls.Add(this.btnNotificationSettings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 440);
            this.panel2.TabIndex = 1;
            // 
            // btnViewAllNotifications
            // 
            this.btnViewAllNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAllNotifications.Location = new System.Drawing.Point(0, 80);
            this.btnViewAllNotifications.Name = "btnViewAllNotifications";
            this.btnViewAllNotifications.Size = new System.Drawing.Size(200, 40);
            this.btnViewAllNotifications.TabIndex = 0;
            this.btnViewAllNotifications.Text = "View All Notifications";
            this.btnViewAllNotifications.UseVisualStyleBackColor = true;
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSendNotification.Location = new System.Drawing.Point(0, 40);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(200, 40);
            this.btnSendNotification.TabIndex = 1;
            this.btnSendNotification.Text = "Send Notification";
            this.btnSendNotification.UseVisualStyleBackColor = true;
            // 
            // btnNotificationSettings
            // 
            this.btnNotificationSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotificationSettings.Location = new System.Drawing.Point(0, 0);
            this.btnNotificationSettings.Name = "btnNotificationSettings";
            this.btnNotificationSettings.Size = new System.Drawing.Size(200, 40);
            this.btnNotificationSettings.TabIndex = 2;
            this.btnNotificationSettings.Text = "Notification Settings";
            this.btnNotificationSettings.UseVisualStyleBackColor = true;
            // 
            // textBoxNotificationContent
            // 
            this.textBoxNotificationContent.Location = new System.Drawing.Point(402, 105);
            this.textBoxNotificationContent.Name = "textBoxNotificationContent";
            this.textBoxNotificationContent.Size = new System.Drawing.Size(200, 31);
            this.textBoxNotificationContent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select User:";
            // 
            // comboBoxUserSelection
            // 
            this.comboBoxUserSelection.FormattingEnabled = true;
            this.comboBoxUserSelection.Location = new System.Drawing.Point(402, 171);
            this.comboBoxUserSelection.Name = "comboBoxUserSelection";
            this.comboBoxUserSelection.Size = new System.Drawing.Size(200, 33);
            this.comboBoxUserSelection.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(317, 252);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(200, 30);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send Notification";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxNotificationContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUserSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Name = "Form5";
            this.Text = "Notifications Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
