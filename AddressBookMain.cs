using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        int pinCode;
        long phone_number;
        string email;
        public void AddressBook()
        {
            firstName = "Donald";
            lastName = "JK";
            address = "4/119/4 Muthammal colony 5th Street";
            city = "Thoothukudi";
            state = "Tamilnadu";
            pinCode = 628002;
            phone_number = 8056446118;
            email = "donaldkarey@gmail.com";

            Console.WriteLine("FirstName: "+firstName+"\nLastName: "+lastName+"\nAdress: "+address+"\nCity: "+city+"\nState: "+state+"\nPinCode: "+pinCode+"\nPhoneNUmber: "+phone_number+"\nEmailId: "+email);
        }
        public void AddressBook(string name, string lastName, string address, string city, string state, int pinCode, long contact, string email)
        {
            firstName = name;
            lastName = lastName;
            address = address;
            city = city;
            state = state;
            pinCode = pinCode;
            phone_number = contact;
            email = email;
            Console.WriteLine("Hi " + firstName + " " + lastName + " your details have been saved");
        }
    }
}
