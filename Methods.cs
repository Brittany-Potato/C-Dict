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

        
    }
}