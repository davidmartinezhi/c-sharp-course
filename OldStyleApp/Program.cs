using Microsoft.VisualBasic;

namespace OldStyleApp;
class Program
{
    // static es que podemos llamar el metodo sin instanciar la clase
    // void es porque no regresa ningún valor
    static void Main(string[] args) 
    {
        Conversions();

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
}

