using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd2_Fedorov
{
    public partial class Form1 : Form
    {
        private Shop shop = new Shop();
        public Form1()
        {
            InitializeComponent();
        }
        private void menuAddProduct_Click(object sender, EventArgs e)
        {
            panelInput.Visible = true;
            labelPrompt.Text = "Введите: название, цена, количество (через запятую)";
            buttonConfirm.Click -= ButtonConfirmAll_Clicks;
            buttonConfirm.Click -= ButtonSellMultiple_Click;
            buttonConfirm.Click -= ButtonShowProfitWithTax_Click;
            buttonConfirm.Click += ButtonAddProduct_Click;
        }
        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = textBoxInput.Text.Split(',');
                if (parts.Length != 3)
                    throw new FormatException("Формат: название, цена, количество");
                string name = parts[0].Trim();
                decimal price = decimal.Parse(parts[1].Trim());
                int count = int.Parse(parts[2].Trim());
                shop.CreateProduct(name, price, count);
                MessageBox.Show("Товар добавлен!");
                textBoxInput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void menuViewProducts_Click(object sender, EventArgs e)
        {
            panelInput.Visible = false;
            listBoxOutput.Items.Clear();
            List<string> allProducts = shop.GetAllProducts();
            foreach (string item in allProducts)
            {
                listBoxOutput.Items.Add(item);
            }
        }
        private void menuShowProfitWithTax_Click(object sender, EventArgs e)
        {
            panelInput.Visible = true;
            labelPrompt.Text = "Введите процент налога (например, 20)";
            buttonConfirm.Click -= ButtonConfirmAll_Clicks;
            buttonConfirm.Click -= ButtonAddProduct_Click;
            buttonConfirm.Click -= ButtonSellMultiple_Click;
            buttonConfirm.Click += ButtonShowProfitWithTax_Click;
        }
        private void ButtonShowProfitWithTax_Click(object sender, EventArgs e)
        {
            try
            {
                decimal taxPercent = decimal.Parse(textBoxInput.Text.Trim());
                if (taxPercent < 0 || taxPercent > 100)
                {
                    MessageBox.Show("Процент налога должен быть от 0 до 100.");
                    return;
                }
                decimal profitAfterTax = shop.GetProfit(taxPercent);
                listBoxOutput.Items.Clear();
                listBoxOutput.Items.Add($"Прибыль после налога ({taxPercent}%): {profitAfterTax:F2} руб.");
                textBoxInput.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число для процента налога.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void ButtonConfirmAll_Clicks(object sender, EventArgs e) { }
        private void toolStripMenuItemSellMultiple_Click(object sender, EventArgs e)
        {
            panelInput.Visible = true;
            labelPrompt.Text = "Введите: название, количество";
            buttonConfirm.Click -= ButtonConfirmAll_Clicks;
            buttonConfirm.Click -= ButtonAddProduct_Click;
            buttonConfirm.Click -= ButtonShowProfitWithTax_Click;
            buttonConfirm.Click += ButtonSellMultiple_Click;
        }
        private void ButtonSellMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = textBoxInput.Text.Split(',');
                if (parts.Length != 2)
                    throw new FormatException("Формат: название, количество");
                string name = parts[0].Trim();
                int quantity = int.Parse(parts[1].Trim());
                bool sold = shop.SellProduct(name, quantity);
                if (sold)
                    MessageBox.Show($"Продано {quantity} шт. товара.");
                else
                    MessageBox.Show("Не удалось продать товар. Проверьте наличие или корректность данных.");
                textBoxInput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}