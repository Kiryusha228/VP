using FileSystem;
using System.IO;
using System.Security.AccessControl;

namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string pathK1 = @"C:\temp\K1";
            string pathK2 = @"C:\temp\K2";

            DirectoryInfo K1 = new DirectoryInfo(pathK1);
            DirectoryInfo K2 = new DirectoryInfo(pathK2);
            // Пытаемся создать директорию
            K1.Create();
            K2.Create();

            Environment.

            DriveInfo d = new DriveInfo("C");
            Console.WriteLine($"{d.Name}\n" +
                $"{d.VolumeLabel}\n" +
                $"{d.DriveType}\n" +
                $"{d.DriveFormat} \n" +
                $"{d.AvailableFreeSpace}\n" +
                $"{d.TotalSize} \n" +
                $"{d.TotalFreeSpace}");

            string patht1 = @"C:\temp\K1\t1.txt";
            var fileInfot1 = new FileInfo(patht1);

            // Создаем файл для записи
            using (StreamWriter sw = fileInfot1.CreateText())
            {
                sw.WriteLine("Этот текст записан в файле t1.txt");
            }

            string patht2 = @"C:\temp\K1\t2.txt";
            var fileInfot2 = new FileInfo(patht2);

            // Создаем файл для записи
            using (StreamWriter sw = fileInfot2.CreateText())
            {
                sw.WriteLine("Этот текст записан в файле t2.txt");
            }

            

            string line1;

            using (StreamReader sr = new StreamReader(patht1))
            {
                line1 = sr.ReadLine();
            }

            string line2;

            using (StreamReader sr = new StreamReader(patht2))
            {
                line2 = sr.ReadLine();
            }

            string patht3 = @"C:\temp\K2\t3.txt";
            var fileInfot3 = new FileInfo(patht3);

            // Создаем файл для записи
            using (StreamWriter sw = fileInfot3.CreateText())
            {
                sw.WriteLine($"{line1} {line2}");
            }


            Console.WriteLine($"Информация о t1:\n" +
                $"{fileInfot1.FullName}\n" +
                $"{fileInfot1.Name}\n" +
                $"{fileInfot1.LinkTarget}\n" +
                $"{fileInfot1.CreationTime}\n" +
                $"{fileInfot1.CreationTimeUtc}\n");
            Console.WriteLine($"Информация о t2:\n" +
                $"{fileInfot2.FullName}\n" +
                $"{fileInfot2.Name}\n" +
                $"{fileInfot2.LinkTarget}\n" +
                $"{fileInfot2.CreationTime}\n" +
                $"{fileInfot2.CreationTimeUtc}\n");
            Console.WriteLine($"Информация о t3:\n" +
                $"{fileInfot3.FullName}\n" +
                $"{fileInfot3.Name}\n" +
                $"{fileInfot3.LinkTarget}\n" +
                $"{fileInfot3.CreationTime}\n" +
                $"{fileInfot3.CreationTimeUtc}\n");
            string newPatht2 = pathK2 + "\\t2.txt";
            string newPatht1 = pathK2 + "\\t1.txt";

            fileInfot2.MoveTo(newPatht2);
            fileInfot1.CopyTo(newPatht1);
            fileInfot1.Delete();
            K1.Delete();
            K2.MoveTo(@"C:\temp\All");

            FileInfo[] files = K2.GetFiles();
            foreach ( FileInfo file in files )
            {
                Console.WriteLine($"Информация о {file.Name}:\n" +
               $"{file.FullName}\n" +
               $"{file.Name}\n" +
               $"{file.LinkTarget}\n" +
               $"{file.CreationTime}\n" +
               $"{file.CreationTimeUtc}\n");
            }
        }
    }
}