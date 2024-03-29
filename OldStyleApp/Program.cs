﻿using Microsoft.VisualBasic;
using OldStyleApp.AbstractClasses;
/*
* cheatsheet
* https://cheatography.com/laurence/cheat-sheets/c/
*/

using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
        //Car audi = new Car("Audi A4", 250);
        //audi.Name = "audi a3";
        //audi.Details();
        //audi.Name = "   ";
        //audi.Details();
        //Console.WriteLine(audi.Name);

        //audi.MaxSpeed = 10;
        //Console.WriteLine(audi.MaxSpeed);

        //Members member1 = new Members();
        //member1.Introducing(false);
        //member1.Introducing(true);

        //ForLoops();
        //ParamsMethod("this", " is", " a", " string");

        //int price = 50;
        //float pi = 3.14f;
        //char at = '@';
        //string book = "the hobbit";
        //ParamsMethod2(price, pi, at, book);
        //ParamsMethod2("hello", 5.3, "$");
        //ParamsExample(6,4,8,10,1,5);

        //CollectionsExamples();
        //InheritanceExample();
        //OverrideExample();
        //OOPExercise();

        //InterfaceDemo();
        //IEnumerableDemo();
        //IEnumerableDemo2();

        //PolymorphismDemo();

        //AbstractClassesDemo();
        DateTimeExample();




        Console.ReadKey();
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

    public static void ForLoops()
    {
        int[] nums = new int[10];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i;
        }

        foreach (int k in nums)
        {
            Console.WriteLine(k);
        }
    }

    //we can pass as many parameters as we want with this keyword
    public static void ParamsMethod(params string[] sentence)
    {
        for (int i = 0; i < sentence.Length; i++)
        {
            Console.Write(sentence[i]);
        }
    }

    /*
     why params? for input where we can have multiple values, to create flexible methods
     it can only be used with the last parameter of a function, it can also impact performance
     */
    public static void ParamsMethod2(params object[] stuff)
    {
        //every object class has inherited the method ToString()
        foreach (Object obj in stuff)
        {
            //print object followed by a space
            Console.Write(obj + " ");
        }
    }

    public static void ParamsExample(params int[] numbers)
    {
        int minVal = int.MaxValue;

        //every object class has inherited the method ToString()
        foreach (int num in numbers)
        {
            minVal = Math.Min(num, minVal);
        }

        Console.WriteLine("Min Value: " + minVal);
    }

    //using collections
    public static void CollectionsExamples()
    {

        Console.WriteLine("===========ArrayList===========");
        //work like lists in python
        ArrayList myArrayList = new ArrayList();

        myArrayList.Add(2); //add elements
        myArrayList.Add("hello");

        myArrayList.Remove("hello"); //delete especific value

        myArrayList.RemoveAt(0);//delete value at specific index, we can also removeRange

        myArrayList.Add(2);
        myArrayList.Add("hello");
        myArrayList.Add(1.1);

        Console.WriteLine(myArrayList.Count); //returns size

        double sum = 0;

        //can traverse depending on type
        //object is the highest data type there is, so we can use it
        foreach (object obj in myArrayList)
        {
            if (obj is int)
            {
                Console.WriteLine("integer");
                sum += Convert.ToDouble(obj); //convert integer to double
                //sum += (int)obj;
            }
            else if (obj is string)
            {
                Console.WriteLine(obj);
            }
            else if (obj is double)
            {
                Console.WriteLine("double");
                sum += (double)obj; //cannot simply add an object to double, so we do casting
            }
        }

        Console.WriteLine("sum: " + sum);

        Console.WriteLine("===========List===========");
        var numbers = new List<int>(); // var is implicit type variable and must be assigned when initialized
        var numbers2 = new List<int> { 1, 2, 3, 4 }; // var is implicit type variable and must be assigned when initialized

        //add values
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        //remove values
        numbers.Remove(1);

        //remove values at index
        numbers.RemoveAt(0);

        //emopty the list
        numbers.Clear();

        //loop with for or foreach

        myArrayList.Clear(); //empties the list

        Console.WriteLine("===========Hashtables===========");
        //Its of System.Collections

        Hashtable table = new Hashtable(); //initialize
        Car car1 = new Car("car1", 100);
        Car car2 = new Car("car2", 150);
        Car car3 = new Car("car3", 200);

        table.Add(car1.Name, car1); //add k-v pairs
        table.Add(car2.Name, car2);
        table.Add(car3.Name, car3);

        Car storedCar = (Car)table[car2.Name]; //we cast the object as car, we return individual item by key value

        storedCar.Details();

        //retireve all values from hashtable
        //hashtable is collection of dictionary entries
        foreach (DictionaryEntry entry in table) //entries are of type Dictionary entry
        {
            Car temp = (Car)entry.Value; //we can also get key and other things

            Console.WriteLine(temp.Name);
            temp.Details();
        }

        foreach (Car value in table.Values)
        {
            Console.WriteLine(value.Name);
            value.Details();
        }

        //check if key exists, use containskey method
        Console.WriteLine(table.ContainsKey("car1"));


        Console.WriteLine("===========Dictionary===========");
        //Its of System.Collections.Generic
        //Dictionary is collection of key value pairs, is a struct
        //KeyValuePair <TKey, TValue>

        Dictionary<int, string> ht = new Dictionary<int, string>() { { 1, "one" }, { 2, "two" } };
        //works the same as Hashtable

        //we can use TryGetValue(key, out variableToStore), works as try pase, we get a boolean value

        Dictionary<int, Car> dict = new Dictionary<int, Car>();
        dict.Add(1, car1);
        dict.Add(2, car2);
        dict.Add(3, car3);


        //we can traverse dictionary with for loop and get KeyValuePair data with ElementAt()
        //there is always an number attached to a key
        for (int i = 0; i < dict.Count; i++) {
            KeyValuePair<int, Car> keyValPair = dict.ElementAt(i);
            Car carValue = keyValPair.Value;
            carValue.Details();
        }

        //edit a dictionary
        int key = 1;
        if (dict.ContainsKey(key)) //if it contains key, we update it
        {
            dict[key] = new Car("newCar1", 300);
        }

        dict[key].Details();


        //remove item from dictionary
        int keyToRemove = 2;
        if (dict.Remove(keyToRemove))
        {
            Console.WriteLine("Car was removed!");
        }
        else
        {
            Console.WriteLine("That key does not exists in dict.");
        }


        Console.WriteLine("===========STACK===========");
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine(stack.Peek());
        stack.Pop();
        stack.Push(3);

        while (stack.Count > 0)
        {
            stack.Pop();
        }
        Console.WriteLine("Stack is empty");

        Console.WriteLine("===========QUEUE===========");
        Queue<int> queue = new Queue<int>();

        //add items
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
        }
        Console.WriteLine("Queue is empty");

    }

    //inheritance
    public static void InheritanceExample()
    {
        Radio myRadio = new Radio(false, "Sony");
        //Console.WriteLine(myRadio.Brand);
        myRadio.SwitchOn();
        myRadio.ListenRadio();
        myRadio.SwitchOff();
        myRadio.ListenRadio();

        TV myTV = new TV(false, "Samsung");
        myTV.SwitchOn();
        myTV.WatchTV();
        myTV.SwitchOff();
        myTV.WatchTV();
        Console.WriteLine(myTV.ToString());
    }

    public static void OverrideExample()
    {
        Dog dog = new Dog("Sif", 50);
        Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
        dog.MakeSound();
        dog.Play();
        dog.Eat();
        Console.WriteLine(dog.ToString());


    }

    public static void OOPExercise()
    {
        Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
        Console.WriteLine(post1.ToString());

        ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Denis Panjuta", "https://images.com/shoes", true);
        Console.WriteLine(imagePost1.ToString());


        VideoPost videoPost1 = new VideoPost("Check out my new shoes", "Denis Panjuta", "https://video.com/shoes", 12, true);
        Console.WriteLine(videoPost1.ToString());


        videoPost1.Play();
        Console.WriteLine("Press any key to stop the video");
        Console.ReadKey();
        videoPost1.Stop();



    }

    public interface IShootable
    {
        void Shoot();
    }

    public class Weapon
    {
        public string Name { get; protected set; }

        public Weapon(string name)
        {
            this.Name = name;
        }

        public void Label()
        {
            Console.WriteLine($"This is {Name}!");
        }
    }

    public class Gun : Weapon, IShootable
    {

        public Gun() : base("Gun") { }

        public void Shoot()
        {
            Console.WriteLine("Bang!");
        }
    }

    public static void InterfaceDemo()
    {
        //Ticket t1 = new Ticket(10);
        //Ticket t2 = new Ticket(6);
        //Console.WriteLine(t1.Equals(t2));

        // new instance 
        Gun pist = new Gun();

        // test for methods
        pist.Label();
        pist.Shoot();

        // verifying the interface and the parent class
        if (pist is IShootable && pist is Weapon)
            System.Console.WriteLine("Yes, it is my parents.");


    }

    ///<summary>
    //This method return diff type of lists depending on option
    ///</summary>
    static IEnumerable<int> GetCollection(int option)
    {
        List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

        Queue<int> numbersQueue = new Queue<int>();
        numbersQueue.Enqueue(6);
        numbersQueue.Enqueue(7);
        numbersQueue.Enqueue(8);
        numbersQueue.Enqueue(9);
        numbersQueue.Enqueue(10);

        if (option == 1)
        {
            return numbersList;
        } else if (option == 2)
        {
            return numbersQueue;
        }
        else
        {
            return new int[] { 11, 12, 13, 14, 15 };
        }
    }

    public static void IEnumerableDemo()
    {
        //IEnumerable is the base of collections and we can have different type of collections here
        //because all their child classes follows its properties and methods
        IEnumerable<int> unknownCollection;
        unknownCollection = GetCollection(1);
        foreach (int num in unknownCollection) Console.WriteLine(num);

        unknownCollection = GetCollection(2);
        foreach (int num in unknownCollection) Console.WriteLine(num);

        unknownCollection = GetCollection(5);
        foreach (int num in unknownCollection) Console.WriteLine(num);
    }

    static void CollectionSum(IEnumerable<int> anyCollection) //we can pass any collection that uses the IEnumerable Interface. List, Array, Queue, Stack, etc.
    {
        int sum = 0;

        foreach (int num in anyCollection) sum += num;

        Console.WriteLine($"Sum: {sum}");
    }

    //pass IEnumerable as parameter
    public static void IEnumerableDemo2()
    {
        List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };
        int[] numbersArray = new int[] { 6, 7, 8, 9, 10 };
        CollectionSum(numbersList);
        CollectionSum(numbersArray);

    }

    static void PolymorphismDemo()
    {

        //subclasses can be instantiated based on their parent class
        List<Animal> animalsList = new List<Animal>()
        {
            new Dog("Max", 13),
            new Cat("Roger", 10)
        };

        foreach(Animal an in animalsList)
        {
            //their methods are called based ont their class, not on the parent class
            Console.WriteLine(an.ToString());
        }

        Cat cat2 = new Cat("tony", 10);
        Animal animal2 = cat2; //now i can use the methods of base class, the ones without the new keyword

        //new keyword helps to assign a method to a derived class with same name as one in your parent class,
        // but we dont want it to participate in a virtual invocation

        //we use the sealed keyword to avoid a method being replaced


        //----
        animalsList[0].SetAnimalIDInfo(123, "David");
        animalsList[1].SetAnimalIDInfo(234, "David");

        animalsList[0].GetAnimalIdInfo();
        animalsList[1].GetAnimalIdInfo();


    }


    static void AbstractClassesDemo()
    {
        Console.WriteLine("Hello world!");
        Cube cube = new Cube(3.5);
        cube.GetInfo();

        Sphere sphere = new Sphere(3.5);
        sphere.GetInfo();


        Shape[] shapes = { new Sphere(4), new Cube(3) };
        foreach(Shape shape in shapes)
        {
            shape.GetInfo();
            Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");

            Cube iceCube = shape as Cube; //if it cannot be cube it will be null

            if(iceCube == null)
            {
                Console.WriteLine("THIS SHAPE IS NOT A CUBE");
            }

            //Se puede checar type de este modo
            if(shape is Cube)
            {
                Console.WriteLine("THIS SHAPE IS A CUBE");
            }

            object cube2 = new Cube(4);
            Cube cube3 = (Cube)cube2; //it will cast the object into a cube if object is a cube
        }
    }

    static void DateTimeExample() {
        DateTime dateTime = new DateTime(2018, 5, 31);
        Console.WriteLine(DateTime.Today); //day
        Console.WriteLine(DateTime.Now); //date and time
        Console.WriteLine(DateTime.Today.AddDays(1)); //tomorrow
    }
}

