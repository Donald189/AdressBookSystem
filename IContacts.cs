using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    interface IContacts
    {
        public void addContact(string firstName, string lastName, string email, string phoneNumber, string address, string zip, string city, String state);
        public void Edit(string Name);
        public void Remove(string name);
    }
}
