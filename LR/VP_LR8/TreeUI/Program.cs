using TreeLib;

namespace TreeUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();
            tree.Insert(8);
            tree.Insert(4);
            tree.Insert(21);
            tree.Insert(5);
            tree.Insert(19);
            Console.WriteLine(tree.ToString());
            Console.WriteLine($"finded {tree.Find(5)?.Data}");
            tree.Remove(8);
            Console.WriteLine(tree.ToString());

            tree.Remove(21);
            Console.WriteLine(tree.ToString());

            tree.Remove(4);
            Console.WriteLine(tree.ToString());

            Tree<Item> tree2 = new ();
            Item item = new Item(3, "rubber", "blue", 0);

            tree2.Insert(new Item(43, "pen", "red", 0));
            tree2.Insert(new Item(3, "rubber", "blue", 0));
            tree2.Insert(new Item(23, "pen", "gold", 0));
            tree2.Insert(new Item(112, "line", "red", 0));
            Console.WriteLine(tree2.ToString());
            Console.WriteLine($"finded {tree2.Find(item)?.Data}");
            tree2.Remove(item);
            Console.WriteLine(tree2.ToString());


        }
    }
}