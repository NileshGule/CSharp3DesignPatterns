using System;

namespace DecoratorDesignPattern
{
    public class BorderedPhoto : IPhoto
    {
        private readonly IPhoto _photo;

        private readonly string _borderColor;

        public BorderedPhoto(IPhoto photo, string borderColor)
        {
            _photo = photo;

            _borderColor = borderColor;
        }

        public void Draw()
        {
            Console.WriteLine();

            Console.WriteLine("From Bordered photo draw");

            _photo.Draw();

            Console.WriteLine("This photo is bordered with {0} color.", _borderColor);
        }
    }
}