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
    public partial class UsersFrm : UserControl
    {
        HealthInformationSystemEntities db = new HealthInformationSystemEntities();
        private int User_ID;
        private int getAction = 0;
        public UsersFrm()
        {
            InitializeComponent();
            panel_newUser.Visible = false;
        }

        private void UsersFrm_Load(object sender, EventArgs e)
        {
            LoadListUsers();
        }

        private void gdv_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            getAction = 1;
            panel_newUser.Visible = true;
            btnU_Save.Text = "Save";
            txtU_Name.Clear();
            txtU_Password.Clear();
            txtU_Username.Clear();
        }

        public void LoadListUsers()
        {

            var u_users = (from u in db.Users
                             select new
                             {
                                 u.User_ID,
                                 u.Username,
                                 u.Name
                             }).ToList();

            gdv_Users.DataSource = u_users;
        }

        

        private void panel_newUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnU_Save_Click(object sender, EventArgs e)
        {
            if(getAction == 1)
            {
                createNew();
                LoadListUsers();
            }
            else if(getAction == 2)
            {

            }
        }

        private void createNew()
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
            new UsersFrm().LoadListUsers();
            getAction = 0;
        }

        private void retrieveUser()
        {
            if (gdv_Users.SelectedRows.Count != 0)
            {
                User_ID = (int)gdv_Users.SelectedCells[0].Value;

                var U_User = db.Users.Find(User_ID);

                txtU_Username.Text = U_User.Username;
                txtU_Name.Text = U_User.Name;
                txtU_Password.Text = U_User.Password;
                btnU_Save.Text = "UPDATE";
                panel_newUser.Visible = true;
                getAction = 0;
            }
        }

        private void btnU_Back_Click(object sender, EventArgs e)
        {
            panel_newUser.Visible = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void uPDATEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            getAction = 2;
            if (getAction == 2)
            {
                retrieveUser();
            }
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to remove this record?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                int id = (int)gdv_Users.SelectedCells[0].Value;
                var U_User = db.Users.Find(id);

                db.Users.Remove(U_User);
                db.SaveChanges();
                LoadListUsers();
                MessageBox.Show("Deleted.");
            }
        }
    }
}
