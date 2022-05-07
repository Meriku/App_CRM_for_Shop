﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    /// <summary>
    /// Продавец. Сущность в БД. 
    /// Необходим для работы кассы.
    /// </summary>
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
