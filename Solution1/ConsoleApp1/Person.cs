using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public Person(string name, int age, string adress)
        {
            Name = name;
            Age = age;
            Adress = adress;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name},{this.Age},{this.Adress}";
        }
    }
}
