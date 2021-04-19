namespace Task1
{
    public class DefaultProducts 
    {
        public void AddDefaultProducts()
        {
            Store._products.Add(new Product("Pineapple", 10, 5));
            Store._products.Add(new Product("Apple", 999, 1));
            Store._products.Add(new Product("Peach", 3, 10));
            Store._products.Add(new Product("Potato", 1, 50));
            Store._products.Add(new Product("Carrot", 0.5, 100));
            Store._products.Add(new Product("Cabage", 5, 5));
            Store._products.Add(new Product("Corn", 0.7, 50));
            Store._products.Add(new Product("Pea", 0.1, 70));
            Store._products.Add(new Product("Onion", 1, 30));
            Store._products.Add(new Product("Tomato", 2, 20));


        }
    }
}

/*1. Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
 * Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
 * он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.*/

/*var store = new Store();
            store._Products.Add("Pineapple | 10 | 5");
            store._Products.Add("Apple© | 999 | 1");
            store._Products.Add("Peach | 3 | 10");
            store._Products.Add("Popato | 1 | 50");
            store._Products.Add("Carrot | 0.5 | 100");
            store._Products.Add("Cabage | 5 | 5");
            store._Products.Add("Corn | 0.7 | 50");
            store._Products.Add("Pea | 0.1 | 70");
            store._Products.Add("Onion |  | 5");
*/