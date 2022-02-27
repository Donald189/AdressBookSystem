using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class EditPersonDetails
    {
        public void editUserDetails()
        {
            string firstName;
            string lastName;
            string address;
            string city;
            string state;
            int pinCode;
            long phoneNumber;
            string email;

            Console.WriteLine("Edit your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Edit your last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Edit your address:");
            address = Console.ReadLine();
            Console.WriteLine("Edit your city:");
            city = Console.ReadLine();
            Console.WriteLine("Edit your state:");
            state = Console.ReadLine();
            Console.WriteLine("Edit zip code:");
            pinCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Edit phone number:");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Edit your email:");
            email = Console.ReadLine();

            Console.WriteLine("Dear " + firstName + " " + lastName + " your details have been updated!");

        }
    }
}
