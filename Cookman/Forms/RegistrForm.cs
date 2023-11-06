using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Cookman
{
    public partial class RegistrForm : Form
    {
        static String connection = "Host = localhost;Port = 5432;Username=postgres;Password=11111111;database=cookman";
        NpgsqlConnection cnct = new NpgsqlConnection(connection);
        public RegistrForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PassBox.Text == PassBoxDupl.Text)
                {
                    cnct.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT public.insertuser(:_surname, :_name, :_patronymic, :_user_login, :_user_password)");
                    cmd.Connection = cnct;
                    cmd.Parameters.AddWithValue("_name", NameBox.Text);
                    cmd.Parameters.AddWithValue("_surname", SurnameBox.Text);
                    cmd.Parameters.AddWithValue("_patronymic", PartBox.Text);
                    cmd.Parameters.AddWithValue("_user_login", LoginBox.Text);
                    cmd.Parameters.AddWithValue("_user_password", PassBoxDupl.Text);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Успешно!");
                    this.Close();
                    AuthoForm.roleUser = "1";
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
                else
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Пароли не совпадают";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnct.Close();
            }
        }


        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthoForm LoginForm = new AuthoForm();
            LoginForm.ShowDialog();
        }

        private void RegistrForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
