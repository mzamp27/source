////Namespace declaration
//using System;



//class Program
//{

//    //main method is always the entry point to our application
//    public static void Main()
//    {

#region beep music
//// First, let's determine the keys and the corresponding frequencies:
//// I have found these frequency values somewhere on the web with Google,
//// but I don't remember where exactly.
//int C = 264;
//int D = 297;
//int E = 330;
//int F = 352;
//int G = 396;
//int A = 440;
//int Bb = 466;
//int B = 495;
//int C2 = 528;

//// Now, we need to set the tempo for a note, half note, quarter note, and eighth note.
//int note = 1000;
//int half = 1000 / 2;
//int quarter = 1000 / 4;
//int eighth = 1000 / 8;

//// Now we can already "sing" a scale to warm up:
//Console.WriteLine("Warming up the voice ...");
//Thread.Sleep(2000);
//Console.Beep(C, quarter);
//Console.Beep(D, quarter);
//Console.Beep(E, quarter);
//Console.Beep(F, quarter);
//Console.Beep(G, quarter);
//Console.Beep(A, quarter);
//Console.Beep(B, quarter);
//Console.Beep(C2, half);
//Thread.Sleep(quarter);
//Console.Beep(C2, quarter);
//Console.Beep(B, quarter);
//Console.Beep(A, quarter);
//Console.Beep(G, quarter);
//Console.Beep(F, quarter);
//Console.Beep(E, quarter);
//Console.Beep(D, quarter);
//Console.Beep(C, half);

//// Let's sing happy birthday, just because Ged Mead turned 60 some days ago:
//Console.WriteLine("We're warmed up, so then let's sing ...");
//Thread.Sleep(2000);
//Console.Beep(C, eighth);
//Thread.Sleep(quarter);
//Console.Beep(C, eighth);
//Thread.Sleep(eighth);
//Console.Beep(D, half);
//Thread.Sleep(eighth);
//Console.Beep(C, half);
//Thread.Sleep(eighth);
//Console.Beep(F, half);
//Thread.Sleep(eighth);
//Console.Beep(E, note);
//Thread.Sleep(quarter);

//Console.Beep(C, eighth);
//Thread.Sleep(quarter);
//Console.Beep(C, eighth);
//Thread.Sleep(eighth);
//Console.Beep(D, half);
//Thread.Sleep(eighth);
//Console.Beep(C, half);
//Thread.Sleep(eighth);
//Console.Beep(G, half);
//Thread.Sleep(eighth);
//Console.Beep(F, note);

//Thread.Sleep(quarter);
//Console.Beep(C, eighth);
//Thread.Sleep(quarter);
//Console.Beep(C, eighth);
//Thread.Sleep(eighth);
//Console.Beep(C2, half);
//Thread.Sleep(eighth);
//Console.Beep(A, half);
//Thread.Sleep(eighth);
//Console.Beep(F, quarter);
//Thread.Sleep(eighth);
//Console.Beep(F, eighth);
//Thread.Sleep(eighth);
//Console.Beep(E, half);
//Thread.Sleep(eighth);
//Console.Beep(D, note);

//Thread.Sleep(quarter);
//Console.Beep(Bb, eighth);
//Thread.Sleep(quarter);
//Console.Beep(Bb, eighth);
//Thread.Sleep(eighth);
//Console.Beep(A, half);
//Thread.Sleep(eighth);
//Console.Beep(F, half);
//Thread.Sleep(eighth);
//Console.Beep(G, half);
//Thread.Sleep(eighth);
//Console.Beep(F, note);
#endregion BEEP MUSIC

#region lesson1 write and readline to console
//Console.WriteLine("Please enter your name");

////intellisense on readline() method tell you that this method will return a string there it must be stored in a variable
//string UserName = Console.ReadLine();

////concatenation
////Console.WriteLine("Hello " + UserName);

////placeholder (prefferred method)
//Console.WriteLine("Hello {0}", UserName);

////TO COMMENT AND UNCOMMENT CODE PRESS Ctrl+k then Ctrl+u, TO COMMENT CODE press Ctrl+k then Ctrl+c
////TO GIVE A CLASS A DESCRIPTION COMMENT USE TRIPLE SLASH ///
#endregion

#region lesson2 builtin types (bool, numbers, chars), and string escapes
////Bool
////bool b = true;

