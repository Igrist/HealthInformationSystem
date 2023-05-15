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
    public partial class PatientsFrm : UserControl
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        
        public PatientsFrm()
        {
            InitializeComponent();
            
        }

        private void PatientsFrm_Load(object sender, EventArgs e)
        {
            LoadListPatients();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            NewPatient Pfrm = new NewPatient();
            Pfrm.ShowDialog();
            LoadListPatients();
        }

        private void gdv_Patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadListPatients()
        {


            var p_patients = (from p in db.Patients
                              select new
                              {
                                  p.Patient_ID,
                                  p.First_name,
                                  p.Last_name,
                                  p.MI_name,
                                  p.Age,
                                  p.Date_of_birth,
                                  p.Gender,
                                  p.Height,
                                  p.Weight,
                                  p.Address,
                                  p.Contact_num
                              }).ToList();
            gdv_Patients.DataSource = p_patients;
        }


        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to remove this record?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                int id = (int)gdv_Patients.SelectedCells[0].Value;
                var p_patients = db.Patients.Find(id);

                db.Patients.Remove(p_patients);
                db.SaveChanges();
                LoadListPatients();
                MessageBox.Show("Deleted.");
            }
        }

        private void gdv_Patients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gdv_Patients.Rows.Count > 0) { 
                UpdatePatientFrm frm = new UpdatePatientFrm();
                frm.id = (int) gdv_Patients.SelectedCells[0].Value;
                frm.ShowDialog();
                LoadListPatients();
            }
        }
    }
}
