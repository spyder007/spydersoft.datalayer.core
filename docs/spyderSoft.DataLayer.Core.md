## `DataItem`

Class DataItem.
```csharp
public abstract class spyderSoft.DataLayer.Core.DataItem
    : IDataItem

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Int64` | Id | Gets or sets the identifier. | 


Events

| Type | Name | Summary | 
| --- | --- | --- | 
| `EventHandler<DataItemEventArgs>` | ValueChanged | An event which is raised when the value of a property is updated | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | RaiseValueChanged(`Expression<Func<TPropertyReturnType>>` propertyExpression) | Raises the [spyderSoft.DataLayer.Core.DataItem.ValueChanged](spyderSoft.DataLayer.Core.DataItem#valuechanged) event using the name from the given property expression. | 
| `void` | RaiseValueChanged(`String` propertyName) | Raises the [spyderSoft.DataLayer.Core.DataItem.ValueChanged](spyderSoft.DataLayer.Core.DataItem#valuechanged) event using the name from the given property expression. | 
| `void` | SetPropertyField(`String` propertyName, `T&` field, `T` newValue) |  | 


Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | GetPropertyName(`Expression<Func<T>>` propertyExpression) | Gets the name of the property. | 


## `DataItemEventArgs`

Event arguments used by a Data Item when a property value has been modified.
```csharp
public class spyderSoft.DataLayer.Core.DataItemEventArgs
    : PropertyChangedEventArgs

```

## `IDataItem`

Defines the basic interface of a DataItem or data contract.
```csharp
public interface spyderSoft.DataLayer.Core.IDataItem

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Int64` | Id | Gets the identifier. | 


Events

| Type | Name | Summary | 
| --- | --- | --- | 
| `EventHandler<DataItemEventArgs>` | ValueChanged | An event which is raised when the value of a property is updated | 


## `IDataStore`

The generic interface that defines the functionality of a DataStore.  A Data Store is the mechanism by which data can be retrieved from a data base,  be it an XML file, SQL Server Database, Oracle Database, SQLite database, etc.
```csharp
public interface spyderSoft.DataLayer.Core.IDataStore

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | DataStorePath | Gets or sets the means by which a connection can be made to a data base.  In some cases a File Path, in Others a Connection string. | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | DeleteItem(`IDataItem` itemToDelete) | Delete the item of type `DataItem`. | 
| `void` | DeleteItems(`IEnumerable<IDataItem>` itemsToDelete) | Delete a list of `DataItem` items. | 
| `Expression<Func<TDataContract, Boolean>>` | FixDynamicExpression(`Expression<Func<TDataContract, Boolean>>` predicate) | Takes a predicate that has been built dynamically and resolves all variables. | 
| `TDataContract` | GetItem(`Int64` key) | Gets Item TDataContract using the Id of the item | 
| `IEnumerable<TDataContract>` | GetItems() | Gets all Items of type TDataContract | 
| `IEnumerable<TDataContract>` | GetItems(`Int32` skip, `Int32` take) | Gets all Items of type TDataContract | 
| `IEnumerable<TDataContract>` | GetItems(`Expression<Func<TDataContract, Boolean>>` predicate) | Gets all Items of type TDataContract | 
| `IEnumerable<TDataContract>` | GetItems(`Expression<Func<TDataContract, Boolean>>` predicate, `Int32` skip, `Int32` take) | Gets all Items of type TDataContract | 
| `Int32` | GetItemsCount() | Gets the count of all items of type TDataContract | 
| `Int32` | GetItemsCount(`Expression<Func<TDataContract, Boolean>>` predicate) | Gets the count of all items of type TDataContract | 
| `IQueryable<TDataContract>` | GetItemsQueryable() | Gets the items queryable. | 
| `TDataContract` | SaveItem(`TDataContract` itemToSave) | Save the item of type TDataContract | 
| `IEnumerable<TDataContract>` | SaveItems(`IEnumerable<TDataContract>` itemsToSave) | Save the list of items of type TDataContract | 


