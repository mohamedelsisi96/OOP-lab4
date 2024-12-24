using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class School
    {
        public string? Name { get; set; }
        public void OrganizeClass(Teacher teacher)
        {
            Console.WriteLine($"the teacher {teacher.Name} at {Name}");
           teacher.Teach("arabic");
        }
    }
}
