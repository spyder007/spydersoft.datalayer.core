using System;
using System.Collections.Generic;
using System.Text;

namespace spyderSoft.DataLayer.Core.UnitTests.Support
{
    public class TestDataItem : DataItem
    {
        private long _id;

        public override long Id
        {
            get => _id;
            set => SetPropertyField(nameof(Id), ref _id, value);
        }
    }
}
