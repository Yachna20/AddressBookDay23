﻿namespace AddressBookDay23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address BOOK Program");
            AddressBook ad = new AddressBook();
            Console.WriteLine("Enter Number Of Contact To Add");
            int Contact = Convert.ToInt32(Console.ReadLine());
            while (Contact > 0)
            {
                Console.WriteLine("Enter FirstName");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter LastName");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter City");
                string City = Console.ReadLine();
                Console.WriteLine("Enter State");
                string State = Console.ReadLine();
                Console.WriteLine("Enter Zip");
                int Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Eamil");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter PhoneNumber");
                long PhoneNum = Convert.ToInt64(Console.ReadLine());
                ad.CreateContact(FirstName, LastName, Address, City, State, Email, Zip, PhoneNum);
                Contact--;
            }
            Console.WriteLine("Do YOu Want To MOdify(Y/N)");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'Y' || ch == 'y')
            {
                ad.EditContact();
            }
        }
        public void DisplayContacts(AddressBook[] ContactArray, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Name {0} {1}", ContactArray[i].FirstName, ContactArray[i].LastName);
                Console.WriteLine("Address : {0}", ContactArray[i].Address);
                Console.WriteLine("City :{0}", ContactArray[i].City);
                Console.WriteLine("State : {0}", ContactArray[i].State);
                Console.WriteLine("Email :{0}", ContactArray[i].Email);
                Console.WriteLine("Zip :{0}", ContactArray[i].Zip);
                Console.WriteLine("Phone :{0}", ContactArray[i].PhoneNum);
            }
        }
    }
}


