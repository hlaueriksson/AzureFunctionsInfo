# AzureFunctionsInfo

[![build](https://github.com/hlaueriksson/AzureFunctionsInfo/actions/workflows/build.yml/badge.svg)](https://github.com/hlaueriksson/AzureFunctionsInfo/actions/workflows/build.yml)

> Information gathered on Azure Functions by executing Azure Functions

![Azure Functions Logo](https://raw.githubusercontent.com/Azure/azure-functions-cli/master/src/Azure.Functions.Cli/npm/assets/azure-functions-logo-color-raster.png)

Get information about available:

* `Assemblies` and their version
* `Types` and what `Assembly` they belong to

This information is available for:

* [.NET 8.0 Isolated (Long-term support)](V8.md)

When is this useful?

* If you are writing libraries for Azure Functions, and want to know what assembly versions to depend on.

## Assemblies

> Get information about available `Assemblies` and their version

* https://azurefunctionsinfov8.azurewebsites.net/api/Assemblies

## Types

> Get information about available `Types` and what `Assembly` they belong to

### FullName

Query by:

> The fully qualified name of the type, including its namespace but not its assembly

* `https://azurefunctionsinfov8.azurewebsites.net/api/Types?FullName={FullName}`

### Name

Query by:

> The simple name of the type

* `https://azurefunctionsinfov8.azurewebsites.net/api/Types?Name={Name}`
