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

    public partial class UpdateUserFrm : Form
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        public int id;
        public UpdateUserFrm()
        {
            InitializeComponent();
        }

        private void UpdateUserFrm_Load(object sender, EventArgs e)
        {
            var s_users = db.Users.Find(id);
            txtU_Username.Text = s_users.Username;
            txtU_Name.Text = s_users.Name;
            txtU_Password.Text = s_users.Password;
        }

        private void btnU_Save_Click(object sender, EventArgs e)
        {
            if (txtU_Password.Text == txt_cnfrmPass.Text)
            {
                User s_user = db.Users.Find(id);
                s_user.Username = txtU_Username.Text;
                s_user.Name = txtU_Name.Text;
                s_user.Password = txtU_Password.Text;

                db.SaveChanges();
                MessageBox.Show("Information Saved!");
                this.Hide();
                new UsersFrm().LoadListUsers();
            }
            else
            {
                MessageBox.Show("Password is incorrect!");
            }
        }
    }
}
