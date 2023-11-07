using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Cookman
{
    public partial class AuthoForm : Form
    {
        public static String loginUser {  get; set; }
        public static String passUser { get; set; }
        public static String roleUser { get; set; }
        public static int IdUser { get; set; }
        MainForm f { get; set; }


        public AuthoForm()
        {
            InitializeComponent();
            LoadCapcha();
        }

        String result = "";

        /// <summary>
        /// Генерация капчи
        /// </summary>
        private void LoadCapcha()
        {
            string abc = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890"; //набор символов
            int kol = 6; // кол-во символов
            result = "";
            Random rnd = new Random();
            int lng = abc.Length;
            for (int i = 0; i < kol; i++)
                result += abc[rnd.Next(lng)];

            ///Random r1 = new Random();
            //num = r1.Next(100, 999);
            var ing = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);  
            var font = new Font("TT Geekette Trial Muscles", 30F, FontStyle.Bold,GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(ing);
            graphics.DrawString(result, font,Brushes.Red, new Point (0,0));
            pictureBox2.Image = ing;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {           
            try
            {
               // if (textBox1.Text == result)
              //  {
                    String loginUser = LoginBox.Text;
                    String passUser = PassBox.Text;

                    String connection = "Host=localhost;Port=5432;Username=postgres;Password=11111111;database=cookman";
                    NpgsqlConnection nc = new NpgsqlConnection(connection);

                    nc.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM public.users WHERE user_login= \'{loginUser}\' and user_password= \'{passUser}\'");
                    DataTable dt = new DataTable();
                    cmd.Connection = nc;
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (dt.Rows.Count > 0)
                    {
                   
                        IdUser = Convert.ToInt32(reader["user_id"]);
                        roleUser = Convert.ToString(reader[6]);
                        f = new MainForm();
                        Hide();
                        f.ShowDialog();
                    }
                    else MessageBox.Show("Nooo");
               // }
               // else MessageBox.Show("Ввод неверный");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm RegisterForm = new RegistrForm();
            RegisterForm.ShowDialog();
        }

        private void AuthoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            MainForm frm = new MainForm();
            frm.ShowDialog(); 
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadCapcha();
        }
    }
}
