using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Team
    {
        Player[] players;
        int _size;
        public Team()
        {
            _size = 5;
            players = new Player[5];
        }
        public Player this[int index]
        {
            get {
                if (index > 0 || index <= players.Length) { 
                    return players[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                players[index] = value;
            }
        }
    }
}
