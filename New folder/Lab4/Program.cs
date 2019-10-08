using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list of teams
            List<Team> teams = new List<Team>();

            //Constructor
            Team SligoRovers = new Team("Sligo Rovers");
            Team FinnHarps = new Team("Finn Harps");
            Team GalwayUnited = new Team("Galway United");
            Team DerryCity = new Team("DerryCity");
            Team Dundalk = new Team("Dundalk");

            //Addition of list with teams
            teams.Add(SligoRovers);
            teams.Add(FinnHarps);
            teams.Add(GalwayUnited);
            teams.Add(DerryCity);
            teams.Add(Dundalk);

            //Display all the teams on a table
            Console.WriteLine("Table without values");
            Display(teams);

            //Suppliying the results to the teams
            SligoRovers.AddResult(Result.Win);
            FinnHarps.AddResult(Result.Loss);
            FinnHarps.AddResult(Result.Draw);
            GalwayUnited.AddResult(Result.Win);
            Dundalk.AddResult(Result.Loss);

            //Display all the teams on a table
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("Table with values");
            Display(teams);

            //Display the values from highest to lowest on a table
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("Table sorted");
            teams.Sort();
            teams.Reverse();
            Display(teams);

            //Adding values to players
            SligoRovers.Players.Add(new Player() { Name = "Ed Sean", Position = "Goalie" });
            SligoRovers.Players.Add(new Player() { Name = "John Big", Position = "Striker" });
            SligoRovers.Players.Add(new Player() { Name = "Bert Hern", Position = "Defender" });

            //Displaying the player values
            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("Sligo Rovers Teamsheet");
            foreach (Player player in SligoRovers.Players)
            {
                Console.WriteLine($"{player.Name} - {player.Position}");
            }
        }

        //Displays list of teams in display team table
        static void Display(List<Team> teams)
        {
            Console.WriteLine("{0,-15}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}", "NAME", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");
            //The foreach loop displays it in the DisplayTeamTable
            foreach (Team team in teams)
            { Console.WriteLine(team.DisplayTeamTable()); }

        }
    }
}
