using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib
{
    public class Student
    {
        private int _id;

        private string _name;

        private string _surname;

        //private string _patronymic;

        private DateTime _bornDate;

        private string _adress;

        private string _phoneNumber;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value >= 0)
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Номер зачетки не может быть отрицательным");
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != string.Empty)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Имя должно быть указано");
                }
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value != string.Empty)
                {
                    _surname = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Фамилия должна быть указана");
                }
            }
        }
        
        
        public string Patronymic { get; private set; }


        public DateTime BornDate
        {
            get
            {
                return _bornDate;
            }
            set
            {
                if (value != null)
                {
                    _bornDate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Дата рождения должна быть указана");
                }
            }
        }

        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                if (value != string.Empty)
                {
                    _adress = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Адрес должен быть указан");
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value != string.Empty)
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Номер телефона должен быть указан");
                }
            }
        }

        public override string ToString()
        {
            return $"\nСтудент: {Surname} {Name} {Patronymic}" +
                $"\nНомер зачетной книжки: {Id}" +
                $"\nДата рождения: {BornDate.ToShortDateString()}" +
                $"\nАдрес: {Adress}" +
                $"\nНомер телефона: {PhoneNumber}\n";
        }

        public override bool Equals(object obj)  //Перегрузка метода 
        {
            Student student = (Student)obj;
            return (this.Id == student.Id && this.Surname == student.Surname &&
                this.Name == student.Name && this.Patronymic == student.Patronymic &&
                this.BornDate == student.BornDate && this.Adress == student.Adress &&
                this.PhoneNumber == student.PhoneNumber);
        }

        //public override bool Equals(object obj)  //Перегрузка метода 
        //{
        //    //Student student = (Student)obj;
        //    return (obj as Student) == this;
        //    //return this == student;
        //}
        public Student(int id, string name, string surname, string patronymic, DateTime bornDate, string adress, string phoneNumber)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BornDate = bornDate;
            Adress = adress;
            PhoneNumber = phoneNumber;
        }
    }
}
