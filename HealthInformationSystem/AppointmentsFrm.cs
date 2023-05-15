using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthInformationSystem
{
    public partial class AppointmentsFrm : UserControl
    {
        int month, year;
        public AppointmentsFrm()
        {
            InitializeComponent();
        }

        private void AppointmentsFrm_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void txt_next_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d") + 1);

            for (int i = 1; i < daysoftheweek; i++)
            {
                BlankFrm ucblank = new BlankFrm();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                DaysFrm ucdays = new DaysFrm();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }

        private void txt_previous_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d") + 1);

            for (int i = 1; i < daysoftheweek; i++)
            {
                BlankFrm ucblank = new BlankFrm();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                DaysFrm ucdays = new DaysFrm();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_MonthYear.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")+1);

            for(int i =1; i < daysoftheweek; i++) { 
                BlankFrm ucblank = new BlankFrm();
                daycontainer.Controls.Add(ucblank);
            }

            for(int i = 1; i <= days; i++) { 
                DaysFrm ucdays = new DaysFrm();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
