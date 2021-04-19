using System;

namespace Task1
{
    public class ChooseRole
    {
        public void ChooseRoleForEnter()
        {
            Console.WriteLine("You are the Manager(M) or the Customer(C)");
            var role = Console.ReadLine().ToLower();

            if(role == "m")
            {
                new Manager().ChooseActionForManager();
            }

            else if (role == "c")
            {
                new Customer().ChooseActionForCustomer();
            }

            else
            {
                Console.WriteLine($"There is no role as {role}");
            }

            
        }
    }

}

/*1. Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
 * Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
 * он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.*/
