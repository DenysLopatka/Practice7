namespace Task1
{
    public class Product
    {
        public string _productName;
        public double _productPrice;
        public int _productAmount;
        

        public Product(string productName, double productPrice, int productAmount)
        {
            _productName = productName;
            _productPrice = productPrice;
            _productAmount = productAmount;
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