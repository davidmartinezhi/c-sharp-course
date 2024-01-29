using Microsoft.VisualBasic;
/*
 * cheatsheet
 * https://cheatography.com/laurence/cheat-sheets/c/
*/

// for code snippets press tab twice

namespace OldStyleApp;
class Program
{

    //here i declare constants
    //constants as fields
    //constants are inmutable
    const double PI = 3.1415926;
    const int weeks = 12;
    const int months = 12;
    const string birthday = "21 January 2000";



    // static es que podemos llamar el metodo sin instanciar la clase
    // void es porque no regresa ningún valor
    static void Main(string[] args)
    {
        //Console.WriteLine($"My birthday is going to always be {birthday}");
        //ParseStringToNumber();
        //StringManipulation();

        //UsingInput();
        //TryCatchAndFinally();
        //Operators();
        //TryParse();
        //SwitchCondition();


        //OBJECT audi of DATATYPE car and we save a new car
        //keyword key allocates memory in the heap for the new object
        //audi has a reference to the location where our car is stored
        Car audi = new Car("Audi A4", 250);
        audi.Details();

        Car bmw = new Car("BMW M5", 350, "blue");
        bmw.Details();

        audi.setName("");
        audi.Details();

        Console.WriteLine(audi.getName());


    }

    //access modifier (static) return type method name (parameter 1, parameter 2)
    //static is it refers to the class itself, not the object
    public static void WriteSomething()
    {
        Console.WriteLine("Called from method");
        Console.Read();
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

        //sringValue.substring(starting index, length) (igual que en c++)
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

        //special characters in a string
        //backslash is a scape character, double backslash to show a backslash
        // backslash and 
        string s1 = "this string has / and colon : ";
        Console.WriteLine(s1); 





        Console.Read();
    }

    public static void UsingInput()
    {
        /*
        string input = Console.ReadLine();
        Console.WriteLine(input);
        Console.Read();
        */

        //get inputs
        Console.Write("Type a number: ");
        string num1 = Console.ReadLine();

        Console.Write("Type another number: ");
        string num2 = Console.ReadLine();

        //transform strings to numbers
        int num1Int = Int32.Parse(num1);
        int num2Int = Int32.Parse(num2);

        //make sum
        int sum = num1Int + num2Int;

        //print sum
        Console.WriteLine(sum);


        Console.Read();
    }

    public static void TryCatchAndFinally()
    {
        //use and obtain resources in try block
        //deal with exceptional circunstances in catch block
        //release the resources in the finally block

        //prompting into an error
        Console.WriteLine("Please enter a number!");
        string userInput = Console.ReadLine();

        try
        {
            //we try this code
            int userInputAsInt = int.Parse(userInput); //we'll input string that wont be able to be parsed

        }
        catch (FormatException) //can use generic exception or specific ones
        {
            Console.WriteLine("Format Exception, please enter int.");
            //throw; //this would throw the error
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow exception.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Argument Null exception, the value was empty (null)");
        }
        catch (Exception) //generic exception
        {
            Console.WriteLine("General exception");
        }
        finally //this code is always executed whenever try and catch are done. Its cool for example to close connections
        {
            
            Console.WriteLine("This is called always");
        }


        Console.ReadKey();

    }

    public static void Operators()
    {
        int num1 = 5;
        int num2 = 3;
        int num3;

        //unary operator
        num3 = -num1; //multiplies num1 * -1
        Console.WriteLine($"Num3 is: {num3}");

        bool isSunny = true;
        Console.WriteLine($"Is it sunny? it is {!isSunny}");

        //increment operators, same for decrement
        int num = 0;
        num++;

        Console.WriteLine($"Num is {num}");
        Console.WriteLine($"Num is {++num}"); //pre increment
        Console.WriteLine($"Num is {num++}"); //post increment
        Console.WriteLine($"Num is {num}");

        //relational and type operators
        // val1 < val2
        // val1 == val2
        // val1 != val2
        // val1 && val2
        // val1 || val2


        Console.ReadKey();
    }

    public static void TryParse()
    {
        String numberAsString = "1";
        int parsedValue;

        //we can use this with other numeric data types
        bool success = int.TryParse(numberAsString, out parsedValue); //will return true if succesfull, else false

        if (success) Console.WriteLine("Parse was successfull");
        else Console.WriteLine("Parse failed");


        Console.WriteLine("What is the temperature?");
        string temperature = Console.ReadLine();
        int numTemp;
        int number;
        bool userEnteredANumber = int.TryParse(temperature, out number);


        if (userEnteredANumber) //check if user entered correct value
        {
            numTemp = number;
        }
        else
        {
            numTemp = 0;
            Console.WriteLine("Value entered was no number, 0 set as temperature");
        }

        Console.ReadKey();

    }

    public static void SwitchCondition()
    {
        int age = 25;

        switch (age)
        {
            case 15:
                Console.WriteLine("To young to enter the club.");
                break;
            case 25:
                Console.WriteLine("Okay to enter the club.");
                break;
            default:
                Console.WriteLine("How old are you?");
                break;
        }

        Console.ReadKey();
    }

    public static void TernaryOperator()
    {
        //condition ? first expression : second expression;
        //condition has to be true or false
        //can chain line a ? b : c ? d : e -> a ? b : (c ? d : e)
        Console.WriteLine("Sames as in javascript/typescript, method contains notes");
    }

}

