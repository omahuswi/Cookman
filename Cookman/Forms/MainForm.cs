using Cookman.Forms;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Cookman
{
    public partial class MainForm : Form
    {
        static String connection = "Host=localhost;Port=5432;Username=postgres;Password=11111111;database=cookman";
        NpgsqlConnection nc = new NpgsqlConnection(connection);

        static public String open { get; set; }

        public MainForm()
        {
             
            InitializeComponent();
            ArticleListBox.Visible = false;
            switch (Convert.ToString(AuthoForm.roleUser))
            {
                case null:
                    MenuPanel.Visible = false;
                    ExitButton1.Visible = false;
                    ArticleListBox.Visible = false;
                    ProductListBox.Visible = false;
                    CountListBox.Visible = false;
                    label2.Visible = false;
                    PickUpPointsBox.Visible = false;
                    label4.Visible = false;
                    PriceLabel.Visible = false;
                    OrderButton.Visible = false;
                    AddProductButton.Visible = false;
                    //UpdateProductButton.Visible = false;
                    DeleteProductButton.Visible = false;
                    UpdateProductButton.Text = "Подробнее";
                    AddInOrderButton.Visible = false;   
                    break;
                case "1":
                    MenuPanel.Visible = false;
                    ExitButton1.Visible = false;
                    label6.Visible = false;
                    label5.Visible = false;
                    AddProductButton.Visible = false;
                    UpdateProductButton.Text = "Подробнее";
                    //UpdateProductButton.Visible = false;
                    DeleteProductButton.Visible = false;
                    break;

                case "2":
                    MenuPanel.Visible = false;
                    ExitButton1.Visible = false;
                    label6.Visible = false;
                    label5.Visible = false;
                    break;
                case "3":
                    MenuPanel.Visible = true;
                    OrderPanel.Visible = false;
                    AddInOrderButton.Visible = false;
                    break;
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
               
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //вывод продуктов на форму
                if (nc.State == ConnectionState.Closed)
                    nc.Open();
                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT product_article, product_name as \"Название\", price as \"Цена\" FROM public.products");
                cmd.Connection = nc;
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapter.Fill(ds);
                ProductsBut.DataSource = ds.Tables[0];
                nc.Close();
                ProductsBut.Columns[0].Visible = false;

                //вывод пунктов выдачи на форму
                if (nc.State == ConnectionState.Closed)
                    nc.Open();
                cmd = new NpgsqlCommand("SELECT point_id,point_index,point_street,point_house_num FROM public.pick_up_points", nc);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["point_index"].ToString();
                        string pickuppointstreet = reader["point_street"].ToString();
                        string pickuppointnumber = reader["point_house_num"].ToString();
                        string new_str = id + ", " + pickuppointstreet + ",д." + pickuppointnumber;
                        PickUpPointsBox.Items.Add(new_str);
                    }
                }
                nc.Close();

                //вывод категорий товара на форму
                if (nc.State == ConnectionState.Closed)
                    nc.Open();
                cmd = new NpgsqlCommand("select distinct category from public.products", nc);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string category = reader["category"].ToString();
                        FiltrProductBox.Items.Add(category);
                    }
                }
                nc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ///<summary>
        ///Метод, открывающий форму добавления нового товара
        ///</summary>
        private void AddBut_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.ShowDialog();
        }    
       
        ///<summary>
        ///Метод, открывающий форму регистрации нового пользователя
        ///</summary>
        private void button6_Click(object sender, EventArgs e)
        {
            RegistrForm RegisterForm = new RegistrForm();
            RegisterForm.ShowDialog();
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            (ProductsBut.DataSource as DataTable).DefaultView.RowFilter = $" Название LIKE '%{ FindTextBox.Text}%'";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            try 
            {
                open = Convert.ToString(ProductsBut.CurrentRow.Cells[0].Value);
                UpdateForm form = new UpdateForm();
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Выберите продукт, чтобы посмотреть информацию о нём");
            }
        }

        ///<summary>
        ///Метод, добавляющий товар в список для заказа
        ///</summary>
        private void AddInOrderButton_Click(object sender, EventArgs e)
        {
            ProductsBut.Columns[0].Visible = true;
            if (nc.State == ConnectionState.Closed)
                nc.Open();
            String ProductArticle = Convert.ToString(ProductsBut.CurrentRow.Cells[0].Value);
            String Product = Convert.ToString(ProductsBut.CurrentRow.Cells[1].Value);
            int Price = Convert.ToInt32(ProductsBut.CurrentRow.Cells[2].Value);
            int ProductCount = 1;
            ArticleListBox.Visible = true;


            if (ArticleListBox.Items.Contains(ProductArticle))
            {
                int iindex = ArticleListBox.Items.IndexOf(ProductArticle);
                ProductCount = Convert.ToInt32(CountListBox.Items[iindex]);
                CountListBox.Items.RemoveAt(iindex);
                ProductCount++;
                CountListBox.Items.Insert(iindex, ProductCount++);

            }
            else
            {
                ArticleListBox.Items.Add(ProductArticle);
                ProductListBox.Items.Add(Product);
                CountListBox.Items.Add(ProductCount);
            }
            int OldPrice = Convert.ToInt32(PriceLabel.Text);
            PriceLabel.Text = Convert.ToString(OldPrice + Price);
            ArticleListBox.Visible = false;
            ProductsBut.Columns[0].Visible = false;
            nc.Close();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (nc.State == ConnectionState.Closed)
                nc.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"SELECT product_article, product_name as \"Название\", price as \"Цена\" FROM public.products");
            cmd.Connection = nc;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            ProductsBut.DataSource = ds.Tables[0];
            nc.Close();
            ProductsBut.Columns[0].Visible = false;
        }

        private void FiltrProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = FiltrProductBox.Text;
            if (nc.State == ConnectionState.Closed)
                nc.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"SELECT product_article, product_name as \"Название\", price as \"Цена\" FROM public.products where category = \'{category}\'");
            cmd.Connection = nc;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            ProductsBut.DataSource = ds.Tables[0];
            nc.Close();
            ProductsBut.Columns[0].Visible = false;

        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            AuthoForm form = new AuthoForm();
            form.Show();
        }
    }
}
