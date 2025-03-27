using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Applicant : Person
    {
        string faculty;

        public string Faculty { get => faculty; set => faculty = value; }

        public Applicant(DateTime dateOfBirth, string name, string surname, string faculty) : base(name, surname, dateOfBirth)
        {
            Faculty = faculty;
        }

        public override void Print()
        {
            Console.WriteLine($"Абитуриент: {Name}\n" +
                $"Дата рождения: {DateOfBirth}\n" +
                $"Фаультет: {Faculty}\n" +
                $"Возраст: {Age()}");
        }

        public override int Age()
        {
            if(DateOfBirth.DayOfYear < DateTime.Now.DayOfYear)
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
            else
            {
                return DateTime.Now.Year - DateOfBirth.Year + 1;
            }
        }
    }
}
