using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthInformationSystem
{
    public partial class DoctorsFrm : UserControl
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();

        public DoctorsFrm()
        {
            InitializeComponent();
        }

        private void gdv_Doctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_Doctors.Rows.Count > 0)
            {
                UpdateDoctorFrm frm = new UpdateDoctorFrm();
                frm.id = (int)gdv_Doctors.SelectedCells[0].Value;
                frm.ShowDialog();
                LoadListDoctors();
            }
        }

        private void btnNewDoctor_Click(object sender, EventArgs e)
        {
            NewDoctor Dfrm = new NewDoctor();
            Dfrm.ShowDialog();
            LoadListDoctors();
        }

        private void DoctorsFrm_Load(object sender, EventArgs e)
        {
            LoadListDoctors();
        }

        public void LoadListDoctors()
        {

            var d_doctors = (from d in db.Doctors
                             select new
                             {
                                 d.Doctor_ID,
                                 d.First_name,
                                 d.Last_name,
                                 d.MI_name,
                                 d.Specialty,
                                 d.Position,
                                 d.Gender,
                                 d.Contact_num
                             }).ToList();

            gdv_Doctors.DataSource = d_doctors;
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to remove this record?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                int id = (int)gdv_Doctors.SelectedCells[0].Value;
                var d_doctors = db.Doctors.Find(id);

                db.Doctors.Remove(d_doctors);
                db.SaveChanges();
                LoadListDoctors();
                MessageBox.Show("Deleted.");
            }
        }
        
    }
}
