namespace DecoratorDesignPattern
{
    public class Program
    {
        public static void Main()
        {
            IPhoto photo = new Photo();

            string tag = "Singapore";

            TaggedPhoto taggedPhoto = new TaggedPhoto(photo, tag);

            BorderedPhoto secondTaggedPhoto = new BorderedPhoto(taggedPhoto, "Red");

            secondTaggedPhoto.Draw();
        }
    }
}