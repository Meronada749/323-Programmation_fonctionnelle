// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

//var charValues = new Dictionary<char, double>();

//charValues.Add('a', 1.5);

//double Epsilon(string word)
//{
//    return word.Length;
//}


//Console.WriteLine(Epsilon("meron"));
//Console.WriteLine(charValues['a']);


//string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleux", "jaune" };

//IEnumerable<string> query = from word in words
//                            where word.Length == 4
//                            where !word.Contains("x")
//                            where word.Average(w => w.Length);
//                            select word;

//foreach (string str in query)
//{
//    Console.WriteLine(str);
//}

/* This code produces the following output:

    the
    fox
*/

//string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

//Func<string, bool> noX = w => !w.Contains('x');

//Func<string, bool> fourCharsOrMore = w => w.Length >= 4;

//double avgLength = words.Average(w => w.Length);

//Func<string, bool> sameasAverage = w => w.Length == avgLength;

//Console.WriteLine(avgLength);

//Console.WriteLine(string.Join(", ",words.Where(noX).Where(fourCharsOrMore).Where(longerThanAverage)));

//foreach (string item in words.Where(noX).Where(fourCharsOrMore).Where(longerThanAverage))
//{
//    Console.WriteLine(item);
//}

/*
string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

Func<string, bool> noX = w => !w.Contains('x');

Func<string, bool> fourCharsOrMore = w => w.Length >= 4;

double avgLength = words.Average(w => w.Length);

Func<string, bool> sameasAverage = w => w.Length == avgLength;

Console.WriteLine("Choose an option:");
Console.WriteLine("0: Print all words with 4 characters or more");
Console.WriteLine("1: Print all words that don't contain 'x'");
Console.WriteLine("2: Print average word length and words that have as many characters as the average number of characters in the list");

string choice = Console.ReadLine();



switch (choice)
{
    case "0":
        Console.WriteLine("Choose display order: 1 for A-Z, 2 for Z-A, 3 for Reverse the array");
        string orderChoice = Console.ReadLine();

        if (orderChoice == "1")
            Console.WriteLine(string.Join(", ", words.Where(fourCharsOrMore).OrderBy(w => w)));
        else if (orderChoice == "2")
            Console.WriteLine(string.Join(", ", words.Where(fourCharsOrMore).OrderByDescending(w => w)));
        else if (orderChoice == "3")
            Console.WriteLine(string.Join(", ", words.Where(fourCharsOrMore).Reverse()));

        break;

    case "1":
        Console.WriteLine("Choose display order: 1 for A-Z, 2 for Z-A, 3 for Reverse the array");
        orderChoice = Console.ReadLine();

        if (orderChoice == "1")
            Console.WriteLine(string.Join(", ", words.Where(noX).OrderBy(w => w)));
        else if (orderChoice == "2")
            Console.WriteLine(string.Join(", ", words.Where(noX).OrderByDescending(w => w)));
        else if (orderChoice == "3")
            Console.WriteLine(string.Join(", ", words.Where(noX).Reverse()));

        break;

    case "2":

        Console.WriteLine("Choose display order: 1 for A-Z, 2 for Z-A, 3 for Reverse the array");
        orderChoice = Console.ReadLine();

        if (orderChoice == "1")
            Console.WriteLine(string.Join(", ", words.Where(sameasAverage).OrderBy(w => w)));
        else if (orderChoice == "2")
            Console.WriteLine(string.Join(", ", words.Where(sameasAverage).OrderByDescending(w => w)));
        else if (orderChoice == "3") 
            Console.WriteLine(string.Join(", ", words.Where(sameasAverage).Reverse()));
        
        break;

    default:
        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
        break;
}*/


static void Greet()
{
    Console.WriteLine("I am Action.");
}
Greet();
static void Greet1(int a, bool b, string s)
{
    Console.WriteLine($"{a} + {b} + {s}");
}
Greet1(1, true, "Meron");

// Action without parameters
Action greet = () => Console.WriteLine("Hello from Action!");
greet(); // ✅ No arguments needed

// Action with 3 parameters
Action<int, bool, string> greet1 = (a, b, s) => Console.WriteLine($"{a} + {b} + {s}");
greet1(1, true, "Essayas");

static int f1()
{
    return 123;
}

Console.WriteLine(f1());
static int f2(int a)
{
    return a * a;
}

Console.WriteLine(f2(10));

static int f3(int i, bool b, string s)
{
    return i * 555;
}

Console.WriteLine(f3(3, true, "Tewelde"));

// Func with no parameters, returns int
Func<int> f4 = () => 123;
Console.WriteLine(f4()); // 123

// Func with 1 int parameter, returns int
Func<int, int> f5 = a => a * a;
Console.WriteLine(f5(10)); // 100

// Func with 3 parameters (int, bool, string), returns int
Func<int, bool, string, int> f6 = (i, b, s) => i * 555;
Console.WriteLine(f6(3, true, "Tekleab")); // 2,775,000
