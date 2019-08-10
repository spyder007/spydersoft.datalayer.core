# Spydersoft.Datalayer.Core

## Purpose

This class library provides the basic interfaces and classes necessary to support a storage-agnostic data layer with observable data items. 

The main interfaces are **IDataItem** and **IDataStore**, with the latter providing the contract for CRUD operations on the former.  **DataItem** is a basic implementation of **IDataItem** which provides functions to raise the **ValueChanged** event in derived classes.

The **Attributes** namespace provides ORM-agnostic attributes for marking up instances of **IDataItem** for **IDataStore** instances to use for data store initialization and CRUD operations.

## Examples

[spydersoft.datalayer.core.entityframework](https://github.com/spyder007/spydersoft.datalayer.core.entityframework) is an implementation of **IDataStore** which utilizes EntityFramework.Core for CRUD operations on a SQL database.  Ideas for additional implementations include implementations for SQLite, couchDB, MongoDB, or even basic file-based JSON or XML storage.

## Object documentation

Generated object documentation for this library can be found in the repository's [documentation](docs/).