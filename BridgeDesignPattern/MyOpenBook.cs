using ProxyDesignPattern;

namespace BridgeDesignPattern
{
    public class MyOpenBook : IBridge
    {
        private readonly SpaceBook _mySpaceBook;
        private readonly string _name;
        private static int users;

        public MyOpenBook(string name)
        {
            _name = name;

            users++;

            _mySpaceBook = new SpaceBook(string.Format("{0}-{1}", _name, users));
        }

        public void Add(string message)
        {
            _mySpaceBook.Add(message);
        }

        public void MessageFriend(string friendName, string message)
        {
            _mySpaceBook.MessageFriend(friendName, string.Format("{0} said {1}", _name, message));
        }

        public void Poke(string who)
        {
            _mySpaceBook.Poke(who, _name);
        }
    }
}