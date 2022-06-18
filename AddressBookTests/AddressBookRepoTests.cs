using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Tests
{
    [TestClass()]
    public class AddressBookRepoTests
    {
        AddressBookRepo repo = new AddressBookRepo();
        [TestMethod()]

        public void GetAllContactOf_AddressBookTest()
        {
            Console.WriteLine("Display of AddressBook");
            repo.GetAllContactOf_AddressBook();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_PersonDetailTest()
        {
            Console.WriteLine("Display of PersonDetail");
            repo.GetAllContactOf_PersonDetail();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_Address_BookTest()
        {
            Console.WriteLine("Display of Address_Book");
            repo.GetAllContactOf_Address_Book();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_PersonTypesTest()
        {
            Console.WriteLine("Display of PersonTypes");
            repo.GetAllContactOf_PersonTypes();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_PersonsDetail_TypeTest()
        {
            Console.WriteLine("Display of PersonsDetail_Type");
            repo.GetAllContactOf_PersonsDetail_Type();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_Employee_DepartmentTest()
        {
            Console.WriteLine("Display of Employee_Department");
            repo.GetAllContactOf_Employee_Department();
            Console.WriteLine("*********************************************************");
        }
    }
}