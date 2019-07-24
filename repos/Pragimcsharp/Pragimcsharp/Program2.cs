using System;
using System.Collections.Generic;


//FOUR PILLARS OF OBJECT ORIENTATED PROGRAMMING
//1. ABSTRACTION
//2. ENCAPSULATION
//3. INHERITANCE
//4. POLYMORPHISM


//All lessons in this section have 2 parts that need to be uncommented because of created classes

//public class Program2
//{

//    public static void Main()
//    {

        #region lesson 16 Inheritance

        ////List of c# inheritance capabilities
        ////Derived class inherits from parent class
        ////Only supports single class inheritance(cannot inherit from multiple parents)
        ////Support multiple interface inheritance
        ////Child class is a specialization of base class
        ////Base classes are automatically instantiated before any derived classes
        ////Parent class constructor executes before child class constructor

        //Employee EMP = new Employee();
        //Console.WriteLine("Enter Employees First name");
        //EMP.FirstName = Console.ReadLine();

        //EMP.PrintFullName();

        //Employee EMP2 = new Employee("Mike", "Zamp", "Mzamp27@yahoo.com");
        //EMP2.PrintFullName();

        //FullTimeEmployee FTE = new FullTimeEmployee(50000);
        //FTE.PrintFullName();
        //Console.WriteLine( FTE.YearlySalary);

        #endregion

        #region lesson 17 Polymorphism

        ////polymorphism enables us to invoke a derived class method through a base class reference variable during runtime


        ////create array of employees since all these classes are related by inheritance they all share the Employee base type
        //Employee[] employees = new Employee[4];

        //employees[0] = new Employee();
        //employees[1] = new PartTimeEmployee();
        //employees[2] = new FullTimeEmployee();
        //employees[3] = new TemporaryEmployee();

        ////printfullname() is available in the parent class so all children can call it
        //foreach (Employee e in employees)
        //{
        //    e.PrintFullName();
        //}


        #endregion

        #region lesson 18 Method Hiding vs Overriding and Overloading

        ////IN METHOD HIDING A BASE CLASS REFERENCE VARIABLE POINTING TO A CHILD CLASS OBJECT WILL INVOKE THE HIDDEN METHOD IN THE BASE CLASS
        //// SEE BELOW CLASS CONSTRUCTION NOTES
        //BaseClass B = new DerivedClass();
        //B.Print();

        #endregion

        #region lesson 19 Encapsulation

        ////The advantage of using properties over get() and set() methods is that you can access them as if they were public fields
        //Student C1 = new Student();
        //C1.SetId(25);
        //C1.Grade = 100;


        //Console.WriteLine(C1.GetId());
        //Console.WriteLine(C1.Name);
        //Console.WriteLine(C1.Grade);


        #endregion

        #region lesson 20 Structs

        ////As you can see the struct looks identical to a class however there are differences
        //Customer C1 = new Customer(101, "Mark");
        //C1.PrintDetails();

        //Customer C2 = new Customer();
        //C2.ID = 102;
        //C2.NAME = "John";
        //C2.PrintDetails();

        //Customer C3 = new Customer
        //{
        //    ID = 103,
        //    NAME = "Rob"
        //};
        //C3.PrintDetails();

        //A STRUCTURE IS A VALUE TYPE WHEREAS A CLASS IS A REFERENCE TYPE

        //Value types : int, float, bool, struct, enums  (STORED ON THE STACK )
        //*note (object reference variables) are also stored on the stack whereas the actual object it points to in on the heap
        //Value types hold their value in memory where they are declared        
        //values types are destroyed immediately after the scope is lost

        //Structs are immutable
        //Structs can NOT have destructors
        //Structs can NOT have explicit parameter-less constructor (empty constructor)
        //Structs can NOT inherit from another class, and NEITHER can inherit from a struct
        //BOTH can inhereit from an interface
        //Structs are inherently SEALED


        //Reference types : classes, interfaces, delegates  (STORED ON THE HEAP)
        //holds a reference to an object in memory
        //object is later destroyed by garbage collector
        //reference types are mutable

        //classes can have destructors
        //classes can have empty constructors
        //classes can inherit from other classes
        //If you mark a class as SEALED it acts like a struct and won't allow it to be inherited



        #endregion

        #region lesson 21 Interfaces


        //Customer C1 = new Customer();
        //C1.Print();

        //ChainEx C2 = new ChainEx();
        //C2.Print1();
        //C2.Print2();

        ////You cannot create an instance of an interface, but an interface reference variable can point-to a derived class object
        ////A parent class reference variable can point to a child class object since customer is inheriting from Icustomer
        //ICustomer Cust = new Customer();

        ////Now cust only shows ICustomer print method
        //Cust.Print();


        #endregion

        #region lesson 22 Explicit Interface

        //Example E = new Example();

        ////YOU MUST TYPE CAST OBJECT E TO USE THE CORRECT INTERFACE

        //((I1)E).InterfaceMethod();
        //((I2)E).InterfaceMethod();

        ////When a class explicitly implements and interface member, the interface member can no longer be accessed thru
        ////the interface reference variable.

        ////if you don't want to typecast you can also create obejct using I1
        //I1 F = new Example();
        //I2 G = new Example();

        //F.InterfaceMethod();
        //G.InterfaceMethod();

        ////IF YOU LEAVE THE ACCESS MODIFIER (public) ON IT IS NO LONGER EXPLICIT BUT BECOMES THE DEFAULT
        ////AND THE ONLY WAY TO ACCESS THE OTHER EXPLICIT METHOD IS WITH TYPE CASTING (see below for explicit requirements)

        #endregion

        #region lesson 23 Continued Abstract Classes
        //abstract class is incomplete and cannot be instantiated
        //it can only be used as a base class
        //it cannot be sealed
        //it may contain abstract memebers
        //a non-abstract class that inherits the abstract class must implement all of its members
        //if not the class must be declared as abstract itself.

        //Differences between abstract class and an interface;
        //1. Abstract can implement its memebers while interfaces cannot
        //2. Abstract can be declared private while interfaces are always public(access modifiers)
        //3. Abstract classes can have fields while interfaces cannot
        //4. Abstract classes can inherit from other abstract classes or interfaces while interfaces can only inherit other interfaces
        //5. Classes cannot inherit from multiple classes, but can inherit from multiple interface


        #endregion

        #region lesson 24 Inheriting multiple classes workaround (w/ interfaces)

        ////Because of the way we implemented the method in AB we are effectively inheriting from multiple classes(enabled by interfaces)
        //AB ab = new AB();
        //ab.AMethod();
        //ab.BMethod();
        #endregion

        #region lesson 25 Delegates
        // Delegates are used to make a class and its methods reusable

        //List<Employee> empList = new List<Employee>();

        //empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
        //empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
        //empList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
        //empList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

        ////Here we needed to create a delegate and point it to the create function Promote
        ////IsPromotable isPromotable = new IsPromotable(Promote);
        ////Employee.PromoteEmployee(empList, isPromotable);

        ////A better way for a simple bool delegate is to use a lambda expression
        //Employee.PromoteEmployee(empList, x => x.Experience >= 5);

        #endregion
        //}
        //Without lambda expression you need to create a function for the delegate to point to
        //public static bool Promote(Employee emp)
        //{
        //    if (emp.Experience >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        #region lesson 26 Mulitcast Delegates
    //    SampleDelegate del1, del2, del3, del4;
    //    del1 = new SampleDelegate(SampleMethodOne);
    //    del2 = new SampleDelegate(SampleMethodTwo);
    //    del3 = new SampleDelegate(SampleMethodThree);

    //    del4 = del1 + del2 + del3 -del2;
    //    del4();

    //    //can use += and  -= because inside there is a delegates invocation list
    //    SampleDelegate del5 = new SampleDelegate(SampleMethodOne);
    //    del5 += SampleMethodTwo;
    //    del5();

    //    //if a return type delegate has multiple functions its pointing to, it will return whatever is returned from the last method in the invocation list.
    //    //also if it has an out parameter, the value of the output parameter will be whatever from the last methods in the invoke list

    //    //Q. WHERE DO WE USE MULTICAST DELEGATES?
    //    //A. Observer design pattern. aka publish/subscribe patter

    //}

    //public static void SampleMethodOne()
    //{
    //    Console.WriteLine("SampleMethodOne Invoked");
    //}
    //public static void SampleMethodTwo()
    //{
    //    Console.WriteLine("SampleMethodTWO Invoked");
    //}
    //public static void SampleMethodThree()
    //{
    //    Console.WriteLine("SampleMethodTHREE Invoked");
    //}

    #endregion
