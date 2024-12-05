namespace Event_management_System
{
    partial class Admin7
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnViewAllEvents;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.TextBox textBoxEventDate;
        private System.Windows.Forms.TextBox textBoxEventLocation;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.Button btnSearchEvent;
        private System.Windows.Forms.TextBox textBoxSearch;

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
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnViewAllEvents = new System.Windows.Forms.Button();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.textBoxEventDate = new System.Windows.Forms.TextBox();
            this.textBoxEventLocation = new System.Windows.Forms.TextBox();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.btnSearchEvent = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Events";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnAddNewEvent);
            this.panel2.Controls.Add(this.btnEditEvent);
            this.panel2.Controls.Add(this.btnDeleteEvent);
            this.panel2.Controls.Add(this.btnViewAllEvents);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 440);
            this.panel2.TabIndex = 1;
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewEvent.Location = new System.Drawing.Point(0, 120);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(200, 40);
            this.btnAddNewEvent.TabIndex = 0;
            this.btnAddNewEvent.Text = "Add New Event";
            this.btnAddNewEvent.UseVisualStyleBackColor = true;
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditEvent.Location = new System.Drawing.Point(0, 80);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(200, 40);
            this.btnEditEvent.TabIndex = 1;
            this.btnEditEvent.Text = "Edit Event";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteEvent.Location = new System.Drawing.Point(0, 40);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteEvent.TabIndex = 2;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnViewAllEvents
            // 
            this.btnViewAllEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAllEvents.Location = new System.Drawing.Point(0, 0);
            this.btnViewAllEvents.Name = "btnViewAllEvents";
            this.btnViewAllEvents.Size = new System.Drawing.Size(200, 40);
            this.btnViewAllEvents.TabIndex = 3;
            this.btnViewAllEvents.Text = "View All Events";
            this.btnViewAllEvents.UseVisualStyleBackColor = true;
            this.btnViewAllEvents.Click += new System.EventHandler(this.btnViewAllEvents_Click);
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(443, 109);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(200, 31);
            this.textBoxEventName.TabIndex = 4;
            // 
            // textBoxEventDate
            // 
            this.textBoxEventDate.Location = new System.Drawing.Point(443, 174);
            this.textBoxEventDate.Name = "textBoxEventDate";
            this.textBoxEventDate.Size = new System.Drawing.Size(200, 31);
            this.textBoxEventDate.TabIndex = 5;
            // 
            // textBoxEventLocation
            // 
            this.textBoxEventLocation.Location = new System.Drawing.Point(443, 233);
            this.textBoxEventLocation.Name = "textBoxEventLocation";
            this.textBoxEventLocation.Size = new System.Drawing.Size(200, 31);
            this.textBoxEventLocation.TabIndex = 6;
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(443, 300);
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(200, 31);
            this.textBoxEventDescription.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Event Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Event Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Event Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Event Description:";
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.Location = new System.Drawing.Point(336, 391);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(200, 30);
            this.btnSaveEvent.TabIndex = 12;
            this.btnSaveEvent.Text = "Save Event";
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            // 
            // btnSearchEvent
            // 
            this.btnSearchEvent.Location = new System.Drawing.Point(550, 20);
            this.btnSearchEvent.Name = "btnSearchEvent";
            this.btnSearchEvent.Size = new System.Drawing.Size(75, 30);
            this.btnSearchEvent.TabIndex = 13;
            this.btnSearchEvent.Text = "Search";
            this.btnSearchEvent.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(350, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 31);
            this.textBoxSearch.TabIndex = 14;
            // 
            // Form8
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxEventName);
            this.Controls.Add(this.textBoxEventDate);
            this.Controls.Add(this.textBoxEventLocation);
            this.Controls.Add(this.textBoxEventDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaveEvent);
            this.Controls.Add(this.btnSearchEvent);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "Form8";
            this.Text = "Event Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
