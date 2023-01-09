namespace LibraryManagementSystem
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.User_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OrderHistory_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderPrice_txtBox = new System.Windows.Forms.TextBox();
            this.order_BooksName_txtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderQuantity_txtBox = new System.Windows.Forms.TextBox();
            this.books_dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnOrderReset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalprice_name = new System.Windows.Forms.Label();
            this.Order_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice_label = new System.Windows.Forms.Label();
            this.QST_name = new System.Windows.Forms.Label();
            this.GST_name = new System.Windows.Forms.Label();
            this.QST_label = new System.Windows.Forms.Label();
            this.GST_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bookList_comboBox = new System.Windows.Forms.ComboBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.books_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 1245);
            this.panel1.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.ForeColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(29, 1007);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 80);
            this.panel5.TabIndex = 10;
            this.panel5.Click += new System.EventHandler(this.panel5_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = global::LibraryManagementSystem.Properties.Resources.logout;
            this.pictureBox5.Location = new System.Drawing.Point(10, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Logout";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.User_label);
            this.panel6.ForeColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(29, 278);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 140);
            this.panel6.TabIndex = 9;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::LibraryManagementSystem.Properties.Resources.loginUser_;
            this.pictureBox6.Location = new System.Drawing.Point(64, 67);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(62, 58);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(19, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 42);
            this.label12.TabIndex = 5;
            this.label12.Text = "Welcome back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.BackColor = System.Drawing.Color.Transparent;
            this.User_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.ForeColor = System.Drawing.Color.White;
            this.User_label.Location = new System.Drawing.Point(141, 80);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(89, 39);
            this.User_label.TabIndex = 5;
            this.User_label.Text = "User";
            this.User_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.OrderHistory_label);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(29, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 80);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.panel5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.order;
            this.pictureBox2.Location = new System.Drawing.Point(10, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // OrderHistory_label
            // 
            this.OrderHistory_label.AutoSize = true;
            this.OrderHistory_label.BackColor = System.Drawing.Color.Transparent;
            this.OrderHistory_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderHistory_label.ForeColor = System.Drawing.Color.White;
            this.OrderHistory_label.Location = new System.Drawing.Point(112, 25);
            this.OrderHistory_label.Name = "OrderHistory_label";
            this.OrderHistory_label.Size = new System.Drawing.Size(181, 32);
            this.OrderHistory_label.TabIndex = 5;
            this.OrderHistory_label.Text = "Order History";
            this.OrderHistory_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.logo;
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(105, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 26.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(604, 77);
            this.label5.TabIndex = 28;
            this.label5.Text = "CanConnect Library";
            // 
            // orderPrice_txtBox
            // 
            this.orderPrice_txtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderPrice_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderPrice_txtBox.Font = new System.Drawing.Font("Trebuchet MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPrice_txtBox.Location = new System.Drawing.Point(643, 230);
            this.orderPrice_txtBox.Multiline = true;
            this.orderPrice_txtBox.Name = "orderPrice_txtBox";
            this.orderPrice_txtBox.Size = new System.Drawing.Size(237, 34);
            this.orderPrice_txtBox.TabIndex = 33;
            // 
            // order_BooksName_txtBox
            // 
            this.order_BooksName_txtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order_BooksName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.order_BooksName_txtBox.Font = new System.Drawing.Font("Trebuchet MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_BooksName_txtBox.Location = new System.Drawing.Point(643, 172);
            this.order_BooksName_txtBox.Multiline = true;
            this.order_BooksName_txtBox.Name = "order_BooksName_txtBox";
            this.order_BooksName_txtBox.Size = new System.Drawing.Size(476, 34);
            this.order_BooksName_txtBox.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 43);
            this.label9.TabIndex = 31;
            this.label9.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 43);
            this.label7.TabIndex = 30;
            this.label7.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 43);
            this.label6.TabIndex = 29;
            this.label6.Text = "Book Name :";
            // 
            // orderQuantity_txtBox
            // 
            this.orderQuantity_txtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderQuantity_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderQuantity_txtBox.Font = new System.Drawing.Font("Trebuchet MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderQuantity_txtBox.Location = new System.Drawing.Point(642, 296);
            this.orderQuantity_txtBox.Multiline = true;
            this.orderQuantity_txtBox.Name = "orderQuantity_txtBox";
            this.orderQuantity_txtBox.Size = new System.Drawing.Size(237, 34);
            this.orderQuantity_txtBox.TabIndex = 34;
            // 
            // books_dataGridView
            // 
            this.books_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.books_dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.books_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.books_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.books_dataGridView.Location = new System.Drawing.Point(395, 609);
            this.books_dataGridView.Name = "books_dataGridView";
            this.books_dataGridView.ReadOnly = true;
            this.books_dataGridView.RowHeadersVisible = false;
            this.books_dataGridView.RowHeadersWidth = 72;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.books_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.books_dataGridView.RowTemplate.Height = 31;
            this.books_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.books_dataGridView.Size = new System.Drawing.Size(899, 555);
            this.books_dataGridView.TabIndex = 35;
            this.books_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.books_dataGridView_CellContentClick);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F);
            this.btnAddToCart.Location = new System.Drawing.Point(562, 380);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(227, 80);
            this.btnAddToCart.TabIndex = 36;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnOrderReset
            // 
            this.btnOrderReset.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F);
            this.btnOrderReset.Location = new System.Drawing.Point(895, 380);
            this.btnOrderReset.Name = "btnOrderReset";
            this.btnOrderReset.Size = new System.Drawing.Size(227, 80);
            this.btnOrderReset.TabIndex = 36;
            this.btnOrderReset.Text = "Reset";
            this.btnOrderReset.UseVisualStyleBackColor = true;
            this.btnOrderReset.Click += new System.EventHandler(this.btnOrderReset_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(423, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(299, 64);
            this.label11.TabIndex = 37;
            this.label11.Text = "Books List :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1614, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 64);
            this.label2.TabIndex = 38;
            this.label2.Text = "Order List :";
            // 
            // totalprice_name
            // 
            this.totalprice_name.AutoSize = true;
            this.totalprice_name.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice_name.Location = new System.Drawing.Point(1626, 893);
            this.totalprice_name.Name = "totalprice_name";
            this.totalprice_name.Size = new System.Drawing.Size(210, 43);
            this.totalprice_name.TabIndex = 39;
            this.totalprice_name.Text = "Total Price :";
            this.totalprice_name.Visible = false;
            // 
            // Order_dataGridView
            // 
            this.Order_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Order_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Order_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.Order_dataGridView.Location = new System.Drawing.Point(1274, 101);
            this.Order_dataGridView.Name = "Order_dataGridView";
            this.Order_dataGridView.ReadOnly = true;
            this.Order_dataGridView.RowHeadersVisible = false;
            this.Order_dataGridView.RowHeadersWidth = 72;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.Order_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Order_dataGridView.RowTemplate.Height = 31;
            this.Order_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_dataGridView.Size = new System.Drawing.Size(927, 488);
            this.Order_dataGridView.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "OrderID";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Name";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unit Price";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TotalPrice";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "OrderDate";
            this.Column6.MinimumWidth = 9;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // totalPrice_label
            // 
            this.totalPrice_label.AutoSize = true;
            this.totalPrice_label.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice_label.Location = new System.Drawing.Point(1874, 893);
            this.totalPrice_label.Name = "totalPrice_label";
            this.totalPrice_label.Size = new System.Drawing.Size(0, 43);
            this.totalPrice_label.TabIndex = 39;
            this.totalPrice_label.Visible = false;
            // 
            // QST_name
            // 
            this.QST_name.AutoSize = true;
            this.QST_name.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QST_name.Location = new System.Drawing.Point(1626, 772);
            this.QST_name.Name = "QST_name";
            this.QST_name.Size = new System.Drawing.Size(242, 43);
            this.QST_name.TabIndex = 39;
            this.QST_name.Text = "QST(9.975%) :";
            this.QST_name.Visible = false;
            // 
            // GST_name
            // 
            this.GST_name.AutoSize = true;
            this.GST_name.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GST_name.Location = new System.Drawing.Point(1626, 833);
            this.GST_name.Name = "GST_name";
            this.GST_name.Size = new System.Drawing.Size(169, 43);
            this.GST_name.TabIndex = 39;
            this.GST_name.Text = "GST(5%) :";
            this.GST_name.Visible = false;
            // 
            // QST_label
            // 
            this.QST_label.AutoSize = true;
            this.QST_label.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QST_label.Location = new System.Drawing.Point(1874, 772);
            this.QST_label.Name = "QST_label";
            this.QST_label.Size = new System.Drawing.Size(0, 43);
            this.QST_label.TabIndex = 39;
            this.QST_label.Visible = false;
            // 
            // GST_label
            // 
            this.GST_label.AutoSize = true;
            this.GST_label.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GST_label.Location = new System.Drawing.Point(1874, 833);
            this.GST_label.Name = "GST_label";
            this.GST_label.Size = new System.Drawing.Size(0, 43);
            this.GST_label.TabIndex = 39;
            this.GST_label.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.14286F);
            this.button1.Location = new System.Drawing.Point(1007, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 53);
            this.button1.TabIndex = 42;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookList_comboBox
            // 
            this.bookList_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookList_comboBox.Font = new System.Drawing.Font("Trebuchet MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookList_comboBox.FormattingEnabled = true;
            this.bookList_comboBox.ItemHeight = 28;
            this.bookList_comboBox.Items.AddRange(new object[] {
            "Business",
            "Art",
            "Science",
            "Music"});
            this.bookList_comboBox.Location = new System.Drawing.Point(745, 542);
            this.bookList_comboBox.MaxDropDownItems = 10;
            this.bookList_comboBox.Name = "bookList_comboBox";
            this.bookList_comboBox.Size = new System.Drawing.Size(234, 36);
            this.bookList_comboBox.TabIndex = 41;
            this.bookList_comboBox.Text = "Select your type";
            this.bookList_comboBox.SelectionChangeCommitted += new System.EventHandler(this.bookList_comboBox_SelectionChangeCommitted);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(1489, 1019);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(571, 78);
            this.btnPlaceOrder.TabIndex = 43;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(2234, 1176);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookList_comboBox);
            this.Controls.Add(this.Order_dataGridView);
            this.Controls.Add(this.GST_label);
            this.Controls.Add(this.QST_label);
            this.Controls.Add(this.totalPrice_label);
            this.Controls.Add(this.GST_name);
            this.Controls.Add(this.QST_name);
            this.Controls.Add(this.totalprice_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnOrderReset);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.books_dataGridView);
            this.Controls.Add(this.orderQuantity_txtBox);
            this.Controls.Add(this.orderPrice_txtBox);
            this.Controls.Add(this.order_BooksName_txtBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.books_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderPrice_txtBox;
        private System.Windows.Forms.TextBox order_BooksName_txtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox orderQuantity_txtBox;
        private System.Windows.Forms.DataGridView books_dataGridView;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnOrderReset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalprice_name;
        private System.Windows.Forms.DataGridView Order_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label totalPrice_label;
        private System.Windows.Forms.Label QST_name;
        private System.Windows.Forms.Label GST_name;
        private System.Windows.Forms.Label QST_label;
        private System.Windows.Forms.Label GST_label;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox bookList_comboBox;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label OrderHistory_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
    }
}