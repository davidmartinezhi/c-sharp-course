using Microsoft.VisualBasic;

namespace OldStyleApp;
class Program
{
    // static es que podemos llamar el metodo sin instanciar la clase
    // void es porque no regresa ningún valor
    static void Main(string[] args)
    {
        //ParseStringToNumber();
        StringManipulation();

    }

    static void Variables()
    {
        int num1; //this will be 0

        num1 = 13; //reassigned

        Console.WriteLine(num1);


        //nullable versions
        //int? number;

        //take input
        string input = Console.ReadLine();
        Console.WriteLine("You entered: " + input);

        int inputASCII = Console.Read();
        Console.WriteLine("You entered: " + inputASCII);



        Console.ReadKey();
    }

    static void Conversions()
    {

        //implicit conversion
        int num = 1223;
        long bigNumber = num;
        Console.WriteLine(bigNumber);

        float myFloat = 13.37f;
        double myNewDouble = myFloat;
        Console.WriteLine(myNewDouble);

        double myDouble = 13.37;
        int myInt;

        //explicit conversion
        //cast double to int
        myInt = (int)myDouble; //it does not round up, just leaves everything after dot


        //type conversion
        string myString = myDouble.ToString(); //converts to string
        string myNumString = num.ToString();
        string myFloatString = myFloat.ToString();


        bool sunIsShining = false;
        string boolToString = sunIsShining.ToString();

        Console.WriteLine(myString);
        Console.WriteLine(myNumString);
        Console.WriteLine(myFloatString);
        Console.WriteLine(boolToString);


        Console.Read();
    }

    static void ParseStringToNumber()
    {
        string a = "10";
        string b = "11";
        string c = a + b;
        Console.WriteLine(c);

        int num1 = Int32.Parse(a);
        int num2 = Int32.Parse(b);
        int num3 = int.Parse(a);
        int result = num1 + num2;
        Console.WriteLine(result);

        string f = "1.2";
        float x = float.Parse(f);
        Console.WriteLine(x);


        //if string is not a number value, we'll get an exception
        //try parse tells us if it worked or if it didn't work




        Console.Read();


    }

    static void StringManipulation()
    {
        int age = 24;
        string name = "David";

        Console.WriteLine("Concatenation");
        Console.WriteLine("Hello I'm " + name + " I'm " + age);

        Console.WriteLine("Formatting");
        Console.WriteLine("Hello I'm {0}, I'm {1} years old.", name, age);

        Console.WriteLine("Interpolation");
        Console.WriteLine($"Hello I'm {name}, I'm {age} years old.");

        Console.WriteLine("Verbatim");
        Console.WriteLine(@"Hello I'm {name},

            I'm {age} years old."); //funciona bien para paths


        //SubSubstring(int32) is used get get substring from string starting from specified index
        //ToLower() used to convert string to lower case
        //ToUpper()
        //Trim() quite whitespace al inicio y al final
        //InedxOf(string) used to get the first ocurrance of the string or character inside the string
        //IsNullOrWhitespace, regresa true si string es nulo o no tiene nada
        //string.Concat(val1,val2,val3)
        //String.Format is used to insert the object or variable value inside any string
        // we can replace value in specified format
        //String.Format("any string {index}", object);





        Console.Read();
    }
}

