namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Red Dead Redemption 2",
                "The Witcher 3: Wild Hunt",
                "Dark Souls III",
                "Super Mario Odyssey",
                "Bloodborne",
                "Persona 5",
                "God of War",
                "Hollow Knight",
                "Sekiro: Shadows Die Twice",
                "Grand Theft Auto V",
                "The Legend of Zelda: A Link to the Past",
                "Half-Life 2"

            };
            var gameCollection = videoGames.OrderBy(game => game.Length);

            foreach(var item in gameCollection)
            {
                Console.WriteLine(item);
            }

           
        }
    }
}
