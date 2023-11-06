using Cookman.Properties;

namespace Cookman
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.ProductsBut = new System.Windows.Forms.DataGridView();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.ExitButton2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ArticleListBox = new System.Windows.Forms.ListBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountListBox = new System.Windows.Forms.ListBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PickUpPointsBox = new System.Windows.Forms.ComboBox();
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddInOrderButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.FiltrProductBox = new System.Windows.Forms.ComboBox();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.DesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBut)).BeginInit();
            this.OrderPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.DesktopPanel);
            this.MainPanel.Controls.Add(this.OrderPanel);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Controls.Add(this.TitlePanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1299, 788);
            this.MainPanel.TabIndex = 24;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Controls.Add(this.ExitButton1);
            this.DesktopPanel.Controls.Add(this.AddInOrderButton);
            this.DesktopPanel.Controls.Add(this.FindButton);
            this.DesktopPanel.Controls.Add(this.FiltrProductBox);
            this.DesktopPanel.Controls.Add(this.UpdateProductButton);
            this.DesktopPanel.Controls.Add(this.DeleteProductButton);
            this.DesktopPanel.Controls.Add(this.ProductsBut);
            this.DesktopPanel.Controls.Add(this.FindTextBox);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(0, 157);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(831, 631);
            this.DesktopPanel.TabIndex = 26;
            // 
            // ProductsBut
            // 
            this.ProductsBut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsBut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsBut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductsBut.BackgroundColor = System.Drawing.Color.White;
            this.ProductsBut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsBut.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ProductsBut.Location = new System.Drawing.Point(23, 84);
            this.ProductsBut.Name = "ProductsBut";
            this.ProductsBut.RowHeadersWidth = 51;
            this.ProductsBut.RowTemplate.Height = 24;
            this.ProductsBut.Size = new System.Drawing.Size(788, 456);
            this.ProductsBut.TabIndex = 1;
            // 
            // OrderPanel
            // 
            this.OrderPanel.Controls.Add(this.label5);
            this.OrderPanel.Controls.Add(this.ProductListBox);
            this.OrderPanel.Controls.Add(this.ExitButton2);
            this.OrderPanel.Controls.Add(this.label6);
            this.OrderPanel.Controls.Add(this.ArticleListBox);
            this.OrderPanel.Controls.Add(this.PriceLabel);
            this.OrderPanel.Controls.Add(this.label4);
            this.OrderPanel.Controls.Add(this.CountListBox);
            this.OrderPanel.Controls.Add(this.OrderButton);
            this.OrderPanel.Controls.Add(this.label3);
            this.OrderPanel.Controls.Add(this.label2);
            this.OrderPanel.Controls.Add(this.PickUpPointsBox);
            this.OrderPanel.Controls.Add(this.label1);
            this.OrderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OrderPanel.Location = new System.Drawing.Point(831, 157);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(468, 631);
            this.OrderPanel.TabIndex = 25;
            // 
            // ExitButton2
            // 
            this.ExitButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton2.FlatAppearance.BorderSize = 2;
            this.ExitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ExitButton2.Location = new System.Drawing.Point(306, 566);
            this.ExitButton2.Name = "ExitButton2";
            this.ExitButton2.Size = new System.Drawing.Size(139, 44);
            this.ExitButton2.TabIndex = 43;
            this.ExitButton2.Text = "Выход";
            this.ExitButton2.UseVisualStyleBackColor = true;
            this.ExitButton2.Click += new System.EventHandler(this.ExitButton2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.Location = new System.Drawing.Point(13, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "Авторизируйтесь, чтобы оформить заказ";
            // 
            // ArticleListBox
            // 
            this.ArticleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticleListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ArticleListBox.FormattingEnabled = true;
            this.ArticleListBox.ItemHeight = 28;
            this.ArticleListBox.Location = new System.Drawing.Point(18, 99);
            this.ArticleListBox.Name = "ArticleListBox";
            this.ArticleListBox.Size = new System.Drawing.Size(10, 172);
            this.ArticleListBox.TabIndex = 41;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.PriceLabel.Location = new System.Drawing.Point(124, 380);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(24, 28);
            this.PriceLabel.TabIndex = 40;
            this.PriceLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(13, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "К оплате:";
            // 
            // CountListBox
            // 
            this.CountListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.CountListBox.FormattingEnabled = true;
            this.CountListBox.ItemHeight = 28;
            this.CountListBox.Location = new System.Drawing.Point(347, 99);
            this.CountListBox.Name = "CountListBox";
            this.CountListBox.Size = new System.Drawing.Size(98, 172);
            this.CountListBox.TabIndex = 38;
            // 
            // OrderButton
            // 
            this.OrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderButton.FlatAppearance.BorderSize = 2;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.OrderButton.Location = new System.Drawing.Point(18, 411);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(139, 44);
            this.OrderButton.TabIndex = 37;
            this.OrderButton.Text = "Оформить";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(37, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Состав заказа";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(37, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "Пункт выдачи";
            // 
            // PickUpPointsBox
            // 
            this.PickUpPointsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PickUpPointsBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.PickUpPointsBox.FormattingEnabled = true;
            this.PickUpPointsBox.Location = new System.Drawing.Point(18, 313);
            this.PickUpPointsBox.Name = "PickUpPointsBox";
            this.PickUpPointsBox.Size = new System.Drawing.Size(427, 36);
            this.PickUpPointsBox.TabIndex = 34;
            // 
            // ProductListBox
            // 
            this.ProductListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.ItemHeight = 28;
            this.ProductListBox.Location = new System.Drawing.Point(18, 99);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(332, 172);
            this.ProductListBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Оформление заказа";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.MenuPanel.Controls.Add(this.tableLayoutPanel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 100);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1299, 57);
            this.MenuPanel.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 51);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить пользователя";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button6_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.AddProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.AddProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.AddProductButton.Location = new System.Drawing.Point(327, 3);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(318, 51);
            this.AddProductButton.TabIndex = 7;
            this.AddProductButton.Text = "Добавить продукт";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.pictureBox1);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1299, 100);
            this.TitlePanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.TitleLabel.Location = new System.Drawing.Point(245, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(252, 60);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Поварёнок";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cookman.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AddInOrderButton
            // 
            this.AddInOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddInOrderButton.FlatAppearance.BorderSize = 2;
            this.AddInOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInOrderButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.AddInOrderButton.ForeColor = global::Cookman.Properties.Settings.Default.mainColor;
            this.AddInOrderButton.Location = new System.Drawing.Point(204, 564);
            this.AddInOrderButton.Name = "AddInOrderButton";
            this.AddInOrderButton.Size = new System.Drawing.Size(210, 43);
            this.AddInOrderButton.TabIndex = 21;
            this.AddInOrderButton.Text = "Добавить в заказ";
            this.AddInOrderButton.UseVisualStyleBackColor = true;
            this.AddInOrderButton.Click += new System.EventHandler(this.AddInOrderButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton.FlatAppearance.BorderSize = 2;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.FindButton.ForeColor = global::Cookman.Properties.Settings.Default.mainColor;
            this.FindButton.Location = new System.Drawing.Point(672, 26);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(139, 43);
            this.FindButton.TabIndex = 19;
            this.FindButton.Text = "Обновить";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FiltrProductBox
            // 
            this.FiltrProductBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.FiltrProductBox.ForeColor = global::Cookman.Properties.Settings.Default.mainColor;
            this.FiltrProductBox.FormattingEnabled = true;
            this.FiltrProductBox.Location = new System.Drawing.Point(23, 26);
            this.FiltrProductBox.Name = "FiltrProductBox";
            this.FiltrProductBox.Size = new System.Drawing.Size(184, 36);
            this.FiltrProductBox.TabIndex = 18;
            this.FiltrProductBox.Text = "Категория";
            this.FiltrProductBox.SelectedIndexChanged += new System.EventHandler(this.FiltrProductBox_SelectedIndexChanged);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateProductButton.FlatAppearance.BorderSize = 2;
            this.UpdateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProductButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.UpdateProductButton.ForeColor = global::Cookman.Properties.Settings.Default.mainColor;
            this.UpdateProductButton.Location = new System.Drawing.Point(23, 564);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(152, 43);
            this.UpdateProductButton.TabIndex = 16;
            this.UpdateProductButton.Text = "Изменить";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteProductButton.FlatAppearance.BorderSize = 2;
            this.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.DeleteProductButton.ForeColor = global::Cookman.Properties.Settings.Default.mainColor;
            this.DeleteProductButton.Location = new System.Drawing.Point(204, 564);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(152, 43);
            this.DeleteProductButton.TabIndex = 8;
            this.DeleteProductButton.Text = "Удалить";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.FindTextBox.ForeColor = global::Cookman.Properties.Settings.Default.mainColor;
            this.FindTextBox.Location = new System.Drawing.Point(213, 26);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(438, 35);
            this.FindTextBox.TabIndex = 4;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(975, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 51);
            this.button2.TabIndex = 22;
            this.button2.Text = "Добавить пользователя";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(651, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(318, 51);
            this.button3.TabIndex = 23;
            this.button3.Text = "Добавить пользователя";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddProductButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ExitButton1
            // 
            this.ExitButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton1.FlatAppearance.BorderSize = 2;
            this.ExitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ExitButton1.Location = new System.Drawing.Point(672, 566);
            this.ExitButton1.Name = "ExitButton1";
            this.ExitButton1.Size = new System.Drawing.Size(139, 44);
            this.ExitButton1.TabIndex = 45;
            this.ExitButton1.Text = "Выход";
            this.ExitButton1.UseVisualStyleBackColor = true;
            this.ExitButton1.Click += new System.EventHandler(this.ExitButton2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label5.Location = new System.Drawing.Point(140, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Авторизиризация";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 788);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поворёнок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.DesktopPanel.ResumeLayout(false);
            this.DesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBut)).EndInit();
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ComboBox FiltrProductBox;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridView ProductsBut;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox CountListBox;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PickUpPointsBox;
        private System.Windows.Forms.ListBox ProductListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ArticleListBox;
        private System.Windows.Forms.Button ExitButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddInOrderButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ExitButton1;
        private System.Windows.Forms.Label label5;
    }
}