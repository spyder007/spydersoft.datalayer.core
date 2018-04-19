using System;

namespace mgSoft.DataLayer.Core.Attributes
{
    /// <summary>
    /// Class IgnorePropertyAttribute. This attribute must be used to ignore a field for a DataItem.
    /// This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public sealed class IgnorePropertyAttribute : Attribute { }
}