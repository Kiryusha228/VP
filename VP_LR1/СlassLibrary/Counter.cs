using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CounterLibrary
{
   public class Counter
    {
        public static double Percent(string fullStr, string symbol) 
        {
            double count = 0;
            for (int i = 0; i < fullStr.Length; i++)
            {
                if (fullStr[i] == symbol[0])
                {
                    count++;
                }
            }
            return (count / Convert.ToDouble(fullStr.Length)) * 100;
        }
    }
}
