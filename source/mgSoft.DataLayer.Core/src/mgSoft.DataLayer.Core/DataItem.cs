﻿using System;
using System.Linq.Expressions;
using System.Reflection;

namespace mgSoft.DataLayer.Core
{
    /// <summary>
    /// Class DataItem.
    /// </summary>
    public abstract class DataItem : IDataItem
    {
        #region IDataItem Implementation

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public abstract long Id { get; set; }

        /// <summary>
        /// An event which is raised when the value of a property is updated
        /// </summary>
        public event EventHandler<DataItemEventArgs> ValueChanged;

        #endregion IDataItem Implementation

        #region RaiseValueChanged Protected Methods

        /// <summary>
        /// Raises the <see cref="ValueChanged"/> event using the name from the given property expression. 
        /// </summary>
        /// <typeparam name="TPropertyReturnType">When using this method the PropertyReturnType specified must be the same as the type of the property that is changing</typeparam>
        /// <param name="propertyExpression">An expression representing the property whose value has changed.</param>
        protected virtual void RaiseValueChanged<TPropertyReturnType>(Expression<Func<TPropertyReturnType>> propertyExpression)
        {
            var handler = ValueChanged;
            if (handler != null)
            {
                var propertyName = GetPropertyName(propertyExpression);
                handler(this, new DataItemEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Raises the <see cref="ValueChanged"/> event using the <paramref name="propertyName"/> given.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void RaiseValueChanged(string propertyName)
        {
            var handler = ValueChanged;
            if (handler != null)
            {
                handler(this, new DataItemEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyExpression">The property expression.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.ArgumentNullException">propertyExpression</exception>
        /// <exception cref="System.ArgumentException">
        /// Invalid argument;propertyExpression
        /// or
        /// Argument is not a property;propertyExpression
        /// </exception>
        protected static string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
            {
                throw new ArgumentNullException("propertyExpression");
            }

            var body = propertyExpression.Body as MemberExpression;

            if (body == null)
            {
                throw new ArgumentException("Invalid argument", "propertyExpression");
            }

            var property = body.Member as PropertyInfo;

            if (property == null)
            {
                throw new ArgumentException("Argument is not a property", "propertyExpression");
            }

            return property.Name;
        }

        #endregion RaiseValueChanged Protected Methods
    }
}