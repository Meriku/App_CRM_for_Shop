using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class Customer
    {
        /// <summary>
        /// Покупатель
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
            
        public override string ToString()
        {
            return Name;
        }
    }
}
