using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] games =
            { "Halo", "Portals", "Super Smash Bros", "Legend of Zelda", "Mario Kart"};
            
            var myVideoGames = games.OrderBy(x => x.Length).ToList();

            foreach ( var i in myVideoGames ) 
            {
                Console.WriteLine( i );
            }
        }
    }
}
