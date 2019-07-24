using SnapsLibrary;

public class BasicContacts
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("My Contacts");

        string command = SnapsEngine.SelectFrom2Buttons("New Contact", "Find Contact");

        if (command == "New Contact")
        {
            NewContact();
        }
        else
        {
            FindContact();
        }
    }

    public void NewContact()
    {

        SnapsEngine.DisplayString("Enter the Contact");
        string name = SnapsEngine.ReadString("Enter new contact name");
        string address = SnapsEngine.ReadMultiLineString("Enter Contact Address");
        string phone = SnapsEngine.ReadString("Enter contact phone");

        StoreContact(name: name, address: address, phone: phone);

    }

    public void StoreContact(string name, string address, string phone)
    {

        name = TidyInput(name);

        //create a name to store the address
        SnapsEngine.SaveStringToLocalStorage(itemName: name + ":address", itemValue: address);

        //create a name to store the phonenumber
        SnapsEngine.SaveStringToLocalStorage(itemName: name + ":phone", itemValue: phone);


    }



    public void FindContact()
    {
        //get the name of contact to search for
        string name = SnapsEngine.ReadString("Enter contact name");

        // variable to hold the address and phone being returned
        string contactAddress;
        string contactPhone;

        if (FetchContact(name: name, address: out contactAddress, phone: out contactPhone) == true)
        {
            //got the contact details display them
            SnapsEngine.ClearTextDisplay();
            SnapsEngine.AddLineToTextDisplay("Name: " + name);
            SnapsEngine.AddLineToTextDisplay("Address: " + contactAddress);
            SnapsEngine.AddLineToTextDisplay("Phone: " + contactPhone);
        }

        else
        {
            SnapsEngine.DisplayString("Name not found");
        }

        SnapsEngine.WaitForButton("Continue");

        SnapsEngine.ClearTextDisplay();



    }

    

    public bool FetchContact(string name, out string address, out string phone)
    {

        name = TidyInput(name);
        address = SnapsEngine.FetchStringFromLocalStorage(itemName: name + ":address");
        phone = SnapsEngine.FetchStringFromLocalStorage(itemName: name + ":phone");

        if (address == null || phone == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    

    /// <summary>
    /// Alters the contact name for use in a search
    /// </summary>
    /// <param name="input">name to be tidied up</param>
    /// <returns>trimmed lowercase name</returns>
    public string TidyInput(string input)
    {
        input = input.Trim();
        input = input.ToLower();
        return input;
    }




}


