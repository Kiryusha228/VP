using FileLib;

namespace FileUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyFile file = new MyFile(@"C:\temp\file.txt");

            //file = null;

            //MyFile file1 = new MyFile(@"C:\temp\file.txt");

            MyFile file = new MyFile(@"C:\temp\file.txt");

            file.Dispose();

            MyFile file1 = new MyFile(@"C:\temp\file.txt");

        }
            
    }
}