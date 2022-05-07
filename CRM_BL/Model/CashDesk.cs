using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class CashDesk
    {
        CRMContext db;

        public int Number { get; set; }
        public Seller Seller { get; set; }
        public Queue<Cart> Queue { get; set; }
        public int MaxQueueLenght { get; set; } 
        public int ExitCustomer { get; set; }
        public int Count => Queue.Count;
        public bool IsModel { get; set; } 

        public event EventHandler<Receipt> ReceiptClosed;

        public CashDesk(int number, Seller seller, CRMContext db)
        {
            Number = number;
            Seller = seller;
            Queue = new Queue<Cart>();
            MaxQueueLenght = 10;
            IsModel = false;
            this.db = db ?? new CRMContext();
        }

        public void Enqueue(Cart cart)
        {
            if (Queue.Count < MaxQueueLenght)
            {
                Queue.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }

        public decimal Dequeue()
        {
            decimal sum = 0;
            if (Queue.Count == 0)
            {
                return 0;
            }

            var card = Queue.Dequeue();

            if (card != null)
            {
                var receipt = new Receipt()
                {
                    SellerId = Seller.Id,
                    Seller = Seller,
                    CustomerId = card.Customer.Id,
                    Customer = card.Customer,
                    Created = DateTime.Now
                };

                if (!IsModel)
                {
                    db.Receipts.Add(receipt);
                    db.SaveChanges();
                }
                else
                {
                    receipt.Id = 0;
                }

                var sells = new List<Sell>();

                foreach (Product product in card)
                {
                    if (product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            Id = receipt.Id,
                            Receipt = receipt,
                            ProductId = product.Id,
                            Product = product
                        };

                        sells.Add(sell);

                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }

                        product.Count--;
                        sum += product.Price;
                    }
                }

                receipt.Price = sum;

                if (!IsModel)
                {
                    db.SaveChanges();
                }

                ReceiptClosed?.Invoke(this, receipt);
                // Событие того что чек закрыт, продажа совершена
            }

            return sum;
        }

        public override string ToString()
        {
            return $"Касса #{Number}";
        }

    }
}
