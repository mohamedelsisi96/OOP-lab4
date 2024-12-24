using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Room
    {
        public string? Type { get; set; }
        public double Size { get; set; }
        public Room(string type, int size)
        {
            Type = type;
            Size = size;
        }
    }
}
