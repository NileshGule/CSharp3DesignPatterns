using System;
using System.Collections.Generic;

namespace ProxyDesignPattern
{
    public class SpaceBook
    {
        private const string GAP = "\n\t\t\t\t";

        private static readonly SortedList<string, SpaceBook> Community = new SortedList<string, SpaceBook>(100);

        private readonly string _name;

        private string _pages;

        public SpaceBook(string name)
        {
            _name = name;

            Community[name] = this;
        }

        public static bool IsUnique(string name)
        {
            return Community.ContainsKey(name);
        }

        public void Add(string name)
        {
            _pages += GAP + name;

            Console.WriteLine(GAP + "=====" + _name + "'s Spacebook =====");

            Console.WriteLine(_pages);

            Console.WriteLine(GAP + "==========");
        }

        public void MessageFriend(string friendName, string message)
        {
            Community[friendName].Add(message);
        }

        public void Poke(string who, string friend)
        {
            Community[who]._pages += GAP + friend + " poked you.";
        }
    }
}