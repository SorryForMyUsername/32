using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    abstract class Person
    {
        string name;
        string surname;
        DateTime dateOfBirth;

        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public Person(string name, string surname, DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public abstract void Print();

        public abstract int Age();
    }
}
