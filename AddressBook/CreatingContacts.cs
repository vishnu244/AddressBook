using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreatingContacts
    {
        public List<contacts> People = new List<contacts>();
        public Dictionary<string, List<contacts>> dict = new Dictionary<string, List<contacts>>();
        public Dictionary<string, List<contacts>> dictcity = new Dictionary<string, List<contacts>>();
        public Dictionary<string, List<contacts>> dictstate = new Dictionary<string, List<contacts>>();



        public void Contacts()
        {
            contacts contact = new contacts();

            int Flag = 0;
            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();


            string FirstNameToBeAdded = contact.FirstName;
            foreach (var data in People)
            {
                if (People.Exists(data => data.FirstName == FirstNameToBeAdded))
                {
                    Flag++;
                    Console.WriteLine("This FirstName already Exist! Can't take the Duplicate Record ");
                    break;
                }

            }
            if (Flag == 0)
            {

                Console.WriteLine("Enter Last Name : ");
                contact.LastName = Console.ReadLine();

                Console.WriteLine("Enter Email : ");
                contact.Email = Console.ReadLine();

                Console.WriteLine("Enter Phone Number : ");
                contact.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Address : ");
                contact.Address = Console.ReadLine();

                Console.WriteLine("Enter City : ");
                contact.City = Console.ReadLine();

                Console.WriteLine("Enter Zip : ");
                contact.Zip = Console.ReadLine();

                Console.WriteLine("Enter State : ");
                contact.State = Console.ReadLine();

                Console.WriteLine("\n");


            }

            People.Add(contact);
        }


        public void EditDetails()

        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.FirstName != name)
                {
                    Console.WriteLine("This contact doesn't exists");
                }
                else if (data.FirstName == name)
                {
                    Console.WriteLine("choose the option to change the data : \n1)FirstName\n2)LastName\n3)Email\n4)Phone Number\n5)Address\n6)City\n7)Zip\n8)State");

                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)

                    {
                        case 1:
                            Console.WriteLine("Please enter the First Name : ");
                            string firstName = Console.ReadLine();
                            data.FirstName = firstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the Last Name : ");
                            string lastName = Console.ReadLine();
                            data.LastName = lastName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Email : ");
                            string Email = Console.ReadLine();
                            data.Email = Email;
                            break;
                        case 4:
                            Console.WriteLine("Please enter the Phone Number : ");
                            string PhoneNumber = Console.ReadLine();
                            data.PhoneNumber = PhoneNumber;
                            break;
                        case 5:
                            Console.WriteLine("Please enter the Address : ");
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the City : ");
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the State : ");
                            string State = Console.ReadLine();
                            data.State = State;
                            break;
                        case 9:
                            Console.WriteLine("Please enter the Zip Code : ");
                            string Zip = Console.ReadLine();
                            data.Zip = Zip;
                            break;
                        default:
                            Console.WriteLine(" Wrong input,Please choose from above options : ");
                            break;
                    }

                }

            }

        }

        public void RemoveContact()
        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.FirstName == name)
                {
                    Console.WriteLine("given name contact exists");
                    People.Remove(data);

                    Console.WriteLine("contact deleted successfully");
                    return;
                }
                else
                {
                    Console.WriteLine("given contact doesn't found");
                }

            }
        }

        public void Addmultiplepersons(int n)
        {
            while (n > 0)
            {
                Contacts();
                n--;
            }

        }

        public void Adduniquecontacts()
        {
            Console.WriteLine("Enter the Firstname in your contactlist");

            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (People.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("This contact exists please enter an unique name to store this data");
                        string uniquename = Console.ReadLine();
                        if (dict.ContainsKey(uniquename))
                        {
                            Console.WriteLine("This unique name already exists");
                        }
                        dict.Add(uniquename, People);
                        return;
                    }
                }
            }
            Console.WriteLine("This contactlist doesn't exist, please creat a contactlist");
            return;

        }


        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter the Uniquename of your contacts");
            string name = Console.ReadLine();
            foreach (var contacts in dict)
            {
                //Console.WriteLine("The details of " + name + " are \n" + contacts.Value);
                if (contacts.Key.Contains(name))
                {
                    foreach (var contact in contacts.Value)
                    {
                        Console.WriteLine("The details of " + name + " are \n" + "Name: " + contact.FirstName + " " + contact.LastName + "\n" + "Email: " + contact.Email + "\n" +
                            "Phone Number: " + contact.PhoneNumber + "\n" + "Address: " + contact.Address + "\n" + "city: " + contact.City + "\n" + "Zip: " + contact.Zip + "\n" + "state: " + contact.State);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("this unique name doesn't exist");
                }
            }
            Console.WriteLine("This Uniquelist doesn't exist, please creat a Uniquelist");
        }

        public void RemoveContact()
        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            try
            {
                foreach (var data in People)
                {
                    if (People.Contains(data))
                    {
                        if (data.FirstName == name)
                        {
                            Console.WriteLine("given name contact exists");
                            People.Remove(data);

                            Console.WriteLine("contact deleted successfully");
                            return;
                        }
                    }
                }
                Console.WriteLine("given name contact does not exists");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void output()
        {
            foreach (var data in People)
            {
                Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                Console.WriteLine("Email ID : " + data.Email);
                Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                Console.WriteLine("Address : " + data.Address);
                Console.WriteLine("City : " + data.City);
                Console.WriteLine("Zip : " + data.Zip);

                Console.WriteLine("\n");

            }
        }


        
        public void SearchByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");

            string WantedCityOrState = Console.ReadLine();
            foreach (var data in People)
            {
                string actualcity = data.City;
                string actualState = data.State;
                if (People.Exists(data => (actualcity == WantedCityOrState || actualState == WantedCityOrState)))
                {
                        Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                        Console.WriteLine("Email ID : " + data.Email);
                        Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                        Console.WriteLine("Address : " + data.Address);
                        Console.WriteLine("City : " + data.City);
                        Console.WriteLine("State : " + data.State);
                        Console.WriteLine("Zip : " + data.Zip);
                        Console.WriteLine("\n");
                }

            }
        }

        public void CountByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");
            string WantedCityOrState = Console.ReadLine();

            int count = 0;
            foreach (var data in People)
            {
                string actualcity = data.City;
                string actualState = data.State;
                if (People.Exists(data => (actualcity == WantedCityOrState || actualState == WantedCityOrState)))
                {
                    count++;                   
                }
            }
            Console.WriteLine("There are {0} Persons in {1}:",count, WantedCityOrState);
        }


        public void ContactsBycity_dictionary()
        {
            try
            {
                var data = People.GroupBy(x => x.City);
                foreach (var cities in data)
                {
                    List<contacts> cityList = new List<contacts>();
                    foreach (var city in cities)
                    {
                        cityList.Add(city);
                    }
                    dictcity.Add(cities.Key, cityList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       
        public void ContactsBystate_dictionary()
        {
           
            try
            {
                var data = People.GroupBy(x => x.State);
                foreach (var states in data)
                {
                    List<contacts> Statelist = new List<contacts>();
                    foreach (var State in states)
                    {
                        Statelist.Add(State);
                    }
                    dictstate.Add(states.Key, Statelist);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void DisplayContactsByCities_Dictionary()
        {
            if (dictcity.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dictcity.Count >= 1)
            {
                foreach (KeyValuePair<string, List<contacts>> addressBooks in dictcity)
                {
                    Console.WriteLine("Contacts From City: " + addressBooks.Key);
                    foreach (contacts items in addressBooks.Value)
                    {
                        Console.WriteLine($"Name: {items.FirstName + " " + items.LastName}, Phone Number: {items.PhoneNumber}, City: {items.City}, State: {items.State}" +
                            $"\n Address: {items.Address}, Zipcode: {items.Zip}, Email: {items.Email}");
                        Console.WriteLine();
                    }
                }
            }
        }

        public void DisplayContactsByState_dictionary()
        {
            if (dictstate.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dictstate.Count >= 1)
            {
                foreach (KeyValuePair<string, List<contacts>> addressBooks in dictstate)
                {
                    Console.WriteLine("Contacts From State: " + addressBooks.Key);
                    foreach (contacts items in addressBooks.Value)
                    {
                        Console.WriteLine($"Name: {items.FirstName + " " + items.LastName}, Phone Number: {items.PhoneNumber}, City: {items.City}, State: {items.State}" +
                            $"\n Address: {items.Address}, Zipcode: {items.Zip}, Email: {items.Email}");
                        Console.WriteLine();
                    }
                }
            }
        }

        public void SortingDetailsByName()
        {
            //List<Contact> SortedList = new List<Contact>();
            //SortedList = People.OrderBy(s => s.firstName).ToList();
            foreach (var data in People.OrderBy(s => s.FirstName).ToList())
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("\n");
                }

            }
        }

        public void SortingDetailsByCity()
        {
            
            foreach (var data in People.OrderBy(s => s.City).ToList())
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("\n");
                }

            }
        }

        public void SortingDetailsByState()
        {

            foreach (var data in People.OrderBy(s => s.State).ToList())
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("\n");
                }

            }
        }

        public void SortingDetailsByZip()
        {

            foreach (var data in People.OrderBy(s => s.Zip).ToList())
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("\n");
                }

            }
        }

        string path = @"C:\Users\Admin\Desktop\Vishnu\AddressBook\AddressBook\example2.txt";

        public void WriteInFileIO()
        {
            using (TextWriter sw = File.CreateText(path))
            {
                foreach (contacts item in People)
                {
                    Console.WriteLine("Writing the details in .txt File");
                    Console.WriteLine("Details updated to the .txt file");
                    sw.WriteLine("FirstName :" + item.FirstName.ToString());
                    sw.WriteLine("lastName :" + item.LastName.ToString());
                    sw.WriteLine("Email ID :" + item.Email.ToString());
                    sw.WriteLine("Mobile Number :" + item.PhoneNumber.ToString());
                    sw.WriteLine("City  :" + item.City.ToString());
                    sw.WriteLine("State :" + item.State.ToString());
                    sw.WriteLine("ZIP :" + item.Zip.ToString());
                    Console.WriteLine("\n");

                }
            }
        }


        public void AppendInFileIO()
        {

            using (TextWriter Tw = File.AppendText(path)) 
            {
                foreach(contacts item in People)
                {
                    Console.WriteLine("Appending the new details to the Previous File");
                    Tw.WriteLine("FirstName :"+ item.FirstName.ToString());
                    Tw.WriteLine("lastName :" + item.LastName.ToString());
                    Tw.WriteLine("Email ID :" + item.Email.ToString());
                    Tw.WriteLine("Mobile Number :" + item.PhoneNumber.ToString());
                    Tw.WriteLine("City  :" + item.City.ToString());
                    Tw.WriteLine("State :" + item.State.ToString());
                    Tw.WriteLine("ZIP :" + item.Zip.ToString());
                    Console.WriteLine("\n");


                }
            }
        }

        

        public void ReadFileIO()
        {
            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine("Reading All the Text"+ lines);
        }


        public void WriteJson()
        {
            string json = @"C:\Users\Admin\Desktop\Vishnu\AddressBook\AddressBook\jsconfig1.json";
            foreach (contacts item in People)
            {
                string json1 = JsonConvert.SerializeObject(People);
                File.WriteAllText(json, json1);
            }
            Console.WriteLine("copied all data");
        }

        public void ReadJsonFile()
        {
            string json = @"C:\Users\Admin\Desktop\Vishnu\AddressBook\AddressBook\jsconfig1.json";
            string jsonData = File.ReadAllText(json);
            var jsonResult = JsonConvert.DeserializeObject<List<contacts>>(jsonData).ToList();
            Console.WriteLine("Reading from Json file");
            foreach (var data in jsonResult)
            {
                Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                Console.WriteLine("Email ID : " + data.Email);
                Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                Console.WriteLine("Address : " + data.Address);
                Console.WriteLine("City : " + data.City);
                Console.WriteLine("State : " + data.State);
                Console.WriteLine("Zip : " + data.Zip);
                Console.WriteLine("\n");
            }
        }


        public void WriteCsvFile()
        {
            string csvPath = @"C:\Users\Admin\Desktop\Vishnu\AddressBook\AddressBook\CSVfile.csv";
            StreamWriter tw = new (csvPath);
            using (var csvExport = new CsvWriter(tw, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(People);
            }
            Console.WriteLine("People List is saved as Csv file");

        }
        public void ReadCsvFile()
        {
            string csvPath = @"C:\Users\Admin\Desktop\Vishnu\AddressBook\AddressBook\CSVfile.csv";
            StreamReader sr = new (csvPath);
            CsvReader cr = new (sr, CultureInfo.InvariantCulture);
            List<contacts> readResult = cr.GetRecords<contacts>().ToList();
            Console.WriteLine("Reading from CSV file");
           
            foreach (var item in readResult)
            {
                Console.WriteLine(item.FirstName.ToString());
                Console.WriteLine(item.LastName.ToString());
                Console.WriteLine(item.Email.ToString());
                Console.WriteLine(item.PhoneNumber.ToString());
                Console.WriteLine(item.Address.ToString());
                Console.WriteLine(item.City.ToString());
                Console.WriteLine(item.State.ToString());
                Console.WriteLine(item.Zip.ToString());
            }
        }

    }

}
