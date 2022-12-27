namespace AddressBookDay23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address BOOK Program");
            AddressBook add = new AddressBook("Yachna", "Thakre", "GajananColony", "Gondia", "Maharashtra", "thakreyachna20@gmail.com", 4400011, 8989036339);
            add.DisplayContacts();
        }
    }
}