////Numbers
////sbyte - signed 8 bits, range from -128 to 127
////byte  - unsigned 8 bits, range from 0 to 255
////char  - Unicode 16 bit characters, range from U+0000 to U+ffff
////short - signed 16 bit integer, range from -32,768 to 32,767
////ushort - unsigned 16 bit integer, range from 0 to 65,535
////int - signed 32 bit integer, range from -2,147,483,648 to 2,147,483,647
////uint - unsigned 32 bit integer, range from  0 to 4,294,967,295
////long - signed 64 bit integer, range from -2^64/2 to 2^64/2
////ulong - unsigned 64 bit integer, range from 0 to 2^64
////float - signed 32 bit, precision of 7 digits, appx. range +- 1.5e^-45 to +-3.4e^38
////double - signed 64 bit, precision of 15-16 digits, appx. range +-5.0e^-324 to +-1.7e^308
////decimal - signed 128 bit, precision of 28-29 digits.


////note floats can only have 7 TOTAL digits! This example will round the number to 1.123457
////ALSO NOTE AN F IS NEEDED ON THE END OF THE NUMBER
//float f = 1.123456789123456789123456798f;
//Console.WriteLine(f);

////Strings

////Escape special characters with backslash
//// List of most common special characters:
//// \a Bell, \b Backspace, \f Formfeed, \n New Line, \r Carriage Return, \t Horizontal Tab, \v Vertical Tab, 
//// \' ', \" ", \\ \, \? ?,
//string Name = "\"Michael\"";
//string NewLine = "One\nTwo\nThree";
//Console.WriteLine(Name);
//Console.WriteLine(NewLine);

////If you are using too many backslashes to escape use Verbatim Literal @

//string PathEx = @"C:\Users\mzamp\source\repos\Pragimcsharp";
//Console.WriteLine(PathEx);

#endregion

#region lesson3 common operators
////Assignment Operator =
////Arithmetic Operators +,-,*,/,%
////Comparison Operators ==, !=, >, >=, <, <=
////Conditional Operators &&, ||
////Ternary Operator ?:
////Null Coalescing Operator ??

////Short circuiting with OR ||
//int Number = 10;
//int AnotherNumber = 20;

////Here the first test is true and the runtime doesn't bother checking the second.
//if (Number == 10 || AnotherNumber == 20) ;
//{
//    Console.WriteLine("Hello");
//}

////Ternary example  

////Orignal if else construction can be replaced by a single line       
////bool IsNumber10;

////if (Number == 10)
////{
////    IsNumber10 = true;
////}
////else
////{
////    IsNumber10 = false;
////}

////Console.WriteLine("Number == 10 is {0}", IsNumber10);


////Here is the single line 
//bool IsNumber10 = Number == 10 ? true : false;

//Console.WriteLine("Number == 10 is {0}", IsNumber10);

#endregion

#region lesson4 Nullable Types

////In C# types are divided into 2 broad categories: Value Types and Reference Types
////Value types - int, float, double, struct, enum, etc.
////Reference types - Interface, Class(string is actually a class), delegates, arrays, etc.

//// The default value for reference types is Null, While the default value for value types is some form of Zero(0)

////string Name = null;

////int i = null;  //This won't compile

////You can make i nullable by adding ?        
////int? i = null;

//// Why would you want to make a nonnullable type nullable
////Mostly for databases if user wants to leave a field blank (optional inputs)

//bool? AreYouMajor = null;

//if (AreYouMajor == true)
//{
//    Console.WriteLine("User is Major");
//}
//else if (AreYouMajor == false)
//{
//    Console.WriteLine("User is Not Major");
//}
//else
//{
//    Console.WriteLine("User did not answer the question");
//}


////Null Coalescing Operator ??

////Orignal Code without Null Coalescing Operator
////int? TicketsOnSale = null;

////int AvailableTickets;

////if (TicketsOnSale == null)
////{
////    AvailableTickets = 0;
////}
////else
////{
////    //Cannot convert int? to int .meaning there is no implicit conversion between a non nullable type and a nullable type
////    //AvailableTickets = TicketsOnSale;
////    //You must be explicit about the conversion, 2 ways to do it .value method or casting
////    //AvaiableTickets = TicketsOnSale.Value
////    AvailableTickets = (int)TicketsOnSale;
////}

////Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

////Same code for tickets with ??

//int? TicketsOnSale = null;

//int AvailableTickets = TicketsOnSale ?? 0; 

//Console.WriteLine("AvailableTickets = {0}", AvailableTickets);



#endregion

#region lesson5 Data Type Conversions

////Implicit conversion is done by the compiler
////1. when there is no loss of information
////2. if there is no possiblity of throwing exception during conversion
//int i = 100;
//float f = i;
//Console.WriteLine(f);

