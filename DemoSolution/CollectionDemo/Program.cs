Console.WriteLine("Hello, World!");

var lijstje = new List<int>();



var tekst = "hallo ik ben jp en ik geef training vandaag";

var dict = new Dictionary<char, int>();
foreach (var letter in tekst)
{
	dict.TryAdd(letter, 0);
	dict[letter]++;
}

foreach (var entry in dict)
{
	Console.WriteLine($"{entry.Key} komt {entry.Value} keer voor");
}


