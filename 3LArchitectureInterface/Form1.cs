using _3LArchitecture.Common.Entities;
using _3LArchitecture.Service.Interfaces;

namespace _3LArchitectureInterface
{
    public partial class Form1 : Form
    {
        private readonly IProductService<Book> _bookService;
        private readonly IProductService<SportsEquipment> _sportsEquipmentService;
        private readonly IProductService<Toy> _toyService;


        public Form1(
            IProductService<Book> bookService,
            IProductService<SportsEquipment> sportsEquipmentService,
            IProductService<Toy> toyService)
        {
            _bookService = bookService;
            _sportsEquipmentService = sportsEquipmentService;
            _toyService = toyService;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGridViewBooks();
            FillDataGridViewSE();
            FillDataGridViewToys();
        }

        private void FillDataGridViewBooks()
        {
            dataGridViewBooks.Rows.Clear();
            foreach (Book book in _bookService.GetAllProducts())
            {
                dataGridViewBooks.Rows.Add(
                    book.UUID.ToString(),
                    book.Name,
                    book.Author,
                    book.Price,
                    book.Publisher,
                    book.AgeLimit.ToString());
            }
        }
        
        private void FillDataGridViewBooksSorted()
        {
            dataGridViewBooks.Rows.Clear();
            foreach (Book book in _bookService.GetAllProducts().Sort())
            {
                dataGridViewBooks.Rows.Add(
                    book.UUID.ToString(),
                    book.Name,
                    book.Author,
                    book.Price,
                    book.Publisher,
                    book.AgeLimit.ToString());
            }
        }

        private void FillDataGridViewSE()
        {
            dataGridViewSE.Rows.Clear();
            foreach (SportsEquipment equipment in _sportsEquipmentService.GetAllProducts())
            {
                dataGridViewSE.Rows.Add(
                    equipment.UUID.ToString(),
                    equipment.Name,
                    equipment.Price,
                    equipment.Manufacturer,
                    equipment.AgeLimit.ToString());
            }
        }
        
        private void FillDataGridViewSESorted()
        {
            dataGridViewSE.Rows.Clear();
            foreach (SportsEquipment equipment in _sportsEquipmentService.GetAllProducts().Sort())
            {
                dataGridViewSE.Rows.Add(
                    equipment.UUID.ToString(),
                    equipment.Name,
                    equipment.Price,
                    equipment.Manufacturer,
                    equipment.AgeLimit.ToString());
            }
        }

        private void FillDataGridViewToys()
        {
            dataGridViewToys.Rows.Clear();
            foreach (Toy toy in _toyService.GetAllProducts())
            {
                dataGridViewToys.Rows.Add(
                    toy.UUID.ToString(),
                    toy.Name,
                    toy.Price,
                    toy.Manufacturer,
                    toy.Material,
                    toy.AgeLimit.ToString());
            }
        }
        
        private void FillDataGridViewToysSorted()
        {
            dataGridViewToys.Rows.Clear();
            foreach (Toy toy in _toyService.GetAllProducts().Sort())
            {
                dataGridViewToys.Rows.Add(
                    toy.UUID.ToString(),
                    toy.Name,
                    toy.Price,
                    toy.Manufacturer,
                    toy.Material,
                    toy.AgeLimit.ToString());
            }
        }

        private void toyPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void toyAgeLimitMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void toyAgeLimitMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addNewToyButton_Click(object sender, EventArgs e)
        {
            if (
                toyNameTextBox.Text.Length > 0 &&
                toyPriceTextBox.Text.Length > 0 &&
                toyManufacturerTextBox.Text.Length > 0 &&
                toyMaterialTextBox.Text.Length > 0 &&
                toyAgeLimitMinTextBox.Text.Length > 0 &&
                toyAgeLimitMaxTextBox.Text.Length > 0 &&
                int.Parse(toyAgeLimitMaxTextBox.Text) >= int.Parse(toyAgeLimitMinTextBox.Text))
            {
                Toy toy = new(
                    toyNameTextBox.Text,
                    double.Parse(toyPriceTextBox.Text),
                    toyManufacturerTextBox.Text,
                    toyMaterialTextBox.Text,
                    new AgeLimit(
                        int.Parse(toyAgeLimitMaxTextBox.Text),
                        int.Parse(toyAgeLimitMinTextBox.Text))
                    );
                var addedToy = _toyService.AddProduct(toy);

                dataGridViewToys.Rows.Add(
                    addedToy.UUID.ToString(),
                    addedToy.Name,
                    addedToy.Price,
                    addedToy.Manufacturer,
                    addedToy.Material,
                    addedToy.AgeLimit.ToString());

                toyNameTextBox.Text = "";
                toyPriceTextBox.Text = "";
                toyManufacturerTextBox.Text = "";
                toyMaterialTextBox.Text = "";
                toyAgeLimitMinTextBox.Text = "";
                toyAgeLimitMaxTextBox.Text = "";
            }
        }