//}

#region lesson 16 Continued Inheritance

//public class Employee
//{
//    //Hide access to these fields
//    private string firstname;
//    private string lastname;
//    private string email;

//    //Public way of accessing and changing private fields
//public string FirstName { get => firstname; set => firstname = value; }
//public string LastName { get => lastname; set => lastname = value; }
//public string Email { get => email; set => email = value; }


//    //default constructor with no arguments
//    public Employee()
//    {

//    }

//    //constructor if user wants to pass arguments in
//    public Employee(string fn, string ln, string em)
//    {
//        FirstName = fn;
//        LastName = ln;
//        Email = em;
//    }



//    public void PrintFullName()
//    {
//        Console.WriteLine(this.firstname + this.lastname);
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    private float yearlysalary;
//    public float YearlySalary { get => yearlysalary; set => yearlysalary = value; }

//    //This constructor will call Employee.Employee() and add one required argument 
//    public FullTimeEmployee(float ys) : base()
//    {
//        YearlySalary = ys; 
//    }

//    //This constructor will call Employee.Employee(fn, ln, em) and also require a ys required argument
//    public FullTimeEmployee(string fn, string ln, string em, float ys) : base(fn, ln, em)
//    {
//        YearlySalary = ys;
//    }
//}


//public class PartTimeEmployee : Employee
//{
//    float HourlyRate;
//}

