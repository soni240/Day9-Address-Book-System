﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook

{
    internal class Program
    {
        public static object Sample { get; private set; } 

        static void Main(string[] args)
        {


            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":

                    Sample.AddrBook.GetCustomer();
                    Sample.AddrBook.ListingPeople();
                    break;

                case "2":
                    Sample.AddrBook.GetCustomer();
                    Sample.AddrBook.Modify();
                    Sample.AddrBook.ListingPeople();
                    break;

                case "3":
                    Sample.AddrBook.GetCustomer();
                    Sample.AddrBook.ListingPeople();
                    break;

                case "4":

                    Sample.AddrBook.GetCustomer();
                    Sample.AddrBook.RemovePeople();
                    

                   break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }


        }
    }
}

