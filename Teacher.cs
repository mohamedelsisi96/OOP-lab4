using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Teacher
    {
        public string? Name { get; set; }

        public void Teach(string subject)
        {
            Console.WriteLine($"the teacher {Name} teach {subject}");
        }
    }
}
