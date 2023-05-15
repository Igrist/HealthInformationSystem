namespace HealthInformationSystem
{
    partial class DoctorsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsFrm));
            this.gdv_Doctors = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Doctors)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdv_Doctors
            // 
            this.gdv_Doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_Doctors.ContextMenuStrip = this.contextMenuStrip1;
            this.gdv_Doctors.Location = new System.Drawing.Point(39, 128);
            this.gdv_Doctors.Name = "gdv_Doctors";
            this.gdv_Doctors.RowHeadersWidth = 51;
            this.gdv_Doctors.RowTemplate.Height = 24;
            this.gdv_Doctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdv_Doctors.Size = new System.Drawing.Size(1036, 532);
            this.gdv_Doctors.TabIndex = 0;
            this.gdv_Doctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_Doctors_CellContentClick);
            this.gdv_Doctors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_Doctors_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 28);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctors List";
            // 
            // btnNewDoctor
            // 
            this.btnNewDoctor.FlatAppearance.BorderSize = 0;
            this.btnNewDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNewDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDoctor.Image")));
            this.btnNewDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDoctor.Location = new System.Drawing.Point(235, 44);
            this.btnNewDoctor.Name = "btnNewDoctor";
            this.btnNewDoctor.Size = new System.Drawing.Size(180, 54);
            this.btnNewDoctor.TabIndex = 2;
            this.btnNewDoctor.Text = "Add New";
            this.btnNewDoctor.UseVisualStyleBackColor = true;
            this.btnNewDoctor.Click += new System.EventHandler(this.btnNewDoctor_Click);
            // 
            // DoctorsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.btnNewDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdv_Doctors);
            this.Name = "DoctorsFrm";
            this.Size = new System.Drawing.Size(1109, 704);
            this.Load += new System.EventHandler(this.DoctorsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Doctors)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdv_Doctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewDoctor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
    }
}
