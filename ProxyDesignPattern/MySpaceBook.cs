using System;

namespace ProxyDesignPattern
{
    public class MySpaceBook
    {
        private SpaceBook mySpaceBook;

        private string password;

        private string name;

        private bool loggedIn;

        public void Add(string message)
        {
            Check();

            if (loggedIn)
            {
                mySpaceBook.Add(message);
            }
        }

        public void MessageFriend(string friendName, string message)
        {
            Check();

            if (loggedIn)
            {
                mySpaceBook.MessageFriend(friendName, string.Format("{0} said : {1}", name, message));
            }
        }

        public void Poke(string who)
        {
            Check();

            if (loggedIn)
            {
                mySpaceBook.Poke(who, name);
            }
        }

        private void Check()
        {
            if (loggedIn)
            {
                return;
            }

            if (password == null)
            {
                Register();
            }

            if (mySpaceBook == null)
            {
                Authenticate();
            }
        }

        private void Register()
        {
            Console.WriteLine("Lets register you for Spacebook...");

            do
            {
                Console.WriteLine("All Spacebook names must  be unique.");
                Console.WriteLine("Type in a username: ");

                name = Console.ReadLine();
            }
            while (SpaceBook.IsUnique(name));

            Console.WriteLine("Type in a password :");
            password = Console.ReadLine();

            Console.WriteLine("Thanks for registering with Spacebook.");
        }

        private bool Authenticate()
        {
            Console.WriteLine("Welcome {0}. Please type in your password.", name);

            string suppliedPassword = Console.ReadLine();

            if (suppliedPassword.Equals(password))
            {
                loggedIn = true;

                Console.WriteLine("Logged into Spacebook");

                if (mySpaceBook == null)
                {
                    mySpaceBook = new SpaceBook(name);
                }

                return true;
            }

            Console.WriteLine("Incorrect password");
            return false;
        }
    }
}