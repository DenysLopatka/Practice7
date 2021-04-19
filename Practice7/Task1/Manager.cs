using System;

namespace Task1
{
    public class Manager
    {
        public void ChooseActionForManager()
        {
            Console.WriteLine("What do you want to do?\nShow products(S)/Delete product(D)/Add Product(A)");
            var customerAction = Console.ReadLine().ToLower();

            if (customerAction == "s")
            {
                new Store().ShowProducts();
            }

            else if (customerAction == "d")
            {
                Console.WriteLine("Enter name of product you want to delete: ");
                var productName = Console.ReadLine();

                Store.DeleteProduct(productName);
            }

            else if (customerAction == "a")
            {
                try
                {
                    Console.WriteLine("Enter name of product:");
                    var productName = Console.ReadLine();

                    Console.WriteLine("Enter price of product:");
                    var productPrice = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter amount of product:");
                    var productAmount = Convert.ToInt32(Console.ReadLine());

                    Store.AddProduct(productName, productPrice, productAmount);
                }

                catch
                {
                    Console.WriteLine("You enter wrong data! Adding ne product failed!");
                }
            }

            else
            {
                Console.WriteLine($"There is no option as {customerAction}.");
            }
        }
    }

    

}

/*1. Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
 * Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
 * он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.*/
