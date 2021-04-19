using System;

namespace Task1
{
    public class Customer
    {
        public static double _cash = 50;

        public void ChooseActionForCustomer()
        {
            Console.WriteLine("What do you want to do?\nShow products(S)/Buy something(B)");
            var customerAction = Console.ReadLine().ToLower();

            if (customerAction == "s")
                new Store().ShowProducts();

            else if (customerAction == "b")
                BuySomething();

            else
                Console.WriteLine($"There is no option as {customerAction}.");
        }

        

        private void BuySomething()
        {
            ShowCashCustomer();
            var store = new Store();
            
            System.Console.WriteLine("What you want to buy? \n");
            var productNameToBuy = Console.ReadLine();

            if (Store.IsProductExist(productNameToBuy))
            {
                Console.WriteLine($"How many {productNameToBuy} you want to buy? \n");
                var howManyBuy = Convert.ToInt32(Console.ReadLine());
                
                var finalPrice = Store.GetFinanPriceForCustomer(productNameToBuy, howManyBuy);

                if (finalPrice > _cash)
                {
                    Console.WriteLine("You don't have enough money for that. \n");
                }

                else
                {
                    _cash -= finalPrice;

                    Store.TryBuySomething(productNameToBuy, howManyBuy, out bool isEnough);

                    if (isEnough)
                        Console.WriteLine("Purchase was successful! \n");

                    ShowCashCustomer();

                    Store.RefreshStore();
                }   
            }            
        }
        private void ShowCashCustomer()
        {
            Console.WriteLine($"You have {_cash}$");
        }
    }

    

}

/*1. Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
 * Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
 * он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.*/
