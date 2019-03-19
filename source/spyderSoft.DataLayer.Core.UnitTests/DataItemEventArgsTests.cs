using NUnit.Framework;

namespace spyderSoft.DataLayer.Core.UnitTests
{
    public class DataItemEventArgsTests
    {
        [Test]
        [TestCase("MyProperty")]
        [TestCase("Another Property Name")]
        public void DataItemConstructorTest(string propertyName)
        {
            var eventArgs = new DataItemEventArgs(propertyName);
            Assert.IsInstanceOf<DataItemEventArgs>(eventArgs);
            Assert.AreEqual(propertyName, eventArgs.PropertyName);
        }
    }
}