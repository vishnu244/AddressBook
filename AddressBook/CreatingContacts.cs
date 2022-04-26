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
        contacts contact = new contacts();

        public void Addperson()
        {
            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            contact.Email = Console.ReadLine();
            
            Console.WriteLine("Enter Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();
        }

        public void output()
        {
            Console.WriteLine("Name of the Person : " + contact.FirstName + contact.LastName);
            Console.WriteLine("Email ID : " + contact.Email);
            Console.WriteLine("Mobile Number : " + contact.PhoneNumber);
        }
    }
}
