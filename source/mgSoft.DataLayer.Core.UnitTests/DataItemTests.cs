using System;
using System.Collections.Generic;
using System.Text;
using mgSoft.DataLayer.Core.UnitTests.Support;
using Moq;
using NUnit.Framework;

namespace mgSoft.DataLayer.Core.UnitTests
{
    public class DataItemTests
    {
        [Test]
        public void DataItemConstructorTest()
        {
            var testDataItem = new TestDataItem();
            Assert.IsInstanceOf<TestDataItem>(testDataItem);
            Assert.AreEqual(0, testDataItem.Id);
        }

        [Test]
        public void DataItemValueChangedFiresTest()
        {
            var testDataItem = new TestDataItem();
            var receivedPropertyChanges = new List<string>();
            testDataItem.ValueChanged += delegate(object sender, DataItemEventArgs args)
                {
                    receivedPropertyChanges.Add(args.PropertyName);
                };

            testDataItem.Id = 1;
            Assert.That(receivedPropertyChanges.Count == 1);
            Assert.That(receivedPropertyChanges[0] == nameof(testDataItem.Id));
        }

        [Test]
        public void DataItemValueChangedDoesNotFireTest()
        {
            var testDataItem = new TestDataItem();
            var receivedPropertyChanges = new List<string>();
            testDataItem.ValueChanged += delegate (object sender, DataItemEventArgs args)
            {
                receivedPropertyChanges.Add(args.PropertyName);
            };

            testDataItem.Id = 0;
            Assert.That(receivedPropertyChanges.Count == 0);
        }
    }
}
