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
    public partial class Mainfrm : Form
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        public Mainfrm()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeFrm1.Visible = true;
            appointmentsFrm1.Visible = false;
            patientsFrm1.Visible = false;
            doctorsFrm1.Visible = false;
            usersFrm1.Visible = false;
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            appointmentsFrm1.Visible = true;
            patientsFrm1.Visible = false;
            doctorsFrm1.Visible = false;
            usersFrm1.Visible = false;
            homeFrm1.Visible = false;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            patientsFrm1.Visible = true;
            doctorsFrm1.Visible = false;
            usersFrm1.Visible = false;
            homeFrm1.Visible = false;
            appointmentsFrm1.Visible = false;
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            doctorsFrm1.Visible = true;
            usersFrm1.Visible = false;
            patientsFrm1.Visible = false;
            homeFrm1.Visible = false;
            appointmentsFrm1.Visible = false;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            usersFrm1.Visible = true;
            patientsFrm1.Visible = false;
            doctorsFrm1.Visible = false;
            homeFrm1.Visible = false;
            appointmentsFrm1.Visible = false;
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {

        }

        private void usersFrm1_Load(object sender, EventArgs e)
        {

        }

        private void doctorsFrm1_Load(object sender, EventArgs e)
        {

        }

        private void patientsFrm1_Load(object sender, EventArgs e)
        {

        }

        private void appointmentsFrm1_Load(object sender, EventArgs e)
        {

        }

        private void homeFrm1_Load(object sender, EventArgs e)
        {

        }
    }
}
