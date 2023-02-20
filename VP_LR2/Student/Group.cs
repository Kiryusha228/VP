using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib
{
    public class Group
    {
        public List<Student> students;

        public int GroupNumber { get; private set; }

        public void Add(Student student)
        {
            students.Add(student);
            students.Sort(Geek);
        }

        private int Geek(Student x, Student y)
        {
            if (x.Surname == null)
            {
                if (y.Surname == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y.Surname == null)
                {
                    return 1;
                }

                else
                {
                    return x.Surname.CompareTo(y.Surname);
                }
            }
        }

        public void Remove(int index)
        {
            students.RemoveAt(index);
        }

        public string GetInfo()
        {
            string studentsList = $"Номер группы: {GroupNumber}" +
                $"\nСостав:\n";
            if (students.Count == 0)
            {
                studentsList += "\nВ группе нет студентов";
            }
            else
            {
                for (int i = 0; i < students.Count; i++)
                {
                    studentsList += $"\n{i + 1}. {students[i].Surname} {students[i].Name} {students[i].Patronymic}, {students[i].Id}";
                }
            }
            studentsList += "\n";
            return studentsList;
        }

        public virtual Student this[int index]
        {
            get 
            {
                return students[index];
            }
            set 
            {
                students[index] = value;
            }
        }
        public Group(int groupNumber)
        {
            students = new List<Student>();
            GroupNumber = groupNumber;
        }
    }
}
