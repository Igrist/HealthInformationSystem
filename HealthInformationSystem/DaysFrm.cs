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
    public partial class DaysFrm : UserControl
    {
        public DaysFrm()
        {
            InitializeComponent();
        }

        private void DaysFrm_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lblDay.Text = numday + "";
        }
    }
}
