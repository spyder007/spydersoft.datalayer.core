﻿using System;
using System.Collections.Generic;
using System.Text;
using spyderSoft.DataLayer.Core.UnitTests.Support;
using Moq;
using NUnit.Framework;

namespace spyderSoft.DataLayer.Core.UnitTests
{
    public class DataItemTests
    {
        [Test]
        public void DataItemConstructorTest()
        {
            var testDataItem = new TestDataItem();
            Assert.IsInstanceOf<TestDataItem>(testDataItem);
            Assert.That(testDataItem.Id, Is.EqualTo(0));
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
            Assert.That(receivedPropertyChanges.Count, Is.EqualTo(1));
            Assert.That(receivedPropertyChanges, Has.Member(nameof(testDataItem.Id)));
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
            Assert.That(receivedPropertyChanges, Is.Empty);
        }
    }
}
