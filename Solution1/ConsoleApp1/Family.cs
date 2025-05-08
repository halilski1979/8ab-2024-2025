
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Family
    {
        List<Person> people=new List<Person>();

        public void AddMember(Person member)
        {
            people.Add(member);
        }

        public void Print()
        {
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name}, {item.Age} godini. {item.Adress}");
            }
        }
    }
}
