using System;

namespace spyderSoft.DataLayer.Core.Attributes
{
    /// <summary>
    /// Class KeyAttribute. This attribute must be used to identify the key field for a DataItem.  
    /// This class cannot be inherited.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public sealed class KeyAttribute : Attribute { }
}
