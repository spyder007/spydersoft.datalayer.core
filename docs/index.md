# Spydersoft.DataLayer.Core

## Purpose

This class library provides the basic interfaces and classes necessary to support a storage-agnostic data layer with observable data items. 

The main interfaces are [IDataItem](xref:spyderSoft.DataLayer.Core.IDataItem) and [IDataStore](xref:spyderSoft.DataLayer.Core.IDataStore), with the latter providing the contract for CRUD operations on the former.  [DataItem](xref:spyderSoft.DataLayer.Core.DataItem) is a basic implementation of [IDataItem](xref:spyderSoft.DataLayer.Core.IDataItem) which provides functions to raise the [ValueChanged](xref:spyderSoft.DataLayer.Core.DataItem.ValueChanged) event in derived classes.

The [IDataItem](xref:spyderSoft.DataLayer.Core.Attributes) namespace provides ORM-agnostic attributes for marking up instances of [IDataItem](xref:spyderSoft.DataLayer.Core.IDataItem) for [IDataStore](xref:spyderSoft.DataLayer.Core.IDataStore) instances to use for data store initialization and CRUD operations.

## Examples

[spydersoft.datalayer.core.entityframework](https://github.com/spyder007/spydersoft.datalayer.core.entityframework) is an implementation of [IDataStore](xref:spyderSoft.DataLayer.Core.IDataStore) which utilizes EntityFramework.Core for CRUD operations on a SQL database.  Ideas for additional implementations include implementations for SQLite, couchDB, MongoDB, or even basic file-based JSON or XML storage.