        private void dataGridViewToys_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var result = MessageBox.Show(
               "�� ������� ��� ������ ������� ���� �������?",
               "������������� ��������",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Guid id = new Guid((string)e.Row.Cells["ToyId"].Value);
                _toyService.DeleteProduct(id);
            }
        }



        private void bookPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void bookMinAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bookMaxAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addNewBookButton_Click(object sender, EventArgs e)
        {
            if (
                bookNameTextBox.Text.Length > 0 &&
                bookAuthorTextBox.Text.Length > 0 &&
                bookPublisherTextBox.Text.Length > 0 &&
                bookPriceTextBox.Text.Length > 0 &&
                bookMaxAgeTextBox.Text.Length > 0 &&
                bookMinAgeTextBox.Text.Length > 0 &&
                int.Parse(bookMaxAgeTextBox.Text) > int.Parse(bookMinAgeTextBox.Text))
            {
                Book book = new(
                    bookNameTextBox.Text,
                    bookAuthorTextBox.Text,
                    bookPublisherTextBox.Text,
                    double.Parse(bookPriceTextBox.Text),
                    new AgeLimit(
                        int.Parse(bookMaxAgeTextBox.Text),
                        int.Parse(bookMinAgeTextBox.Text))
                    );
                var addedBook = _bookService.AddProduct(book);

                dataGridViewBooks.Rows.Add(
                    addedBook.UUID.ToString(),
                    addedBook.Name,
                    addedBook.Author,
                    addedBook.Price.ToString(),
                    addedBook.Publisher,
                    addedBook.AgeLimit);

                bookNameTextBox.Text = "";
                bookAuthorTextBox.Text = "";
                bookPublisherTextBox.Text = "";
                bookPriceTextBox.Text = "";
                bookMaxAgeTextBox.Text = "";
                bookMinAgeTextBox.Text = "";
            }
        }

        private void dataGridViewBooks_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var result = MessageBox.Show(
               "�� ������� ��� ������ ������� ���� �������?",
               "������������� ��������",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Guid id = new Guid((string)e.Row.Cells["BookId"].Value);
                _bookService.DeleteProduct(id);
            }
        }

        private void SEPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void SEMinAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SEMaxAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addNewSEButton_Click(object sender, EventArgs e)
        {
            if (
                SENameTextBox.Text.Length > 0 &&
                SEPriceTextBox.Text.Length > 0 &&
                SEManufacturerTextBox.Text.Length > 0 &&
                SEMaxAgeTextBox.Text.Length > 0 &&
                SEMinAgeTextBox.Text.Length > 0 &&
                int.Parse(SEMaxAgeTextBox.Text) > int.Parse(SEMinAgeTextBox.Text))
            {
                SportsEquipment sportsEquipment = new(
                    SENameTextBox.Text,
                    double.Parse(SEPriceTextBox.Text),
                    SEManufacturerTextBox.Text,
                    new AgeLimit(
                        int.Parse(SEMaxAgeTextBox.Text),
                        int.Parse(SEMinAgeTextBox.Text))
                    );
                var addedSportsEquipment = _sportsEquipmentService.AddProduct(sportsEquipment);

                dataGridViewSE.Rows.Add(
                    addedSportsEquipment.UUID.ToString(),
                    addedSportsEquipment.Name,
                    addedSportsEquipment.Price.ToString(),
                    addedSportsEquipment.Manufacturer,
                    addedSportsEquipment.AgeLimit.ToString());

                SENameTextBox.Text = "";
                SEPriceTextBox.Text = "";
                SEManufacturerTextBox.Text = "";
                SEMaxAgeTextBox.Text = "";
                SEMinAgeTextBox.Text = "";
            }
        }

        private void dataGridViewSE_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var result = MessageBox.Show(
               "�� ������� ��� ������ ������� ���� �������?",
               "������������� ��������",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Guid id = new Guid((string)e.Row.Cells["SEId"].Value);
                _sportsEquipmentService.DeleteProduct(id);
            }
        }
    }
}

//<RuntimeIdentifier>win-x64</RuntimeIdentifier>
// <SelfContained>true</SelfContained>
