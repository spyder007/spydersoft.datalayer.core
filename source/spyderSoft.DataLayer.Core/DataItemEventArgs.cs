using System.ComponentModel;

namespace spyderSoft.DataLayer.Core
{
    /// <summary>
    ///     Event arguments used by a Data Item when a property value has been modified.
    /// </summary>
    public class DataItemEventArgs
        : PropertyChangedEventArgs
    {
        /// <summary>
        /// Overrides the base class <see cref="T:PropertyChangedEventArgs"/> by accepting a field ID
        /// and a property name. The property name is passed on to the base class.
        /// </summary>
        /// <param name="propertyName">The name of the property that has changed</param>
        public DataItemEventArgs(string propertyName)
            : base(propertyName)
        {
        }
    }
}
