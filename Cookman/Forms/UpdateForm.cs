using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookman.Forms
{

    public partial class UpdateForm : Form
    {
        static String connection = "Host=localhost;Port=5432;Username=postgres;Password=11111111;database=cookman";
        NpgsqlConnection nc = new NpgsqlConnection(connection);

        public UpdateForm()
        {
            InitializeComponent();
            switch (Convert.ToString(AuthoForm.roleUser))
            {
                case null:
                    UpdateButton.Visible = false;
                    break;
                case "1":
                    UpdateButton.Visible = false;
                    break;

                case "2":
                    
                    break;
                case "3":
                    
                    break;
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            if (nc.State == ConnectionState.Closed) 
                nc.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"Select * from public.products where product_article = \'{MainForm.open}\'");
            cmd.Connection = nc;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            textBox1.Text = Convert.ToString(reader["product_article"]);
            textBox2.Text = Convert.ToString(reader["product_name"]);
            richTextBox1.Text = Convert.ToString(reader["description"]);
            textBox4.Text = Convert.ToString(reader["price"]);
            textBox5.Text = Convert.ToString(reader["manufacturer"]);
            textBox6.Text = Convert.ToString(reader["max_discount"]);
            textBox7.Text = Convert.ToString(reader["discount"]);
            textBox8.Text = Convert.ToString(reader["provider"]);
            textBox9.Text = Convert.ToString(reader["quantity_in_stock"]);
            String pic = Convert.ToString(reader["picture"]);
            if (pic != "")    
                pictureBox2.Image = Image.FromFile($"D:\\0 папочек\\WorldSkills\\Поворёнок\\Cookman\\Cookman\\img\\{pic}");
            nc.Close();
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
