namespace BridgeDesignPattern
{
    public interface IBridge
    {
        void Add(string message);

        void MessageFriend(string friendName, string message);

        void Poke(string who);
    }
}