using DAPS.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAPS
{
    public partial class DaysUserControl : UserControl
    {
        public static string static_day;
        public List<Appointment> appions;

        public DaysUserControl()
        {
            InitializeComponent();
        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }
        private void DayUserControl_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
        }
        private void lbdays_Click(object sender, EventArgs e)
        {

        }

        private void displayEvent()
        {

            /*            MySqlConnection conn = new MySqlConnection(connstring);
                        conn.Open();
                        String sql = "SELECT * FROM tbl_calendar where date = ?";
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("date", calendar.static_year+"_"+ calendar.static_month + "_" +lbdays.Text);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lbevent.Text = reader["event"].ToString();
                        }
                        reader.Dispose();
                        cmd.Dispose();
                        conn.Close();*/
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string x = calendar.static_month.ToString();
            if (x.Count() == 1) {
                x = '0' + x;
            }
            string y = DaysUserControl.static_day;
            if (y.Count() == 1)
            {
                y = '0' + y;
            }
            var events = await Manager.DatabaseManager.GetEvents(y + "/" + x + "/" + calendar.static_year);
            appions = events;
            ViewAppointments viewAppointments = new ViewAppointments(appions);
            viewAppointments.ShowDialog();
        }
    }
}
