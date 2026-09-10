var emmaStone = new Actor { Name = "Emma Stone", Age = 37 };
var oscarIsaac = new Actor { Name = "Oscar Isaac", Age = 47 };
var florencePugh = new Actor { Name = "Florence Pugh", Age = 30 };
var danielKaluuya = new Actor { Name = "Daniel Kaluuya", Age = 37 };
var anaDeArmas = new Actor { Name = "Ana de Armas", Age = 38 };
var devPatel = new Actor { Name = "Dev Patel", Age = 36 };
var zendaya = new Actor { Name = "Zendaya", Age = 30 };
var paulMescal = new Actor { Name = "Paul Mescal", Age = 30 };
var anyaTaylorJoy = new Actor { Name = "Anya Taylor-Joy", Age = 30 };
var johnBoyega = new Actor { Name = "John Boyega", Age = 34 };
var saoirseRonan = new Actor { Name = "Saoirse Ronan", Age = 32 };
var lakeithStanfield = new Actor { Name = "LaKeith Stanfield", Age = 35 };
var margotRobbie = new Actor { Name = "Margot Robbie", Age = 36 };
var robertPattinson = new Actor { Name = "Robert Pattinson", Age = 40 };
var lupitaNyongo = new Actor { Name = "Lupita Nyong'o", Age = 43 };
var pedroPascal = new Actor { Name = "Pedro Pascal", Age = 51 };
var rebeccaFerguson = new Actor { Name = "Rebecca Ferguson", Age = 42 };
var stevenYeun = new Actor { Name = "Steven Yeun", Age = 42 };
var jodieComer = new Actor { Name = "Jodie Comer", Age = 33 };
var barryKeoghan = new Actor { Name = "Barry Keoghan", Age = 33 };

var movies = new List<Movie>
{
    // Rond 1995
    new()
    {
        Title = "Midnight Protocol",
        ReleaseYear = 1994,
        Actors = [oscarIsaac, danielKaluuya, anaDeArmas]
    },
    new()
    {
        Title = "The Last Frequency",
        ReleaseYear = 1995,
        Actors = [emmaStone, devPatel, zendaya, johnBoyega]
    },
    new()
    {
        Title = "Silent Harbour",
        ReleaseYear = 1995,
        Actors = [florencePugh, oscarIsaac, saoirseRonan, lakeithStanfield, pedroPascal]
    },
    new()
    {
        Title = "Red Horizon",
        ReleaseYear = 1997,
        Actors = [danielKaluuya, anaDeArmas, robertPattinson]
    },

    // Rond 2005
    new()
    {
        Title = "Glass City",
        ReleaseYear = 2003,
        Actors = [emmaStone, oscarIsaac, devPatel, margotRobbie, stevenYeun, jodieComer]
    },
    new()
    {
        Title = "Echoes of Tomorrow",
        ReleaseYear = 2004,
        Actors = [zendaya, johnBoyega, lupitaNyongo]
    },
    new()
    {
        Title = "The Northern Line",
        ReleaseYear = 2005,
        Actors =
        [
            florencePugh,
            danielKaluuya,
            anaDeArmas,
            paulMescal,
            anyaTaylorJoy,
            robertPattinson,
            rebeccaFerguson,
            barryKeoghan
        ]
    },
    new()
    {
        Title = "Paper Kingdom",
        ReleaseYear = 2006,
        Actors = [saoirseRonan, devPatel, jodieComer, pedroPascal]
    },
    new()
    {
        Title = "Blackwater",
        ReleaseYear = 2007,
        Actors = [oscarIsaac, lakeithStanfield, stevenYeun]
    },

    // Rond 2015
    new()
    {
        Title = "Neon Valley",
        ReleaseYear = 2013,
        Actors = [emmaStone, zendaya, anaDeArmas, anyaTaylorJoy, margotRobbie]
    },
    new()
    {
        Title = "Gravity's Edge",
        ReleaseYear = 2014,
        Actors =
        [
            oscarIsaac,
            danielKaluuya,
            johnBoyega,
            robertPattinson,
            lupitaNyongo,
            pedroPascal,
            rebeccaFerguson
        ]
    },
    new()
    {
        Title = "A Thousand Winters",
        ReleaseYear = 2015,
        Actors = [florencePugh, paulMescal, saoirseRonan]
    },
    new()
    {
        Title = "The Broken Compass",
        ReleaseYear = 2015,
        Actors = [devPatel, stevenYeun, jodieComer, barryKeoghan]
    },
    new()
    {
        Title = "After the Storm",
        ReleaseYear = 2017,
        Actors = [emmaStone, danielKaluuya, lakeithStanfield, margotRobbie, pedroPascal, jodieComer]
    },

    // Rond 2020
    new()
    {
        Title = "Solaris Nine",
        ReleaseYear = 2019,
        Actors =
        [
            zendaya,
            oscarIsaac,
            anaDeArmas,
            johnBoyega,
            anyaTaylorJoy,
            robertPattinson,
            rebeccaFerguson,
            stevenYeun
        ]
    },
    new()
    {
        Title = "The Forgotten Room",
        ReleaseYear = 2020,
        Actors = [florencePugh, saoirseRonan, barryKeoghan]
    },
    new()
    {
        Title = "No Signal",
        ReleaseYear = 2021,
        Actors = [danielKaluuya, lakeithStanfield, lupitaNyongo, jodieComer]
    },

    // Recent
    new()
    {
        Title = "Atlas Falling",
        ReleaseYear = 2024,
        Actors = [pedroPascal, zendaya, paulMescal, rebeccaFerguson, oscarIsaac]
    },
    new()
    {
        Title = "The Long Way Home",
        ReleaseYear = 2025,
        Actors = [emmaStone, devPatel, margotRobbie]
    },
    new()
    {
        Title = "Event Horizon Zero",
        ReleaseYear = 2025,
        Actors =
        [
            anaDeArmas,
            johnBoyega,
            robertPattinson,
            anyaTaylorJoy,
            stevenYeun,
            florencePugh,
            danielKaluuya,
            barryKeoghan
        ]
    }
};

// deferred execution

// var year = 2000;
// var query = movies.Where(x => x.ReleaseYear > year).OrderBy(x => x.ReleaseYear).ToList();
// year = 2010;
// query.Dump();


// var prettyMovies = from m
//                    in movies
//                    let nrOfActors = m.Actors.Count() * 10
//                    orderby nrOfActors
//                    select new { m.Title, m.ReleaseYear, NrOfActors = nrOfActors };
// prettyMovies.Dump();



var prettyMovies2 = from m
                   in movies
                    group m by m.ReleaseYear into grp
                    select new { grp.Key, NrOfMovies = grp.Count(), NrOfActors = grp.Sum(x => x.Actors.Count()) };
prettyMovies2.Dump();

// movies.Select(x => new { x.Title, x.ReleaseYear, NrOfActors = x.Actors.Count }).Dump();







class Movie
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public List<Actor> Actors { get; set; } = [];
}
class Actor
{

    public string Name { get; set; }
    public int Age { get; set; }
    public List<Movie> Movies { get; set; } = [];
}