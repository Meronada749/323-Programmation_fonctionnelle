
List<Movie> frenchMovies = new List<Movie>() {
new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 6.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 6.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 8.4, Year = 2003, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} }
};

//Version 1
//List<Movie> NotComedyNorDrama = frenchMovies.Where(x => !x.Genre.Contains("Comédie") && !x.Genre.Contains("Drame")).ToList();

//NotComedyNorDrama.ForEach(x => Console.WriteLine(x.Title + " " + string.Join(',', x.StreamingPlatforms) + " " + string.Join(',', x.LanguageOptions)));

//Console.WriteLine(string.Join(" | ", NotComedyNorDrama.Select(x => $"{x.Title} - {string.Join(',', x.StreamingPlatforms)} - {string.Join(',', x.LanguageOptions)}")));

//foreach (Movie x in NotComedyNorDrama)
//{
//    Console.WriteLine($"{x.Title}");
//}

//Console.WriteLine("");

//List<Movie> ratingLessThan7 = frenchMovies.Where(x => x.Rating < 7).ToList();

//ratingLessThan7.ForEach(x => Console.WriteLine(x.Title));

//Console.WriteLine("");

//List<Movie> madeBefore2000 = frenchMovies.Where(x => x.Year < 2000).ToList();

//madeBefore2000.ForEach(x => Console.WriteLine(x.Title));

//Console.WriteLine("");

//List<Movie> noFrenchDubbing = frenchMovies.Where(x => !x.LanguageOptions.Contains("Français")).ToList();

//noFrenchDubbing.ForEach(x => Console.WriteLine(x.Title));

//Console.WriteLine("");

//List<Movie> notInNetflix = frenchMovies.Where(x => !x.StreamingPlatforms.Contains("Netflix")).ToList();

//notInNetflix.ForEach(x => Console.WriteLine(x.Title));

// Version 2 
//List<Movie> filteredMovies = frenchMovies.Where(x =>
//    !x.Genre.Contains("Comédie") &&
//    !x.Genre.Contains("Drame") &&
//    x.Rating < 7 &&
//    x.Year < 2000 &&
//    !x.LanguageOptions.Contains("Français") &&
//    !x.StreamingPlatforms.Contains("Netflix")
//).ToList();

//filteredMovies.ForEach(x => Console.WriteLine(x.Title));

Func<List<Movie>, List<Movie>> filterByGenre = (movies) =>
    movies.Where(x => !x.Genre.Contains("Comédie") && !x.Genre.Contains("Drame")).ToList();

Func<List<Movie>, List<Movie>> filterByRating = (movies) =>
    movies.Where(x => x.Rating < 7).ToList();

Func<List<Movie>, List<Movie>> filterByYear = (movies) =>
    movies.Where(x => x.Year < 2000).ToList();

Func<List<Movie>, List<Movie>> filterByLanguage = (movies) =>
    movies.Where(x => !x.LanguageOptions.Contains("Français")).ToList();

Func<List<Movie>, List<Movie>> filterByStreamingPlatform = (movies) =>
    movies.Where(x => !x.StreamingPlatforms.Contains("Netflix")).ToList();

// Define filters
List<Func<List<Movie>, List<Movie>>> filters = new();

Console.WriteLine("Choose filters to apply (separate with commas):");
Console.WriteLine("1. Genre (Excludes 'Comédie' and 'Drame')");
Console.WriteLine("2. Rating (Less than 7)");
Console.WriteLine("3. Year (Before 2000)");
Console.WriteLine("4. Language (Excludes 'Français')");
Console.WriteLine("5. Streaming Platform (Excludes 'Netflix')");
Console.WriteLine("Enter filter numbers (e.g. '1,3,5'):");

string input = Console.ReadLine();
var filterChoices = input.Split(',').Select(int.Parse).ToList();

if (filterChoices.Contains(1)) filters.Add(filterByGenre);
if (filterChoices.Contains(2)) filters.Add(filterByRating);
if (filterChoices.Contains(3)) filters.Add(filterByYear);
if (filterChoices.Contains(4)) filters.Add(filterByLanguage);
if (filterChoices.Contains(5)) filters.Add(filterByStreamingPlatform);

// Apply all selected filters
var filteredMovies = filters.Aggregate(frenchMovies, (current, filter) => filter(current));

// Display the filtered movies
Console.WriteLine("Filtered Movies:");
filteredMovies.ForEach(x => Console.WriteLine(x.Title));

// Version Query Syntax

// 1. Movies that are neither Comedy nor Drama
//IEnumerable<Movie> NotComedyNorDrama2 = from m in frenchMovies
//                         where !(m.Genre.Contains("Comédie") || m.Genre.Contains("Drame"))
//                         select m;

//foreach (var movie in NotComedyNorDrama2)
//{
//    Console.WriteLine($"{movie.Title} {string.Join(',', movie.StreamingPlatforms)} {string.Join(',', movie.LanguageOptions)}");
//}

//Console.WriteLine("");

//// 2. Movies with rating < 7
//IEnumerable<string> ratingLessThan72 = from m in frenchMovies
//                       where m.Rating < 7
//                       select m.Title;

//foreach (var title in ratingLessThan72)
//{
//    Console.WriteLine(title);
//}

//Console.WriteLine("");

//// 3. Movies made before 2000
//IEnumerable<string> madeBefore20002 = from m in frenchMovies
//                      where m.Year < 2000
//                      select m.Title;

//foreach (var title in madeBefore20002)
//{
//    Console.WriteLine(title);
//}

//Console.WriteLine("");

//// 4. Movies without French dubbing
//IEnumerable<string> noFrenchDubbing2 = from m in frenchMovies
//                       where !m.LanguageOptions.Contains("Français")
//                       select m.Title;

//foreach (var title in noFrenchDubbing2)
//{
//    Console.WriteLine(title);
//}

//Console.WriteLine("");

//// 5. Movies not on Netflix
//IEnumerable<string> notInNetflix2 = from m in frenchMovies
//                    where !m.StreamingPlatforms.Contains("Netflix")
//                    select m.Title;

//foreach (var title in notInNetflix2)
//{
//    Console.WriteLine(title);
//}

//Convert.ToInt32(Console.ReadLine());

