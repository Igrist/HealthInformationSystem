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
    }
}
