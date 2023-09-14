//makes a List of game titles

List<string> games = new List<string>
{
    "CS:GO",
    "Halo 3",
    "Borderland 3",
    "Fifa 22",
    "Minecraft"
};

//stores the text into the "otherGames" string.
string[] otherGames = new string[]
{
    "Tiny TinaWonderlands",
    "Farcry 3",
};

//shows each game as text.
foreach (string game in games)
{
    Console.WriteLine(game);
}

//writes text of the amount of games in the list.
Console.WriteLine($"\nGames in list: {games.Count}");

//add the range in the otherGames string and puts it the lists of games.
games.AddRange(otherGames);

Console.WriteLine($"\nGame in list: {games.Count}");

//if the game title "Halo" is in the lists then it will say the writeline text below. If not then it will add Halo.
if (games.Contains("Halo"))
{
    Console.WriteLine("\nMASTER CHEIF is in the house!!");
}
else
{
    games.Add("Halo");
}

//sets an int equal to 6.
int myInt = 6;

//if the "games.Count" is bigger then the "myInt" variable then it will "RemoveAt" the "myInt" variable.
if (myInt < games.Count)
{
    games.RemoveAt(myInt);
}
else
{
    Console.WriteLine("\nGame not found!");
}

//displays the games by their titles.
Console.WriteLine("\nAll games in the list:");
foreach (string game in games)
{
    Console.WriteLine(game);
}

//sorts the lists in alphabetical order.
games.Sort();

Console.WriteLine("\nSorted games list:");
foreach (string game in games)
{
    Console.WriteLine(game);
}

//makes "newList" store the "games.Count" and copies the games to "newList".
string[] newList = new string[games.Count];

games.CopyTo(newList);

games.Clear();

//makes the sorted lists as the new list.
Console.WriteLine("\nNew list:");
foreach (string game in newList)
{
    Console.WriteLine(game);
}
