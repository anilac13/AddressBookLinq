using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class AddressBookMain
    {
        public void TopRecords(List<Contacts> contacts)
        {
            var result = (from contact in contacts
                          orderby contact.FirstName descending
                          select contact);
            foreach (var data in result)
            {
                Console.WriteLine($"FirstName:- {data.FirstName} \t LastName:- {data.LastName} \t Address:- {data.Address} \t City:- {data.City}" +
                    $"\t State:- {data.State} \t ZIP:- {data.ZIP} \t PhoneNumber:- {data.PhoneNumber} \t Email:- {data.Email}");
            }
        }
        public void SkipRecords(List<Contacts> contacts)
        {
            var skipRecords = (from records in contacts
                               orderby records.FirstName descending
                               select records).Skip(3);
            foreach (var data in skipRecords)
            {
                Console.WriteLine($"FirstName:- {data.FirstName} \t LastName:- {data.LastName} \t Address:- {data.Address} \t City:- {data.City}" +
                    $"\t State:- {data.State} \t ZIP:- {data.ZIP} \t PhoneNumber:- {data.PhoneNumber} \t Email:- {data.Email}");
            }
        }
        public void GetRecords(List<Contacts> contacts)
        {
            var records = (from contact in contacts
                           select contact);
            foreach (var data in records)
            {
                Console.WriteLine($"FirstName:- {data.FirstName} \t LastName:- {data.LastName} " +
                    $"\t PhoneNumber:- {data.PhoneNumber}");
            }
        }
    }
}
