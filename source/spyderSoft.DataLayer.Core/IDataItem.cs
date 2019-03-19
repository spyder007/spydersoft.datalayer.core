using System;

namespace spyderSoft.DataLayer.Core
{
    /// <summary>
    /// Defines the basic interface of a DataItem or data contract.
    /// </summary>
    public interface IDataItem
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        long Id { get; }

        /// <summary>
        /// An event which is raised when the value of a property is updated
        /// </summary>
        event EventHandler<DataItemEventArgs> ValueChanged;
    }
}
