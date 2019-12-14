# AzureFunctionsInfo

[![Build status](https://ci.appveyor.com/api/projects/status/jflnn0l4437y4cs3?svg=true)](https://ci.appveyor.com/project/hlaueriksson/azurefunctionsinfo)

> Information gathered on Azure Functions by executing Azure Functions

![Azure Functions Logo](https://raw.githubusercontent.com/Azure/azure-functions-cli/master/src/Azure.Functions.Cli/npm/assets/azure-functions-logo-color-raster.png)

Get information about available:

* `Assemblies` and their version
* `Types` and what `Assembly` they belong to

This information is available on three runtimes:

* [Azure Functions v1 (.NET Framework)](v1.md)
* [Azure Functions v2 (.NET Core)](v2.md)
* [Azure Functions v3 (.NET Core)](v3.md)

This project was created with [Azure Functions Tools for Visual Studio](https://docs.microsoft.com/en-us/azure/azure-functions/functions-develop-vs)

When is this useful?

* If you are using [C# script](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-csharp), and want to know what assembly to reference.
* If you are using [precompiled functions](https://docs.microsoft.com/en-us/azure/azure-functions/functions-dotnet-class-library), and want to know what NuGet package to depend on.
* If you are writing a multi-targeted library for Azure Functions, and want to know what assembly versions to depend on.

## Assemblies

> Get information about available `Assemblies` and their version

* Azure Functions v1 (.NET Framework): https://azurefunctionsinfov1.azurewebsites.net/api/Assemblies
* Azure Functions v2 (.NET Core): https://azurefunctionsinfov2.azurewebsites.net/api/Assemblies
* Azure Functions v3 (.NET Core): https://azurefunctionsinfov3.azurewebsites.net/api/Assemblies

## Type

> Get information about available `Types` and what `Assembly` they belong to

### FullName

Query by:

> The fully qualified name of the type, including its namespace but not its assembly

* Azure Functions v1 (.NET Framework): https://azurefunctionsinfov1.azurewebsites.net/api/Type?FullName={FullName}
* Azure Functions v2 (.NET Core): https://azurefunctionsinfov2.azurewebsites.net/api/Type?FullName={FullName}
* Azure Functions v3 (.NET Core): https://azurefunctionsinfov3.azurewebsites.net/api/Type?FullName={FullName}

### Name

Query by:

> The simple name of the type

* Azure Functions v1 (.NET Framework): https://azurefunctionsinfov1.azurewebsites.net/api/Type?Name={Name}
* Azure Functions v2 (.NET Core): https://azurefunctionsinfov2.azurewebsites.net/api/Type?Name={Name}
* Azure Functions v3 (.NET Core): https://azurefunctionsinfov3.azurewebsites.net/api/Type?Name={Name}

## Azure Functions Core Tools

If you are using [Azure Functions Core Tools](https://github.com/Azure/azure-functions-core-tools) these links may come in handy when working with assemblies, namespaces and types:

* [Importing namespaces](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-csharp#importing-namespaces)
* [Referencing External Assemblies](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-csharp#referencing-external-assemblies)
* [Using NuGet packages](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-csharp#using-nuget-packages)
