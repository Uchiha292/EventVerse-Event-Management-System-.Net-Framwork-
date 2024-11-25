namespace WindowsFormsApp1
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnEditRole;
        private System.Windows.Forms.Button btnAssignPermissions;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.CheckedListBox checkedListBoxPermissions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.btnAssignPermissions = new System.Windows.Forms.Button();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.checkedListBoxPermissions = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(373, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles and Permissions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnAddRole);
            this.panel2.Controls.Add(this.btnEditRole);
            this.panel2.Controls.Add(this.btnAssignPermissions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 440);
            this.panel2.TabIndex = 1;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRole.Location = new System.Drawing.Point(0, 80);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(200, 40);
            this.btnAddRole.TabIndex = 0;
            this.btnAddRole.Text = "Add New Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            // 
            // btnEditRole
            // 
            this.btnEditRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditRole.Location = new System.Drawing.Point(0, 40);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(200, 40);
            this.btnEditRole.TabIndex = 1;
            this.btnEditRole.Text = "Edit Role";
            this.btnEditRole.UseVisualStyleBackColor = true;
            // 
            // btnAssignPermissions
            // 
            this.btnAssignPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignPermissions.Location = new System.Drawing.Point(0, 0);
            this.btnAssignPermissions.Name = "btnAssignPermissions";
            this.btnAssignPermissions.Size = new System.Drawing.Size(200, 40);
            this.btnAssignPermissions.TabIndex = 2;
            this.btnAssignPermissions.Text = "Assign Permissions";
            this.btnAssignPermissions.UseVisualStyleBackColor = true;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(401, 75);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(200, 31);
            this.txtRoleName.TabIndex = 5;
            // 
            // checkedListBoxPermissions
            // 
            this.checkedListBoxPermissions.FormattingEnabled = true;
            this.checkedListBoxPermissions.Items.AddRange(new object[] {
            "View Users",
            "Edit Users",
            "Delete Users",
            "Assign Roles",
            "Manage Permissions"});
            this.checkedListBoxPermissions.Location = new System.Drawing.Point(401, 131);
            this.checkedListBoxPermissions.Name = "checkedListBoxPermissions";
            this.checkedListBoxPermissions.Size = new System.Drawing.Size(200, 88);
            this.checkedListBoxPermissions.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Role Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Permissions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Assigned Permissions";
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.checkedListBoxPermissions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Form3";
            this.Text = "Roles and Permissions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
