﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace up123
{
    public partial class Visits : Form
    {
        public string id;
        string connectionString = "Data Source=10.10.1.24;Initial Catalog=up123;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        public Visits()
        {
            InitializeComponent();
        }

        private void Visits_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT Title, StartTime, DurationInSeconds FROM Client,ClientService,Service WHERE Client.ID =ClientService.ClientID AND ServiceID = Service.ID AND Client.ID ='" + id + "'";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    VisitsGrid.DataSource = ds.Tables[0];
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка");
            }
        }
    }
}
