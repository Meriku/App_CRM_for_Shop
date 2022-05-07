using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class ShopComputerModel
    {
        // Компьютерная модель работы магазина

        public bool IsWorking = false;
        Random rnd = new Random();

        public Factory Factory { get; set; } = new Factory();
        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Receipt> Receipts { get; set; } = new List<Receipt>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();
        public int CustomerSpeed { get; set; } = 100;
        public int CashDeskSpeed { get; set; } = 100;

        /// <summary>
        /// Инициализируем модель. Создаем продавцов и кассы. 
        /// </summary>
        public ShopComputerModel()
        {

            foreach (var seller in Factory.GetNewSellers(20))
            {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 6; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue(), null)
                {
                    MaxQueueLenght = 60,
                    IsModel = true,
                });
            }
        }
            
        /// <summary>
        /// Начинаем процесс моделирования.
        /// </summary>
        public void Start()
        {
            IsWorking = true;
            Task.Run(() => CreateCarts(10) );   // Создание клиентов (продуктов корзин) в отдельном потоке      

            var cashDeskTasks = CashDesks.Select(c => new Task(() => CashDeskWork(c)));
            // Создали коллекцию задач (Task), в которой каждая задача - работающая касса в магазине

            foreach (var task in cashDeskTasks)
            {
                task.Start();
            }            
        }

        public void Stop()
        {
            IsWorking = false;
        }

        private void CashDeskWork(CashDesk cashDesk)
        {
            while (IsWorking)
            {
                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();             // Обрабатываем один элемент из очереди
                    Thread.Sleep(CashDeskSpeed);    // Период паузы указывается через GUI
                }
            }          
        }

        private void CreateCarts(int customersCount)
        {
            while (IsWorking)
            {
                var customers = Factory.GetCustomers(customersCount);        
                foreach (var cust in customers)
                {
                    var cart = new Cart(cust);

                    foreach (var prod in Factory.GetRandomProducts(10, 30))
                    {
                        cart.Add(prod);
                    }

                    var cash = CashDesks[rnd.Next(CashDesks.Count)];
                    cash.Enqueue(cart);
                }

                Thread.Sleep(CustomerSpeed);        // Период паузы указывается через GUI
            }
        }
    }
}