#endregion

#region lesson 17 Continued Polymorphism
//public class Employee
//{
//    public string FirstName = "FN";
//    public string LastName = "LN";

//    //IN ORDER TO OVERRIDE WE NEED TO MARK THIS AS VIRTUAL
//    public virtual void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName);
//    }
//}


////when these specific printfullname() is called normally they would hide the one in the base class
////however hiding is not enough you need to OVERRIDE using special keywords virtual and override
//public class PartTimeEmployee : Employee
//{
//    public override void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName + " - Part Time" );
//    }
//}
//public class FullTimeEmployee : Employee
//{
//    public override void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName + " - Full Time");
//    }
//}
//public class TemporaryEmployee : Employee
//{
//    public override void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName + " - Temporary");
//    }
//}

#endregion

#region lesson 18 Continued Method Hiding vs Overriding and Overloading

//public class  BaseClass
//{
//    public virtual void Print()
//    {
//        Console.WriteLine("I am the base class method");
//    }
//}

//public class DerivedClass : BaseClass
//{
//    //HERE WE USE OVERRIDE KEYWORD SO EVEN THOUGH THE MAIN CODE CONSTRUCS B WITH BASE CLASS THE DERIVED CLASS METHOD OVERRIDES IT
//    public override void Print()
//    {
//        Console.WriteLine("I am the derived class method");
//    }
//}

////HIDING EXAMPLE
////public class DerivedClass : BaseClass
////{
////    //HERE WE USE NEW KEYWORD SO BECAUSE THE MAIN CODE CONSTRUCTS B WITH BASE CLASS THE METHOD CALL WILL REFERENCE THE BASE CLASS
////    public new void Print()
////    {
////        Console.WriteLine("I am the derived class method");
////    }
////}


#endregion

#region lesson 19 Continued Encapsulation

////The advantage of using properties over get() and set() methods is that you can access them as if they were public fields

//class Student
//{
//    private int id;
//    private string name;
//    //this is greyed because without logic inside the setter auto implement wants to handle it
//    private int grade;

//    //Old Style using separate methods to get and set private fields
//    public void SetId(int Id)
//    {
//        if (Id <= 0)
//        {
//            throw new Exception("Student Id cannot be negative");
//        }
//        this.id = Id;
//    }
//    public int GetId()
//    {
//        return this.id;
//    }

//    //Here is get/set without using a method rather use a property, (notice the use of VALUE)
//    public string Name
//    {
//        set
//        {
//            if (string.IsNullOrEmpty(value))
//            {
//                throw new Exception("Please set the students name");
//            }
//            this.name = value;
//        }
//        get
//        {
//            return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
//        }
//    }

//    //Here is an even shorter version if you just need simple read and write access
//    //**However this doesnt reference the private field "grade" 
//    public int Grade
//    {
//        get => grade;
//        set => grade = value;
//    }


//}

#endregion

#region lesson 20 Continued Structs

