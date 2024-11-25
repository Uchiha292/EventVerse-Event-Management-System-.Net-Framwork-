namespace Admin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnActiveUsers = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.labelTotalUsers = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 94);
            this.panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(18, 28);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(367, 51);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "EventVerse | Admin Dashboard";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSidebar.Controls.Add(this.button1);
            this.panelSidebar.Controls.Add(this.btnEvents);
            this.panelSidebar.Controls.Add(this.btnActiveUsers);
            this.panelSidebar.Controls.Add(this.btnNotifications);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 94);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(300, 609);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnEvents
            // 
            this.btnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvents.Location = new System.Drawing.Point(0, 72);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(300, 36);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // btnActiveUsers
            // 
            this.btnActiveUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActiveUsers.Location = new System.Drawing.Point(0, 36);
            this.btnActiveUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActiveUsers.Name = "btnActiveUsers";
            this.btnActiveUsers.Size = new System.Drawing.Size(300, 36);
            this.btnActiveUsers.TabIndex = 2;
            this.btnActiveUsers.Text = "User Management";
            this.btnActiveUsers.UseVisualStyleBackColor = true;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifications.Location = new System.Drawing.Point(0, 0);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(300, 36);
            this.btnNotifications.TabIndex = 1;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // labelTotalUsers
            // 
            this.labelTotalUsers.AutoSize = true;
            this.labelTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTotalUsers.Location = new System.Drawing.Point(356, 118);
            this.labelTotalUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalUsers.Name = "labelTotalUsers";
            this.labelTotalUsers.Size = new System.Drawing.Size(430, 37);
            this.labelTotalUsers.TabIndex = 2;
            this.labelTotalUsers.Text = "Welcome to the Admin Panel";
            this.labelTotalUsers.Click += new System.EventHandler(this.labelTotalUsers_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:                      zurrafa1990@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name:             Zurrafa   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalUsers);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnActiveUsers;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Label labelTotalUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
