// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Runtime.InteropServices;

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

        //? LIST<T> METHODS 
        // The List<T> is a versatile and dynamic collection that can growor shrink in size. It offers a rich set of methods for manipulation.

        //* Add
        Add("T item"); // Adds an object to the end of the List<T>.
        List<string> fruits = new List<string>();
        fruits.Add("apple");

        //* AddRange
        AddRange("TEnumerable<T> collection"); // Adds the elements of a specified collection to the end of the List<T>.
        List<string> fruits = new List<string>(); string[] moreFruits =
        { "banana", "orange" }; fruits.AddRange(moreFruits);

        //* Remove
        Remove("T item"); // Removes the first occurance of a specified object from the list<T>
        List<string> fruits = new List<string> { "apple", "banana" };
        fruits.Remove("apple");

        //* RemoveAt
        RemoveAt("int index"); // Removes the element at the specified index of the List<T>
        List<string> fruits = new List<string> { "apple", "banana" };
        fruits.RemoveAt(0);

        //* Insert
        Insert("int index, T item"); // Inserts an element into the list<T> at the specified index.
        List<string> fruits = new List<string> { "apple", "orange" };
        fruits.Insert(1, "banana"); // {"apple", "orange", "bananna"}

        //* Contains
        Contains("T items"); // Determines whether an element is in the List<T>.
        List<string> fruits = new List<string> { "apple", "banana" };
        bool hasApple = fruits.Contains("apple"); // True

        //* Clear
        Clear(); // Removes all elements from the List<T>.
        List<string> fruits = new List<string> { "Apple", "banana" };
        fruits.Clear(); // {} 

        //* Sort
        Sort(); // Sorts the lements in the entire List<T> using the default comparer.
        List<int> numbers = new List<int> { 5, 2, 8, 1 };
        numbers.Sort(); // {1, 2, 5, 8}

        //* Reverse
        Reverse(); // Reverses the order of the elemnts in the list<T>.
        List<int> numbers = new List<int> { 1, 2, 3, 4 };
        numbers.Reverse(); // {4, 3, 2, 1};


        //? DICTIONARY <TKey, TValue> METHODS
        // The Dictionary<TKey, TValue> is a collection of key-value pairs. Each key  must be unique.

        //* Add
        Add("TKey key, TValue value"); // Adds the specified key and value to the dictionary.
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages.Add("Alive", 30);

        //* Remove
        Remove("TKey, TValue"); // Removes the value with the specified value from the dictionary.
        Dictionary<string, int> ages = new Dictionary<string, int>
        {{ "alice", 30 }}; ages.Remove("Alice");

        //* ContainsKey
        ContainsKey("Tkey key"); // Determines whether the dictionary contains the specified key.
        Dictionary<string, int> ages = new Dictionary<string, int>
        {{"Alice", 30}}; bool hasAlice = ages.ContainsKey("Alice"); // False

        //* ContainsValue
        ContainsValue("TValue, value"); // Determines whether the dictionary contains the specified value.
        Dictionary<string, int> ages = new Dictionary<string, int>
        {{"Alice", 30}}; bool has30 = ages.ContainsValue(30);

        //* TryGetValue
        TryGetValue("TKey, out TValue value"); // Gets the value associated with the key. A more efficent way to retrieve values if the key may not exist.
        Dictionary<string, int> ages = new Dictionary<string, int>
        {{"Alice", 30}}; int age; if (ages.TryGetValue("Alice", out age)) {/* age is 30 */}

        //* Clear
        Clear(); // Removes all keys and values from the dictionary.
        Dictionary<string, int> ages = new Dictionary<string, int>
        {{"Alice", 30}}; ages.Clear();


        //? FILE AN DIRECTORY METHODS

        //* File -> Exists(string path) -> Determines whether the specified file exists.
        bool fileExists = File.Exists("myFails.txt");

        //* File -> ReadAllText(string path) -> Opens a text file, reads all the text in the file, and then closes the file.
        string content = File.ReadAllText("myFile.txt");

        //* File -> WriteAllText(string path, string contents) -> Creates a new file, writes the specified string to the file, and then closes the file.
        //* If the file already exists, it is overwritten.
        File.WriteAllText("myFile.txt", "Hello, C#");

        //* File -> AppendAllText(string path, string contents) -> Appends the specified strign to the file, creating the file if it does not already exist.
        FillErrorEventArgs.AppendAllText("myFile.txt", "This is new content");

        //* File -> Copy(string courseFileName, string desFileName) -> Copies an existing file to a new file.
        File.Copy("myFile.txt", "destination.txt");

        //* File -> Delete(string path) -> Deletes the specified file.
        File.Delete("myFile.txt");

        //* Directory -> Exists(string path) -> Determines whether the given path refers to an existing directory on disk.
        bool dirExists = Directory.Exists("myFolder");

        //* Directiory -> CreateDirectory(string path) -> Creates all directories and subdirectories in the specified path.
        Directory.CreateDirectory("newFolder");

        //* Directory -> Delete(string path, bool recursive) -> Deletes a directory. If recursive is true, it deletes all subdirectoriesa and files.
        Directory.Delete("myFolder", true);

        //* Directory -> GetFiles(string path) -> Returns the names of files (including their paths) in the specified directory.
        string[] files = Directory.GetFiles("myFolder");

        //* Directory -> GetDirectories(strign path) -> Returns the names of subdirectories (Including teir paths) in the specified directory.
        string[] dirs = Directory.GetDirectories("myFolder");

        
    }
}