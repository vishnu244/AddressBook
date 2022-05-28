// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Welcom to Address Book Program!");

CreatingContacts contact = new CreatingContacts();



while (true)
{

    Console.WriteLine("\nEnter the number :\n1)Creatingcontacts\n2)Edit Details\n3)Remove Contacts\n4)Adding multiple contacts\n5)Output Details\n6)Adding Unique Contacts\n7)Display unique contacts" +
        "\n8)Search Person by city or State\n9)Count Persons by city or State\n10)Contacts by city using Dictionary\n11)Contacts by State using Dictionary\n12)Sorting Details By FirstName\n13)Sorting " +
        "Details By State\n14)Sorting Details By City\n15)Sorting Details By Zip\n16)Write File Using FileIO\n17)Append File Using FileIO\n18)Read File Using FileIO\n19)Updating Contacts to Json File\n20)Reading Contacts from Json File");

    int option = Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
        case 1:
            contact.Contacts();
            break;
        case 2:
            contact.EditDetails();
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

    }
}