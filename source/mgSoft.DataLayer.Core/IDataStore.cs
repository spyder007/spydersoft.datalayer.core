using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace mgSoft.DataLayer.Core
{
    /// <summary>
    /// The generic interface that defines the functionality of a DataStore.
    /// A Data Store is the mechanism by which data can be retrieved from a data base, 
    /// be it an XML file, SQL Server Database, Oracle Database, SQLite database, etc.
    /// </summary>
    public interface IDataStore
    {
        /// <summary>
        /// Gets or sets the means by which a connection can be made to a data base.
        /// In some cases a File Path, in Others a Connection string.
        /// </summary>
        /// <value>The data store path.</value>
        string DataStorePath { get; set; }

        /// <summary>
        /// Takes a predicate that has been built dynamically and resolves all variables.
        /// </summary>
        /// <typeparam name="TDataContract">The type of the Data Item</typeparam>
        /// <param name="predicate">the expression to resolve</param>
        /// <returns>Expression&lt;Func&lt;TDataContract, System.Boolean&gt;&gt;.</returns>
        Expression<Func<TDataContract, bool>> FixDynamicExpression<TDataContract>
            (Expression<Func<TDataContract, bool>> predicate) where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Gets Item TDataContract using the Id of the item
        /// </summary>
        /// <typeparam name="TDataContract">Type of item</typeparam>
        /// <param name="key">Key of the item</param>
        /// <returns>Item of type TDataContract</returns>
        TDataContract GetItem<TDataContract>(long key) where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Gets all Items of type TDataContract
        /// </summary>
        /// <typeparam name="TDataContract">Type of item</typeparam>
        /// <returns>List of items of type TDataContract, or <c>null</c> if the collection is empty.</returns>
        IEnumerable<TDataContract> GetItems<TDataContract>() where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Gets the items queryable.
        /// </summary>
        /// <typeparam name="TDataContract">The type of the t data contract.</typeparam>
        /// <returns>IQueryable&lt;TDataContract&gt;.</returns>
        IQueryable<TDataContract> GetItemsQueryable<TDataContract>() where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Gets all items of type TDataContract skipping the number of items specified by skip then taking the number of
        /// items specified by take.
        /// </summary>
        /// <typeparam name="TDataContract">Type of the item.</typeparam>
        /// <param name="skip">The number of items to skip before taking items to return.</param>
        /// <param name="take">The number of items to take or return.</param>
        /// <returns>List of items of type TDataContract, or <c>null</c> if the collection is empty.</returns>
        IEnumerable<TDataContract> GetItems<TDataContract>(int skip, int take) where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Gets All items of type TDataContract using a LINQ predicate
        /// </summary>
        /// <typeparam name="TDataContract">Type of item</typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <returns>List of items of type TDataContract, or <c>null</c> if the collection is empty.</returns>
        IEnumerable<TDataContract> GetItems<TDataContract>(Expression<Func<TDataContract, bool>> predicate) where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Gets all items of type TDataContract using a LINQ predicate skipping the number of items specified by <paramref name="skip"/> 
        /// then taking the number of items specified by <paramref name="take"/>.
        /// </summary>
        /// <typeparam name="TDataContract">Type of item</typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <param name="skip">The number of items to skip before taking items to return.</param>
        /// <param name="take">The number of items to take or return.</param>
        /// <returns>List of items of type TDataContract, or <c>null</c> if the collection is empty.</returns>
        IEnumerable<TDataContract> GetItems<TDataContract>(Expression<Func<TDataContract, bool>> predicate, int skip, int take) where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Gets the count of all items of type TDataContract
        /// </summary>
        /// <typeparam name="TDataContract">Type of item</typeparam>
        /// <returns>Count of items</returns>
        int GetItemsCount<TDataContract>() where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Gets the count of all items of type TDataContract matching LINQ predicate
        /// </summary>
        /// <typeparam name="TDataContract">Type of item</typeparam>
        /// <param name="predicate">query predicate</param>
        /// <returns>Count of items</returns>
        int GetItemsCount<TDataContract>(Expression<Func<TDataContract, bool>> predicate) where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Save the item of type TDataContract
        /// </summary>
        /// <typeparam name="TDataContract">Type of item</typeparam>
        /// <param name="itemToSave">item to be saved</param>
        /// <returns>TDataContract.</returns>
        TDataContract SaveItem<TDataContract>(TDataContract itemToSave) where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Save the list of items of type TDataContract
        /// </summary>
        /// <typeparam name="TDataContract">Type of item</typeparam>
        /// <param name="itemsToSave">List of items to be saved</param>
        /// <returns>IEnumerable&lt;TDataContract&gt;.</returns>
        IEnumerable<TDataContract> SaveItems<TDataContract>(IEnumerable<TDataContract> itemsToSave) where TDataContract : class, IDataItem, new();

        /// <summary>
        /// Delete the item of type <see cref="T:DataItem"/>.
        /// </summary>
        /// <param name="itemToDelete">Item to be deleted</param>
        void DeleteItem(IDataItem itemToDelete);

        /// <summary>
        /// Delete a list of <see cref="T:DataItem"/> items.
        /// </summary>
        /// <param name="itemsToDelete">List of items to be deleted</param>
        void DeleteItems(IEnumerable<IDataItem> itemsToDelete);
    }
}
