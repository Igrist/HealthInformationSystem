using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthInformationSystem
{
    public partial class LogInFrm : Form
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        public int User_ID;
        public LogInFrm()
        {
            InitializeComponent();
            
        }

        private void LogInFrm_Load(object sender, EventArgs e)
        {

        }

        private void txtL_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtL_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //var U_User = db.Users.Find(User_ID);

            //if (txtL_Username==Username && txtL_Password == Password)
            //{
            //    new Mainfrm().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("The Username or Password you entered is incorrect.");
            //    txtL_Username.Clear();
            //    txtL_Password.Clear();
            //}

        }
    }
}
