namespace _3LArchitectureInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            mainTabControl = new TabControl();
            tabPage1 = new TabPage();
            addNewBookButton = new Button();
            bookMaxAgeTextBox = new TextBox();
            bookMinAgeTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            bookPublisherTextBox = new TextBox();
            bookPriceTextBox = new TextBox();
            bookAuthorTextBox = new TextBox();
            bookNameTextBox = new TextBox();
            dataGridViewBooks = new DataGridView();
            BookId = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            BookAuthor = new DataGridViewTextBoxColumn();
            BookPrice = new DataGridViewTextBoxColumn();
            BookPublisher = new DataGridViewTextBoxColumn();
            BookAgeLimit = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            addNewSEButton = new Button();
            SEMaxAgeTextBox = new TextBox();
            SEMinAgeTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SEManufacturerTextBox = new TextBox();
            SEPriceTextBox = new TextBox();
            SENameTextBox = new TextBox();
            dataGridViewSE = new DataGridView();
            SEId = new DataGridViewTextBoxColumn();
            SEName = new DataGridViewTextBoxColumn();
            SEPrice = new DataGridViewTextBoxColumn();
            SEManufacturer = new DataGridViewTextBoxColumn();
            SEAgeLimit = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            addNewToyButton = new Button();
            label3 = new Label();
            label2 = new Label();
            toyAgeLimitMaxTextBox = new TextBox();
            toyAgeLimitMinTextBox = new TextBox();
            toyMaterialTextBox = new TextBox();
            toyManufacturerTextBox = new TextBox();
            toyPriceTextBox = new TextBox();
            toyNameTextBox = new TextBox();
            dataGridViewToys = new DataGridView();
            ToyId = new DataGridViewTextBoxColumn();
            ToyName = new DataGridViewTextBoxColumn();
            ToyPrice = new DataGridViewTextBoxColumn();
            ToyManufacturer = new DataGridViewTextBoxColumn();
            ToyMaterial = new DataGridViewTextBoxColumn();
            ToyAgeLimit = new DataGridViewTextBoxColumn();
            mainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSE).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToys).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPage1);
            mainTabControl.Controls.Add(tabPage2);
            mainTabControl.Controls.Add(tabPage3);
            mainTabControl.Location = new Point(12, 12);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1152, 387);
            mainTabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(addNewBookButton);
            tabPage1.Controls.Add(bookMaxAgeTextBox);
            tabPage1.Controls.Add(bookMinAgeTextBox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(bookPublisherTextBox);
            tabPage1.Controls.Add(bookPriceTextBox);
            tabPage1.Controls.Add(bookAuthorTextBox);
            tabPage1.Controls.Add(bookNameTextBox);
            tabPage1.Controls.Add(dataGridViewBooks);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1144, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Книги";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // addNewBookButton
            // 
            addNewBookButton.Location = new Point(732, 239);
            addNewBookButton.Name = "addNewBookButton";
            addNewBookButton.Size = new Size(393, 23);
            addNewBookButton.TabIndex = 33;
            addNewBookButton.Text = "Добавить";
            addNewBookButton.UseVisualStyleBackColor = true;
            addNewBookButton.Click += addNewBookButton_Click;
            // 
            // bookMaxAgeTextBox
            // 
            bookMaxAgeTextBox.Location = new Point(989, 193);
            bookMaxAgeTextBox.Name = "bookMaxAgeTextBox";
            bookMaxAgeTextBox.PlaceholderText = "Возраст";
            bookMaxAgeTextBox.Size = new Size(135, 23);
            bookMaxAgeTextBox.TabIndex = 32;
            bookMaxAgeTextBox.KeyPress += bookMaxAgeTextBox_KeyPress;
            // 
            // bookMinAgeTextBox
            // 
            bookMinAgeTextBox.Location = new Point(758, 193);
            bookMinAgeTextBox.Name = "bookMinAgeTextBox";
            bookMinAgeTextBox.PlaceholderText = "Возраст";
            bookMinAgeTextBox.Size = new Size(129, 23);
            bookMinAgeTextBox.TabIndex = 31;
            bookMinAgeTextBox.KeyPress += bookMinAgeTextBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(961, 196);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 30;
            label4.Text = "До";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(731, 196);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 29;
            label5.Text = "От";
            // 
            // bookPublisherTextBox
            // 
            bookPublisherTextBox.Location = new Point(732, 150);
            bookPublisherTextBox.Name = "bookPublisherTextBox";
            bookPublisherTextBox.PlaceholderText = "Издательство";
            bookPublisherTextBox.Size = new Size(393, 23);
            bookPublisherTextBox.TabIndex = 4;
            // 
            // bookPriceTextBox
            // 
            bookPriceTextBox.Location = new Point(732, 103);
            bookPriceTextBox.Name = "bookPriceTextBox";
            bookPriceTextBox.PlaceholderText = "Цена";
            bookPriceTextBox.Size = new Size(393, 23);
            bookPriceTextBox.TabIndex = 3;
            bookPriceTextBox.KeyPress += bookPriceTextBox_KeyPress;
            // 
            // bookAuthorTextBox
            // 
            bookAuthorTextBox.Location = new Point(732, 57);
            bookAuthorTextBox.Name = "bookAuthorTextBox";
            bookAuthorTextBox.PlaceholderText = "Автор";
            bookAuthorTextBox.Size = new Size(393, 23);
            bookAuthorTextBox.TabIndex = 2;
            // 
            // bookNameTextBox
            // 
            bookNameTextBox.Location = new Point(732, 13);
            bookNameTextBox.Name = "bookNameTextBox";
            bookNameTextBox.PlaceholderText = "Название";
            bookNameTextBox.Size = new Size(393, 23);
            bookNameTextBox.TabIndex = 1;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { BookId, BookName, BookAuthor, BookPrice, BookPublisher, BookAgeLimit });
            dataGridViewBooks.Location = new Point(5, 6);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.Size = new Size(707, 347);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.UserDeletingRow += dataGridViewBooks_UserDeletingRow;
            // 
            // BookId
            // 
            BookId.HeaderText = "Id";
            BookId.Name = "BookId";
            BookId.ReadOnly = true;
            BookId.Visible = false;
            // 
            // BookName
            // 
            BookName.HeaderText = "Название";
            BookName.Name = "BookName";
            BookName.ReadOnly = true;
            BookName.Width = 150;
            // 
            // BookAuthor
            // 
            BookAuthor.HeaderText = "Автор";
            BookAuthor.Name = "BookAuthor";
            BookAuthor.ReadOnly = true;
            BookAuthor.Width = 150;
            // 
            // BookPrice
            // 
            BookPrice.HeaderText = "Цена";
            BookPrice.Name = "BookPrice";
            BookPrice.ReadOnly = true;
            // 
            // BookPublisher
            // 
            BookPublisher.HeaderText = "Издательство";
            BookPublisher.Name = "BookPublisher";
            BookPublisher.ReadOnly = true;
            BookPublisher.Width = 150;
            // 
            // BookAgeLimit
            // 
            BookAgeLimit.HeaderText = "Возрастные ограничения";
            BookAgeLimit.Name = "BookAgeLimit";
            BookAgeLimit.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(addNewSEButton);
            tabPage2.Controls.Add(SEMaxAgeTextBox);
            tabPage2.Controls.Add(SEMinAgeTextBox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(SEManufacturerTextBox);
            tabPage2.Controls.Add(SEPriceTextBox);
            tabPage2.Controls.Add(SENameTextBox);
            tabPage2.Controls.Add(dataGridViewSE);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1144, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Спорт-инвентарь";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // addNewSEButton
            // 
            addNewSEButton.Location = new Point(732, 205);
            addNewSEButton.Name = "addNewSEButton";
            addNewSEButton.Size = new Size(391, 23);
            addNewSEButton.TabIndex = 37;
            addNewSEButton.Text = "Добавить";
            addNewSEButton.UseVisualStyleBackColor = true;
            addNewSEButton.Click += addNewSEButton_Click;
            // 
            // SEMaxAgeTextBox
            // 
            SEMaxAgeTextBox.Location = new Point(989, 156);
            SEMaxAgeTextBox.Name = "SEMaxAgeTextBox";
            SEMaxAgeTextBox.PlaceholderText = "Возраст";
            SEMaxAgeTextBox.Size = new Size(135, 23);
            SEMaxAgeTextBox.TabIndex = 36;
            SEMaxAgeTextBox.KeyPress += SEMaxAgeTextBox_KeyPress;
            // 
            // SEMinAgeTextBox
            // 
            SEMinAgeTextBox.Location = new Point(758, 156);
            SEMinAgeTextBox.Name = "SEMinAgeTextBox";
            SEMinAgeTextBox.PlaceholderText = "Возраст";
            SEMinAgeTextBox.Size = new Size(129, 23);
            SEMinAgeTextBox.TabIndex = 35;
            SEMinAgeTextBox.KeyPress += SEMinAgeTextBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(961, 159);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 34;
            label6.Text = "До";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(731, 159);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 33;
            label7.Text = "От";
            // 
            // SEManufacturerTextBox
            // 
            SEManufacturerTextBox.Location = new Point(732, 102);
            SEManufacturerTextBox.Name = "SEManufacturerTextBox";
            SEManufacturerTextBox.PlaceholderText = "Производитель";
            SEManufacturerTextBox.Size = new Size(391, 23);
            SEManufacturerTextBox.TabIndex = 3;
            // 
            // SEPriceTextBox
            // 
            SEPriceTextBox.Location = new Point(732, 57);
            SEPriceTextBox.Name = "SEPriceTextBox";
            SEPriceTextBox.PlaceholderText = "Цена";
            SEPriceTextBox.Size = new Size(391, 23);
            SEPriceTextBox.TabIndex = 2;
            SEPriceTextBox.KeyPress += SEPriceTextBox_KeyPress;
            // 
            // SENameTextBox
            // 
            SENameTextBox.Location = new Point(732, 15);
            SENameTextBox.Name = "SENameTextBox";
            SENameTextBox.PlaceholderText = "Название";
            SENameTextBox.Size = new Size(391, 23);
            SENameTextBox.TabIndex = 1;
            // 
            // dataGridViewSE
            // 
            dataGridViewSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSE.Columns.AddRange(new DataGridViewColumn[] { SEId, SEName, SEPrice, SEManufacturer, SEAgeLimit });
            dataGridViewSE.Location = new Point(6, 6);
            dataGridViewSE.Name = "dataGridViewSE";
            dataGridViewSE.ReadOnly = true;
            dataGridViewSE.Size = new Size(706, 347);
            dataGridViewSE.TabIndex = 0;
            dataGridViewSE.UserDeletingRow += dataGridViewSE_UserDeletingRow;
            // 
            // SEId
            // 
            SEId.HeaderText = "Id";
            SEId.Name = "SEId";
            SEId.ReadOnly = true;
            SEId.Visible = false;
            // 
            // SEName
            // 
            SEName.HeaderText = "Название";
            SEName.Name = "SEName";
            SEName.ReadOnly = true;
            SEName.Width = 150;
            // 
            // SEPrice
            // 
            SEPrice.HeaderText = "Цена";
            SEPrice.Name = "SEPrice";
            SEPrice.ReadOnly = true;
            // 
            // SEManufacturer
            // 
            SEManufacturer.HeaderText = "Производитель";
            SEManufacturer.Name = "SEManufacturer";
            SEManufacturer.ReadOnly = true;
            SEManufacturer.Width = 150;
            // 
            // SEAgeLimit
            // 
            SEAgeLimit.HeaderText = "Возрастные ограничения";
            SEAgeLimit.Name = "SEAgeLimit";
            SEAgeLimit.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(addNewToyButton);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(toyAgeLimitMaxTextBox);
            tabPage3.Controls.Add(toyAgeLimitMinTextBox);
            tabPage3.Controls.Add(toyMaterialTextBox);
            tabPage3.Controls.Add(toyManufacturerTextBox);
            tabPage3.Controls.Add(toyPriceTextBox);
            tabPage3.Controls.Add(toyNameTextBox);
            tabPage3.Controls.Add(dataGridViewToys);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1144, 359);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Игрушки";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // addNewToyButton
            // 
            addNewToyButton.Location = new Point(728, 253);
            addNewToyButton.Name = "addNewToyButton";
            addNewToyButton.Size = new Size(399, 23);
            addNewToyButton.TabIndex = 29;
            addNewToyButton.Text = "Добавить";
            addNewToyButton.UseVisualStyleBackColor = true;
            addNewToyButton.Click += addNewToyButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(958, 209);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 28;
            label3.Text = "До";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(728, 203);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 27;
            label2.Text = "От";
            // 
            // toyAgeLimitMaxTextBox
            // 
            toyAgeLimitMaxTextBox.Location = new Point(985, 206);
            toyAgeLimitMaxTextBox.Name = "toyAgeLimitMaxTextBox";
            toyAgeLimitMaxTextBox.PlaceholderText = "Возраст";
            toyAgeLimitMaxTextBox.Size = new Size(142, 23);
            toyAgeLimitMaxTextBox.TabIndex = 26;
            // 
            // toyAgeLimitMinTextBox
            // 
            toyAgeLimitMinTextBox.Location = new Point(755, 206);
            toyAgeLimitMinTextBox.Name = "toyAgeLimitMinTextBox";
            toyAgeLimitMinTextBox.PlaceholderText = "Возраст";
            toyAgeLimitMinTextBox.Size = new Size(142, 23);
            toyAgeLimitMinTextBox.TabIndex = 25;
            // 
            // toyMaterialTextBox
            // 
            toyMaterialTextBox.Location = new Point(728, 156);
            toyMaterialTextBox.Name = "toyMaterialTextBox";
            toyMaterialTextBox.PlaceholderText = "Материал";
            toyMaterialTextBox.Size = new Size(399, 23);
            toyMaterialTextBox.TabIndex = 24;
            // 
            // toyManufacturerTextBox
            // 
            toyManufacturerTextBox.Location = new Point(728, 107);
            toyManufacturerTextBox.Name = "toyManufacturerTextBox";
            toyManufacturerTextBox.PlaceholderText = "Производитель";
            toyManufacturerTextBox.Size = new Size(399, 23);
            toyManufacturerTextBox.TabIndex = 23;
            // 
            // toyPriceTextBox
            // 
            toyPriceTextBox.Location = new Point(728, 57);
            toyPriceTextBox.Name = "toyPriceTextBox";
            toyPriceTextBox.PlaceholderText = "Цена";
            toyPriceTextBox.Size = new Size(399, 23);
            toyPriceTextBox.TabIndex = 22;
            toyPriceTextBox.KeyPress += toyPriceTextBox_KeyPress;
            // 
            // toyNameTextBox
            // 
            toyNameTextBox.Location = new Point(728, 15);
            toyNameTextBox.Name = "toyNameTextBox";
            toyNameTextBox.PlaceholderText = "Название";
            toyNameTextBox.Size = new Size(399, 23);
            toyNameTextBox.TabIndex = 21;
            // 
            // dataGridViewToys
            // 
            dataGridViewToys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewToys.Columns.AddRange(new DataGridViewColumn[] { ToyId, ToyName, ToyPrice, ToyManufacturer, ToyMaterial, ToyAgeLimit });
            dataGridViewToys.Location = new Point(6, 6);
            dataGridViewToys.Name = "dataGridViewToys";
            dataGridViewToys.ReadOnly = true;
            dataGridViewToys.Size = new Size(705, 347);
            dataGridViewToys.TabIndex = 0;
            dataGridViewToys.UserDeletingRow += dataGridViewToys_UserDeletingRow;
            // 
            // ToyId
            // 
            ToyId.HeaderText = "Id";
            ToyId.Name = "ToyId";
            ToyId.ReadOnly = true;
            ToyId.Visible = false;
            // 
            // ToyName
            // 
            ToyName.HeaderText = "Название";
            ToyName.Name = "ToyName";
            ToyName.ReadOnly = true;
            // 
            // ToyPrice
            // 
            ToyPrice.HeaderText = "Цена";
            ToyPrice.Name = "ToyPrice";
            ToyPrice.ReadOnly = true;
            // 
            // ToyManufacturer
            // 
            ToyManufacturer.HeaderText = "Производитель";
            ToyManufacturer.Name = "ToyManufacturer";
            ToyManufacturer.ReadOnly = true;
            // 
            // ToyMaterial
            // 
            ToyMaterial.HeaderText = "Материал";
            ToyMaterial.Name = "ToyMaterial";
            ToyMaterial.ReadOnly = true;
            // 
            // ToyAgeLimit
            // 
            ToyAgeLimit.HeaderText = "Возрастные ограничения";
            ToyAgeLimit.Name = "ToyAgeLimit";
            ToyAgeLimit.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 411);
            Controls.Add(mainTabControl);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(1191, 450);
            Name = "Form1";
            Text = "Товары";
            Load += Form1_Load;
            mainTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSE).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToys).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addNewBookButton;
        private TabControl mainTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridViewBooks;
        private DataGridView dataGridViewSE;
        private DataGridView dataGridViewToys;
        private Button addNewToyButton;
        private Label label3;
        private Label label2;
        private TextBox toyAgeLimitMaxTextBox;
        private TextBox toyAgeLimitMinTextBox;
        private TextBox toyMaterialTextBox;
        private TextBox toyManufacturerTextBox;
        private TextBox toyPriceTextBox;
        private TextBox toyNameTextBox;
        private DataGridViewTextBoxColumn ToyId;
        private DataGridViewTextBoxColumn ToyName;
        private DataGridViewTextBoxColumn ToyPrice;
        private DataGridViewTextBoxColumn ToyManufacturer;
        private DataGridViewTextBoxColumn ToyMaterial;
        private DataGridViewTextBoxColumn ToyAgeLimit;
        private TextBox bookPublisherTextBox;
        private TextBox bookPriceTextBox;
        private TextBox bookAuthorTextBox;
        private TextBox bookNameTextBox;
        private TextBox bookMaxAgeTextBox;
        private TextBox bookMinAgeTextBox;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookAuthor;
        private DataGridViewTextBoxColumn BookPrice;
        private DataGridViewTextBoxColumn BookPublisher;
        private DataGridViewTextBoxColumn BookAgeLimit;
        private DataGridViewTextBoxColumn SEId;
        private DataGridViewTextBoxColumn SEName;
        private DataGridViewTextBoxColumn SEPrice;
        private DataGridViewTextBoxColumn SEManufacturer;
        private DataGridViewTextBoxColumn SEAgeLimit;
        private TextBox SEManufacturerTextBox;
        private TextBox SEPriceTextBox;
        private TextBox SENameTextBox;
        private TextBox SEMaxAgeTextBox;
        private TextBox SEMinAgeTextBox;
        private Label label6;
        private Label label7;
        private Button addNewSEButton;
    }
}
