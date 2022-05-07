using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class Sell
    {
        /// <summary>
        /// Класс для создания связи многие ко многим.
        /// Звено между чеком и товаром. 
        /// </summary>
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public int ProductId { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual Product Product { get; set; }
    }
}
