using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLib
{
    public static class FuncDelegate
    {
        static public void Mul(char a) => Console.WriteLine(a);

        static public double FuncExample(Action<char> operation, bool flag, double a)
        {
            double b = a;

            if (flag)
            {
                for (int i = 0; i < a; i++)
                {
                    operation('a');
                }
                return a;
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    operation('b');
                }
                return b;
            }
        }

        public static Func<Action<char>, bool, double, double> SecondTask = FuncExample;


    }
}
