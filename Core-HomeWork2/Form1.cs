using Core_HomeWork2.Data;
using Core_HomeWork2.Models.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Core_HomeWork2
{
    public partial class Form1 : Form
    {
        AppDbContext dbContext = new AppDbContext();
        string SelectedCategory;
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double.TryParse(txtBoxPrice.Text, out double result);
                Category SelectedCategoryAdd = new();
                var Categories = dbContext.Categories.Include(c => c.Products).ToList();
                foreach (var item in Categories)
                {
                    if (item.Name == SelectedCategory) SelectedCategoryAdd = item;
                }

                Product AddProduct = new Product()
                {
                    Name = txtBoxName.Text,
                    Description = txtBoxDescription.Text,
                    Price = result,
                    CategoryId = SelectedCategoryAdd.Id
                };
                dbContext.Products.Add(AddProduct);
                dbContext.SaveChanges();

                txtBoxName.Text = null;
                txtBoxDescription.Text = null;
                txtBoxPrice.Text = null;

                MessageBox.Show("Product added!!!");
                comboBoxCategory_SelectionChangeCommitted(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the information correctly!!!");
               
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewProducts.View = View.Details;
            listViewProducts.GridLines = true;
            listViewProducts.Columns.Add("Name", 140);
            listViewProducts.Columns.Add("Description", 250);
            listViewProducts.Columns.Add("Price", 150);

            var Categories = dbContext.Categories.Include(c => c.Products).ToList();

            foreach (var item in Categories)
            {
                comboBoxCategory.Items.Add(item!.Name!);
            }


        }

        private void comboBoxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SelectedCategory = comboBoxCategory.GetItemText(comboBoxCategory.SelectedItem)!;


            var Products = dbContext.Products.Include(c => c.Category).ToList();
            listViewProducts.Items.Clear();
            foreach (var productItem in Products)
            {
                if(productItem.Category!.Name == SelectedCategory)
                {
                    ListViewItem listViewItem = new ListViewItem(productItem.Name);
                    listViewItem.SubItems.Add(productItem.Description);
                    listViewItem.SubItems.Add(productItem.Price.ToString());
                    listViewProducts.Items.Add(listViewItem);

                }
            }


        }
    }
}
