
List<Movie> frenchMovies = new List<Movie>() {
new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 8.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 8.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 8.4, Year = 2003, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} }
};

//Version 1
List<Movie> NotComedyNorDrama = frenchMovies.Where(x => !x.Genre.Contains("Comédie") && !x.Genre.Contains("Drame")).ToList();

NotComedyNorDrama.ForEach(x => Console.WriteLine(x.Title + " " + string.Join(',', x.StreamingPlatforms) + " " + string.Join(',', x.LanguageOptions)));

Console.WriteLine("");

List<Movie> ratingLessThan7 = frenchMovies.Where(x => x.Rating < 7).ToList();

ratingLessThan7.ForEach(x => Console.WriteLine(x.Title));

Console.WriteLine("");

List<Movie> madeBefore2000 = frenchMovies.Where(x => x.Year < 2000).ToList();

madeBefore2000.ForEach(x => Console.WriteLine(x.Title));

Console.WriteLine("");

List<Movie> noFrenchDubbing = frenchMovies.Where(x => !x.LanguageOptions.Contains("Français")).ToList();

noFrenchDubbing.ForEach(x => Console.WriteLine(x.Title));

Console.WriteLine("");

List<Movie> notInNetflix = frenchMovies.Where(x => !x.StreamingPlatforms.Contains("Netflix")).ToList();

notInNetflix.ForEach(x => Console.WriteLine(x.Title));

// Version 2 - Query Syntax

// 1. Movies that are neither Comedy nor Drama
IEnumerable<Movie> NotComedyNorDrama2 = from m in frenchMovies
                         where !(m.Genre.Contains("Comédie") || m.Genre.Contains("Drame"))
                         select m;

foreach (var movie in NotComedyNorDrama2)
{
    Console.WriteLine($"{movie.Title} {string.Join(',', movie.StreamingPlatforms)} {string.Join(',', movie.LanguageOptions)}");
}

Console.WriteLine("");

// 2. Movies with rating < 7
IEnumerable<string> ratingLessThan72 = from m in frenchMovies
                       where m.Rating < 7
                       select m.Title;

foreach (var title in ratingLessThan72)
{
    Console.WriteLine(title);
}

Console.WriteLine("");

// 3. Movies made before 2000
IEnumerable<string> madeBefore20002 = from m in frenchMovies
                      where m.Year < 2000
                      select m.Title;

foreach (var title in madeBefore20002)
{
    Console.WriteLine(title);
}

Console.WriteLine("");

// 4. Movies without French dubbing
IEnumerable<string> noFrenchDubbing2 = from m in frenchMovies
                       where !m.LanguageOptions.Contains("Français")
                       select m.Title;

foreach (var title in noFrenchDubbing2)
{
    Console.WriteLine(title);
}

Console.WriteLine("");

// 5. Movies not on Netflix
IEnumerable<string> notInNetflix2 = from m in frenchMovies
                    where !m.StreamingPlatforms.Contains("Netflix")
                    select m.Title;

foreach (var title in notInNetflix2)
{
    Console.WriteLine(title);
}

Convert.ToInt32(Console.ReadLine());