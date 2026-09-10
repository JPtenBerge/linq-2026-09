// var


using PrelinqDemo;

var getal = 14; // efficient keyword
// getal = "qwe";

// dynamic hoi = 14;
// hoi.DoeIetsLeuks(14, "huh", 23747);

Console.WriteLine(getal);





// tuples: variabele met meerdere waardes
var ogTuple = new Tuple<int, string, decimal>(14, "hoi", 45m);
var beterTuple = (14, "hoi", 45m);

// var (getalletje, tekstje) = GeefTuple();
var result = GeefTuple();
// result.MijnGetal

static (int MijnGetal, string MijnTekst) GeefTuple()
{
	return (47, "deze etkst");
}



// anonieme objecten

class Bla
{
	public void Hoi()
	{
		var mooiObj = new { AantalDingen = 14, MooieTekst = "hoi" };
		
	}
}

class CustomerEntity
{
}



// extension methods
var nu = DateTime.Now;
DateTime.Whoa();


Console.WriteLine($"{nu.ToMyPrettyString3()}");

