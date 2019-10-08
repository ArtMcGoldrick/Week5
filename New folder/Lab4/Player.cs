using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Player
    {
        //This class holds properties for the players
        public string Name { get; set; }
        public string Position { get; set; }

        //Displays players name and position
        public override string ToString()
        {
            return string.Format($"{Name} - {Position}");
        }
    }
}
