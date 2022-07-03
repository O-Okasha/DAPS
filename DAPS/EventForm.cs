using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DAPS
{
    public partial class EventForm : Form
    {
        string connstring = "server=localhost;user id=root;database=db_calendar;";
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            textdate.Text = calendar.static_month+ "/" + DaysUserControl.static_day + "/" + calendar.static_year;
        }
        private void save_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date,event)values(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", textdate.Text);
            cmd.Parameters.AddWithValue("event", textevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();



        }
    }
}
