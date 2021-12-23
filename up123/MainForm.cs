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

namespace up123
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Connect("SELECT * FROM Client");
            CBRowItems();
            AllCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
            RowsCount();
        }
        int id = 101; int ids = 100000; int idPLUS = 25;
        string connectionString = "Data Source=10.10.1.24;Initial Catalog=up123;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        ClientsForm Client1 = new ClientsForm();
        void Connect(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridClients.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        void CBRowItems()
        {
            CBRow.Items.AddRange(new string[] { "10 Записей", "50 Записей", "200 Записей", "Все записи" });
            CBRow.SelectedIndex = 3;
        }
        string SelectMaxID(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int reader = (int)command.ExecuteScalar();
                string maxID = reader.ToString();
                connection.Close();
                RowsCount();
                return maxID.ToString();
            }
        }
        void RowsCount()
        {
            int rows = GridClients.Rows.Count;
            rows = rows - 1;
            CurrentCount.Text = rows.ToString();
        }

        private void CBRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SState = CBRow.SelectedItem.ToString();
            if (SState == "10 Записей")
            {
               Connect("SELECT TOP (10) * FROM Client");
                idPLUS = 10; ids = 110; id = 101;
                RowsCount();
            }
            if (SState == "50 Записей")
            {
                Connect("SELECT TOP (50) * FROM Client");
                idPLUS = 25; ids = 150; id = 101;
                RowsCount();
            }
            if (SState == "200 Записей")
            {
                Connect("SELECT TOP (200) * FROM Client");
                idPLUS = 25; ids = 200; id = 101;
                RowsCount();
            }
            if (SState == "Все Записи")
            {
                Connect("SELECT * FROM Client");
                idPLUS = 25; ids = 100000; id = 101;
                RowsCount();
            }
        }
        private void FirstnameBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstnameBox.Text != "")
            {
                Connect("SELECT * FROM Client WHERE FirstName LIKE'"+ FirstnameBox.Text + "%'");
                PreviousBTN.Enabled = false; NextBTN.Enabled = false;
                RowsCount();
            }
            else
            {
                PreviousBTN.Enabled = true; NextBTN.Enabled = true;
                Connect("SELECT * FROM Client");
                RowsCount();
            }
        }
        private void LastnameBox_TextChanged(object sender, EventArgs e)
        {
            if (LastnameBox.Text != "")
            {
                Connect("SELECT * FROM Client WHERE LastName LIKE'" + LastnameBox.Text + "%'");
                PreviousBTN.Enabled = false; NextBTN.Enabled = false;
                RowsCount();
            }
            else
            {
                PreviousBTN.Enabled = true; NextBTN.Enabled = true;
                Connect("SELECT * FROM Client");
                RowsCount();
            }
        }
        private void PatronymicBox_TextChanged(object sender, EventArgs e)
        {
            if (PatronymicBox.Text != "")
            {
                Connect("SELECT * FROM Client WHERE Patronymic LIKE'" + PatronymicBox.Text + "%'");
                PreviousBTN.Enabled = false; NextBTN.Enabled = false;
                RowsCount();
            }
            else
            {
                PreviousBTN.Enabled = true; NextBTN.Enabled = true;
                Connect("SELECT * FROM Client");
                RowsCount();
            }
        }
        private void PreviousBTN_Click(object sender, EventArgs e)
        {
            id=id-idPLUS; ids = ids - idPLUS;
            Connect("SELECT * FROM Client WHERE ID BETWEEN " + id + " AND " + ids);
        }
        private void NextBTN_Click(object sender, EventArgs e)
        {
            id = id+idPLUS; ids = ids + idPLUS;
            Connect("SELECT * FROM Client WHERE ID BETWEEN " + id + " AND " + ids);
        }

        private void TelephoneBox_TextChanged(object sender, EventArgs e)
        {
            if (TelephoneBox.Text != "")
            {
                Connect("SELECT * FROM Client WHERE Phone LIKE'" + TelephoneBox.Text + "%'");
                PreviousBTN.Enabled = false; NextBTN.Enabled = false;
                RowsCount();
            }
            else
            {
                PreviousBTN.Enabled = true; NextBTN.Enabled = true;
                Connect("SELECT * FROM Client");
                RowsCount();
            }
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailBox.Text != "")
            {
                Connect("SELECT * FROM Client WHERE Email LIKE'" + EmailBox.Text + "%'");
                PreviousBTN.Enabled = false; NextBTN.Enabled = false;
                RowsCount();
            }
            else
            {
                PreviousBTN.Enabled = true; NextBTN.Enabled = true;
                Connect("SELECT * FROM Client");
                RowsCount();
            }
        }
        private void FilterM_Click(object sender, EventArgs e)
        {
            Connect("SELECT * FROM Client WHERE GenderCode = 'м'");
            RowsCount();
        }

        private void FilterF_Click(object sender, EventArgs e)
        {
            Connect("SELECT * FROM Client WHERE GenderCode = 'ж'");
            RowsCount();
        }
        private void ResetBTN_Click(object sender, EventArgs e)
        {
            Connect("SELECT * FROM Client");
            RowsCount();
        }

        private void LastnameBTN_Click(object sender, EventArgs e)
        {
            Connect("SELECT * FROM Client ORDER BY LastName");
            RowsCount();
        }

        private void DateBTN_Click(object sender, EventArgs e)
        {
           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Client1 = new ClientsForm();
            Client1.options = "add";
            Client1.IDlabel.Visible = false;
            Client1.IDBox.Visible = false;
            Client1.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Client1 = new ClientsForm();
            int rowindex = GridClients.CurrentCell.RowIndex;
            Client1.IDBox.Text = GridClients.Rows[rowindex].Cells[0].Value.ToString();
            Client1.IDBox.Enabled = false;
            Client1.NameBox.Text = GridClients.Rows[rowindex].Cells[1].Value.ToString();
            Client1.LastnameBox.Text = GridClients.Rows[rowindex].Cells[2].Value.ToString();
            Client1.PatronymicBox.Text = GridClients.Rows[rowindex].Cells[3].Value.ToString();
            string date = GridClients.Rows[rowindex].Cells[4].Value.ToString();
            var parcedDate = DateTime.Parse(date);
            Client1.BirthdayBox.Value = parcedDate;
            Client1.EmailBox.Text = GridClients.Rows[rowindex].Cells[6].Value.ToString();
            Client1.PhoneBox.Text = GridClients.Rows[rowindex].Cells[7].Value.ToString();
            Client1.GenderBox.SelectedItem = GridClients.Rows[rowindex].Cells[8].Value.ToString();
            Client1.ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                Client1.ImageBox.Image = Image.FromFile(@"C:\Users\is12332\source\repos\up123\up123\res\" + GridClients.Rows[rowindex].Cells[9].Value.ToString());
            }
            catch (Exception)
            {
                Client1.ImageBox.Image = Image.FromFile(@"C:\Users\is12332\source\repos\up123\up123\res\Клиенты\default.png");
            }
            Client1.options = "edit";
            Client1.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (VisitsLabel.Text == "0")
            {
                int rowindex = GridClients.CurrentCell.RowIndex;
                string id = GridClients.Rows[rowindex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Удалить клиента с ID " + id + "?", " Подтверждение удаления", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                    string sql = "DELETE FROM Client WHERE ID='" + id + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    }
                Connect("SELECT * FROM Client");
                }
            }
            else
            {
                MessageBox.Show("Данного клиента нельзя удалить, у него есть посещения");
            }
        }

        private void VisitsBTN_Click(object sender, EventArgs e)
        {
            int rowindex = GridClients.CurrentCell.RowIndex;
            string id = GridClients.Rows[rowindex].Cells[0].Value.ToString();
            Visits visit = new Visits();
            visit.id = id;
            if (VisitsLabel.Text != "0")
            {
                visit.Show();
            }
            else
            {
                MessageBox.Show("У данного клиента еще нет посещений");
            }
        }

        private void GridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int rowindex = GridClients.CurrentCell.RowIndex;
                string id = GridClients.Rows[rowindex].Cells[0].Value.ToString();
                string sql = "SELECT COUNT (StartTime) as Visit, Client.ID, FirstName FROM Client LEFT JOIN ClientService ON ClientService.ClientID = Client.ID Where Client.ID = " + id + " GROUP BY Client.ID, FirstName ORDER BY Visit DESC";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int reader = (int)command.ExecuteScalar();
                string clientVisits = reader.ToString();
                VisitsLabel.Text = clientVisits;
                connection.Close();
            }
        }
    }
}
