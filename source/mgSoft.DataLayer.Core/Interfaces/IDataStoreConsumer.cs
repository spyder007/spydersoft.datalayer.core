using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mgSoft.DataLayer.Core.Interfaces
{
    /// <summary>
    /// Interface IDataStoreConsumer.  Implement this interface to support injection of the DataStore into the class.
    /// </summary>
    public interface IDataStoreConsumer
    {
        /// <summary>
        /// Sets the data store.
        /// </summary>
        /// <param name="store">The store.</param>
        void SetDataStore(IDataStore store);
    }
}
