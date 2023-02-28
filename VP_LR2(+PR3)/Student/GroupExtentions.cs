using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib
{
    public static class GroupExtensions
    {
        public static string GetStudentsFromOneHouse(this Group group, string address)
        {
            string str = string.Empty;
            List<Student> list = new List<Student>(group.Students);
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].Adress == address)
                {
                    str += list[i].ToString();
                }
            }

            return str;
        }
    }
}
