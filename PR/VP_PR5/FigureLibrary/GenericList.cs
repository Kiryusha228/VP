using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FigureLibrary
{
    public class GenericList<T> where T : IComparable<T>
    {
        private List<T> list;

        public void Add(T element)
        {
            list.Add(element);
        }

        public void BubbleSort()
        {
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = 0; j < list.Count() - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        (list[j], list[j + 1]) = (list[j+1], list[j]);
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0;i < list.Count(); i++)
            {
                sb.Append(list[i].ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public GenericList() 
        {
            list = new List<T>();
        }
    }
}
