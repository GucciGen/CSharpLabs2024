using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace WinFormsApp4
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();
        private int nextId = 1;
        private const string FilePath = "products.json";

        public void AddProduct(Product product)
        {
            product.Id = nextId++;
            products.Add(product);
        }

        public void OrderProduct(int productId, int quantity)
        {
            var product = products.Find(p => p.Id == productId);
            if (product != null)
            {
                if (product.Quantity >= quantity)
                {
                    product.Quantity -= quantity;
                    RemoveProduct(product);
                }
            }
        }

        public double SellProduct(int productId, int quantity)
        {
            var product = products.Find(p => p.Id == productId);
            if (product != null)
            {
                if (product.Quantity >= quantity)
                {
                    product.Quantity -= quantity;
                    double total = quantity * product.Price;
                    Console.WriteLine($"Продаж продукту \"{product.Name}\" з ID {product.Id} здійснено. Загальна сума: {total}");
                    RemoveProduct(product);
                    return total;
                }
                else
                {
                    Console.WriteLine("Не вистачає запасів для продажу.");
                }
            }
            else
            {
                Console.WriteLine("Товар не знайдено.");
            }
            return 0;
        }

        private void RemoveProduct(Product product)
        {
            if (product.Quantity == 0)
            {
                products.Remove(product);
                product.Id = 0;
                Console.WriteLine($"Товар {product.Name} з ID {product.Id} вилучено, оскільки його кількість дорівнює нулю.");
            }
        }

        public void SaveProducts()
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public void LoadProducts()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                products = JsonConvert.DeserializeObject<List<Product>>(json);
                nextId = products.Count > 0 ? products[^1].Id + 1 : 1;
            }
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}

