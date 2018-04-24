using System;

namespace mgSoft.DataLayer.Core.Attributes
{
    /// <summary>
    /// Class TableAttribute.  This attribute can be used to decorate a class and identify the table properties for
    /// the data contract.  This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class TableAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableAttribute" /> class.
        /// </summary>
        /// <param name="name">The name of the table which maps to the decorated class.</param>
        public TableAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets the name of the table which maps to the decorated class.
        /// </summary>
        /// <value>The name of the table which maps to the decorated class.</value>
        public string Name { get; set; }
    }
}
