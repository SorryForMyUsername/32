using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Teacher : Person
    {
        string faculty;
        string job;
        int expirience;

        public string Faculty { get => faculty; set => faculty = value; }
        public string Job { get => job; set => job = value; }
        public int Expirience { get => expirience; set => expirience = value; }

        public Teacher(string name, string surname, DateTime dateOfBirth, string faculty, string job, int expirience) : base(name, surname, dateOfBirth)
        {
            Faculty = faculty;
            Job = job;
            Expirience = expirience;
        }

        public override void Print()
        {
            Console.WriteLine($"Студент: {Name}\n" +
                $"Дата рождения: {DateOfBirth}\n" +
                $"Фаультет: {Faculty}\n" +
                $"Должность: {Job}\n" +
                $"Стаж: {Expirience}\n" +
                $"Возраст: {Age()}");
        }

        public override int Age()
        {
            if (DateOfBirth.DayOfYear < DateTime.Now.DayOfYear)
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
            else
            {
                return DateTime.Now.Year - DateOfBirth.Year + 1;
            }
        }

        public static Teacher Enter()
        {
            Console.Clear();
            Console.Write("Имя преподавателя: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия преподавателя: ");
            string surname = Console.ReadLine();
            Console.Write("Дата рождения: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Факультет: ");
            string faculty = Console.ReadLine();
            Console.Write("Должность: ");
            string job = Console.ReadLine();
            Console.Write("Стаж: ");
            int expirience = int.Parse(Console.ReadLine());
            return new Teacher(name, surname, dateOfBirth, faculty, job, expirience);
        }
    }
}
