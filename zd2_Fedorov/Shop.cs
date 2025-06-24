using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd2_Fedorov
{
    public class Shop
    {
        private Dictionary<Product, int> products = new Dictionary<Product, int>();
        private decimal profit = 0m;
        public void AddProduct(Product product, int count)
        {
            if (products.ContainsKey(product))
                products[product] += count;
            else
                products.Add(product, count);
        }
        public void CreateProduct(string name, decimal price, int count)
        {
            Product newProduct = new Product(name, price);
            AddProduct(newProduct, count);
        }
        public List<string> GetAllProducts()
        {
            List<string> result = new List<string>();
            foreach (KeyValuePair<Product, int> item in products)
            {
                result.Add(item.Key.Name + ", Цена: " + item.Key.Price + ", В наличии: " + item.Value);
            }
            return result;
        }
        public decimal GetProfit()
        {
            return profit;
        }
        public decimal GetProfit(decimal taxPercent)
        {
            if (taxPercent < 0 || taxPercent > 100)
                throw new ArgumentException("Процент налога должен быть от 0 до 100.");
            decimal taxAmount = profit * (taxPercent / 100);
            return profit - taxAmount;
        }

        public bool SellProduct(string productName, int quantity)
        {
            foreach (KeyValuePair<Product, int> item in products)
            {
                if (item.Key.Name == productName)
                {
                    Product product = item.Key;
                    int available = products[product];
                    if (available >= quantity && quantity > 0)
                    {
                        products[product] -= quantity;
                        profit += product.Price * quantity;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

    }
}
