//IEnumerable<string> names = products.Select(x => x.Provider);

//foreach (string i in names)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(products.Count());
//Console.WriteLine(products[0].Provider.Count());

using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

List<Product> products = new()
{
    new Product() { Location = "1", Provider = "Bornand", Name = "Pommes", Quantity = 20, Unit = "kg", Price = 6.90m },
    new Product() { Location = "2", Provider = "Dumont", Name = "Noix", Quantity = 20, Unit = "sac", Price = 8.60m },
    new Product() { Location = "2", Provider = "Dumont", Name = "Noix", Quantity = 20, Unit = "sac", Price = 8.0m },
    new Product() { Location = "3", Provider = "Vonlanthen", Name = "Pêches", Quantity = 8, Unit = "kg", Price = 8.70m },
    new Product() { Location = "4", Provider = "Barizzi", Name = "Poires", Quantity = 5, Unit = "kg", Price = 6.30m },
    new Product() { Location = "5", Provider = "Blanc", Name = "Pruneaux", Quantity = 5, Unit = "kg", Price = 9.00m },
    new Product() { Location = "6", Provider = "Repond", Name = "Courges", Quantity = 12, Unit = "pièce", Price = 7.40m },
    new Product() { Location = "7", Provider = "Mancini", Name = "Pêches", Quantity = 10, Unit = "kg", Price = 2.90m },
    new Product() { Location = "8", Provider = "Favre", Name = "Poires", Quantity = 5, Unit = "kg", Price = 8.40m },
    new Product() { Location = "9", Provider = "Bovay", Name = "Pommes", Quantity = 13, Unit = "kg", Price = 7.70m },
    new Product() { Location = "10", Provider = "Cherix", Name = "Raisin", Quantity = 8, Unit = "kg", Price = 7.10m },
    new Product() { Location = "11", Provider = "Beaud", Name = "Haricots", Quantity = 19, Unit = "kg", Price = 8.40m },
    new Product() { Location = "12", Provider = "Corbaz", Name = "Pastèques", Quantity = 15, Unit = "pièce", Price = 7.40m },
    new Product() { Location = "13", Provider = "Amaudruz", Name = "Myrtilles", Quantity = 18, Unit = "kg", Price = 5.70m },
    new Product() { Location = "14", Provider = "Bühlmann", Name = "Tomates", Quantity = 12, Unit = "kg", Price = 7.70m },
    new Product() { Location = "15", Provider = "Crizzi", Name = "Noix", Quantity = 10, Unit = "sac", Price = 1.60m },
};

Dictionary<string, string> Dict = new()
{
    { "Pommes","Apples"},
    { "Poires","Pears"},
    { "Pastèques","Watermelons"},
    { "Melons","Melons"},
    { "Noix","Nuts"},
    { "Raisin","Grapes"},
    { "Pruneaux","Plums"},
    { "Myrtilles","Blueberries"},
    { "Groseilles","Berries"},
    { "Tomates","Tomatoes"},
    { "Courges","Pumpkins"},
    { "Pêches","Peaches"},
    { "Haricots","Beans"}
};

//Func<Product, string> transformedNames = (p) => p.Provider.Substring(0, 3) + "..." + p.Provider.Last();
//Func<Product, string> translatedNames = (p) => Dict[p.Name];
//Func<Product, decimal> chiffreAffaires = (p) => p.Quantity * p.Price;

//Console.WriteLine("Seller,Product,CA \n" + string.Join("\n", products.Select(p => $"{transformedNames(p)}, {translatedNames(p)}, {chiffreAffaires(p)}")));

//transformedNames.ForEach(p => Console.WriteLine(p));
//Console.WriteLine(string.Join("\n", transformedNames));

//translatedNames.ForEach(p => Console.WriteLine(p));
//Console.WriteLine(string.Join("\n", translatedNames));

//chiffreAffaires.ForEach(p => Console.WriteLine(p));
//Console.WriteLine(string.Join("\n", chiffreAffaires));

List<string> transformednames = products.Select(p => p.Provider.Substring(0, 3) + "..." + p.Provider.Last()).ToList();
List<string> translatednames = products.Select(p => Dict[p.Name]).ToList();
List<decimal> chiffreaffaires = products.Select(p => p.Quantity * p.Price).ToList();

//IEnumerable<string> print = Enumerable.Range(0, products.Count)
//    .Select(i => string.Join(" | ", transformednames[i], translatednames[i], chiffreaffaires[i]));

//// Add header + join everything
//string result = "Seller,Product,CA" + Environment.NewLine + string.Join(Environment.NewLine, print);

//Console.WriteLine(result);

//string allExport = string.Join("\n", products.Select(p => (transformNames(p), translate(p), chiffreAffaire(p))));
//File.WriteAllText("productExport.csv", $"Seller, Product,CA\n{allExport}");

//--------------------------------------------SELLECT--------------------------------------------------------------------------------------

IEnumerable<string> names = products.Select(x => x.Name);
//Console.WriteLine(string.Join(", ", names)); //print horizontally
//names.ToList().ForEach(Console.WriteLine); //print vertically

IEnumerable<int> addition = products.Select(x => x.Quantity + (int)x.Price);
//Console.WriteLine(string.Join(", ", addition)); //print horizontally
//addition.ToList().ForEach(Console.WriteLine); //print vertically

