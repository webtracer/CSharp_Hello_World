using System;

namespace HelloWorld
{
    class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello dumbass!");
            Console.Read();  //keeps the CMD window open for input
            //Console.ReadKey() is the Mac version

            // Working with the console (includes first two lines of code above
            Console.Write("Text without a CR");
            Console.WriteLine("THis has a CR");
            Console.Read(); //returns ASCII value
            Console.ReadLine(); //capture user input
            Console.ReadKey(); //returns after single key press

            Console.WriteLine("Hello Welcome");
            Console.Write("Hello");
            Console.Write("Welcome");
            Console.ReadKey();

            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a string and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII valie is {0}", asciiValue);
            Console.ReadKey();

            // Implicit and Explicit conversion
            // implicit
            int num = 123456;
            long bigNum = num;
            float myFloat = 13.37f;
            double mySecondDouble = myFloat;

            // explicit
            double myDouble = 13.37;
            int myInt;

            myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.Read();

            // Type Conversion
            string myString = myDouble.ToString();
            string myNextString = myFloat.ToString();

            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);
            Console.ReadKey();

            //parsing a string into an integer
            string myParseString = "15";
            string mySecondParse = "13";
            int num1 = Int32.Parse(myParseString);
            int num2 = Int32.Parse(mySecondParse);
            int resultInt = num1 + num2;
            string result = myParseString + mySecondParse;

            Console.WriteLine($"This is the unparsed result {result}");
            Console.WriteLine($"This is the parsed result {resultInt}");
            Console.ReadKey();

            //String Manipulation
            int age = 33;
            string name = "Alphonso";
            string residence = "Graham";

            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");
            Console.Read();

            //String Formatting
            //string formatting uses the index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}. I am {1} years old, and I live in {2}", name, age, residence);
            Console.Read();

            //String Interpolation
            //string Interpolation uses $ at the start will allow us to write our variables like {variable}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}. I am {age} years old");
            Console.Read();

            //Verbatim strings
            //verbatim strings start with @ and tells the compiler to take the string literally
            //and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"THis is just some random text to show verbatim strings

I can put this down a line


or maybe more, and it should display
                        even with the indent tabs");
            Console.Read();
            Console.Write("Verbatim Strings are useful for displaying things like this: ");
            Console.Write(@"C:\Users\randybi\iCloudDrive\Documents");
            Console.Read();

            //String Methods
            string fName = "Randy";
            string lName = "Bitts";
            string fullName = string.Concat(" ", fName, lName," ");
            Console.WriteLine(fullName);
            Console.WriteLine(fName.Substring(2));
            Console.WriteLine(fName.ToUpper());
            Console.WriteLine(fName.ToLower());
            Console.WriteLine(fullName.Trim());

        }
    }
}
