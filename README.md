# AzureFunctionsInfo

> ⚡️ Information gathered on Azure Functions by executing Azure Functions ⚡️

Get information about available:

* `Assemblies` and their version
* `Types` and what `Assembly` they belong to

This project was created with [Azure Functions CLI](https://github.com/Azure/azure-functions-cli)

## [`Assemblies`](/Assemblies)

> Get information about available `Assemblies` and their version

https://azurefunctionsinfo.azurewebsites.net/api/Assemblies

`curl https://azurefunctionsinfo.azurewebsites.net/api/Assemblies`

> 148 assemblies found

```json
[
    "Anonymously Hosted DynamicMethods Assembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "App_global.asax, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Autofac, Version=4.2.1.0, Culture=neutral, PublicKeyToken=17863af14b0044da",
    "Autofac.Integration.WebApi, Version=4.0.0.0, Culture=neutral, PublicKeyToken=17863af14b0044da",
    "easyauthshim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "edge_nativeclr, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "EdgeJs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "EnvSettings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "f-Assemblies__-347757627, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "f-Assemblies__-730094651, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "FSharp.Core, Version=4.4.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "f-Type__1608557509, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "f-Type__1990894533, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.AI.ServerTelemetryChannel, Version=2.3.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.ApplicationInsights, Version=2.3.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Common, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.Azure, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.Bitbucket, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.Dropbox, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.DynamicsCRM, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.Generic, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.GitHub, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.MailChimp, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.Pusher, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.Salesforce, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.Slack, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.Stripe, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.Trello, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNet.WebHooks.Receivers.WordPress, Version=1.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNetCore.Cryptography.Internal, Version=1.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.DataProtection, Version=1.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.DataProtection.Abstractions, Version=1.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Hosting.Abstractions, Version=1.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.WebUtilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Azure.ApiHub.Sdk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.AppService.Authentication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.Documents.Client, Version=1.11.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.NotificationHubs, Version=2.16.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs.Extensions, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.ApiHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.BotFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.DocumentDB, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.Http, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.MobileApps, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.NotificationHubs, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.SendGrid, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.Twilio, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Host, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs.Logging, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs.Logging.ApplicationInsights, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs.Script, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Script.Extensibility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Script.WebHost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.ServiceBus, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebSites.DataProtection, Version=0.1.6.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Bot.Connector.DirectLine, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Build.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "Microsoft.Build.Utilities.v4.0, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "Microsoft.CodeAnalysis, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.CodeAnalysis.CSharp, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.CodeAnalysis.CSharp.Scripting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.CodeAnalysis.Scripting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "Microsoft.Data.Edm, Version=5.8.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Data.OData, Version=5.8.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Data.Services.Client, Version=5.8.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Extensions.DependencyInjection, Version=1.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.DependencyInjection.Abstractions, Version=1.1.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging, Version=1.1.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.Abstractions, Version=1.1.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Options, Version=1.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.IdentityModel.Logging, Version=1.1.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.IdentityModel.Tokens, Version=5.1.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.JScript, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "Microsoft.ServiceBus, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.ServiceBus.Messaging.EventProcessorHost, Version=0.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.VisualBasic.Activities.Compiler, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "Microsoft.Web.Hosting.Tracing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.WindowsAzure.Mobile, Version=3.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.WindowsAzure.Storage, Version=7.2.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed",
    "ScriptHost, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "ScriptHost, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "SendGrid, Version=8.0.5.0, Culture=neutral, PublicKeyToken=4f047e93159395ca",
    "SMDiagnostics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Collections, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.Concurrent, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.Immutable, Version=1.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel.DataAnnotations, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Data.SqlXml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Diagnostics.Tracing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.EnterpriseServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Globalization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IdentityModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.IdentityModel.Tokens.Jwt, Version=5.1.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.IO.Abstractions, Version=2.0.0.140, Culture=neutral, PublicKeyToken=null",
    "System.IO.FileSystem, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Linq.Expressions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Http.Formatting, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Reactive.Core, Version=3.0.3000.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reactive.Interfaces, Version=3.0.1000.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reactive.Linq, Version=3.0.3000.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reflection, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Metadata, Version=1.4.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Primitives, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Caching, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.DurableInstancing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Runtime.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Handles, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.InteropServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Security.Cryptography.Algorithms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.ServiceModel.Activation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.ServiceModel.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.ServiceModel.Internals, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Text.Encoding, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Tasks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Tasks.Dataflow, Version=4.5.24.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Transactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.ValueTuple, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Web.ApplicationServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Web.Http, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Web.Http.WebHost, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Web.Services, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Xaml.Hosting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "Twilio.Api, Version=3.4.1.0, Culture=neutral, PublicKeyToken=null"
]
```

Docs:

* [Importing namespaces](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-csharp#importing-namespaces)
* [Referencing External Assemblies](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-csharp#referencing-external-assemblies)

## [`Type`](/Type)

> Get information about available `Types` and what `Assembly` they belong to

## FullName

Query by:

> The fully qualified name of the type, including its namespace but not its assembly

https://azurefunctionsinfo.azurewebsites.net/api/Type?FullName={FullName}

`curl https://azurefunctionsinfo.azurewebsites.net/api/Type?FullName={FullName}`

Example: https://azurefunctionsinfo.azurewebsites.net/api/Type?FullName=System.Net.Http.HttpRequestMessageExtensions

> System.Net.Http.HttpRequestMessageExtensions was found in 2 assemblies

```json
[
    "System.Net.Http.Formatting, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Web.Http, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
]
```

## Name

Query by:

> The simple name of the type

https://azurefunctionsinfo.azurewebsites.net/api/Type?Name={Name}

`curl https://azurefunctionsinfo.azurewebsites.net/api/Type?Name={Name}`

Example: https://azurefunctionsinfo.azurewebsites.net/api/Type?Name=TraceWriter

> TraceWriter matched 2 types

```json
[
    {
        "Type": "Microsoft.Azure.WebJobs.Host.TraceWriter",
        "Assembly": "Microsoft.Azure.WebJobs.Host, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    },
    {
        "Type": "System.Diagnostics.EventSchemaTraceListener+TraceWriter",
        "Assembly": "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
    }
]
```
