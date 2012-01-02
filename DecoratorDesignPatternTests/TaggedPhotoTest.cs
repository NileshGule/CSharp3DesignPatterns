using DecoratorDesignPattern;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorDesignPatternTests
{
    [TestClass]
    public class TaggedPhotoTest
    {
        [TestMethod]
        public void SingleTagTest()
        {
            IPhoto photo = new Photo();

            string tag = "Singapore";

            TaggedPhoto taggedPhoto = new TaggedPhoto(photo, tag);

            taggedPhoto.Draw();

            Assert.AreEqual(1, taggedPhoto.Tags.Count);
            Assert.AreEqual("Singapore", taggedPhoto.Tags[0]);
        }

        [TestMethod]
        public void MultipleTagTest()
        {
            IPhoto photo = new Photo();

            string tag = "Singapore";

            TaggedPhoto taggedPhoto = new TaggedPhoto(photo, tag);

            TaggedPhoto secondTaggedPhoto = new TaggedPhoto(taggedPhoto, "India");
            taggedPhoto.Draw();

            Assert.AreEqual(1, secondTaggedPhoto.Tags.Count);
            Assert.AreEqual("Singapore", secondTaggedPhoto.Tags[0]);
        }
    }
}