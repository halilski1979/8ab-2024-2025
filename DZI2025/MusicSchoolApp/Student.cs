using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MusicSchoolApp
{
    public class Student : SchoolMember
    {
        public Student(string name, int age, string instument, int practiceHours) 
            : base(name, age)
        {
            this.Instrument = instument;
            this.PracticeHours = practiceHours;
        }
        private string instrument;
        private int practiceHours;

        public int PracticeHours
        {
            get { return practiceHours; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Practice hours must be a positive number!");
                }
                practiceHours = value; 
            }
        }

        public string Instrument
        {
            get { return instrument; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Instrument cannot be an empty string");
                }
                instrument = value; 
            }
        }

        public override string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Student: {Name}, Age: {Age} years");
            sb.AppendLine($"Instrument: {Instrument}");
            sb.AppendLine($"Practice hours: {PracticeHours} per week");
            return sb.ToString();
        }
    }
}
