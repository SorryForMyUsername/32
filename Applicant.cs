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

        public Applicant(string name, string surname, DateTime dateOfBirth, string faculty) : base(name, surname, dateOfBirth)
        {
            Faculty = faculty;
        }

        public override void Print()
        {
            Console.WriteLine($"Абитуриент: {Name}\n" +
                $"Дата рождения: {DateOfBirth:d}\n" +
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
                return DateTime.Now.Year - DateOfBirth.Year - 1;
            }
        }

        public static Applicant Enter()
        {
            Console.Clear();
            Console.Write("Имя абитуриента: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия абитуриента: ");
            string surname = Console.ReadLine();
            Console.Write("Дата рождения: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Факультет: ");
            string faculty = Console.ReadLine();
            return new Applicant(name, surname, dateOfBirth, faculty);
        }
    }
}
