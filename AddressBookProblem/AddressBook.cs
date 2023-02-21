using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBook
    {
        Contact contact = new Contact();
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Please add contact details");
            Console.WriteLine("Enter first name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter city");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter state");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter email id");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter zip code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            


        }
        public void display()
        {
            Console.WriteLine(".........");
            Console.WriteLine("contact datails" + "\n" + "FirstName:" + contact.FirstName + "\n" + "LastName:" + contact.LastName + "\n" + "Address:" + contact.Address + "\n" + "city:" + contact.City + "\n" + "state:" + contact.State + "\n" + "PhoneNumber:" + contact.PhoneNumber + "\n" + "Zip:" + contact.Zip + "\n" + "Email:" + contact.Email);
        }
    }
}
