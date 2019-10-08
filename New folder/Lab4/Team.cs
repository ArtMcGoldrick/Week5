using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //These are constants values
    public enum Result { Win, Draw, Loss }
    public class Team : IComparable
    {
        //This class holds properties for the teams
        //All values with private setters
        public string Name { get; private set; }
        public int Wins { get; private set; }
        public int Draws { get; private set; }
        public int Loses { get; private set; }
        public int Games { get; private set; }
        private int points;

        public List<Player> Players { get; set; }

        //A method for giving points worth the value
        public int Points
        {
            get
            {
                points = (Wins * 3) + (Draws * 1);
                return points;
            }         
        }

        //Setting up for program.cs
        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

        //For displaying the teams scores
        public string DisplayTeamTable()
        { return string.Format($"{Name,-15}{Points,-7}{Wins,-7}{Draws,-7}{Loses,-7}{Games,-7}"); }

        //Addition onto the values, with a switch
        public void AddResult(Result result)
        {
            Games++;
            switch(result)
            {
                case Result.Win:
                    Wins++;
                    break;
                case Result.Loss:
                    Loses++;
                    break;
                case Result.Draw:
                    Draws++;
                    break;
            }
        }

        //Allows object to be compared to each other
        public int CompareTo(object obj)
        {
            Team that = (Team)obj;
            return this.Points.CompareTo(that.Points);
        }
    }
   
}
