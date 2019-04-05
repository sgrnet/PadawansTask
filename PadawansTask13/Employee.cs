using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string surname;
        private int age;

        private string Surname { get => surname; set => surname = value; }
        private int Age { get => age; set => age = value; }

        public Employee()
        {
            age = 25;
        }

        public Employee(string surname, int age)
        {
            this.surname = surname;
            if (age != 0)
                this.age = age;
            else
                this.age = 25;
        }
        private string GetAge()
        {
            return Convert.ToString(age);
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public string Information()
        {
            return "Surname: " + surname + ", Age: " + Age;

        }
    }
}
