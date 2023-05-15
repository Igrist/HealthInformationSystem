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
    public partial class UpdateDoctorFrm : Form
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        public int id;
        public UpdateDoctorFrm()
        {
            InitializeComponent();
        }

        private void UpdateDoctorFrm_Load(object sender, EventArgs e)
        {
            var s_doctors = db.Doctors.Find(id);
            txtD_FirstName.Text = s_doctors.First_name;
            txtD_LastName.Text = s_doctors.Last_name;
            txtD_MI.Text = s_doctors.MI_name;
            txtD_Contact.Text = s_doctors.Contact_num.ToString();
            txtPosition.Text = s_doctors.Position;
            txtSpeacialty.Text = s_doctors.Specialty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var s_doctors = db.Doctors.Find(id);

            s_doctors.First_name = txtD_FirstName.Text;
            s_doctors.Last_name= txtD_LastName.Text;
            s_doctors.MI_name= txtD_MI.Text;
            s_doctors.Contact_num = int.Parse(txtD_Contact.Text);
            s_doctors.Position = txtPosition.Text;
            s_doctors.Specialty = txtSpeacialty.Text;


            db.SaveChanges();
            MessageBox.Show("Information Saved!");
            this.Hide();
            new DoctorsFrm().LoadListDoctors();
        }
    }
}
