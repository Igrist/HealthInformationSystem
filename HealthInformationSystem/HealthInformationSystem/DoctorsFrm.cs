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

        }

        private void btnNewDoctor_Click(object sender, EventArgs e)
        {
            NewDoctor Dfrm = new NewDoctor();
            Dfrm.ShowDialog();
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
    }
}
