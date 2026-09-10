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

var getallatjes = GeefGetallen();
// foreach (var getallatje in getallatjes)
// {
// 	Console.WriteLine($"getalletje: {getallatje}");
// }
var enumerator = getallatjes.GetEnumerator();
enumerator.MoveNext();
Console.WriteLine(enumerator.Current);
enumerator.MoveNext();
Console.WriteLine(enumerator.Current);
enumerator.MoveNext();
Console.WriteLine(enumerator.Current);

static IEnumerable<int> GeefGetallen()
{
	Console.WriteLine("eerste");
	yield return 4;
	Console.WriteLine("tweede");
	yield return 8;
	Console.WriteLine("derde");
	yield return 15;
	Console.WriteLine("vierde");
	yield return 16;
	Console.WriteLine("vijfde");
	yield return 23;
	Console.WriteLine("laatste");
	yield return 42;
}

