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
    public partial class NewUserfrm : Form
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        public NewUserfrm()
        {
            InitializeComponent();
        }

        private void btnU_Save_Click(object sender, EventArgs e)
        {
            User U_User = new User
            {
                Username = txtU_Username.Text,
                Name = txtU_Name.Text,
                Password = txtU_Password.Text
            };


            db.Users.Add(U_User);
            db.SaveChanges();
            MessageBox.Show("Information Saved!");
            this.Hide();
            new UsersFrm().LoadListUsers();
        }

        private void NewUserfrm_Load(object sender, EventArgs e)
        {

        }

        private void lbl_RegNewUSer_Click(object sender, EventArgs e)
        {

        }
    }
}
