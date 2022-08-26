using System.Linq;

List<string> videoGameNames = new List<string>
{"Minecraft", "Call of Duty", "Grand Theft Auto", "Sim City"};

IEnumerable<string> gameNames = videoGameNames.OrderBy(x => x.Length);

foreach (string game in gameNames)
{
    Console.WriteLine(game);
}
