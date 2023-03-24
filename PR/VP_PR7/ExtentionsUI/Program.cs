using ExceptionsLib;

namespace ExtentionsUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            try
            {
                shop.Add(new Item(0, "pen", "red", 0));
                shop.Add(new Item(1, "pen", "red", 1));
                shop.Add(new Item(1, "pen", "red", 1));
            }
            catch (ExistingItemCodeException ex) 
            {
                //throw;
                throw ex;
            }
            

        }
    }
}