////Explicit conversion (2 ways to convert)

////typecast operator (notice this doesnt round)
//float r = 123.55f;
//int t = (int) r;
//Console.WriteLine(t);

////use convert class (notice this rounds up)
////This will give an exception if you try to go outside of the int range, this is desired as typecast will return a wrong number
//float p = 123.55f;
//int y = Convert.ToInt32(p);
//Console.WriteLine(y);

////Converting to a string (third way to convert) using parse
//string strNumber = "100";
//int s = int.Parse(strNumber);
//Console.WriteLine(s);

////Use int.TryParse to check first and return a bool value
//string InvalidNumber = "100TG";
//int Result = 0;
//bool IsConversionSuccessful = int.TryParse(InvalidNumber, out Result);

//if (IsConversionSuccessful)
//{
//    Console.WriteLine(Result);
//}
//else
//{
//    Console.WriteLine("Please enter a valid number");
//}


#endregion

#region lesson6 Arrays

////Create an integer array and specify a size (3 integers)

////Arrays are strongly typed (must contain all the same data type and their size must be specified)
//int[] EvenNumbers = new int[3];

//EvenNumbers[0] = 0;
//EvenNumbers[1] = 2;
//EvenNumbers[2] = 4;

//Console.WriteLine(EvenNumbers[1]);

#endregion

#region lesson7 If Else, && vs &, || vs |


////basic if else tester
//Console.WriteLine("Please enter a number");

//int UserNumber = int.Parse(Console.ReadLine());

//if (UserNumber == 1)
//{
//    Console.WriteLine("Your number is one");
//}

//else if (UserNumber == 2)
//{
//    Console.WriteLine("Your number is two");
//}

//else
//{
//    Console.WriteLine("Your number is not one or two");
//}

////basic OR checker ||  (IF you use single pipe it checks both conditions while double pipe shortcircuits(same with && vs &)
//Console.WriteLine("Please enter another number");
//int NextNumber = int.Parse(Console.ReadLine());

//if (NextNumber == 10 || NextNumber == 20)
//{
//    Console.WriteLine("Your number is 10 or 20");
//}
//else
//{

//}

#endregion

#region lesson8 switch statement

//Console.WriteLine("Please enter a number");

//int UserNumber = int.Parse(Console.ReadLine());

//switch(UserNumber)
//{

//    ////basic switch scenario with a default catchall
//    //case 10:
//    //    Console.WriteLine("Your number is 10");
//    //    break;
//    //case 20:
//    //    Console.WriteLine("Your number is 20");
//    //    break;
//    //case 30:
//    //    Console.WriteLine("Your number is 30");
//    //    break;
//    //default:
//    //    Console.WriteLine("Your number is not 10, 20 or30");
//    //    break;

//    //this switch can be shortened by just combining cases
//    case 10:
//    case 20:
//    case 30:
//        Console.WriteLine("Your Number is {0}", UserNumber);
//        break;
//    default:
//        Console.WriteLine("Your number is not 10, 20 or30");
//        break;

//}

////basic coffee shop switch
//int TotalCoffeeCost = 0;


//Start:
//Console.WriteLine("Please select your coffee size: 1 - small, 2 - medium, 3 - large");
//int UserChoice = int.Parse(Console.ReadLine());

////switching on an integer type case must match
//switch (UserChoice)
//{
//    case 1:
//        TotalCoffeeCost += 1;
//        break;
//    case 2:
//        TotalCoffeeCost += 2;
//        break;
//    case 3:
//        TotalCoffeeCost += 3;
//        break;
//    default:
//        Console.WriteLine("Your choice {0} is invalid", UserChoice);
//        goto Start;
//}


//Decide:
//Console.WriteLine("Do you want to buy another coffee - Yes or No?");
//string UserContinue = Console.ReadLine();


////switching on a string type
//switch(UserContinue.ToUpper())
//{
//    case "YES":
//        //if user wants more coffee you must return to the original switch using goto
//        //the goto references a label and just back to that line (GOTO IS DANGEROUS, BAD PROGRAMMING STYLE)
//        goto Start;
//    case "NO":
//        break;
//    default:
//        Console.WriteLine("Your choice {0} is invalid. Please try again", UserContinue);
//        goto Decide;
//}

//Console.WriteLine("Thank you for shopping with us");
//Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
#endregion

#region lesson 9 while and do while loops


////basic while loop
//Console.WriteLine("Please enter a target number");
//int UserTarget = int.Parse(Console.ReadLine());

