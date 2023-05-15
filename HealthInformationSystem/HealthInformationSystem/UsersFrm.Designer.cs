namespace HealthInformationSystem
{
    partial class UsersFrm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersFrm));
            this.btnNewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gdv_Users = new System.Windows.Forms.DataGridView();
            this.panel_newUser = new System.Windows.Forms.Panel();
            this.lbl_RegNewUSer = new System.Windows.Forms.Label();
            this.btnU_Back = new System.Windows.Forms.Button();
            this.btnU_Clear = new System.Windows.Forms.Button();
            this.btnU_Cancel = new System.Windows.Forms.Button();
            this.btnU_Save = new System.Windows.Forms.Button();
            this.txtU_Password = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtU_Name = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtU_Username = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Users)).BeginInit();
            this.panel_newUser.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUser.Image")));
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.Location = new System.Drawing.Point(235, 44);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(180, 54);
            this.btnNewUser.TabIndex = 8;
            this.btnNewUser.Text = "Add New";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Users";
            // 
            // gdv_Users
            // 
            this.gdv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_Users.ContextMenuStrip = this.contextMenuStrip1;
            this.gdv_Users.Location = new System.Drawing.Point(39, 128);
            this.gdv_Users.Name = "gdv_Users";
            this.gdv_Users.RowHeadersWidth = 51;
            this.gdv_Users.RowTemplate.Height = 24;
            this.gdv_Users.Size = new System.Drawing.Size(1036, 532);
            this.gdv_Users.TabIndex = 6;
            this.gdv_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_Users_CellContentClick);
            // 
            // panel_newUser
            // 
            this.panel_newUser.Controls.Add(this.lbl_RegNewUSer);
            this.panel_newUser.Controls.Add(this.btnU_Back);
            this.panel_newUser.Controls.Add(this.btnU_Clear);
            this.panel_newUser.Controls.Add(this.btnU_Cancel);
            this.panel_newUser.Controls.Add(this.btnU_Save);
            this.panel_newUser.Controls.Add(this.txtU_Password);
            this.panel_newUser.Controls.Add(this.lblPassword);
            this.panel_newUser.Controls.Add(this.txtU_Name);
            this.panel_newUser.Controls.Add(this.lblName);
            this.panel_newUser.Controls.Add(this.txtU_Username);
            this.panel_newUser.Controls.Add(this.lblUserName);
            this.panel_newUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_newUser.Location = new System.Drawing.Point(0, 0);
            this.panel_newUser.Name = "panel_newUser";
            this.panel_newUser.Size = new System.Drawing.Size(1109, 704);
            this.panel_newUser.TabIndex = 9;
            this.panel_newUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_newUser_Paint);
            // 
            // lbl_RegNewUSer
            // 
            this.lbl_RegNewUSer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_RegNewUSer.AutoSize = true;
            this.lbl_RegNewUSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RegNewUSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegNewUSer.ForeColor = System.Drawing.Color.Black;
            this.lbl_RegNewUSer.Location = new System.Drawing.Point(444, 127);
            this.lbl_RegNewUSer.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_RegNewUSer.Name = "lbl_RegNewUSer";
            this.lbl_RegNewUSer.Size = new System.Drawing.Size(234, 29);
            this.lbl_RegNewUSer.TabIndex = 111;
            this.lbl_RegNewUSer.Text = "Register New User";
            // 
            // btnU_Back
            // 
            this.btnU_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnU_Back.FlatAppearance.BorderSize = 0;
            this.btnU_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnU_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU_Back.ForeColor = System.Drawing.Color.Black;
            this.btnU_Back.Image = ((System.Drawing.Image)(resources.GetObject("btnU_Back.Image")));
            this.btnU_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnU_Back.Location = new System.Drawing.Point(284, 119);
            this.btnU_Back.Name = "btnU_Back";
            this.btnU_Back.Size = new System.Drawing.Size(130, 50);
            this.btnU_Back.TabIndex = 110;
            this.btnU_Back.Text = "Back";
            this.btnU_Back.UseVisualStyleBackColor = true;
            this.btnU_Back.Click += new System.EventHandler(this.btnU_Back_Click);
            // 
            // btnU_Clear
            // 
            this.btnU_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnU_Clear.FlatAppearance.BorderSize = 0;
            this.btnU_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnU_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU_Clear.ForeColor = System.Drawing.Color.Black;
            this.btnU_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btnU_Clear.Image")));
            this.btnU_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnU_Clear.Location = new System.Drawing.Point(297, 536);
            this.btnU_Clear.Name = "btnU_Clear";
            this.btnU_Clear.Size = new System.Drawing.Size(172, 50);
            this.btnU_Clear.TabIndex = 109;
            this.btnU_Clear.Text = "Clear";
            this.btnU_Clear.UseVisualStyleBackColor = true;
            // 
            // btnU_Cancel
            // 
            this.btnU_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnU_Cancel.FlatAppearance.BorderSize = 0;
            this.btnU_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnU_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btnU_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btnU_Cancel.Image")));
            this.btnU_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnU_Cancel.Location = new System.Drawing.Point(475, 536);
            this.btnU_Cancel.Name = "btnU_Cancel";
            this.btnU_Cancel.Size = new System.Drawing.Size(172, 50);
            this.btnU_Cancel.TabIndex = 108;
            this.btnU_Cancel.Text = "Cancel";
            this.btnU_Cancel.UseVisualStyleBackColor = true;
            // 
            // btnU_Save
            // 
            this.btnU_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnU_Save.FlatAppearance.BorderSize = 0;
            this.btnU_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnU_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU_Save.ForeColor = System.Drawing.Color.Black;
            this.btnU_Save.Image = ((System.Drawing.Image)(resources.GetObject("btnU_Save.Image")));
            this.btnU_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnU_Save.Location = new System.Drawing.Point(653, 536);
            this.btnU_Save.Name = "btnU_Save";
            this.btnU_Save.Size = new System.Drawing.Size(172, 50);
            this.btnU_Save.TabIndex = 107;
            this.btnU_Save.Text = "Save";
            this.btnU_Save.UseVisualStyleBackColor = true;
            this.btnU_Save.Click += new System.EventHandler(this.btnU_Save_Click);
            // 
            // txtU_Password
            // 
            this.txtU_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtU_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU_Password.Location = new System.Drawing.Point(395, 404);
            this.txtU_Password.Name = "txtU_Password";
            this.txtU_Password.PasswordChar = '*';
            this.txtU_Password.Size = new System.Drawing.Size(315, 26);
            this.txtU_Password.TabIndex = 106;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(391, 381);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 20);
            this.lblPassword.TabIndex = 105;
            this.lblPassword.Text = "Password:";
            // 
            // txtU_Name
            // 
            this.txtU_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtU_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU_Name.Location = new System.Drawing.Point(395, 343);
            this.txtU_Name.Name = "txtU_Name";
            this.txtU_Name.Size = new System.Drawing.Size(315, 26);
            this.txtU_Name.TabIndex = 104;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(391, 320);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 103;
            this.lblName.Text = "Name:";
            // 
            // txtU_Username
            // 
            this.txtU_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtU_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU_Username.Location = new System.Drawing.Point(395, 280);
            this.txtU_Username.Name = "txtU_Username";
            this.txtU_Username.Size = new System.Drawing.Size(315, 26);
            this.txtU_Username.TabIndex = 102;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(391, 257);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 20);
            this.lblUserName.TabIndex = 101;
            this.lblUserName.Text = "Username:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uPDATEToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // uPDATEToolStripMenuItem
            // 
            this.uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            this.uPDATEToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.uPDATEToolStripMenuItem.Text = "UPDATE";
            this.uPDATEToolStripMenuItem.Click += new System.EventHandler(this.uPDATEToolStripMenuItem_Click_1);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // UsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.panel_newUser);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdv_Users);
            this.Name = "UsersFrm";
            this.Size = new System.Drawing.Size(1109, 704);
            this.Load += new System.EventHandler(this.UsersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Users)).EndInit();
            this.panel_newUser.ResumeLayout(false);
            this.panel_newUser.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdv_Users;
        private System.Windows.Forms.Panel panel_newUser;
        private System.Windows.Forms.Label lbl_RegNewUSer;
        private System.Windows.Forms.Button btnU_Back;
        private System.Windows.Forms.Button btnU_Clear;
        private System.Windows.Forms.Button btnU_Cancel;
        private System.Windows.Forms.Button btnU_Save;
        private System.Windows.Forms.TextBox txtU_Password;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtU_Name;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtU_Username;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
    }
}
