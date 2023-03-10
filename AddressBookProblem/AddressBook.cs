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
        List<Contact> contactList = new List<Contact>();
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
            contactList.Add(contact);


        }
        public void display()
        {
            Console.WriteLine(".........");
            Console.WriteLine("contact datails" + "\n" + "FirstName:" + contact.FirstName + "\n" + "LastName:" + contact.LastName + "\n" + "Address:" + contact.Address + "\n" + "city:" + contact.City + "\n" + "state:" + contact.State + "\n" + "PhoneNumber:" + contact.PhoneNumber + "\n" + "Zip:" + contact.Zip + "\n" + "Email:" + contact.Email);
        }
        public void EditContact(string name)
        {
            foreach (var contact in contactList)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("1:First name\n2:Last name\n3:Address\n4:City\n5:State\n6:Phone number\n7:Zip code\n8:Email Id");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter new first name");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter new last name");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter new address");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter new city");
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter new state");
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter new phone number");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter new Zip code");
                            Contact.zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter new email id");
                            contact.Email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Please chosse correct option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The contact is not found");
                }
            }
        }
        public void DeleteContact(string name)
        {
            Contact deleteContact = new Contact();
            foreach (var contact in contactList.ToList())
            {
                if (contact.FirstName.Equals(name))
                {
                    deleteContact = contact;
                }
                contactList.Remove(deleteContact);
            }
            Console.WriteLine("The contact is deleted successfully");
        }
    }
}
           
        
    

