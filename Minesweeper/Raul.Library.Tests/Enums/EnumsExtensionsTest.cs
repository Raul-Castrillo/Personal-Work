using NUnit.Framework;

namespace Raul.Library.Tests.Enums
{
    [TestFixture]
    public class EnumsExtensionsTest
    {
        [Test]
        public void GetEnumDescriptionTest()
        {
            var enumString = EnumTest.Enum1.GetDescription();
            Assert.AreEqual("String 1", enumString);
        }
    }
}
