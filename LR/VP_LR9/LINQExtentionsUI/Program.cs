using LINQExtentions;
using System.Linq;

namespace LINQExtentionsUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mix();
            Multiply();
            TakeEvery();
            Shuffle();
            Delegate();






            void Shuffle()
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5 };
                var shuffledNumbers = numbers.Shuffle();
                Console.WriteLine("Перемешать");
                foreach (var item in shuffledNumbers)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

            void TakeEvery()
            {
                var numbers = new List<int> { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 };
                var takedNumbers = numbers.TakeEvery(3);
                Console.WriteLine("Каждая 3");
                foreach (var item in takedNumbers)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }


            void Multiply()
            {
                var numbers = new List<int> { 1, 2, 3};
                var multipliedNumbers = numbers.Multiply(3);
                Console.WriteLine("Умножить");
                foreach (var item in multipliedNumbers)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

            void Mix()
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5 };
                var numbers2 = new List<int> { 11, 22, 33, 44, 55 };
                var mixedNumbers = numbers.Mix(numbers2);
                Console.WriteLine("Смешать");
                foreach (var item in mixedNumbers)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

            void Delegate()
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5 };
                var squaredNumbers = numbers.DelegFunc(x => x * x);
                Console.WriteLine("Метод с делегатом");
                foreach (var item in squaredNumbers)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }

        
    }
}