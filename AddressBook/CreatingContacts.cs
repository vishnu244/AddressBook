using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreatingContacts
    {
        List<contacts> People = new List<contacts> ();


        public void Contacts()
        {
            contacts contact = new contacts();

            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address : ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter Zip : ");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter State : ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Enter Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("\n");

            People.Add(contact);
            
        }


        public void edit()
        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.FirstName == null)
                {
                    Console.WriteLine("Contact for {0} count not be found.", name);
                }
                else if (data.FirstName == name)
                {
                    Console.WriteLine("choose the option to change the data : \n1) firstName\n2)lastName\n3)address\n4)City\n5)State\n6)Zip\n7)Email\n8)Phone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the first name : ");
                            string firstName = Console.ReadLine();
                            data.FirstName = firstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the last name : ");
                            string lastName = Console.ReadLine();
                            data.LastName = lastName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Address : ");
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Please enter the city : ");
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Please enter the state : ");
                            string State = Console.ReadLine();
                            data.State = State;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the zip Code : ");
                            string Zip = Console.ReadLine();
                            data.Zip = Zip;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the Email : ");
                            string Email = Console.ReadLine();
                            data.Email = Email;
                            break;
                        case 8:
                            Console.WriteLine("Please enter the Phone Number : ");
                            string PhoneNumber = Console.ReadLine();
                            data.PhoneNumber = PhoneNumber;
                            break;
                        default:
                            Console.WriteLine(" Wrong input,please choose from above options :");
                            break;
                    }

                }

            }
        }


        public void output()
        {
            foreach (var data in People)
            {

                Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                Console.WriteLine("Email ID : " + data.Email);
                Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                Console.WriteLine("City : " + data.City);
                Console.WriteLine("State : " + data.State);
                Console.WriteLine("Zip : " + data.Zip);
                Console.WriteLine("Address : " + data.Address);
                Console.WriteLine("\n");

            }
            
        }
    }
}
