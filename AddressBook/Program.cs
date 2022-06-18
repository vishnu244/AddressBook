// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Welcom to Address Book Program!");

CreatingContacts contact = new CreatingContacts();
AddressBookRepo repo = new AddressBookRepo();


while (true)
{
    Console.WriteLine("\nEnter the number :\n1)Creatingcontacts\n2)Edit Details\n3)Remove Contacts\n4)Adding multiple contacts\n5)Output Details\n6)Adding Unique Contacts\n7)Display unique contacts" +
        "\n8)Search Person by city or State\n9)Count Persons by city or State\n10)Contacts by city using Dictionary\n11)Contacts by State using Dictionary\n12)Sorting Details By FirstName\n13)Sorting " +
        "Details By State\n14)Sorting Details By City\n15)Sorting Details By Zip\n16)Write File Using FileIO\n17)Append File Using FileIO\n18)Read File Using FileIO\n19)Updating Contacts to Json File\n20)" +
        "Reading Contacts from Json File\n21)Write in CSV file\n22)Read from CSV file\n23)Retreiving Details From AddressBook \n24)Display of PersonDetail\n25)Display of Address_Book\n26)Display of PersonTypes" +
        "\n27)Display of PersonsDetail_Type\n28)Display of Employee_Department\n29)Update Employe details(state)\n30)Added a New Column to PersonDeatils Table\n31)Get details of an Empoloyee in particular DateRange"); 
    int option = Convert.ToInt32(Console.ReadLine());


    switch(option)
    {
        case 1:
            contact.Contacts();
            break;
        case 2:
            contact.EditContacts();
            break;
        case 3:
            contact.RemoveContact();
            break;
        case 4:
            Console.WriteLine("Enter the number of contacts you want");
            int n = Convert.ToInt32(Console.ReadLine());
            contact.Addmultiplepersons(n);
            break;
        case 5:
            contact.output();
            break;
        case 6:
            contact.Adduniquecontacts();           
            break;
        case 7:
            contact.DisplayUniqueContacts();
            break;
        case 8:
            contact.SearchByCityState();
            break;
        case 9:
            contact.CountByCityState();
            break;
        case 10:
            contact.ContactsBycity_dictionary();
            contact.DisplayContactsByCities_Dictionary();
            break;
        case 11:
            contact.ContactsBystate_dictionary();
            contact.DisplayContactsByState_dictionary();
            break;
        case 12:
            contact.SortingDetailsByName();
            break;
        case 13:
            Console.WriteLine("Sorting details by City");
            contact.SortingDetailsByCity();
            break;
        case 14:
            Console.WriteLine("Sorting details by State");
            contact.SortingDetailsByState();
            break;
        case 15:
            Console.WriteLine("Sorting details by Zip");
            contact.SortingDetailsByZip();
            break;
        case 16:
            contact.WriteInFileIO();
            break;
        case 17:
            contact.AppendInFileIO();
            break;
        case 18:
            contact.ReadFileIO();
            break;
        case 19:
            contact.WriteJson();
            break;
        case 20:
            contact.ReadJsonFile();
            break;
        case 21:
            contact.WriteCsvFile();
            break;
        case 22:
            contact.ReadCsvFile();
            break;
        case 23:
            Console.WriteLine("Display of AddressBook");          
            repo.GetAllContactOf_AddressBook();
            Console.WriteLine("*********************************************************");
            break;
        case 24:
            Console.WriteLine("Display of PersonDetail");
            repo.GetAllContactOf_PersonDetail();
            Console.WriteLine("*********************************************************");
            break;
        case 25:
            Console.WriteLine("Display of Address_Book");
            repo.GetAllContactOf_Address_Book();
            Console.WriteLine("*********************************************************");
            break;
        case 26:
            Console.WriteLine("Display of PersonTypes");
            repo.GetAllContactOf_PersonTypes();
            Console.WriteLine("*********************************************************");
            break;
        case 27:
            Console.WriteLine("Display of PersonsDetail_Type");
            repo.GetAllContactOf_PersonsDetail_Type();
            Console.WriteLine("*********************************************************");
            break;
        case 28:
            Console.WriteLine("Display of Employee_Department");
            repo.GetAllContactOf_Employee_Department();
            Console.WriteLine("*********************************************************");
            break;
        case 29:
            string state = repo.updateEmployeeDetails();
            Console.WriteLine("upadated State = " + state);
            break;
        case 30:
            repo.AddColumn_date_added();
            Console.WriteLine("Column Added");
            break;
        case 31:
            repo.GetDetails_in_DateRange();
            //Console.WriteLine("Column Added");
            break;

    }
}