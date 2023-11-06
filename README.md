<!-- PROJECT HEAD -->
<div align="center">
    <img src="" alt="Logo" width="80" height="80">
  <h1 align="center"> ПОВАРЁНОК</h1>
  <p align = "center">Mагазин по продаже кухонных принадлежностей и столовых приборов</p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Содержание</summary>
  <ol>
    <li><a href="#описание-задания">Описание задания</a></li>
    <li><a href="#функционал">Функционал</a>
      <ul>
          <li><a href = #общее>Общее</li>
      <li><a href = #клиент>Клиент</li>
      <li><a href = #менеджер>Менеджер</li>
      <li><a href = #администратор>Администратор</li>
    </ul>
    </li>
    
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## Описание задания

ООО «Поваренок»  - магазин по продаже кухонных принадлежностей и столовых приборов. 

В рамках выполнения задания необходимо было разработать основные модули информационной системы для ООО «Поваренок»:

* неавторизованный и авторизованный клиент может просматривать товары и формировать заказ;
* менеджер может просматривать товары, формировать и редактировать заказы;
* администратор может добавлять/редактировать/удалять товары, просматривать и редактировать заказы. :smile:

Кроме того, разрабатываемая Вами информационная система предполагает установку на терминалах при входе в торговые центры города. На терминале клиент (авторизованный и неавторизованный) может просмотреть товары, сформировать заказ и выбрать удобный для него пункт выдачи. 

Use the `BLANK_README.md` to get started.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Функционал
### Общее
- [x] Авторизация/регистрация в системе
```sh 
private void LoginButton_Click(object sender, EventArgs e)
{           
  try
  {
    if (textBox1.Text == result)
    {
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
        roleUser = Convert.ToString(reader[6]);
        f = new MainForm();
        Hide();
        f.ShowDialog();
      }
      else MessageBox.Show("Nooo");
    }
    else MessageBox.Show("Ввод неверный");
  }
  catch(Exception ex) 
  {
    MessageBox.Show(ex.Message);
  }
}
```
```sh
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
```

- [x] Просмотр списка товаров
```sh
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
```

- [x] Поиск по категории товара и названию
```sh
//Поиск по названию

private void FindTextBox_TextChanged(object sender, EventArgs e)
{
  (ProductsBut.DataSource as DataTable).DefaultView.RowFilter = $" Название LIKE '%{ FindTextBox.Text}%'";
}


//Поиск по категории

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
```

### Клиент:
- [x] Прсмотр информации о выбранном товаре
```sh
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
```

- [x] Оформление заказов(частично)
```sh
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
```
- [ ] Личный кабинет
    - [ ] Просмотр информации о клиенте 
    - [ ] Просмотр всех оформленных заказов
    - [ ] Просмотр информации о выбранном заказе

### Менеджер:
- [x] Оформление заказов (см. Клиент)
- [ ] Просмотр/редактирование заказов 

### Администратор:
- [x] Добавление нового пользователя 
```sh
private void button6_Click(object sender, EventArgs e)
{
  RegistrForm RegisterForm = new RegistrForm();
  RegisterForm.ShowDialog();
}
```
- [ ] Изменение информации о товаре
- [ ] Добавление нового товара
- [ ] Удаление товара
- [ ] Просмотр/редактирование заказов

<p align="right">(<a href="#readme-top">back to top</a>)</p>
