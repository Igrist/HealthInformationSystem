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
    public partial class NewPatient : Form
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        public NewPatient()
        {
            InitializeComponent();
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            //For ComboBox Date of Birth

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
            Patient p_patients = new Patient()
            {
                First_name = txtP_FirstName.Text,
                Last_name = txtP_LastName.Text,
                MI_name = txtP_MI.Text,
                Age = int.Parse(txtAge.Text),
                Date_of_birth = CmbDay.Text + "-" + CmbMonth.Text + "-" + CmbYear.Text,
                Gender = RdMale_P.Checked == true ? "Male" : "Female",
                Height = double.Parse(txtHeight.Text),
                Weight = double.Parse(txtWeight.Text),
                Address = txtAddress.Text,
                Contact_num = txtP_Contact.Text
            };


            db.Patients.Add(p_patients);
            db.SaveChanges();
            MessageBox.Show("Information Saved!");
            this.Hide();
            new PatientsFrm().LoadListPatients();
        }

        
    }
}
