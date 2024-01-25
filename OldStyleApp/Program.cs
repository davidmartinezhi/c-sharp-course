namespace OldStyleApp;
class Program
{
    // static es que podemos llamar el metodo sin instanciar la clase
    // void es porque no regresa ningún valor
    static void Main(string[] args) 
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
}

