using MyRegex;

namespace StringRegexUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Почтовые индексы: 228322, 444333, 312111, 444433, Не почтовые индексы:4, 555, 4334, 22, 33377777";
            string str1 = "Эти слова станут странными";
            string str2 = "Номера телефона: +7(916)348-32-23, +7(78699)853-111, +7(7167)838-32";
            string str3 = "Мой отец катается на автобусе с номером М777СХ62, а у Димы О434ТК62; Номеров ПК332Й43 и КУ444У1024 Не существует";
            string str4 = "IPv4: 222.3.0.1, 255.255.255.0; Не IPv4:  999.222.333.111";
            string str5 = "Снилсы: 444-444-223 32, 333-232-112 32, 423-234-222 23, не снилсы: 233-2332-23-23 32, 32-33-434-3 23";

            Console.WriteLine(str);
            Console.Write("Количество почтовых индексов: ");
            Console.WriteLine(StringRegex.GetPostalIndex(str));
            Console.WriteLine();

            Console.WriteLine(str1);
            Console.Write("Новая строка:\n");
            Console.WriteLine(StringRegex.SwapLetters(str1));
            Console.WriteLine();

            Console.WriteLine(str2);
            Console.Write("Новая строка:\n");
            Console.WriteLine(StringRegex.HidePhoneNumbers(str2));
            Console.WriteLine();

            Console.WriteLine(str3);
            Console.Write("Номера машин: ");
            Console.WriteLine(StringRegex.GetCarNumbers(str3));
            Console.WriteLine();

            Console.WriteLine(str4);
            Console.Write("IPv4 адреса: ");
            Console.WriteLine(StringRegex.GetIPv4(str4));
            Console.WriteLine();

            Console.WriteLine(str5);
            Console.Write("Снилсы: ");
            Console.WriteLine(StringRegex.GetSnils(str5));
            Console.WriteLine();
        }
    }
}