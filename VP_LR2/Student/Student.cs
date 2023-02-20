using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib
{
    public class Student
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Patronymic { get; private set; }

        public string BornDate { get; private set; }

        public string Adress { get; private set; }

        public string PhoneNumber { get; private set; }

        public override string ToString()
        {
            return $"\nСтудент: {Surname} {Name} {Patronymic}" +
                $"\nНомер зачетной книжки: {Id}" +
                $"\nДата рождения: {BornDate}" +
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
        //    Student student = (Student)obj;
        //    //return (obj as Student) == this;
        //    //return this == student;
        //}
        public Student(int id, string name, string surname, string patronymic, string bornDate, string adress, string phoneNumber)
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
