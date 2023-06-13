using System;
namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contacts> contacts = new List<Contacts>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Create Address book \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contacts.Add(new Contacts { FirstName = "James", LastName = "Cameron", Address = "USA", City = "Mexico", State = "US", ZIP = "032145", PhoneNumber = "7890654321", Email = "james@email.com" });
                        contacts.Add(new Contacts { FirstName = "Jeevan", LastName = "Kumar", Address = "KR pura", City = "Bengaluru", State = "Karnataka", ZIP = "560054", PhoneNumber = "9065478321", Email = "jeevan@email.com" });
                        contacts.Add(new Contacts { FirstName = "Veena", LastName = "Kumari", Address = "Marathalli", City = "Bengaluru", State = "Karnataka", ZIP = "560065", PhoneNumber = "8906543217", Email = "veena@email.com" });
                        contacts.Add(new Contacts { FirstName = "Nan", LastName = "jeeva", Address = "Kadugodi", City = "Bengaluru", State = "Karnataka", ZIP = "560068", PhoneNumber = "7890632154", Email = "nan@email.com" });
                        contacts.Add(new Contacts { FirstName = "Soma", LastName = "Shekar", Address = "KGF", City = "Kolar", State = "Karnataka", ZIP = "563123", PhoneNumber = "7890165432", Email = "somu@email.com" });
                        foreach (var data in contacts)
                        {
                            Console.WriteLine($"FirstName:- {data.FirstName} \t LastName:- {data.LastName} \t Address:- {data.Address} \t City:- {data.City}" +
                                $"\t State:- {data.State} \t ZIP:- {data.ZIP} \t PhoneNumber:- {data.PhoneNumber} \t Email:- {data.Email}");
                        }
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}