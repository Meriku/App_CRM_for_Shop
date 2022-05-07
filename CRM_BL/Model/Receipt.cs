using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class Receipt
    {
        /// <summary>
        /// Чек. 
        /// Формируется в момент выполнения обработки продажи на кассе. 
        /// </summary>
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Price { get; set; }
        public virtual Customer Customer { get; set; }
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return $"{Id} at {Created:G}";
        }
    }
}
