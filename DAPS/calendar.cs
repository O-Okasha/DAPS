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

namespace DAPS
{
    public partial class calendar : UserControl
    {
        int month, year;
        public static int static_month, static_year;

        public calendar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //listviewUserControl listview = new listviewUserControl();
            //panel1.Controls.Add(listview);

        }

        private void calendar_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text =monthname + " " + year;



            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);


            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                calendarUserControl ucblank = new calendarUserControl();
                flowLayoutPanel1.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                DaysUserControl ucdays = new DaysUserControl();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);

            }
        }

        private void panel1calendar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbdate_Click(object sender, EventArgs e)
        {

        }

        private void Pervious_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);


            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                calendarUserControl ucblank = new calendarUserControl();
                flowLayoutPanel1.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                DaysUserControl ucdays = new DaysUserControl();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);


            }
        }

        private void Next_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();

            month++;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);




            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                calendarUserControl ucblank = new calendarUserControl();
                flowLayoutPanel1.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                DaysUserControl ucdays = new DaysUserControl();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);


            }
        }
    }
}
    