////As you can see the struct looks identical to a class however there are differences
//public struct Customer
//{
//    //can have properties
//    public int ID { get; set; }
//    public string NAME { get; set; }

//    //can have constructors
//    public Customer(int Id, string Name)
//    {
//        ID = Id;
//        NAME = Name;
//    }

//    //can have methods
//    public void PrintDetails()
//    {
//        Console.WriteLine("Id = {0} && Name = {1}", ID, NAME);
//    }

//}



#endregion

#region lesson 21 Continued Interfaces

////common convention to put I infront of name to convey its an interface
////interfaces can only have DECLARATIONS and cannot have implementations
//interface ICustomer
//{
//    //cannot contain fields

//    //cannot have access modifiers, its public by default
//    //cannot implement this method but can be declared
//    void Print();   
//}

//interface I2
//{
//    void I2Method();
//}


////A class can inherit interfaces
////***since this customer inherits from ICustomer it MUST implement ALL interface members in the entire inheritance chain
////***A class can inherit MULTIPLE interfaces
//public class Customer : ICustomer, I2
//{
//    public void I2Method()
//    {
//        Console.WriteLine("I2 Method");
//    }

//    public void Print()
//    {
//        Console.WriteLine("Interface Print Method");
//    }
//}




//interface IChain1
//{
//    void Print1();
//}
////IChain2 inherits 1
//interface IChain2 : IChain1
//{
//    void Print2();
//}

////example of inheritance chaining, you must implement all interface members from the chain
//public class ChainEx : IChain2
//{
//    public void Print1()
//    {
//        Console.WriteLine("Print1");
//    }
//    public void Print2()
//    {
//        Console.WriteLine("Print2");
//    }
//}

#endregion

#region lesson 22 Continued Explicit Interface

////Explicit interface needs to be used if two interfaces have methods with the same name and are both inherited by a class
//interface I1
//{
//    void InterfaceMethod();
//}
//interface I2
//{
//    void InterfaceMethod();
//}

////Here Example class inherits I1 and I2 but which interfacemethod is it calling?
////To use explicit you have 2 requirements
//public class Example : I1, I2
//{
//    //1. cannot use access modifier on the interface member (public needs to be removed)

//    //2. need to specify which interface (I1.)
//    void I1.InterfaceMethod()
//    {
//        Console.WriteLine("I1 Interface Method");
//    }

//    void I2.InterfaceMethod()
//    {
//        Console.WriteLine("I2 Interface Method");
//    }
//}



#endregion

#region lesson 23 Continued Abstract Classes
//public abstract class Customer
//{
//    //imnplemented method
//    public void Print()
//    {
//        Console.WriteLine("Print Method");
//    }

//    //methods you wish to remain not implemented must have an abstract modifier with it
//    //the inheriting class must define this method or it must be marked abstract if it doesn't
//    public abstract void Print2();

//    //field declaration
//    int ID;

//}

#endregion

#region lesson 24 Continued Inheriting multiple classes workaround (w/ interfaces)

//interface IA
//{
//    void AMethod();
//}
//class A : IA
//{
//    public void AMethod()
//    {
//        Console.WriteLine("A");
//    }
//}

//interface IB
//{
//    void BMethod();
//}
//class B : IB
//{
//    public void BMethod()
//    {
//        Console.WriteLine("B");
//    }
//}

//class AB : IA, IB
//{
//    //RATHER THAN REIMPLEMENT THESE METHODS YOU CREATE AN INSTANCE OF CLASS A AND B AND LET THEM CALL IT
//    A a = new A();
//    B b = new B();
//    public void AMethod()
//    {
//        a.AMethod();
//    }
//    public void BMethod()
//    {
//        b.BMethod();
//    }
//}

#endregion

#region lesson 25 Continued Delegates

////delegate will just boil down the essence of the method its referencing, in this case it comes down to "Is this person getting promoted?" True/False
////therefore because we want a yes or no answer the delegate needs to return a bool
////for our delegate we need to pass in something to test (the employee object, empl)
//public delegate bool IsPromotable(Employee empl); 

//public class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }


//    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleForPromotion)
//    {
//        foreach (Employee employee in employeeList)
//        {
//            if(IsEligibleForPromotion(employee))
//            {
//                Console.WriteLine(employee.Name + " promoted");
//            }
//        }
//    }
//}

#endregion

#region lesson 26 Continued Multicast Delegates
//public delegate void SampleDelegate();
#endregion
