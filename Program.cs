// CIDM 3312 Lab 2 Solution
// Task 1 - Create a new, empty list of strings
List<string> galaxies = new List<string>();

// Task 2 - Add 3 strings to list
galaxies.Add("Milky Way");
galaxies.Add("Andromeda");
galaxies.Add("Whirlpool Galaxy");

// Task 3 - foreach loop to iterate through each element (galaxy)
foreach (string galaxy in galaxies) 
{
    Console.WriteLine(galaxy);
}

// Task 4 - Push changes to github
// Task 5
string testGalaxy = "Sombrero Galaxy";
// testGalaxy = "Whirlpool Galaxy"
if (galaxies.Contains(testGalaxy))
{
    galaxies.Remove(testGalaxy);
    Console.WriteLine($"Galaxy \"{testGalaxy}\" was in the list and has been REMOVED.");
}
else
{
    Console.WriteLine($"Galaxy \"{testGalaxy}\" is not in the list.");
}

// Task 6 - Clear the list
galaxies.Clear();
Console.WriteLine($"List has been cleared. It contains {galaxies.Count} elements now.");