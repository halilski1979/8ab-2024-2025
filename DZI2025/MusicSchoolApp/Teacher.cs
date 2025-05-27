using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolApp
{
    public class Teacher : SchoolMember
    {
        private string specialty;
        private int studentsCount;
        private double salary;
        private readonly List<string> specialtys = new List<string> { "Piano", "Violin", "Guitar" };
        public double Bonus { get { return (Salary * StudentsCount * 0.02); } }
        public double Salary
        {
            get { return salary; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Salary cannot be a negative number!");
                }
                salary = value; 
            }
        }
        public int StudentsCount
        {
            get { return studentsCount; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Students count cannot be negative!");
                }
                studentsCount = value;
            }
        }
        public string Specialty
        {
            get { return specialty; }
            set 
            {
                if (string.IsNullOrEmpty(value)||!specialtys.Contains(value))
                {
                    throw new ArgumentException("Specialty cannot be an empty string!");
                }
                specialty = value; 
            }
        }

        public Teacher(string name, int age, string specialty, int studentsCount, double salary) 
            : base(name, age)
        {
            this.Specialty = specialty;
            this.StudentsCount = studentsCount;
            this.Salary = salary;
            
        }

        public override string Info()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Teacher: {Name}, Age: {Age} years ");
            sb.AppendLine($"Specialty: {Specialty} ");
            sb.AppendLine($"Students count: {StudentsCount}");
            sb.AppendLine($"Salary: {Salary:f2} lv.");
            sb.AppendLine($"Bonus: {Bonus:f2} lv.");
            return sb.ToString().Trim();
        }
    }
}
