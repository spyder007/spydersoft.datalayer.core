using System;

namespace spyderSoft.DataLayer.Core.Attributes
{
    /// <summary>
    /// Class ColumnNameAttribute.  This attribute can be applied to a Property or Field and define the column name in the database table
    /// to which that Property or Field is to be mapped. This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public sealed class ColumnNameAttribute
        : Attribute
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnNameAttribute" /> class.
        /// </summary>
        /// <param name="name">The name of the database column to which the property should be mapped.</param>
        public ColumnNameAttribute(string name)
        {
            Name = name;
        }

        #endregion Constructor

        #region Public Properties

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        /// <value>The name of the database column to which the property should be mapped.</value>
        public string Name { get; set; }

        #endregion Public Properties
    }
}
