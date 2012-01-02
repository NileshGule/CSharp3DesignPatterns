using System;

namespace DecoratorDesignPattern
{
    public class Photo : IPhoto
    {
        private string _photoName;

        public Photo()
        {
            _photoName = "base photo";
        }

        public void Draw()
        {
            Console.WriteLine();

            Console.WriteLine("From Photo draw");

            Console.WriteLine("Photo name : {0}", _photoName);
        }
    }
}