//int Start = 0;

//while (Start <= UserTarget)
//{
//    //Here we used write instead of write line to keep all the numbers on the same line
//    Console.Write(Start + " ");
//    Start = Start + 2;
//}

////basic do-while loop


////this variable needs to be initialized here because it does not exist outside that scope
//string UserChoice = "";

//do
//{
//    Console.WriteLine("Please enter a target number");
//    int UserTarget = int.Parse(Console.ReadLine());

//    int Start = 0;

//    while (Start <= UserTarget)
//    {
//        //Here we used write instead of write line to keep all the numbers on the same line
//        Console.Write(Start + " ");
//        Start = Start + 2;
//    }



//    do
//    {
//        Console.WriteLine("Do you want to continue? - Yes or No?");

//        UserChoice = Console.ReadLine().ToUpper();
//        if (UserChoice != "YES" && UserChoice != "NO")
//        {
//            Console.WriteLine("Invalid Choice, please say yes or no");
//        }
//    } while (UserChoice != "YES" && UserChoice != "NO");
//} while (UserChoice == "YES");



#endregion

#region lesson 10 for and foreach loops, break and continue

//int[] Numbers = new int[3];

//Numbers[0] = 101;
//Numbers[1] = 102;
//Numbers[2] = 103;

//for (int i = 0; i < Numbers.Length; i++)
//{
//    Console.WriteLine(Numbers[i]);
//}

////foreach is better for collections because you dont need to know the index range
////foreach can be used with arrays or collections such as ArrayList, HashTable, and Genercics

//foreach(int j in Numbers)
//{
//    Console.WriteLine("iterate in foreach" + j.ToString());
//}

////break used to stop counting at 10
//for (int n = 1; n <= 20; n++)
//{
//    Console.WriteLine(n);

//    if (n == 10)
//        break;
//}

////continue used to skip odd numbers continue bounces back to start without executing the writeline piece
//for (int m = 0; m <=20; m++)
//{
//    if (m % 2 == 1)
//        continue;

//    Console.WriteLine(m);
//}

#endregion

#region lesson 11 Methods

//    //attributes
//    //access-modifiers return-type method-name (parameters)
//    //{
//    //  Method Body
//    //}


//    //make sure to fix comment of end of main function >>> }


//    //CALLING INSTANCE METHOD  <<public void EvenNumbers()>>
//    //If you have to invoke an instance method you need to first create an "instance of that class"
//    //Program p = new Program();

//    //Then use that instance of class to invoke the instance method
//    //p.EvenNumbers();


//    //CALLING STATIC METHOD    <<public static void EvenNumbers()>>
//    //If your method is not an instance method you cannot invoke it on an instance of that class
//    //Instead you just use the ""name of the class"" with .Method
//    //ADDING STATIC MAKES THIS METHOD NON-INSTANTIABLE
//    Program.EvenNumbers(30);

//    Program p = new Program();
//    int Sum = p.Add(10, 25);

//    Console.WriteLine("Sum = {0}", Sum);
//}

////this is considered an instance method
//public static void EvenNumbers(int Target)
//{
//    int Start = 0;

//    while (Start <= Target)
//    {
//        Console.WriteLine(Start);
//        Start = Start + 2;
//    }

//}

//public int Add(int FN, int SN)
//{
//    return FN + SN;
//}


#endregion

#region lesson 12 Method Parameters

//    //make sure to fix comment of end of main function >>> }


////Passing a variable by Value, here i doesn't get changed
//    int i = 0;
//    SimpleMethod(i);
//    Console.WriteLine(i);

//}

//public static void SimpleMethod(int j)
//{
//    j = 101;
//}


//    //Passing a variable by Reference, here i gets changed by j
//    int i = 0;
//    SimpleMethod( ref i);
//    Console.WriteLine(i);


//}

//public static void SimpleMethod(ref int j)
//{
//    j = 101;
//}

//    //USING THE OUT KEYWORD TO RETURN MULTIPLE PARAMETERS 

//    // create variables to receive sum and product
//    int Total = 0;
//    int Product = 0;
//    Calculate(10, 20, out Total, out Product);      
//    Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
//}


//public static void Calculate(int FN, int SN, out int Sum, out int Product)
//{
//    Sum = FN + SN;
//    Product = FN * SN;
//}

//    int[] List = new int[3];

//    List[0] = 101;
//    List[1] = 102;
//    List[2] = 103;

//    //Can pass in an array like this
//    //ParamsMethod(List);

