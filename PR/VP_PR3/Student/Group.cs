using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib
{
    public class Group
    {
        private List<Student> students;

        public List<Student> Students
        {
            get 
            {
                return students;
            }
        }
        public int GroupNumber { get; private set; }

        public int Size()
        {
            return students.Count;
        }

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

        public void Remove(int id)
        {
            students.RemoveAll(x => x.Id == id);
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

        public virtual Student this[int id]
        {
            get 
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id == id)
                    {
                        return students[i];
                    }
                }
                return default(Student);
            }
            set 
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id == id)
                    {
                        students[i] = value;
                    }
                }
            }
        }
        public Group(int groupNumber)
        {
            students = new List<Student>();
            GroupNumber = groupNumber;
        }
    }
}
