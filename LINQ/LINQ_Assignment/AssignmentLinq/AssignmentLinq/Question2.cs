using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLinq
{
    
    
        class Player
        {
            public Player(string name, string country)
            {
                Name = name;
                Country = country;
            }
            public string Name { get; set; }
            public string Country { get; set; }
        }
        internal class Question2
        {
            static void Main()
            {
              List<Player> list1 = new List<Player>()
              {
               new Player("Team1","India"),
                new Player("Team2","US"),

              };
             List<Player> list2 = new List<Player>()
             {
               new Player("Team3","India"),
                new Player("Team4","UK"),
             };
            var result = from l1 in list1
                         from l2 in list2
                         where l1.Country != l2.Country
                         select new { team = l1.Name, team1 = l2.Name };
            foreach (var i in result)
                
                Console.WriteLine($"{i.team}{i.team1}");
        }
        }
}
