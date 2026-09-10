using System.Globalization;

var numbers = new List<string>
{
	"12",
	"14,1",
	"21848,3845",
	"-23849",
	"4389494",
	"27838459,4857573474347874837834784334897489756897589"
};

// 2
numbers.ForEach(n => Console.WriteLine(n));
Console.WriteLine("==============");


// 3 - var lagerDanNul = numbers.Find(x => x.StartsWith("-")) != null;
var lagerDanNul = numbers.Find(x =>
{
	double.TryParse(x, out var result);
	return result < 0;
}) != null;
Console.WriteLine($"Bevat getallen lager dan 0? {lagerDanNul}");
// var lagerDanNulLinq = numbers.Where(x => double.Parse(x) < 0);

// 4
var enkelGetallen = numbers.Find(x => !double.TryParse(x, out var _)) == null;
Console.WriteLine($"Bevat enkel getallen? {enkelGetallen}");
// var enkelGetallenLinq = numbers.All(x => double.TryParse(x, out var _));

// 5
// var onlyWholeNumbers = numbers.FindAll(x =>
// {
// 	double.TryParse(x, out var result);
// 	return result % 1 != 0;
// });
var onlyWholeNumbers = numbers.FindAll(x =>
{
	if (double.TryParse(x, out var _))
	{
		if (int.TryParse(x, out var _))
		{
			return true;
		}

		return false;
	}

	return false;
});
onlyWholeNumbers.ForEach(n => Console.WriteLine(n));

var doubleList = new List<double>();
numbers.ForEach(n => doubleList.Add(double.Parse(n)));
// var doubleListLinq = numbers.Select(x => double.Parse(x)).ToList();

var sum = 0.0;
doubleList.ForEach(n => sum += n);

Console.WriteLine($"Sum: {sum}");
// doubleList.Sum();





