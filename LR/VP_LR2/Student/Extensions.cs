using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib
{
    public static class Extensions
    {
        public struct StringInfo
        {
            public int Lenght;
            public int LetterCount;
            public int DigitCount;
        }

        public static StringInfo Info(this string str)
        {
            StringInfo info = new StringInfo();
            info.Lenght = str.Length;
            info.DigitCount = str.Where(char.IsDigit).Count();
            info.LetterCount = str.Where(char.IsLetter).Count();
            return info;
        }

        public static string GetStudentsFromOneHouse(this Group group, string address)
        {
            string str = string.Empty;
            List<Student> list = new List<Student>(group.Students);
            for (int i = 0; i< list.Count(); i++)
            {
                if (list[i].Adress == address)
                {
                    str += $"{list[i].ToString()}";
                }
            }
            
            return str;
        }
    }
}
