namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] videoGames =
            {
                "Zelda", "Metroid", "Undertale", "Fire Emblem", "Persona", "Red Dead Redemption", "Elden Ring",
                "Baldur's Gate", "Portal"
            };
            
            videoGames = videoGames.OrderBy(x => x.Length).ToArray();
            
            foreach (var game in videoGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
