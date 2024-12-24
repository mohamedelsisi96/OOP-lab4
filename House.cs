using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class House
    {
        Room[] rooms;
        int _size;
        public House(int size) {
        _size = size;
            rooms = new Room[size];
        }
        public Room this[int index]{
            get {
                if (index > 0 || index <= rooms.Length)
                {
                    return rooms[index];
                }
                else { return null; } }
            set { rooms[index] = value;}
            
            }
        public void AddRoom(Room room ,int index) {
        if (room != null&& index > 0 && index <= rooms.Length)
            {
                rooms[index-1] = room;
            }
        }
        public void AllRoom() {
            Console.WriteLine($"the Howse Contain {rooms.Length} Rooms");
            for (int i = 0; i < rooms.Length; i++)
            {
                Console.WriteLine($"the room {i+1} is {rooms[i].Type} and size is {rooms[i].Size} meter");
            }
        }
    }
}
