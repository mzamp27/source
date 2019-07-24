using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


#region list vs array
//The most important reason I use an array instead of a List<> is to imply that the data is fixed length. 
//If I won't add or remove any items from that data collection, I want to make sure that the type reflects that.

//List<T> offers a lot more functionality than an array (although LINQ evens it up a bit), and is almost always the right choice. 
//Except for params arguments, of course. ;-p



//      Use an array when you are dealing with data that is:

//       fixed in size, or unlikely to grow much
//       suitably large(more than 10, 50, 100 elements, depending on the algorithm)
//       you will be doing lots of indexing into it, i.e.you know you will often want the third element, or the fifth, or whatever.

//      Use a list for:

//      variable length data lists
//      that are mostly used as a stack or a queue or need to be iterated in its entirety
//      when you do not want to write an expression to derive the ultimate array size for the declaration and you do not want to wastefully pick a large number

//      Use a hashmap for:

//      variable length data lists
//      that need to be indexed like an array would

//      In reality, you'll want a list or hashmap almost all of the time. Next time you pick a data structure, think about what it must do well for you (or your code, anyway). Then pick something based on that. When in doubt, pick something as general as possible, i.e. an interface you can replace the implementation of quite easily. Some good links in the other answers as well.


#endregion



public class Program3
{
    public static void Main()
    {

        #region lesson 27 Exception Handling
        //try
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter First Number");
        //        int FN = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine("Enter Second Number");
        //        int SN = Convert.ToInt32(Console.ReadLine());

        //        int result = FN / SN;

        //        Console.WriteLine("Result = {}", result);
        //    }
        //    catch (Exception ex)
        //    {
        //        string filePath = @"C: \Users\mzamp\source\repos\Pragimcsharp\Log.txt";
        //        if (File.Exists(filePath))
        //        {
        //            StreamWriter sw = new StreamWriter(filePath);
        //            sw.Write(ex.GetType().Name);
        //            sw.WriteLine();
        //            sw.Write(ex.Message);
        //            sw.Close();
        //            Console.WriteLine("There is a problem, Please try later");
        //        }
        //        else
        //        {
        //            //if file not found happens, you pass original exception ex as an additional parameter to keep track of it
        //            //But first you need to wrap entire code in another try/catch
        //            throw new FileNotFoundException(filePath + " is not present", ex);
        //        }

        //    }
        //}
        //catch(Exception ex2)
        //{
        //    Console.WriteLine("Current Exception = {0}", ex2.GetType().Name);
        //    //Before you try to access inner exception make sure its not null
        //    if (ex2.InnerException != null)
        //    {
        //        Console.WriteLine("Inner Exception = {0}", ex2.InnerException.GetType().Name);
        //    }
        //}



        #endregion

        #region lesson 28 Validating
        ////its better to validate values as you go instead of waiting to catch exceptions
        ////personally I would validate and loop at the input line
        //Console.WriteLine("Enter new contact nane");
        //string name = Console.ReadLine();
        //Console.WriteLine("Enter contact address");
        //string address = Console.ReadLine();
        //Console.WriteLine("Enter contact phone");
        //string phone = Console.ReadLine();



        #endregion




    }
}

#region lesson 27 Continued Exception Handling


#endregion

#region lesson 28 Validating
////its better to validate values as you go instead of waiting to catch exceptions
//public class Contact
//{
//    //this class will need a validate method for each of the properties
//    static public string ValidateName(string newName)
//    {
//        if (newName == "")
//        {
//            return "A name cannot be an empty string\n";
//        }
//        return "";
//    }
//    static public string ValidateAddress(string newAddress)
//    {
//        if (newAddress == "")
//        {
//            return "A address cannot be an empty string\n";
//        }
//        return "";
//    }
//    static public string ValidatePhone(string newPhone)
//    {
//        if (newPhone == "")
//        {
//            return "A phone number cannot be an empty string\n";
//        }
//        return "";
//    }

//    private string contactName;
//    private string contactAddress;
//    private string contactPhone;
//    private int contactMinutesSpent;

//    //Here we call various validate methods within within the constructor
//    public Contact(string name, string address, string phone)
//    {
//        string errorMessage = "";
//        string error;

//        error = ValidateName(name);
//        if (error != "")
//        {
//            errorMessage = error;
//        }
//        error = ValidateAddress(address);
//        if (error != "")
//        {
//            errorMessage += error;
//        }
//        error = ValidatePhone(phone);
//        if (error != "")
//        {
//            errorMessage += error;
//        }

//        if (errorMessage != "")
//        {
//            throw new Exception(errorMessage);
//        }

//        this.ContactName = name;
//        this.ContactAddress = address;
//        this.ContactPhone = phone;
//        this.contactMinutesSpent = 0;
//    }

//    public string ContactName
//    {
//        get
//        {
//            return this.contactName;
//        }
//        set
//        {
//            this.contactName = value;
//        }
//    }
//    public string ContactAddress
//    {
//        get
//        {
//            return this.contactAddress;
//        }
//        set
//        {
//            this.contactAddress = value;
//        }
//    }
//    public string ContactPhone
//    {
//        get
//        {
//            return this.contactPhone;
//        }
//        set
//        {
//            this.contactPhone = value;
//        }
//    }
//}

#endregion

