﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public Contact(string firstName, string lastName, string email, string phoneNumber, string address, string zip, string city, string state)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.zip = zip;
            this.city = city;
            this.state = state;
        }

        public string toString()
        {
            return "first Name=" + firstName + ",last name=" + lastName + ",email=" + email + ",phone number=" + phoneNumber + ",address=" + address + ",zip=" + zip + ",city=" + city + ",state=" + state;
        }
    }
}
