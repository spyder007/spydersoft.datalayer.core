## `ColumnNameAttribute`

Class ColumnNameAttribute.  This attribute can be applied to a Property or Field and define the column name in the database table  to which that Property or Field is to be mapped. This class cannot be inherited.
```csharp
public class spyderSoft.DataLayer.Core.Attributes.ColumnNameAttribute
    : Attribute, _Attribute

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Name | Gets or sets the name | 


## `IgnorePropertyAttribute`

Class IgnorePropertyAttribute. This attribute must be used to ignore a field for a DataItem.  This class cannot be inherited.
```csharp
public class spyderSoft.DataLayer.Core.Attributes.IgnorePropertyAttribute
    : Attribute, _Attribute

```

## `KeyAttribute`

Class KeyAttribute. This attribute must be used to identify the key field for a DataItem.  This class cannot be inherited.
```csharp
public class spyderSoft.DataLayer.Core.Attributes.KeyAttribute
    : Attribute, _Attribute

```

## `TableAttribute`

Class TableAttribute.  This attribute can be used to decorate a class and identify the table properties for  the data contract.  This class cannot be inherited.
```csharp
public class spyderSoft.DataLayer.Core.Attributes.TableAttribute
    : Attribute, _Attribute

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Name | Gets or sets the name of the table which maps to the decorated class. | 


