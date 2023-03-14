using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_16
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; }=new List<Contact>();

        private void DisplayContactDetalis(Contact contact)
        {
            Console.WriteLine($"Contact:{ contact.Name},{ contact.Number}");
        }

        private void DisplayContactsDeatlis(List<Contact> contacts) 
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetalis(contact);
            }

        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetalis(contact);
            }
        }

        public void DisplayAllContanct()
        {
            DisplayContactsDeatlis(_contacts);
        }

        public void DisplayMatchingContacts(string searchPharse)
        {
            var matchingContacts = _contacts.Where(c=>c.Name.Contains(searchPharse)).ToList();

            DisplayContactsDeatlis(matchingContacts);

        }

    }
}
