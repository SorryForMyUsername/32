using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            bool flag = true;
            do
            {
                Console.Write("Введите название персоны: ");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "а":
                    case "А":
                        people.Add(Applicant.Enter());
                        break;
                    case "п":
                    case "П":
                        people.Add(Teacher.Enter());
                        break;
                    case "с":
                    case "С":
                        people.Add(Student.Enter());
                        break;
                    case "в":
                    case "В":
                        OutputPersons(people);
                        break;
                    case "д":
                    case "Д":
                        OutputPersonsInRange(people);
                        break;
                    case "е":
                    case "Е":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Нет такой печатной продукции");
                        break;
                }
                Console.WriteLine();
            } while (flag);
        }

        static void OutputPersons(List<Person> persons)
        {
            Console.Clear();
            foreach(Person person in persons)
            {
                person.Print();
                Console.WriteLine();
            }
        }

        static void OutputPersonsInRange(List<Person> persons)
        {
            Console.Clear();
            Console.WriteLine("Введите нижнюю границу диапазона возраста:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу диапазона возраста:");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Персоны, чей возраст попадает в заданный диапазон:\n");

            List<Person> personsInRange = persons.Where(p => p.Age() >= min && p.Age() <= max).ToList();
            OutputPersons(personsInRange);
        }
    }
}
