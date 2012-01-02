using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DecoratorDesignPattern
{
    internal class TaggedPhoto : IPhoto
    {
        private readonly IPhoto _photo;

        private IList<string> _tags = new List<string>();

        public TaggedPhoto(IPhoto photo, string tag)
        {
            _photo = photo;

            _tags.Add(tag);
        }

        public ReadOnlyCollection<string> Tags
        {
            get
            {
                return new ReadOnlyCollection<string>(_tags);
            }
        }

        public void Draw()
        {
            Console.WriteLine();

            Console.WriteLine("From Tagged photo draw");

            _photo.Draw();

            Console.WriteLine("Tags for photo ");

            foreach (string tag in _tags)
            {
                Console.WriteLine(tag);
            }
        }
    }
}