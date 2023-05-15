namespace HealthInformationSystem
{
    partial class PatientsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsFrm));
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gdv_Patients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Patients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.FlatAppearance.BorderSize = 0;
            this.btnNewPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPatient.Image")));
            this.btnNewPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPatient.Location = new System.Drawing.Point(235, 44);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(180, 54);
            this.btnNewPatient.TabIndex = 5;
            this.btnNewPatient.Text = "Add New";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patients List";
            // 
            // gdv_Patients
            // 
            this.gdv_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_Patients.ContextMenuStrip = this.contextMenuStrip1;
            this.gdv_Patients.Location = new System.Drawing.Point(39, 128);
            this.gdv_Patients.Name = "gdv_Patients";
            this.gdv_Patients.RowHeadersWidth = 51;
            this.gdv_Patients.RowTemplate.Height = 24;
            this.gdv_Patients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdv_Patients.Size = new System.Drawing.Size(1036, 532);
            this.gdv_Patients.TabIndex = 3;
            this.gdv_Patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_Patients_CellContentClick);
            this.gdv_Patients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_Patients_CellDoubleClick);
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
            // PatientsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdv_Patients);
            this.Name = "PatientsFrm";
            this.Size = new System.Drawing.Size(1109, 704);
            this.Load += new System.EventHandler(this.PatientsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Patients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdv_Patients;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
    }
}