IEnumerable<(string Provider, int Quantity)> adults = products.Select(x => (x.Provider, x.Quantity)).Where(tuple => tuple.Item2 >= 18);
//Console.WriteLine(adults.First().Item1); //print horizontally
//adults.Take(1).ToList().ForEach(item => Console.WriteLine($"{item.Provider}"));

//--------------------------------------------TUPLES--------------------------------------------------------------------------------------
var f = (1, 2, 3);
//Console.WriteLine(f.Item1);
//Console.WriteLine(f.Item2);
//Console.WriteLine(f.Item3);

(int first, int second, int third) ff = (first: 1, second: 2, third: 3);
//Console.WriteLine(ff.first);
//Console.WriteLine(ff.second);
//Console.WriteLine(ff.third);

//--------------------------------------------ANONYMOUS TYPES--------------------------------------------------------------------------------------

var fff = new { first = 1, second = 2, third = 3 };
//Console.WriteLine(fff.first);
//Console.WriteLine(fff.second);

//var projections = products.Select(p => new
//{
//    p.Provider,
//    p.Name
//});

//foreach (var x in projections)
//{
//    Console.WriteLine($"{x.Provider} - {x.Name}");
//}


//--------------------------------------------GROUP BY--------------------------------------------------------------------------------------
var productsByProvider = products.GroupBy(p => p.Provider);

//foreach (var group in productsByProvider)
//{
//    Console.WriteLine($"Provider: {group.Key}");
//    foreach (var p in group)
//    {
//        Console.WriteLine($"  {p.Name} - {p.Quantity} x {p.Price} CHF");
//    }
//}

//--------------------------------------------TO LIST--------------------------------------------------------------------------------------
//Converts an IEnumerable<string> to a List<string>.
//var productNames = products
//    .Select(p => p.Name)
//    .ToList();

//productNames.ForEach(Console.WriteLine);

//--------------------------------------------TO DICTIONARY--------------------------------------------------------------------------------------
//var productDict = products.DistinctBy(p => p.Name)
//    .ToDictionary(
//        p => p.Provider,  // key
//        p => p.Price  // value
//    );

//Console.WriteLine(productDict["Dumont"]); // prints the price of "Pommes"

//--------------------------------------------TO ARRAY--------------------------------------------------------------------------------------
//var productPrices = products
//    .Select(p => p.Price)
//    .ToArray();

//foreach (var price in productPrices)
//{
//    Console.WriteLine(price);
//}

//Dictionary<string, Product> dico = new()
//{
//    { "Pommes", new Product { Name = "Pommes", Quantity = 20, Price = 6.9m } },
//    { "Poires", new Product { Name = "Poires", Quantity = 16, Price = 3.5m } },
//    { "Pastèques", new Product { Name = "Pastèques", Quantity = 14, Price = 6.0m } },
//    { "Melons", new Product { Name = "Melons", Quantity = 5, Price = 7.0m } }
//};

////Dictionary
//Product toto = dico["Pommes"];
//Console.WriteLine(toto.Price);

////List
//Product tota = products.Where(p => p.Quantity == 5).First();
//Console.WriteLine(tota.Name);

//In IEnumerable u gotta add .ToList() to use .ForEach
IEnumerable<int> numbers = Enumerable.Range(0, 5);
Console.WriteLine(string.Join(", ", numbers));
//numbers.ToList().ForEach(Console.WriteLine);
//foreach (int n in numbers)
//{
//    Console.WriteLine(n);
//}

IEnumerable<int> num = numbers.Select(_ => 1);
//List<int> num = numbers.Select(_ => 1).ToList();
Console.WriteLine(string.Join(", ", num));
//num.ForEach(Console.WriteLine);
//foreach (int n in num)
//{
//    Console.WriteLine(n);
//}

List<object> objects = numbers.Select(_ => new object()).ToList();
Console.WriteLine(string.Join(", ", objects));

List<string> s = numbers.Select(x => new string('a', x)).ToList();
Console.WriteLine(string.Join(", ", s));

List<int> result = string.Join(',', numbers).Select(x => Convert.ToInt32(x) + 1).ToList();
Console.WriteLine(string.Join(',', result));

//IEnumerable<IEnumerable<int>> r = "".Select(_ => Enumerable.Range(0, 5000));
//var ro = "".Select(_ => Enumerable.Range(0, 5000));
//Console.WriteLine(string.Join(',', ro));

List<Person> persons = new() {
    new() {Name="Bob",Age=15 },
    new() {Name="Anna",Age=16 },
    new() {Name="Chan",Age=17 }
};

//List<int> ages = persons.Select(x => new { age = x.age}).ToList();

List<int> age = persons.Select(c => c.Age).ToList();

persons.Select(x => x.Name.Substring(0, Math.Min(x.Name.Length, 2)));//Bo,An,Ch

IEnumerable<string> shortNames = persons.Select(x => x.Name.Substring(0, Math.Min(x.Name.Length, 2)));
Console.WriteLine(string.Join(", ", shortNames));

List<string> shortNamesList = persons.Select(x => x.Name.Substring(0, Math.Min(x.Name.Length, 2))).ToList();
//shortNamesList.ForEach(Console.WriteLine);
Console.WriteLine(string.Join(", ", shortNamesList));

//string.Substring(startIndex, length)
//"Bob".Substring(0, 2) // "Bo"
//Math.Min(a, b) → returns the smaller of a and b

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

