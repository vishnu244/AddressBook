// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Welcom to Address Book Program!");

CreatingContacts contact = new CreatingContacts();



while (true)
{
    Console.WriteLine("Enter the number :\n1)creatingcontacts");
    int option = Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
        case 1:
            contact.Addperson();
            contact.output();
            break;
    }
}