namespace BridgeDesignPattern
{
    internal class Program
    {
        private static void Main()
        {
            Portal me = new Portal(new MyOpenBook("Judith"));
            me.Add("Hello World");
            me.Add("Today I worked 18 hours.");

            Portal tom = new Portal(new MyOpenBook("Tom"));
            tom.Poke("Judith-1");
            tom.MessageFriend("Judith-1", "Poor You");
            tom.Add("Hey, I'm on OpenBook - it's cool");
        }
    }
}