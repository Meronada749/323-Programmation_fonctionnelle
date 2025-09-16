
string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "blex", "jaune"}; //array of strings

//bool noX(string w)
//{
//    return !w.Contains('x');
//}

Func<string, bool> noX = w => !w.Contains('x');

Func<string, bool> fourCharsOrMore = w => w.Length >= 4;

//double avgLength = words.Average(w => w.Length); //average length as double

int avgLength = (int)words.Average(w => w.Length); //casting to int will round down the average length

Func<string, bool> sameasAverage = w => w.Length == avgLength;

//Console.WriteLine("The average length is: " + avgLength); //Print average length of words
//Console.WriteLine("Don't have x: " + string.Join(", ",words.Where(noX))); //Print all that does not have x
//Console.WriteLine("Has 4 or more chars: " + string.Join(", ",words.Where(fourCharsOrMore))); //Print all that has 4 or more characters
//Console.WriteLine("Has the same chars as avg: " + string.Join(", ",words.Where(sameasAverage))); //Print all that has same number of characters as the average

//Console.WriteLine("Don't have x: " +
//    string.Join(", ", words.Where(noX).Select(w => $"'{w}'")));

//Console.WriteLine("Has 4 or more chars: " +
//    string.Join(", ", words.Where(fourCharsOrMore).Select(w => w)));

//Console.WriteLine("Has the same chars as avg: " +
//    string.Join(", ", words.Where(sameasAverage).Select(w => w.ToUpper())));

//Console.WriteLine("All 3 filters: " + string.Join(", ",words.Where(noX).Where(fourCharsOrMore).Where(sameasAverage))); //Print all that does not have x and has 4 or more characters and has same number of characters as the average

//foreach (string item in words.Where(noX).Where(fourCharsOrMore).Where(sameasAverage))
//{
//    Console.WriteLine("All 3 filters: " + item); //Print each item in a new line
//}

//IEnumerable<string> query = from w in words
//                            where !w.Contains("x")
//                            where w.Length >= 4
//                            where w.Length == avgLength
//                            select w;

//Console.WriteLine("All 3 filters: " + string.Join(", ", query));

//--------------------------------------------------------------------------

// Store filters in a list
var filters = new List<Func<string, bool>> { noX, fourCharsOrMore, sameasAverage };

// Display menu
Console.WriteLine("The average length is: " + avgLength); //Print average length of words
Console.WriteLine($"Array of strings : {string.Join(", ", words)}");
Console.WriteLine("1. noX ");
Console.WriteLine("2. fourCharsOrMore ");
Console.WriteLine("3. sameasAverage ");
Console.Write("\nChoice: ");

// Read filter choice
if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > filters.Count)
{
    Console.WriteLine("Choice invalid.");
    return;
}

var selectedFilter = filters[choice - 1];

// Ask for display order
Console.WriteLine("Choose display order: 1 = A-Z, 2 = Z-A, 3 = Reverse the array");
string orderChoice = Console.ReadLine();

// Apply filter first
IEnumerable<string> result = words.Where(selectedFilter);

// Apply ordering
result = orderChoice switch
{
    "1" => result.OrderBy(w => w),
    "2" => result.OrderByDescending(w => w),
    "3" => result.Reverse(),
    _ => result
};

// Print result
Console.WriteLine($"Résultat: {string.Join(", ", result)}");


//---------------------------Action and Func------------------------------------------------
/*
void Greet()
{
    Console.WriteLine("I am Action.");
}
Greet();

Action greet = () => Console.WriteLine("I am Action!");
greet();

Console.WriteLine(" ");

void Greet1(int a, bool b, string s)
{
    Console.WriteLine($"{a} + {b} + {s}");
}
Greet1(1, true, "Meron");

Action<int, bool, string> greet1 = (a, b, s) => Console.WriteLine($"{a} + {b} + {s}");
greet1(1, true, "Meron");

Console.WriteLine(" ");

//--------------------------------------------------------------------------

int f1()
{
    return 123;
}

Console.WriteLine(f1());

Func<int> f4 = () => 123;
Console.WriteLine(f4());

Console.WriteLine(" ");

int f2(int a)
{
    return a * a;
}

Console.WriteLine(f2(10));

Func<int, int> f5 = a => a * a;
Console.WriteLine(f5(10));

Console.WriteLine(" ");

int f3(int i, bool b, string s)
{
    return i * 555;
}
Console.WriteLine(f3(3, true, "Tewelde"));

Func<int, bool, string, int> f6 = (i, b, s) => i * 555;
Console.WriteLine(f6(3, true, "Tewelde"));

Console.WriteLine(" ");

//--------------------------------------------------------------------------

int X2(int x)
{
    return x + x;
}

Func<int, int> x3 = X2;
Console.WriteLine(x3(5));

Console.WriteLine(" ");

//--------------------------------------------------------------------------

int Superior(Func<int, int, int> x)
{
    return x(1, 2);
}

var result = Superior(Sub);

int Sub(int a, int b)
{
    return a - b;
}

Console.WriteLine(result);

Console.WriteLine(" ");

//--------------------------------------------------------------------------

Func<int, Func<int, int>> myFunc = x => y => x + y;
Console.WriteLine(myFunc(5)(3));
*/
//--------------------------------------------------------------------------


//List<Person> people = new() {
//    new Person ( name: "john", age: 25 ),
//    new Person ( name: "mary", age: 30 ),
//    new Person ( name: "jane", age: 20 ),
//    new Person ( name: "bob", age: 35 )
//};

//List<Person> adults = people.Where(p => p.Name == "john").ToList();

//adults.ForEach(n => Console.WriteLine(n.Name + " " + n.Age));
//adults.ForEach(n => Console.WriteLine($"{n.Name} {n.Age}"));

//Console.WriteLine(" ");

//Console.WriteLine(string.Join(", ", adults.Select(n => n.Name + " " + n.Age)));
//Console.WriteLine(string.Join(", ", adults.Select(n => $"{n.Name} {n.Age}")));

//--------------------------------------------------------------------------

//List<Coloc> coloc = new() {
//    new Coloc() { Name = "William", Age = 30 }
//};

//coloc.ForEach(n => Console.WriteLine($"{n.Name} {n.Age}"));
//Console.WriteLine(string.Join(", ", coloc.Select(n => n.Name + " " + n.Age)));

////Class without constructor
//class Coloc
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//--------------------------------------------------------------------------