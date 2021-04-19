using System;
using System.Collections.Generic;

namespace Task1
{
    public class Store
    {
        public static List<Product> _products = new List<Product> {};

        public void AddDefaultProducts()
        {
            new DefaultProducts().AddDefaultProducts();
        }

        public void ShowProducts()
        {
            Console.WriteLine("Name | Price, $ | Amount");
            foreach (var product in _products)
            {
                Console.WriteLine($"{product._productName} | {product._productPrice} | {product._productAmount}");
            }
        }

        public static bool IsProductExist(string productName)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i]._productName == productName)
                {
                    return true;
                }
            }
            Console.WriteLine("Product with this name is not exist");

            return false;
        }

        public static void DeleteProduct(string nameProduct)
        {
            if (IsProductExist(nameProduct))
            {
                for (int i = 0; i < _products.Count; i++)
                {
                    if (_products[i]._productName == nameProduct)
                    {
                        _products.Remove(_products[i]);

                        Console.WriteLine("Product was deleted. \n");
                    }
                }
            }            
        }

        public static void AddProduct(string nameProduct, double priceProduct, int amountProduct)
        {
            if (!IsProductExist(nameProduct))
                Store._products.Add(new Product(nameProduct, priceProduct, amountProduct));
            else
                Console.WriteLine("This product already exist");
        }

        public static void TryBuySomething(string nameProduct, int howMany, out bool isEnough)
        {
            if (IsProductExist(nameProduct))
            {
                for (int i = 0; i < _products.Count; i++)
                {
                    if (_products[i]._productName == nameProduct)
                    {
                        if (_products[i]._productAmount >= howMany)
                        {
                            _products[i]._productAmount -= howMany;

                            isEnough = true;

                            return;
                        }

                        else
                        {
                            Console.WriteLine("The Store don't have enough products. \n");

                            isEnough = false;

                            return;
                        }
                    }
                    
                }
            }
            isEnough = false;
        }

        public static double GetFinanPriceForCustomer(string nameProduct, int howManyBuy)
        {
            if (IsProductExist(nameProduct))
            {
                for (int i = 0; i < _products.Count; i++)
                {
                    if (_products[i]._productName == nameProduct)
                    {
                        return _products[i]._productPrice * howManyBuy;
                    }
                    
                }
                
            }
            return 0;
        }

        public static void RefreshStore()
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i]._productAmount == 0)
                {
                    _products.Remove(_products[i]);
                }

            }
        }

    }

}

/*1. Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
 * Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
 * он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.*/
