using ItemsLib;

namespace ShopUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.Add(new Item(1, "Яблоко", "красный", 10.0, "Лента", new DateOnly(2022, 3, 28)));
            shop.Add(new Item(2, "Сок", "синий", 20.0, "Глобус", new DateOnly(2022, 3, 29)));
            shop.Add(new Item(3, "Тыква", "зеленый", 30.0, "Магнит", new DateOnly(2022, 3, 30)));
            shop.Add(new Item(4, "Тапки", "красный", 340.0, "Пятерочка", new DateOnly(2022, 1, 28)));
            shop.Add(new Item(5, "Хлеб", "синий", 23.0, "Красное и белое", new DateOnly(2022, 1, 29)));
            shop.Add(new Item(6, "Кот", "зеленый", 12.0, "Дикси", new DateOnly(2022, 1, 30)));
            shop.Add(new Item(7, "Телевизор", "Черный", 500.0, "Samsung", new DateOnly(2022, 3, 28)));
            shop.Add(new Item(8, "Ноутбук", "Серебристый", 800.0, "Apple", new DateOnly(2022, 4, 2)));
            shop.Add(new Item(9, "Телефон", "Золотой", 400.0, "Samsung", new DateOnly(2022, 1, 15)));
            shop.Add(new Item(10, "Планшет", "Черный", 300.0, "Samsung", new DateOnly(2022, 2, 20)));
            shop.Add(new Item(11, "Умные часы", "Белый", 200.0, "Apple", new DateOnly(2022, 5, 10)));
            shop.Add(new Item(12, "Наушники", "Черный", 100.0, "Sony", new DateOnly(2022, 6, 12)));
            shop.Add(new Item(13, "Диплом", "Красный", 400000.0, "РГРТУ", new DateOnly(2023, 1, 15)));
            Console.WriteLine(shop.GetMinPriceForVendor());
            Console.WriteLine(shop.GetMinPriceForVendorFluent());



        }


    }
}