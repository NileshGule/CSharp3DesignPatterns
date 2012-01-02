namespace BridgeDesignPattern
{
    public class Portal
    {
        private IBridge _bridge;

        public Portal(IBridge bridge)
        {
            _bridge = bridge;
        }

        public void Add(string message)
        {
            _bridge.Add(message);
        }

        public void MessageFriend(string friendName, string message)
        {
            _bridge.MessageFriend(friendName, message);
        }

        public void Poke(string who)
        {
            _bridge.Poke(who);
        }
    }
}