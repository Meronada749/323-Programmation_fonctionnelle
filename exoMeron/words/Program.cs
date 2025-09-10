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



static void Meron() {
    Console.WriteLine("I am Action.");
}
static void Meron1(int a, bool b, string s)
{
    Console.WriteLine($"{a} + {b} + {s} ");
}

Action ilena = Meron;
ilena();

Action<int, bool, string> ilena1 = Meron1;
ilena1(5, true, "meron");

Action<int, bool, string> greet = (a, b, s) => Console.WriteLine($"{a} + {b} + {s} ");
greet(5, false, "Meron");

Action greet1 = () => Console.WriteLine("Hello");
greet1();

static int Meron2()
{
    return 1;
}
static int Meron3(int a, bool b, string s)
{
    return 10;
}
Meron3(5, true, "meron");

Func<int> ilena2 = Meron2;
Console.WriteLine(ilena2());

Func<int, bool, string, int> ilena3 = (i, b, s) => i*895;
Console.WriteLine(ilena3(5987,false,"meron"));
/*
static int Meron4(int a)
{
    return a * a;
}



Console.WriteLine(Meron4(10));*/

Func<int> Meron12 = () => 1991;
Console.WriteLine(Meron12());

Func<int, int> square = a => a * a;

Func<int, int> func = (a) => 10;
Console.WriteLine(func(10));

/*Func<int, int> square = x => x * x;
Console.WriteLine(square(5));

Func<int, int, int> add = (x, y) => x + y;
Console.WriteLine(add(5, 10));

Func<int, int, int, int> addThree = (x, y, z) => x + y + z;
Console.WriteLine(addThree(5, 10, 15));*/
