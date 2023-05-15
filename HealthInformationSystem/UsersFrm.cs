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
        public UsersFrm()
        {
            InitializeComponent();
            
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
            NewUserfrm Ufrm = new NewUserfrm();
            Ufrm.ShowDialog();
            LoadListUsers();
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


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void uPDATEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
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

        private void gdv_Users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_Users.Rows.Count > 0)
            {
                UpdateUserFrm frm = new UpdateUserFrm();
                frm.id = (int)gdv_Users.SelectedCells[0].Value;
                frm.ShowDialog();
                LoadListUsers();
            }
        }
    }
}
