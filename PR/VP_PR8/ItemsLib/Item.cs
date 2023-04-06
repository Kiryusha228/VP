namespace ItemsLib
{
    public class Item
    {
        public int Article { get; private set; }
        public string Name { get; private set; }
        public string Color { get; private set; }
        public double Price { get; private set; }
        public string Vendor { get; private set; }
        public DateOnly DateOfManufacture { get; private set; }


        public Item(int article, string name, string color, double price, string vendor ,DateOnly dateOfManufacture)
        {
            Article = article;
            Name = name;
            Color = color;
            Price = price;
            Vendor = vendor;
            DateOfManufacture = dateOfManufacture;
        }
        public override string ToString()
        {
            return $"Артикул: {Article}, Наименование: {Name}, Цвет: {Color}, Цена: {Price}, Производитель: {Vendor}, Дата производства: {DateOfManufacture}";
        }
    }
}