//    //Or can pass in like this as long as params is expecting ints with int[]
//    ParamsMethod(101, 102, 103);
//}


////To Create Parameter Arrays
////NOTE THE ONLY ONE PARAMS ARRAY CAN BE PASSED INTO A METHOD
////ALSO IF METHOD HAS MULTIPLE PARAMETERS THE PARAMS ARRAY SHOULD BE THE LAST ONE IN THE LIST
//public static void ParamsMethod(params int[] Numbers)
//{
//    Console.WriteLine("There are {0} elements in the passed in array", Numbers.Length);

//    foreach (int i in Numbers)
//    {
//        Console.WriteLine(i);
//    }
//}



#endregion

#region lesson 13 Namespaces

////Namespaces help organize programs and help with avoiding name clashes

////On top import library by writing using XXXX;
////A namespace holds classes here is an example of the heirarchy:
////namespace ProjectA
////{
////    namespace TeamA
////    {
////        class ClassA
////        {
////            public static void Print()
////            {
////                Console.WriteLine("Team A Print Method");
////            }
////        }
////    }

////    namespace TeamB
////    {
////        class ClassA
////        {
////            public static void Print()
////            {
////                Console.WriteLine("Team B Print Method");
////            }
////        }
////    }
////}


////NAMESPACES DONT CORRESPOND TO FILE, DIRECTORY, OR ASSEMBLY NAMES YOU MUST REFERENCE THEM
//// TO MAKE ASSEMBLY REFERENCE YOU USE DISASSEMBLER AND INCLUDE THE CLASS LIBRARY TO THE REFERENCES OF CURRENT PROJECT

#endregion

#region lesson 14 Intro to Classes

////create an instance (aka object)
//Customer C1 = new Customer("Pragim", "Techonologies");
//C1.PrintFullName();
//Customer C2 = new Customer();
//C2.PrintFullName();


#endregion

#region lesson 15 Static vs. Instance
//Use the static keyword if something isn't going to change between instances.
//This is useful because each instance will now share that single static(field, method, etc...) rather than creating a new one each time


//Circle C1 = new Circle(5);
//float Area1 = C1.CalculateArea();
//Console.WriteLine("Area of {0} for a circle of radius: {1}", Area1, C1._Radius);

//Circle C2 = new Circle(6);
//float Area2 = C2.CalculateArea();
//Console.WriteLine("Area is {0}", Area2);


#endregion



//    }

//}

#region lesson 14 Continued Intro to Classes

//A class consists of data and behavior, class data is represented by its fields and behavior by its methods
//class Customer
//{
//    //class fields
//    string _firstName;
//    string _lastName;

//    //You can create a default constructor that allows automatic default values OVERLOADING CONSTRUCTORS
//    public Customer() : this("No first name provided", "No last name provided")
//    {

//    }

//    //CONSTRUCTOR to initialize class fields
//    public Customer(string FirstName, string LastName)
//    {
//        //one way to assign
//        //_firstName = FirstName;
//        //_lastName = LastName;

//        this._firstName = FirstName;
//        this._lastName = LastName;
//    }

//    //lets add a behavior to print name
//    public void PrintFullName()
//    {
//        Console.WriteLine("Full Name  = {0}", this._firstName + " " + this._lastName);
//    }

//    //class destructors don't usually need in csharp, but can be used to cleanup resources used during class lifetime
//    //~Customer()
//    //{
//    //}


//    //You don't neccessarily need to use a constructor every time you call and instance of this class
//    //If you don't write a constructor for your class you can have a default constructor with no parameters and fills class fields with null values
//    //Customer C1 = new Customer();

//}

#endregion

#region lesson 15 Continued Static vs. Instance

//    class Circle
//{
//    //Its smart to add static to this field because it will never change and save on memory
//    //make these public if you want access to them outside of this class
//    public static float _PI;
//    public int _Radius;

//    //Instance Constructor
//    public Circle(int Radius)
//    {
//        this._Radius = Radius;
//        Console.WriteLine("Instance Constructor Called");
//    }

//    //Static Constructor does not allow use of access modifiers can be used to initialize other static fields
//    //Static constructor gets called before instance constructor and is called only once.
//    static Circle()
//    {
//        _PI = 3.14F;
//        Console.WriteLine("Static Constructor Called");
//    }

//    //Getter


//    //method with a return float
//    public float CalculateArea()
//    {
//        //if Pi is static you no longer need the this.
//        return _PI * this._Radius * this._Radius;
//    }

//}


#endregion



