using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class Product
    {
        /// <summary>
        /// Товар.
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }

        /// <summary>
        /// Используем класс Product в Dictionary в классе Cart
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return Id.Equals(product.Id);
            }

            return false;
        }
    }
}
