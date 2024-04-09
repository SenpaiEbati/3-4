using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _3_4
{
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }

        private SortedSet<Product> Path = new SortedSet<Product>();

        private void ViewState()
        {
            Quantity_TB.Text = Path.Count.ToString();
            SumWeightDeliveryList_TB.Text = "";
        }

        private void AddProduct_B_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = Name_TB.Text.Trim();
                string Manufacturer = Manufacturer_TB.Text.Trim();
                if (Name == "")
                {
                    Name_TB.Focus();
                    throw new Exception("Не введено название товара");
                }
                if (Manufacturer == "")
                {
                    Manufacturer_TB.Focus();
                    throw new Exception("Не введен производитель");
                }
                double Weight = Convert.ToDouble(Weight_NUD.Value);
                for (int i = 0; i < Spisok_LB.Items.Count; i++)
                {
                    Product Item = Spisok_LB.Items[i] as Product;
                    if (Item.Name == Name && Item.Manufacturer == Manufacturer)
                    {
                        Name_TB.Focus();
                        throw new Exception(
                        "Товар и производитель с таким наименованиями уже имеются");
                    }
                }
                Product Temp = new Product(Name, Manufacturer, Weight);
                Spisok_LB.Items.Add(Temp);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
                return;
            }
        }

        private void DelProduct_B_Click(object sender, EventArgs e)
        {
            if (Spisok_LB.SelectedIndex >= 0)
            {
                Product Item = Spisok_LB.Items[Spisok_LB.SelectedIndex] as Product;
                Path.RemoveWhere(Value => Value == Item);
                   
                ViewState();
                Spisok_LB.Items.RemoveAt(Spisok_LB.SelectedIndex);
            }
            else
                MessageBox.Show("Не выбран товар для удаления","Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void AddDeliveryList_B_Click(object sender, EventArgs e)
        {
            if (Spisok_LB.SelectedIndex >= 0)
            {
                Product Item = Spisok_LB.SelectedItem as Product;
                Path.Add(Item);
                ViewState();
            }
            else
                MessageBox.Show(
                "Не выбран товар для добавления в список поставки",
                "Информация", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void DelDeliveryList_B_Click(object sender, EventArgs e)
        {
            if (Path.Count > 0)
            {
                double DelWeight = Convert.ToDouble(DelDeliveryList_NUD.Value);
                Path.RemoveWhere(Value => Value.Weight < DelWeight);
                
                ViewState();
            }
            else
                MessageBox.Show(
                "Нет товаров в списке поставки для удаления",
                "Информация", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void CheckDeliveryList_GB_Click(object sender, EventArgs e)
        {
            if (Spisok_LB.SelectedIndex >= 0)
            {
                Product Item = Spisok_LB.SelectedItem as Product;
                if (Path.Contains(Item))
                {
                    MessageBox.Show(
                    string.Format("Товар \"{0}({1}), {2}\" НАЙДЕН в списке поставки", 
                    Item.Name, Item.Manufacturer, Item.Weight),
                    "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                    string.Format("Товар \"{0}({1}), {2}\" НЕ НАЙДЕН в списке поставки",
                    Item.Name, Item.Manufacturer, Item.Weight),
                    "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show(
                "Не выбран товар для проверки его в списке поставки",
                "Информация", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SumWeightDeliveryList_B_Click(object sender, EventArgs e)
        {
            if (Path.Count > 0)
            {
                SumWeightDeliveryList_TB.Text = Path.Sum(Value => Value.Weight).ToString();
            }
            else
                MessageBox.Show("В списке поставке нету товаров(",
                                "Информация", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product Temp1 = new Product("abc", "def", 12);
            Spisok_LB.Items.Add(Temp1);
            Product Temp2 = new Product("abc", "def", 12);
            Spisok_LB.Items.Add(Temp2);
            textBox1.Text = Temp1.Equals(Temp2).ToString();
            textBox2.Text=Temp1.CompareTo(Temp2).ToString();
        }
    }
}
