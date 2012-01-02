namespace ProxyDesignPattern
{
    public class Program
    {
        public static void Main()
        {
            MySpaceBook me = new MySpaceBook();
            me.Add("Hello World");
            me.Add("Today I worked 18 hours.");

            MySpaceBook tom = new MySpaceBook();
            tom.Poke("Judith");
            tom.MessageFriend("Judith", "Poor you");
            tom.Add("Off to see the Lion King tonight");
        }
    }
}