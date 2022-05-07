using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class Cart : IEnumerable
    {
        public Customer Customer { get; set; }
        public Dictionary<Product, int> Products { get; set; }  
        // Храним как ключ Продукт (переопределили GetHashCode()) а как значение - количество продукта в корзине. 

        public decimal Price => Products.Select(x => x.Key.Price * x.Value).Sum();

        public Cart(Customer customer)
        {
            Customer = customer;
            Products = new Dictionary<Product, int>();
        }

        public void Add(Product product)
        {
            if (Products.TryGetValue(product, out int count))
            {
                // Если продукт уже есть - увеличиваем его количество
                Products[product] = ++count;
            }
            else
            {
                // Если продукта нет в корзине - добавляем его  
                Products.Add(product, 1);
            }
        }
        public List<Product> GetAll()
        {
            var result = new List<Product>();
            foreach (Product i in this)
            {
                result.Add(i);
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var product in Products.Keys)
            {
                for (int i = 0; i < Products[product]; i++)
                {
                    yield return product;
                }
            }
        }
    }
}
