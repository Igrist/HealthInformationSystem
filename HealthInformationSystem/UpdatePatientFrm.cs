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
    public partial class UpdatePatientFrm : Form
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        public int id;
        public UpdatePatientFrm()
        {
            InitializeComponent();
        }

        private void UpdatePatientFrm_Load(object sender, EventArgs e)
        {
            var s_patient = db.Patients.Find(id);
            txtP_FirstName.Text = s_patient.First_name;
            txtP_LastName.Text = s_patient.Last_name;
            txtP_MI.Text = s_patient.MI_name;
            txtP_Contact.Text = s_patient.Contact_num.ToString();
            txtAddress.Text = s_patient.Address;
            txtAge.Text = s_patient.Age.ToString();
            txtHeight.Text = s_patient.Height.ToString();
            txtWeight.Text = s_patient.Weight.ToString();



            for (int i = 1; i < 32; i++)
            {
                CmbDay.DisplayMember = i.ToString();
                CmbDay.ValueMember = i.ToString();
                CmbDay.Items.Add(i.ToString());
            }


            for (int i = 1; i < 13; i++)
            {
                CmbMonth.DisplayMember = i.ToString();
                CmbMonth.ValueMember = i.ToString();
                CmbMonth.Items.Add(i.ToString());
            }


            for (int i = 1990; i < 2024; i++)
            {
                CmbYear.DisplayMember = i.ToString();
                CmbYear.ValueMember = i.ToString();
                CmbYear.Items.Add(i.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var s_patient = db.Patients.Find(id);
            s_patient.First_name = txtP_FirstName.Text;
            s_patient.Last_name = txtP_LastName.Text;
            s_patient.MI_name = txtP_MI.Text;
            s_patient.Contact_num = txtP_Contact.Text;
            s_patient.Address = txtAddress.Text;
            s_patient.Age = int.Parse(txtAge.Text);
            s_patient.Height= double.Parse(txtHeight.Text);
            s_patient.Weight= double.Parse(txtWeight.Text);
            s_patient.Date_of_birth = CmbDay.Text + "-" + CmbMonth.Text + "-" + CmbYear.Text;
            s_patient.Gender = RdMale_P.Checked == true ? "Male" : "Female";


            db.SaveChanges();
            MessageBox.Show("Information Saved!");
            this.Hide();
            new PatientsFrm().LoadListPatients();
        }
    }
}
