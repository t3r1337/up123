using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace up123
{
    public partial class ClientsForm : Form
    {
        public string connectionString = "Data Source=10.10.1.24;Initial Catalog=up123;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        public string BDdate;
        public string gen;
        public string options;
        bool rightPhone;
        bool rightEmail;
        bool imageSelected = false;
        public string path;
        string Check(string textbox)
        {
            if (Regex.IsMatch(textbox, @"[1\\2\\3\\4\\5\\6\\7\\8\\9\\0\\!\#\$\%\^\&\*\(\)\}\{\,\.\,\/\\?\'\+\=\:\;\№@]"))
            {
                textbox = Regex.Replace(textbox, @"[1\\2\\3\\4\\5\\6\\7\\8\\9\\0\\!\#\$\%\^\&\*\(\)\}\{\,\.\,\/\\?\'\+\=\:\;\№@]", "");
            }
            if (textbox.Length > 50)
            {
                MessageBox.Show("Длина поля не может превышать 50 символов");
                textbox = textbox.Substring(0, 50);
            }
            return textbox;
        }
        public ClientsForm()
        {
            InitializeComponent();
            GenderBox.Items.AddRange(new string[] { "м", "ж" });
        }
        void Connect(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameBox.Text = Check(NameBox.Text);
        }

        private void LastnameBox_TextChanged(object sender, EventArgs e)
        {
            LastnameBox.Text = Check(LastnameBox.Text);
        }

        private void PatronymicBox_TextChanged(object sender, EventArgs e)
        {
            PatronymicBox.Text = Check(PatronymicBox.Text);
        }

        private void BirthdayBox_ValueChanged(object sender, EventArgs e)
        {
            BDdate = BirthdayBox.Value.ToString("yyyy-MM-dd");
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(PhoneBox.Text, @"^[0-9]+$") || Regex.IsMatch(PhoneBox.Text, @"[+\-\(\)\ \@]"))
            {
                rightPhone = true;
            }
            else
            {
                PhoneBox.Text = Regex.Replace(PhoneBox.Text, @"^[a-zA-zа-яА-Я]+$", "");
                rightPhone = false;
            }
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EmailBox.Text, @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"))
            {
                rightEmail = true;
            }
            else
            {
                rightEmail = false;
            }
        }

        private void GenderBox_SelectedValueChanged(object sender, EventArgs e)
        {
            gen = GenderBox.SelectedItem.ToString();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (options == "add")
            {
                if (rightPhone == true && rightEmail == true)
                {
                    try
                    {
                        Connect("INSERT INTO Client (FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode, PhotoPath) VALUES ('" + NameBox.Text + "', '" + LastnameBox.Text + "', '" + PatronymicBox.Text + "', '" + BDdate + "', '" + DateTime.Today.ToString() + "', '" + EmailBox.Text + "', '" + PhoneBox.Text + "', '" + gen + "', '" + "Клиенты\\" + path + "')");
                        MessageBox.Show("Регистрация успешна");
                    }
                    catch
                    {
                        MessageBox.Show("Возникла ошибка при регистрации, проверьте заполнение всех полей");
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный телефон или почту");
                }
            }
            if (options == "edit")
            {
                try
                {
                    Connect("UPDATE Client SET FirstName='" + NameBox.Text + "', LastName='" + LastnameBox.Text + "', Patronymic='" + PatronymicBox.Text + "', Birthday='" + BirthdayBox.Value.ToString("yyyy-MM-dd") + "', Email='" + EmailBox.Text + "', GenderCode='" + GenderBox.SelectedItem.ToString() + "', PhotoPath='Клиенты\\" + path + "' WHERE ID='" + IDBox.Text + "'");
                    MessageBox.Show("Данные обновлены");
                }
                catch
                {
                    MessageBox.Show("Возникла ошибка при редактировании");
                }
            }
        }

        private void ImageBTN_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                    ImageBox.Image = Image.FromFile(ofd.FileName);
                File.Copy(ofd.FileName, Path.Combine(@"C:\Users\is12332\source\repos\up123\up123\res\Клиенты\", Path.GetFileName(ofd.FileName)));
                path = Path.GetFileName(ofd.FileName);
                imageSelected = true;
                SaveFileDialog saveFile = new SaveFileDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Картинка с таким именем уже загружена.\nПереименуйте картинку и повторите попытку");
            }
        }
    }
}
