// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~ My C# Methods ~~~");
        Console.WriteLine();

        //? STRING METHODS

        //* ToUpper
        ToUpper(); // Converts all characters in a string to uppercase.
        string text = "hello world"; string upperText =
        text.ToUpper(); // "HELLO WORLD"

        //* ToLower
        ToLower(); // Converts all characters in a string to lowercase.
        string text = "HELLO WORLD"; string lowerText =
        text.ToLower(); // "hello world"

        //* Contains
        Contains("String Value"); // Checks if a substring exists within a string. Returns True or False.
        string text = "hello world"; bool hasWorld =
        text.Contains("world"); // True

        //* StartsWith
        StartsWith("String Value"); // Checks if a string begins with a specified substring.
        string text = "hello world"; bool startsWithHello =
        text.StartsWith("hello"); // True

        //* EndsWith
        EndsWith("String Value"); // Checks if a string ends with a specified substring.
        string text = "hello world"; bool endsWithWorld =
        text.EndsWith("world");

        //* IndexOf
        IndexOff("char Value"); // Returns the zero-based index first occurance of a character within a string.
        string text = "hello world"; int indexOf0 =
        text.IndexOff('o'); // 4

        //* Substring
        Substring("int startIndex, int Length"); // Retrieves a substring from the secified position and with the specified length.
        string text = "hello world"; string world =
        text.Substring(6, 5); // "world"

        //* Replace
        Replace("String oldValue, string newValue"); // Replaces all occurances of a specified string with another string.
        string text = "hello world"; string newText =
        text.Replace("world", "C#"); // "hello C#"

        //* Trim
        Trim(); // Removes all leading and trailing white-space characters from a string.
        string text = "hello world "; string trimmedText =
        text.Trim(); // "hello world

        //* Split
        Split("Char seperator"); // Splits a string into an array of substrings based on a specified seperator character.
        string text = "apple,banana,orange"; string[]
        fruits = text.Split(','); // ["apple", "banana", "orange"]

        //* Join
        Join("String Seperator, IEnumerable<string> Values)"); // Concentrates the elements of a specified aray or the members of a collection, using the specified seperator between each element.
        string[] fruits = { "apple", "banana", "orange" };
        string text = string.Join(", ", fruits); // "apple, banana, orange"

        //? ARRAY METHODS

        //* Sort
        Sort("Array array"); // Sorts the elements in an entire one-dimensional array using the default comparer.
        int[] numbers = { 5, 2, 8, 1 };
        Array.Sort(numbers); // { 1, 2, 5, 8 }

        //* Reverse
        Reverse("Array array"); // Reverses the sequence of the elements in an entire one-dimensional array.
        int[] numbers = { 1, 2, 3, 4 };
        Array.Reverse(numbers); // { 4, 3,2 ,1 }

        //* IndexOf
        indexOf("Array array, object value"); // Searches for the specified object and returns the index of its first occurance in a one-dimensional array.
        string[] fruits = { "apple", "banana", "orange" };
        int bananaIndex = Array.IndexOf(fruits, "banana"); // 1

        //* Find
        Find("t[] array, Predicate<T> match"); // Searches for an element tat matches the conditions defined by the specified predicate, and returns the first
                                               // Occurance within the entire array.
        int[] numbers = { 1, 2, 3, 4, 5 }; int[] firstEven =
        Array.Find(numbers, nameof => nameof % x == 0); // { 2 }

        //* FindAll
        FindAll("T[] array, Predicate<T> match"); // Retrieves all the elements that match the conditions defined by the specified predicate.
        int[] numbers = { 1, 2, 3, 4, 5 }; int[] allEven =
        Array.FindAll(numbers, nameof => nameof % 2 == 0); // { 2, 4 }

        //* Exists 
        Exists("T[] array, predicate<T> match"); // Determines whether the specified array contains elements that match the conditions defined by the specified predicate.
        int[] numbers = { 1, 2, 3, 4, 5 }; bool hadEven =
        Array.Exists(numbers, nameof => nameof % 2 == 0); // True

        //? MATH METHODS 

        //* Abs
        Abs("decimal Value"); // Returns the absoloute value of a specified number.
        int absoloute = Math.Abs(-10); // 10

        //* Max
        Max("Val1, Val2"); // Returns the larger of the two numbers.
        int larger = Math.Max(5, 10); // 10

        //* Min
        Min("Val1, Val2"); // Returns the smaller of the two numbers.
        int smaller = Math.Min(5, 10); // 5

        //* Pow
        Pow("double x, double y"); // Returns a specified number raised to the specified power.
        double result = Math.Pow(2, 3); // 8

        //* Sqrt
        Sqrt("double d"); // Returns the square root of a specified number.
        double result = Math.Sqrt(25); // 5

        //* Round
        Round("Double a"); // Rounds a value to the nearest integer or to the specified number of fractional digits.
        double rounded = Math.Round(3.14); // 3

        //* Ceiling
        Ceiling("Decimal d"); // Returns the largest integral value less than or equal to the specified decimal number.
        double ceiling = Math.Ceiling(3.14); // 4

        //* Floor
        Floor("Decimal d"); // Returns the largest integral value less than or equal to the specified decimal number.
        double floor = Math.Floor(3.14); // 3
    }
}