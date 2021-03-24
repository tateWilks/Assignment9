using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {

            DatabaseContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<DatabaseContext>();
            if (context.Database.GetPendingMigrations().Any()) //needed to specify the data path with " AttachDbFilename=|DataDirectory|twilksWebApp5DB.mdf " in the Connection Strings section of the .json file
            {
                context.Database.Migrate(); //this saves it in C:\Users\tatew\source\repos\WebApp5\bin\Debug\netcoreapp3.1
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Avengers, The",
						Director = "Joss Whedon",
						YearReleased = "2012",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Batman",
						Director = "Tim Burton",
						YearReleased = "1989",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Batman & Robin",
						Director = "Joel Schumacher",
						YearReleased = "1997",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Batman Begins",
						Director = "Christopher Nolan",
						YearReleased = "2005",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Batman Forever",
						Director = "Joel Schumacher",
						YearReleased = "1995",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Batman Returns",
						Director = "Tim Burton",
						YearReleased = "1992",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Boondock Saints, The",
						Director = "Troy Duffy",
						YearReleased = "1999",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Dark Knight Rises, The",
						Director = "Christopher Nolan",
						YearReleased = "2012",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Dark Knight, The",
						Director = "Christopher Nolan",
						YearReleased = "2008",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Die Hard",
						Director = "John McTiernan",
						YearReleased = "1988",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "District 9",
						Director = "Neill Blomkamp",
						YearReleased = "2009",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "The Fugitive",
						Director = "Andrew Davis",
						YearReleased = "1993",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Harry Potter and the Chamber of Secrets",
						Director = "Chris Columbus",
						YearReleased = "2002",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Harry Potter and the Deathly Hallows � Part 1",
						Director = "David Yates",
						YearReleased = "2010",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Harry Potter and the Deathly Hallows � Part 2",
						Director = "David Yates",
						YearReleased = "2011",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Harry Potter and the Goblet of Fire",
						Director = "Mike Newell",
						YearReleased = "2005",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Harry Potter and the Half-Blood Prince",
						Director = "David Yates",
						YearReleased = "2009",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Harry Potter and the Order of the Phoenix",
						Director = "David Yates",
						YearReleased = "2007",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Harry Potter and the Prisoner of Azkaban",
						Director = "Alfonso Cuar�n",
						YearReleased = "2004",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Harry Potter and the Sorcerer's Stone",
						Director = "Chris Columbus",
						YearReleased = "2001",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Incredible Hulk, The",
						Director = "Louis Leterrier",
						YearReleased = "2008",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Independence Day",
						Director = "Roland Emmerich",
						YearReleased = "1996",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Indiana Jones and the Last Crusade",
						Director = "Steven Spielberg",
						YearReleased = "1989",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Indiana Jones and the Raiders of the Lost Ark",
						Director = "Steven Spielberg",
						YearReleased = "1981",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Indiana Jones and the Temple of Doom",
						Director = "Steven Spielberg",
						YearReleased = "1984",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Iron Man",
						Director = "Jon Favreau",
						YearReleased = "2008",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Italian Job, The",
						Director = "F. Gary Gray",
						YearReleased = "2003",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Jurassic Park",
						Director = "Steven Spielberg",
						YearReleased = "1993",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Kick-@$$",
						Director = "Matthew Vaughn",
						YearReleased = "2010",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Ladyhawke",
						Director = "Richard Donner",
						YearReleased = "1985",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Live Die Repeat: Edge of Tomorrow",
						Director = "Doug Liman",
						YearReleased = "2014",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Lock, Stock and Two Smoking Barrels",
						Director = "Guy Ritchie",
						YearReleased = "1999",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Lord of the Rings: The Fellowship of the Ring",
						Director = "Peter Jackson",
						YearReleased = "2001",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Lord of the Rings: The Return of the King, The",
						Director = "Peter Jackson",
						YearReleased = "2003",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Lord of the Rings: The Two Towers, The",
						Director = "Peter Jackson",
						YearReleased = "2002",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Lucky Number Slevin",
						Director = "Paul McGuigan",
						YearReleased = "2006",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Mask of Zorro, The",
						Director = "Martin Campbell",
						YearReleased = "1998",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Matrix, The",
						Director = "The Wachowski Brothers",
						YearReleased = "1999",
						Rating = "R",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Mission: Impossible",
						Director = "Brian De Palma",
						YearReleased = "1996",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Mission: Impossible II",
						Director = "John Woo",
						YearReleased = "2000",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Mission: Impossible III",
						Director = "J.J. Abrams�",
						YearReleased = "2006",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Mr. &�Mrs.�Smith",
						Director = "Doug Liman",
						YearReleased = "2005",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Ocean's Eleven",
						Director = "Steven Soderbergh",
						YearReleased = "2001",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Phone Booth",
						Director = "Joel Schumacher",
						YearReleased = "2003",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Pirates of the Caribbean: The Curse of the Black Pearl",
						Director = "Gore Verbinski",
						YearReleased = "2003",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Predator",
						Director = "John McTiernan",
						YearReleased = "1987",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Rocketeer, The",
						Director = "Joe Johnston",
						YearReleased = "1991",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Serenity",
						Director = "Joss Whedon",
						YearReleased = "2005",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Snatch",
						Director = "Guy Ritchie",
						YearReleased = "2001",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Sneakers",
						Director = "Phil Alden Robinson",
						YearReleased = "1992",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Spider-Man",
						Director = "Sam Raimi",
						YearReleased = "2002",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Spider-Man 2",
						Director = "Sam Raimi",
						YearReleased = "2004",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Spider-Man: Into the Spider-Verse",
						Director = "Peter Ramsey, Bob Persichetti, Rodney Rothman",
						YearReleased = "2018",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Star Wars Episode I: The Phantom Menace",
						Director = "George Lucas",
						YearReleased = "1999",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Star Wars Episode II: Attack of the Clones",
						Director = "George Lucas",
						YearReleased = "2002",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Star Wars Episode III: Revenge of the Sith",
						Director = "George Lucas",
						YearReleased = "2005",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Star Wars Episode IV: A New Hope",
						Director = "George Lucas",
						YearReleased = "1977",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Star Wars Episode V: The Empire Strikes Back",
						Director = "�Irvin Kershner",
						YearReleased = "1980",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Star Wars Episode VI: Return of the Jedi",
						Director = "Richard Marquand",
						YearReleased = "1983",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Superman II",
						Director = "Richard Lester",
						YearReleased = "1980",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Superman III",
						Director = "Richard Lester",
						YearReleased = "1983",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Superman IV: The Quest for Peace",
						Director = "Sidney J. Furie",
						YearReleased = "1987",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Superman: The Movie",
						Director = "Richard Donner",
						YearReleased = "1978",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Terminator 2: Judgment Day",
						Director = "James Cameron",
						YearReleased = "1991",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Watchmen",
						Director = "Zack Snyder",
						YearReleased = "2009",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "X-Men",
						Director = "Bryan Singer",
						YearReleased = "2000",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "X-Men: The Last Stand",
						Director = "Brett Ratner�",
						YearReleased = "2006",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "X2",
						Director = "Bryan Singer",
						YearReleased = "2003",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Action/Adventure",
						MovieTitle = "Young Guns",
						Director = "Christopher Cain",
						YearReleased = "1988",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Ace Ventura: Pet Detective",
						Director = "Tom Shadyac",
						YearReleased = "1994",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Am�lie",
						Director = "Jean-Pierre Jeunet",
						YearReleased = "2001",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Anchorman: The Legend of Ron Burgundy",
						Director = "Adam McKay",
						YearReleased = "2004",
						Rating = "PG-13",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Back to the Future",
						Director = "Robert Zemeckis",
						YearReleased = "1985",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Back to the Future Part II",
						Director = "Robert Zemeckis",
						YearReleased = "1989",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Back to the Future Part III",
						Director = "Robert Zemeckis",
						YearReleased = "1990",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Barefoot in the Park",
						Director = "Gene Saks",
						YearReleased = "1967",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Beetlejuice",
						Director = "Tim Burton",
						YearReleased = "1988",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Best In Show",
						Director = "Christopher Guest",
						YearReleased = "2000",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Better Off Dead",
						Director = "Savage Steve Holland",
						YearReleased = "1985",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Bill & Ted's Bogus Journey",
						Director = "Peter Hewitt",
						YearReleased = "1991",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Big",
						Director = "Penny Marshall",
						YearReleased = "1988",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Bill & Ted's Excellent Adventure",
						Director = "Stephen Herek",
						YearReleased = "1989",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Brian Regan: I Walked on the Moon",
						Director = "John Brenkus",
						YearReleased = "2004",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Bridesmaids",
						Director = "Paul Feig",
						YearReleased = "2011",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Bruce Almighty",
						Director = "Tom Shadyac",
						YearReleased = "2003",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Buster Keaton Collection",
						Director = "Buster Keaton",
						YearReleased = "1920",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Clue",
						Director = "Jonathan Lynn",
						YearReleased = "1985",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb",
						Director = "Stanley Kubrick",
						YearReleased = "1964",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Dream Team, The",
						Director = "Howard Zieff",
						YearReleased = "1989",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Dumb & Dumber",
						Director = "The Farrelly Brothers",
						YearReleased = "1994",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Ferris Bueller�s Day Off",
						Director = "John Hughes",
						YearReleased = "1986",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Fletch",
						Director = "Michael Ritchie",
						YearReleased = "1985",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Fletch Lives",
						Director = "Michael Ritchie",
						YearReleased = "1989",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "General, The",
						Director = "Buster Keaton",
						YearReleased = "1927",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Ghostbusters",
						Director = "Ivan Reitman",
						YearReleased = "1984",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Gremlins",
						Director = "Joe Dante",
						YearReleased = "1984",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Gremlins 2: The New Batch",
						Director = "Joe Dante",
						YearReleased = "1990",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Groundhog Day",
						Director = "Harold Ramis",
						YearReleased = "1993",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Hitch",
						Director = "Andy Tennant",
						YearReleased = "2005",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Hot Fuzz",
						Director = "Edgar Wright",
						YearReleased = "2007",
						Rating = "R",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Hot Shots!",
						Director = "Jim Abrahams",
						YearReleased = "1991",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Hudsucker Proxy, The",
						Director = "Joel Coen, Ethan Coen",
						YearReleased = "1994",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "I Love You, Man",
						Director = "John Hamburg",
						YearReleased = "2009",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Innerspace",
						Director = "Joe Dante",
						YearReleased = "1987",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Josie and the Pussycats",
						Director = "Harry Elfont,�Deborah Kaplan",
						YearReleased = "2001",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Kid, The",
						Director = "Charlie Chaplin",
						YearReleased = "1921",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "King of Kong: A Fistful of Quarters, The",
						Director = "Seth Gordon",
						YearReleased = "2007",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Kung Fu Hustle",
						Director = "Stephen Chow",
						YearReleased = "2005",
						Rating = "R",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Kung Pow! Enter the Fist",
						Director = "Steve Oedekerk",
						YearReleased = "2001",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Love Actually",
						Director = "Richard Curtis",
						YearReleased = "2003",
						Rating = "R",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Mask, The",
						Director = "Chuck Russell",
						YearReleased = "1994",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Matador, The",
						Director = "Richard Shepard",
						YearReleased = "2005",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Maverick",
						Director = "Richard Donner",
						YearReleased = "1994",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Mighty Wind, A",
						Director = "Christopher Guest",
						YearReleased = "2003",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Monty Python and the Holy Grail",
						Director = "Terry Gilliam,�Terry Jones",
						YearReleased = "1975",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Mrs. Doubtfire",
						Director = "Chris Columbus",
						YearReleased = "1993",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "My Big Fat Greek Wedding",
						Director = "Joel Zwick",
						YearReleased = "2002",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Mystery Men",
						Director = "Kinka Usher",
						YearReleased = "1999",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Mystery Science Theater 3000: The Movie",
						Director = "Jim Mallon",
						YearReleased = "1996",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Naked Gun 2�: The Smell of Fear, The",
						Director = "David Zucker",
						YearReleased = "1991",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Naked Gun: From the Files of Police Squad!, The",
						Director = "David Zucker",
						YearReleased = "1988",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Napoleon Dynamite",
						Director = "Jared Hess",
						YearReleased = "2004",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "National Lampoon�s Loaded Weapon 1",
						Director = "Gene Quintano",
						YearReleased = "1993",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Opportunity Knocks",
						Director = "Donald Petrie",
						YearReleased = "1990",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Oscar",
						Director = "John Landis",
						YearReleased = "1991",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Planes, Trains and Automobiles",
						Director = "John Hughes",
						YearReleased = "1987",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Pyromaniac�s Love Story, A",
						Director = "Joshua Brand",
						YearReleased = "1995",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Raising Arizona",
						Director = "Joel Coen, Ethan Coen",
						YearReleased = "1987",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Royal Tenenbaums, The",
						Director = "Wes Anderson",
						YearReleased = "2001",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Say Anything",
						Director = "Cameron Crowe",
						YearReleased = "1989",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "School of Rock",
						Director = "Richard Linklater",
						YearReleased = "2003",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Serendipity",
						Director = "Peter Chelsom",
						YearReleased = "2001",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "So I Married An Axe Murderer",
						Director = "Thomas Schlamme",
						YearReleased = "1993",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Spies Like Us",
						Director = "John Landis",
						YearReleased = "1985",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Steamboat Bill, Jr.",
						Director = "Buster Keaton",
						YearReleased = "1928",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Supersize Me",
						Director = "Morgan Spurlock",
						YearReleased = "2004",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Sweet Home Alabama",
						Director = "Andy Tennant",
						YearReleased = "2002",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Team America: World Police",
						Director = "Trey Parker",
						YearReleased = "2004",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Three Amigos",
						Director = "John Landis",
						YearReleased = "1986",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Tillie�s Punctured Romance",
						Director = "Mack Sennett",
						YearReleased = "1914",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Tommy Boy",
						Director = "Peter Segal",
						YearReleased = "1995",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "UHF",
						Director = "Jay Levey",
						YearReleased = "1989",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Waiting For Guffman",
						Director = "Christopher Guest",
						YearReleased = "1996",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Waking Ned Devine",
						Director = "Kirk Jones",
						YearReleased = "1998",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Comedy",
						MovieTitle = "Wedding Planner, The",
						Director = "Adam Shankman",
						YearReleased = "2001",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "127 Hours",
						Director = "Danny Boyle",
						YearReleased = "2010",
						Rating = "R",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "About Time",
						Director = "Richard Curtis",
						YearReleased = "2013",
						Rating = "R",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Big Fish",
						Director = "Tim Burton",
						YearReleased = "2003",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Braveheart",
						Director = "Mel Gibson",
						YearReleased = "1995",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Casablanca",
						Director = "Michael Curtiz",
						YearReleased = "1942",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Count of Monte Cristo, The",
						Director = "Kevin Reynolds",
						YearReleased = "2002",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Departed, The",
						Director = "Martin Scorsese",
						YearReleased = "2006",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Eternal Sunshine of the Spotless Mind",
						Director = "Michel Gondry",
						YearReleased = "2004",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Far and Away",
						Director = "Ron Howard",
						YearReleased = "1992",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Finding Neverland",
						Director = "Marc Forster",
						YearReleased = "2004",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Gone with the Wind",
						Director = "Victor Fleming",
						YearReleased = "1939",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Green Mile, The",
						Director = "Frank Darabont",
						YearReleased = "1999",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "He Loves Me... He Loves Me Not",
						Director = "Laetitia Colombani",
						YearReleased = "2002",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "La La Land",
						Director = "Damien Chazelle",
						YearReleased = "2016",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Ladder 49",
						Director = "Jay Russell",
						YearReleased = "2004",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Lars and the Real Girl",
						Director = "Craig Gillespie",
						YearReleased = "2007",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Leave Her to Heaven",
						Director = "John M. Stahl",
						YearReleased = "1945",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Les Mis�rables",
						Director = "Billie August",
						YearReleased = "1998",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Little Miss Sunshine",
						Director = "Jonathan Dayton,�Valerie Faris",
						YearReleased = "2006",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Memento",
						Director = "Christopher Nolan",
						YearReleased = "2001",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Millions",
						Director = "Danny Boyle",
						YearReleased = "2004",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Moulin Rouge!",
						Director = "Baz Luhrmann",
						YearReleased = "2001",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Phantom of the Opera, The",
						Director = "Joel Schumacher",
						YearReleased = "2005",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Power of One, The",
						Director = "John G. Avildsen",
						YearReleased = "1992",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Pride and Prejudice",
						Director = "Joe Wright",
						YearReleased = "2005",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Shawshank Redemption, The",
						Director = "Frank Darabont",
						YearReleased = "1994",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Silver Linings Playbook",
						Director = "David O. Russell",
						YearReleased = "2012",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Sliding Doors",
						Director = "Peter Howitt",
						YearReleased = "1998",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Slumdog Millionaire",
						Director = "Danny Boyle",
						YearReleased = "2008",
						Rating = "R",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Stranger than Fiction",
						Director = "Marc Forster",
						YearReleased = "2006",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "True Grit",
						Director = "Joel Coen, Ethan Coen",
						YearReleased = "2010",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Truman Show, The",
						Director = "Peter Weir",
						YearReleased = "1998",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Drama",
						MovieTitle = "Unforgiven",
						Director = "Clint Eastwood",
						YearReleased = "1992",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Adventures of Ichabod and Mr. Toad, The",
						Director = "Clyde Geronimi, Jack Kinney, James Algar",
						YearReleased = "1949",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Aladdin",
						Director = "Ron Clements, John Musker",
						YearReleased = "1992",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Annie",
						Director = "John Huston",
						YearReleased = "1982",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Beauty and the Beast",
						Director = "Kirk Wise,�Gary Trousdale",
						YearReleased = "1991",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Best Two Years, The",
						Director = "Scott S. Anderson",
						YearReleased = "2003",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Cars",
						Director = "John Lasseter",
						YearReleased = "2006",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Charlie and the Chocolate Factory",
						Director = "Tim Burton",
						YearReleased = "2005",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Cheaper By The Dozen",
						Director = "Shawn Levy",
						YearReleased = "2003",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Cinderella",
						Director = "Clyde Geronimi,�Wilfred Jackson,�Hamilton Luske",
						YearReleased = "1950",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Cinderella",
						Director = "Kenneth Branagh",
						YearReleased = "2015",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Cinderella Story, A",
						Director = "Mark Rosman",
						YearReleased = "2004",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Cloudy with a Chance of Meatballs",
						Director = "Chris Miller,�Phil Lord",
						YearReleased = "2009",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Despicable Me",
						Director = "Pierre Coffin,�Chris Renaud",
						YearReleased = "2010",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Emperor�s New Groove, The",
						Director = "Mark Dindal",
						YearReleased = "2000",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Enchanted",
						Director = "Kevin Lima",
						YearReleased = "2007",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Ernest Goes to Camp",
						Director = "John R. Cherry III",
						YearReleased = "1987",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Ernest Goes to Jail",
						Director = "John R. Cherry III",
						YearReleased = "1990",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Ernest Scared Stupid",
						Director = "John R. Cherry III",
						YearReleased = "1991",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Goofy Movie, A",
						Director = "Kevin Lima",
						YearReleased = "1995",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Goonies, The",
						Director = "Richard Donner",
						YearReleased = "1985",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Great Muppet Caper, The",
						Director = "Jim Henson",
						YearReleased = "1981",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Greatest Showman, The",
						Director = "Michael Gracey",
						YearReleased = "2017",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "High School Musical",
						Director = "Kenny Ortega",
						YearReleased = "2006",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Home Alone",
						Director = "Chris Columbus",
						YearReleased = "1990",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Honey, I Shrunk the Kids",
						Director = "Joe Johnston",
						YearReleased = "1989",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Hook",
						Director = "Steven Spielberg",
						YearReleased = "1991",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "How to Succeed in Business�Without Really Trying",
						Director = "David Swift",
						YearReleased = "1967",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "In the Good Old Summertime",
						Director = "Buster Keaton,�Robert Z. Leonard",
						YearReleased = "1949",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Incredibles, The",
						Director = "Brad Bird",
						YearReleased = "2004",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "It's a Wonderful Life",
						Director = "Frank Capra",
						YearReleased = "1946",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Labyrinth",
						Director = "Jim Henson",
						YearReleased = "1986",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Leap Frog: Letter Factory",
						Director = "Roy Allen Smith",
						YearReleased = "2009",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Lego Movie, The",
						Director = "Chris Miller,�Phil Lord",
						YearReleased = "2014",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Lion King, The",
						Director = "Rob Minkoff,�Roger Allers",
						YearReleased = "1994",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Little Mermaid, The",
						Director = "Ron Clements, John Musker",
						YearReleased = "1989",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Lizzie McGuire Movie, The",
						Director = "Jim Fall",
						YearReleased = "2003",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Marley & Me",
						Director = "David Frankel",
						YearReleased = "2008",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Matilda",
						Director = "Danny DeVito",
						YearReleased = "1996",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Moana",
						Director = "Ron Clements, John Musker",
						YearReleased = "2016",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Monsters, Inc.",
						Director = "Pete Docter, Lee Unkrich, David Silverman",
						YearReleased = "2001",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Mr. Krueger�s Christmas",
						Director = "Kieth Merrill",
						YearReleased = "1980",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Mr. Popper's Penguins",
						Director = "Mark Waters",
						YearReleased = "2011",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Muppet Movie, The",
						Director = "James Frawley",
						YearReleased = "1979",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Muppets, The",
						Director = "James Bobin",
						YearReleased = "2011",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "My Little Pony: Equestria Girls",
						Director = "Jayson Thiessen",
						YearReleased = "2013",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "NeverEnding Story, The",
						Director = "Wolfgang Petersen",
						YearReleased = "1984",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Newsies",
						Director = "Kenny Ortega",
						YearReleased = "1992",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Nightmare Before Christmas, The",
						Director = "Henry Selick",
						YearReleased = "1993",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "One Magic Christmas",
						Director = "Phillip Borsos",
						YearReleased = "1985",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Open Season",
						Director = "Anthony Stacchi,�Roger Allers,�Jill Culton",
						YearReleased = "2006",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Pink Panther and Friends Classic Cartoon Collection, Vol. 5: The Ant and the Aardvark, The",
						Director = "Robert Sledge",
						YearReleased = "2007",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Pollyanna",
						Director = "David Swift",
						YearReleased = "1960",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Praise to the Man",
						Director = "T.C. Christensen,�Gary Cook",
						YearReleased = "2005",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Princess Bride, The",
						Director = "Rob Reiner",
						YearReleased = "1986",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Ratatouille",
						Director = "Brad Bird, Jan Pinkava",
						YearReleased = "2007",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Sandlot, The",
						Director = "David M. Evans",
						YearReleased = "1993",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Saturday�s Warrior",
						Director = "Bob Williams",
						YearReleased = "1989",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Shop Around the Corner, The",
						Director = "Ernst Lubitsch",
						YearReleased = "1940",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Sleeping Beauty",
						Director = "Clyde Geronimi",
						YearReleased = "1959",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Snow White and the Seven Dwarfs",
						Director = "Larry Morey,�Wilfred Jackson,�Ben Sharpsteen,�Perce Pearce,�David Hand,�William Cottrell",
						YearReleased = "1938",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Sound of Music, The",
						Director = "Robert Wise",
						YearReleased = "1965",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Support Your Local Gunfighter",
						Director = "Burt Kennedy",
						YearReleased = "1971",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Support Your Local Sheriff",
						Director = "Burt Kennedy",
						YearReleased = "1969",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Sword in the Stone, The",
						Director = "Wolfgang Reitherman",
						YearReleased = "1963",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Teenage Mutant Ninja Turtles",
						Director = "Steve Barron",
						YearReleased = "1990",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Teenage Mutant Ninja Turtles II: The Secret of the Ooze",
						Director = "Michael Pressman",
						YearReleased = "1991",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "They Might Be Giants: Here Comes Science",
						Director = "John Linnell, John Flansburgh",
						YearReleased = "2009",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "They Might Be Giants: Here Comes the 123s",
						Director = "John Linnell, John Flansburgh",
						YearReleased = "2008",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "They Might Be Giants: Here Comes the ABCs",
						Director = "John Linnell, John Flansburgh",
						YearReleased = "2005",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Toy Story",
						Director = "John Lasseter",
						YearReleased = "1995",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Toy Story 2",
						Director = "John Lasseter",
						YearReleased = "1999",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Toy Story 3",
						Director = "Lee Unkrich",
						YearReleased = "2010",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "We Bought a Zoo",
						Director = "Cameron Crowe",
						YearReleased = "2011",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "What a Girl Wants",
						Director = "Dennie Gordon",
						YearReleased = "2003",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Willy Wonka and the Chocolate Factory",
						Director = "Mel Stuart",
						YearReleased = "1971",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Wonder",
						Director = "Stephen Chbosky",
						YearReleased = "2017",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Family",
						MovieTitle = "Zootopia",
						Director = "Byron Howard, Rich Moore",
						YearReleased = "2016",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "28 Days Later",
						Director = "Danny Boyle",
						YearReleased = "2002",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "39 Steps",
						Director = "Alfred Hitchcock",
						YearReleased = "1935",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Blackmail",
						Director = "Alfred Hitchcock",
						YearReleased = "1929",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Blair Witch Project, The",
						Director = "Eduardo S�nchez,�Daniel Myrick",
						YearReleased = "1999",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Bride of Frankenstein, The",
						Director = "James Whale",
						YearReleased = "1935",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Buffy the Vampire Slayer",
						Director = "Fran Rubel Kuzui",
						YearReleased = "1992",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Cabin in the Woods",
						Director = "Drew Goddard",
						YearReleased = "2012",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Changeling, The",
						Director = "Peter Medak",
						YearReleased = "1980",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Chronicle",
						Director = "Josh Trank",
						YearReleased = "2012",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Dawn of the Dead",
						Director = "Zack Snyder",
						YearReleased = "2004",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Dementia 13",
						Director = "Francis Ford Coppola",
						YearReleased = "1963",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Devil",
						Director = "John Erick Dowdle",
						YearReleased = "2010",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Dracula",
						Director = "Tod Browning, Karl Freund",
						YearReleased = "1931",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Fido",
						Director = "Andrew Currie",
						YearReleased = "2006",
						Rating = "R",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Frankenstein",
						Director = "James Whale",
						YearReleased = "1931",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Frankenstein Meets the Wolf Man",
						Director = "Roy William Neill",
						YearReleased = "1943",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Grudge, The",
						Director = "Takashi Shimizu",
						YearReleased = "2004",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "House on Haunted Hill",
						Director = "William Castle",
						YearReleased = "1959",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Identity",
						Director = "James Mangold",
						YearReleased = "2003",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Invaders From Mars",
						Director = "Tobe Hooper",
						YearReleased = "1986",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Invisible Man, The",
						Director = "James Whale",
						YearReleased = "1933",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Jaws",
						Director = "Steven Spielberg",
						YearReleased = "1975",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Juno & The Paycock",
						Director = "Alfred Hitchcock",
						YearReleased = "1930",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Lady in White",
						Director = "Frank Laloggia",
						YearReleased = "1988",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Lady Vanishes, The",
						Director = "Alfred Hitchcock",
						YearReleased = "1938",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Lodger",
						Director = "Alfred Hitchcock",
						YearReleased = "1927",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Man Who Knew Too Much, The",
						Director = "Alfred Hitchcock",
						YearReleased = "1934",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Masque of the Red Death, The",
						Director = "Roger Corman",
						YearReleased = "1964",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Monster Squad, The",
						Director = "Fred Dekker",
						YearReleased = "1987",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Mothman Prophecies, The",
						Director = "Mark Pellington",
						YearReleased = "2002",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Mummy, The",
						Director = "Karl Freund",
						YearReleased = "1932",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Night of the Living Dead",
						Director = "George A. Romero",
						YearReleased = "1968",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Nosferatu",
						Director = "F. W. Murnau",
						YearReleased = "1922",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Phantom of the Opera, The",
						Director = "Lon Chaney, Sr.,�Edward Sedgwick,�Rupert Julian,�Ernst Laemmle",
						YearReleased = "1925",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Plan 9 from Outer Space",
						Director = "Ed Wood",
						YearReleased = "1959",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Premature Burial, The",
						Director = "Roger Corman",
						YearReleased = "1962",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Psycho",
						Director = "Alfred Hitchcock",
						YearReleased = "1960",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Rear Window",
						Director = "Alfred Hitchcock",
						YearReleased = "1954",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Return of Dracula, The",
						Director = "Paul Landres",
						YearReleased = "1958",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Rich & Strange",
						Director = "Alfred Hitchcock",
						YearReleased = "1931",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Ring, The",
						Director = "Alfred Hitchcock",
						YearReleased = "1927",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Ring, The",
						Director = "Gore Verbinski",
						YearReleased = "2002",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Sabotage",
						Director = "Alfred Hitchcock",
						YearReleased = "1936",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Saw",
						Director = "James Wan",
						YearReleased = "2004",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Secret Agent",
						Director = "Alfred Hitchcock",
						YearReleased = "1936",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Shaun of the Dead",
						Director = "Edgar Wright",
						YearReleased = "2004",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "She-Wolf of London",
						Director = "Jean Yarbrough",
						YearReleased = "1946",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Signs",
						Director = "M. Night Shyamalan",
						YearReleased = "2002",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Sixth Sense, The",
						Director = "M. Night Shyamalan",
						YearReleased = "1999",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Strange Invaders",
						Director = "Michael Laughlin",
						YearReleased = "1983",
						Rating = "PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Sweeney Todd: The Demon Barber of Fleet Street",
						Director = "Tim Burton",
						YearReleased = "2007",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Thing from Another World, The",
						Director = "Christian Nyby,�Howard Hawks",
						YearReleased = "1951",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Tormented",
						Director = "Bert I. Gordon",
						YearReleased = "1960",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Unbreakable",
						Director = "M. Night Shyamalan",
						YearReleased = "2000",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Vacancy",
						Director = "Nimr�d Antal",
						YearReleased = "2007",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Vampire, The",
						Director = "Paul Landres",
						YearReleased = "1957",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Village, The",
						Director = "M. Night Shyamalan",
						YearReleased = "2004",
						Rating = "PG-13",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "War of the Worlds, The",
						Director = "Byron Haskin",
						YearReleased = "1953",
						Rating = "G",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Werewolf of London",
						Director = "Stuart Armstrong Walker",
						YearReleased = "1935",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Wolf Man, The",
						Director = "George Waggner",
						YearReleased = "1941",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Young & Innocent",
						Director = "Alfred Hitchcock",
						YearReleased = "1937",
						Rating = "UR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Horror/Suspense",
						MovieTitle = "Zombieland",
						Director = "Ruben Fleischer",
						YearReleased = "2009",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "29",
						Director = "Alan Seawright",
						YearReleased = "2003",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "29: Day 2",
						Director = "Alan Seawright",
						YearReleased = "2004",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Barenaked Ladies - Barelaked Nadies",
						Director = "Tim Hamilton",
						YearReleased = "2002",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Bellydance Core Conditioning",
						Director = "Neena & Veena",
						YearReleased = "2005",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Blue Man Group - The Complex Rock Tour Live",
						Director = "Matt Goldman, Phil Stanton, Chris Wink",
						YearReleased = "2003",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Cartoon Lagoon",
						Director = "Euralis Weekes",
						YearReleased = "2012",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Core Secrets: 25 Minute Full Body Workout / Accelerated Core Training",
						Director = "Gunnar Peterson",
						YearReleased = "2003",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Crunch - Pick Your Spot Pilates",
						Director = "Ellen Barrett",
						YearReleased = "2002",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Faux Paw Adventures in the Internet",
						Director = "Kreg Peeler",
						YearReleased = "2008",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Les Miserables the Musical That Swept the World in Concert: The Dream Cast",
						Director = "Gavin Taylor,�Paul Kafno",
						YearReleased = "1995",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Ogden: Junction City of the West",
						Director = "Issac Goeckeritz",
						YearReleased = "2007",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Pet Shop",
						Director = "Trent Halvorsen",
						YearReleased = "2005",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Miscellaneous",
						MovieTitle = "Seven Days Seven Workouts",
						Director = "nan",
						YearReleased = "2005",
						Rating = "NR",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "24 (Season 1)",
						Director = "Joel Surnow, Robert Cochran",
						YearReleased = "2001-2002",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "24 (Season 2)",
						Director = "Joel Surnow, Robert Cochran",
						YearReleased = "2002-2003",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "24 (Season 3)",
						Director = "Joel Surnow, Robert Cochran",
						YearReleased = "2003-2004",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Adventures of Brisco County, Jr.: The Complete Series, The",
						Director = "Carlton Cuse,�Jeffrey Boam",
						YearReleased = "1993-1994",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Arrested Development (Season 1)",
						Director = "Mitchell Hurwitz",
						YearReleased = "2003-2004",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Arrested Development (Season 2)",
						Director = "Mitchell Hurwitz",
						YearReleased = "2004-2005",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Arrested Development (Season 3)",
						Director = "Mitchell Hurwitz",
						YearReleased = "2005-2006",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Avatar: The Last Airbender (Book 1)",
						Director = "Michael Dante DiMartino, Bryan Konietzko",
						YearReleased = "2005",
						Rating = "TV-Y7",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Avatar: The Last Airbender (Book 2)",
						Director = "Michael Dante DiMartino, Bryan Konietzko",
						YearReleased = "2006",
						Rating = "TV-Y7",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Avatar: The Last Airbender (Book 3)",
						Director = "Michael Dante DiMartino, Bryan Konietzko",
						YearReleased = "2007-2008",
						Rating = "TV-Y7",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Community (Season 1)",
						Director = "Dan Harmon",
						YearReleased = "2009 - 2010",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Community (Season 2)",
						Director = "Dan Harmon",
						YearReleased = "2010 - 2011",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Community (Season 3)",
						Director = "Dan Harmon",
						YearReleased = "2011-2012",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Community (Season 4)",
						Director = "Dan Harmon",
						YearReleased = "2013",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Community (Season 5)",
						Director = "Dan Harmon",
						YearReleased = "2014",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Community (Season 6)",
						Director = "Dan Harmon",
						YearReleased = "2015",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Firefly: The Complete Series",
						Director = "Joss Whedon",
						YearReleased = "2002-2003",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Malcolm in the Middle (Season 1)",
						Director = "Linwood Boomer",
						YearReleased = "2000",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000 Collection, Volume 1, The",
						Director = "Joel Hodgson",
						YearReleased = "2002",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000 Collection, Volume 2, The",
						Director = "Joel Hodgson",
						YearReleased = "2003",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000 Collection, Volume 4, The",
						Director = "Joel Hodgson",
						YearReleased = "2003",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000 Collection, Volume 5, The",
						Director = "Joel Hodgson",
						YearReleased = "2004",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000 Collection, Volume 8, The",
						Director = "Joel Hodgson",
						YearReleased = "2005",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000: 20th Anniversary Edition",
						Director = "Joel Hodgson",
						YearReleased = "2008",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000: Eegah!",
						Director = "Joel Hodgson",
						YearReleased = "1993",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000: Escape 2000",
						Director = "Joel Hodgson",
						YearReleased = "1996",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000: Mitchell",
						Director = "Joel Hodgson",
						YearReleased = "1993",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000: Samson vs. Vampire Women",
						Director = "Joel Hodgson",
						YearReleased = "1995",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000: The Essentials",
						Director = "Joel Hodgson",
						YearReleased = "2004",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Mystery Science Theater 3000: Wild World of Batwoman",
						Director = "Joel Hodgson",
						YearReleased = "1993",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Police Squad! The Complete Series",
						Director = "Jim Abrahams,�David Zucker,�Jerry Zucker",
						YearReleased = "1982",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Pushing Daisies (Season 1)",
						Director = "Bryan Fuller",
						YearReleased = "2007",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Pushing Daisies (Season 2)",
						Director = "Bryan Fuller",
						YearReleased = "2008-2009",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Roswell (Season 1)",
						Director = "Jonathon Dukes",
						YearReleased = "1999-2000",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Roswell (Season 2)",
						Director = "Jonathon Dukes",
						YearReleased = "2000-2001",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Roswell (Season 3)",
						Director = "Jonathon Dukes",
						YearReleased = "2001-2002",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Saturday Night Live - 25th Anniversary",
						Director = "Lorne Michaels",
						YearReleased = "2004",
						Rating = "TV-14",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Saved By the Bell (Season 5)",
						Director = "Sam Bobrick",
						YearReleased = "1992-1993",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Saved by the Bell (Seasons 1 & 2)",
						Director = "Sam Bobrick",
						YearReleased = "1989-1990",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Saved by the Bell (Seasons 3 & 4)�",
						Director = "Sam Bobrick",
						YearReleased = "1990-1992",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Wings (Season 1 & 2)",
						Director = "David Angell, Peter Casey, David Lee",
						YearReleased = "1990-1991",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Wings (Season 3)",
						Director = "David Angell, Peter Casey, David Lee",
						YearReleased = "1991-1992",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Wings (Season 4)",
						Director = "David Angell, Peter Casey, David Lee",
						YearReleased = "1992-1993",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Wings (Season 5)",
						Director = "David Angell, Peter Casey, David Lee",
						YearReleased = "1993-1994",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Wings (Season 6)",
						Director = "David Angell, Peter Casey, David Lee",
						YearReleased = "1994-1995",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Wings (Season 7)",
						Director = "David Angell, Peter Casey, David Lee",
						YearReleased = "1995-1996",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "Television",
						MovieTitle = "Wings (Season 8)",
						Director = "David Angell, Peter Casey, David Lee",
						YearReleased = "1996-1997",
						Rating = "TV-PG",
						Edited = false,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "VHS",
						MovieTitle = "Joy Ride",
						Director = "John Dahl",
						YearReleased = "2001",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					},
					new Movie
					{
						Category = "VHS",
						MovieTitle = "Untouchables",
						Director = "Brian De Palma",
						YearReleased = "1987",
						Rating = "R",
						Edited = true,
						LentTo = "",
						Notes = ""
					}


				);

                context.SaveChanges();
            }
        }
    }
}
