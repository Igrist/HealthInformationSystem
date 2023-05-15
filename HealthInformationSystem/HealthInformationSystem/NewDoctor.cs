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
    public partial class NewDoctor : Form
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        public NewDoctor()
        {
            InitializeComponent();
        }

        private void NewDoctor_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Doctor d_doctors = new Doctor()
            {
                First_name = txtD_FirstName.Text,
                Last_name = txtD_LastName.Text,
                MI_name = txtD_MI.Text,
                Gender = RdMale_D.Checked == true ? "Male" : "Female",
                Position = txtPosition.Text,
                Specialty = txtSpeacialty.Text,
                Contact_num = int.Parse(txtD_Contact.Text)
            };

            db.Doctors.Add(d_doctors);
            db.SaveChanges();
            MessageBox.Show("Information Saved!");
            this.Hide();
            new DoctorsFrm().LoadListDoctors();
        }
    }
}
