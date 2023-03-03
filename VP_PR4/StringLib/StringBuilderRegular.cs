using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public static class StringBuilderRegular
    {
       public static string AddString(string strFull, string strSmall, char symbol) 
       {
            StringBuilder sb = new StringBuilder(strFull);
            for (int i = 0; i< sb.Length; i++)
            {
                if (sb[i] == symbol)
                {
                    sb.Insert(i+1, strSmall);
                    i += strSmall.Length;
                }
                
            }
            return sb.ToString();
       }

        public static string AddSpaces(string str1, string str2)
        {
            if (str1.Length > str2.Length) 
            {
                str2 = AddSpaces(new StringBuilder(str2),str1.Length - str2.Length).ToString();
            }
            else
            {
                str1 = AddSpaces(new StringBuilder(str1), str2.Length - str1.Length).ToString();
            }
            return $"{str1}\n{str2}";
        }

        //ИСПОЛЬЗОВАТЬ ДРУГУЮ ПЕРЕГРУЗКУ

        private static StringBuilder AddSpaces(StringBuilder sb, int size)
        {
            sb.Append(' ', size);
            //for (int i = 0; i<size;i++)
            //{
            //    sb.Append(" ");
            //}
            sb.Append("|");
            return sb;
        }

        public static string Convert10To2(string number)
        {
            //StringBuilder sb = new StringBuilder(number);
            return Convert.ToString(Convert.ToInt32(number), 2);
        }

    }
}
