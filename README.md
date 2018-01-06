# AzureFunctionsInfo

> ⚡️ Information gathered on Azure Functions by executing Azure Functions ⚡️

Get information about available:

* `Assemblies` and their version
* `Types` and what `Assembly` they belong to

This information is available on two runtimes:

* Azure Functions v1 (.NET Framework)
* Azure Functions v2 (.NET Core)

This project was created with [Azure Functions Tools for Visual Studio](https://docs.microsoft.com/en-us/azure/azure-functions/functions-develop-vs)

## Assemblies

> Get information about available `Assemblies` and their version

* Azure Functions v1 (.NET Framework): https://azurefunctionsinfov1.azurewebsites.net/api/Assemblies
* Azure Functions v2 (.NET Core): https://azurefunctionsinfov2.azurewebsites.net/api/Assemblies

Docs:

* [Importing namespaces](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-csharp#importing-namespaces)
* [Referencing External Assemblies](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-csharp#referencing-external-assemblies)

#### Azure Functions v1 (.NET Framework)

> 126 assemblies found

```json
[
    "Anonymously Hosted DynamicMethods Assembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "App_global.asax, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Autofac, Version=4.2.1.0, Culture=neutral, PublicKeyToken=17863af14b0044da",
    "Autofac.Integration.WebApi, Version=4.0.0.0, Culture=neutral, PublicKeyToken=17863af14b0044da",
    "AzureFunctionsInfoV1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "easyauthshim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "EnvSettings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AI.ServerTelemetryChannel, Version=2.4.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.ApplicationInsights, Version=2.4.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
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
    "Microsoft.Azure.AppService.Proxy.Common, Version=0.3.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.Documents.ChangeFeedProcessor, Version=1.14.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.Documents.Client, Version=1.13.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.NotificationHubs, Version=2.16.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs.Extensions, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.ApiHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.BotFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.DocumentDB, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.EventGrid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.Http, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.MobileApps, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.NotificationHubs, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.SendGrid, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.Twilio, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Host, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs.Logging, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs.Logging.ApplicationInsights, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebJobs.Script, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Script.WebHost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.ServiceBus, Version=2.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Azure.WebSites.DataProtection, Version=0.1.6.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Bot.Connector.DirectLine, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Build.Utilities.v4.0, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "Microsoft.CodeAnalysis, Version=2.3.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.CodeAnalysis.Scripting, Version=2.3.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
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
    "Microsoft.Practices.EnterpriseLibrary.TransientFaultHandling, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Rest.ClientRuntime, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.ServiceBus, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.ServiceBus.Messaging.EventProcessorHost, Version=0.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Web.Hosting.Tracing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Web.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.WindowsAzure.Mobile, Version=3.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.WindowsAzure.Storage, Version=7.2.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed",
    "ScriptHost, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "SendGrid, Version=8.0.5.0, Culture=neutral, PublicKeyToken=4f047e93159395ca",
    "SMDiagnostics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Collections, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.Concurrent, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.Immutable, Version=1.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel.DataAnnotations, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Diagnostics.Tracing, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Globalization, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IdentityModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.IdentityModel.Tokens.Jwt, Version=5.1.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.IO.Abstractions, Version=2.0.0.140, Culture=neutral, PublicKeyToken=null",
    "System.Linq, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Linq.Expressions, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Management.Automation, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Net.Http, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Http.Formatting, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Reactive.Core, Version=3.0.3000.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reactive.Interfaces, Version=3.0.1000.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reactive.Linq, Version=3.0.3000.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reflection, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Caching, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Extensions, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.ServiceModel.Activation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.ServiceModel.Internals, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Spatial, Version=5.8.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Threading, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Tasks, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Tasks.Dataflow, Version=4.5.24.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Web.ApplicationServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Web.Http, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Web.Http.WebHost, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "Twilio.Api, Version=3.4.1.0, Culture=neutral, PublicKeyToken=null"
]
```

#### Azure Functions v2 (.NET Core)

> 201 assemblies found

```json
[
    "Anonymously Hosted DynamicMethods Assembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Autofac, Version=4.0.0.0, Culture=neutral, PublicKeyToken=17863af14b0044da",
    "Autofac.Extensions.DependencyInjection, Version=4.2.0.0, Culture=neutral, PublicKeyToken=17863af14b0044da",
    "AzureFunctionsInfoV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
    "FSharp.Core, Version=4.4.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "Google.Protobuf, Version=3.3.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604",
    "Grpc.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d754f35622e28bad",
    "Microsoft.ApplicationInsights, Version=2.4.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.AspNetCore, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Antiforgery, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Authentication, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Authentication.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Authentication.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Authentication.JwtBearer, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Authorization, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Authorization.Policy, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Cors, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Cryptography.Internal, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.DataProtection, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.DataProtection.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Diagnostics, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Diagnostics.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Hosting, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Hosting.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Hosting.Server.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Html.Abstractions, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Http, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Http.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Http.Extensions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Http.Features, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.HttpOverrides, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.JsonPatch, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.ApiExplorer, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.Cors, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.DataAnnotations, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.Formatters.Json, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.Formatters.Xml, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.Razor, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.Razor.Extensions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.RazorPages, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.TagHelpers, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.ViewFeatures, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Mvc.WebApiCompatShim, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Razor, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Razor.Language, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Razor.Runtime, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Routing, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Routing.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.IISIntegration, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.Kestrel, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.Kestrel.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.Kestrel.Transport.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.SpaServices, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.WebUtilities, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Azure.AppService.Proxy.Client.Contract, Version=0.3.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Extensions.Http, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Host, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Logging, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Logging.ApplicationInsights, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Script, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Script.Grpc, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Script.WebHost, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebJobs.Script.WebHost.PrecompiledViews, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Azure.WebSites.DataProtection, Version=0.1.6.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Build, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "Microsoft.CodeAnalysis, Version=2.4.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.CodeAnalysis.CSharp, Version=2.4.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.CodeAnalysis.Razor, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.CodeAnalysis.Scripting, Version=2.4.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Extensions.Caching.Abstractions, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Caching.Memory, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.Abstractions, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.Binder, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.CommandLine, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.EnvironmentVariables, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.FileExtensions, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.Json, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.DependencyInjection, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.DependencyInjection.Abstractions, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.DependencyModel, Version=2.0.3.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.FileProviders.Abstractions, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.FileProviders.Physical, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.FileSystemGlobbing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Hosting.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Identity.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Localization.Abstractions, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.Abstractions, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.Configuration, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.Console, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.Debug, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.ObjectPool, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Options, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Options.ConfigurationExtensions, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Primitives, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.WebEncoders, Version=2.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.IdentityModel.Logging, Version=1.1.4.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.IdentityModel.Protocols.OpenIdConnect, Version=2.1.4.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.IdentityModel.Tokens, Version=5.1.4.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "Microsoft.Net.Http.Headers, Version=2.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Win32.Registry, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "Microsoft.WindowsAzure.Storage, Version=8.6.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "Newtonsoft.Json, Version=10.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed",
    "NuGet.Common, Version=4.4.0.3, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "NuGet.LibraryModel, Version=4.4.0.3, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "NuGet.ProjectModel, Version=4.4.0.3, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "NuGet.Versioning, Version=4.4.0.3, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "ScriptHost, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "ScriptHost, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "System.AppContext, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Buffers, Version=4.0.2.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Collections, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.Concurrent, Version=4.0.14.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.Immutable, Version=1.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.NonGeneric, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.Specialized, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel.Annotations, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel.Primitives, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel.TypeConverter, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Console, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Diagnostics.Debug, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Diagnostics.DiagnosticSource, Version=4.0.2.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Diagnostics.Process, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Diagnostics.StackTrace, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Diagnostics.TraceSource, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Diagnostics.Tracing, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Drawing.Primitives, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Dynamic.Runtime, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Globalization, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IdentityModel.Tokens.Jwt, Version=5.1.4.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.IO, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IO.Abstractions, Version=2.1.0.175, Culture=neutral, PublicKeyToken=96bf224d23c43e59",
    "System.IO.Compression, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
    "System.IO.FileSystem, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IO.FileSystem.Primitives, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IO.FileSystem.Watcher, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Linq, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Linq.Expressions, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Http, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Primitives, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Requests, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Numerics.Vectors, Version=4.1.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ObjectModel, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e",
    "System.Private.DataContractSerialization, Version=4.1.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Private.Uri, Version=4.0.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Private.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Private.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Reactive.Core, Version=3.0.6000.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reactive.Interfaces, Version=3.0.0.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reactive.Linq, Version=3.0.3000.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reactive.PlatformServices, Version=3.0.6000.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263",
    "System.Reflection, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Emit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Emit.ILGeneration, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Emit.Lightweight, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Extensions, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Metadata, Version=1.4.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Primitives, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Resources.ResourceManager, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.CompilerServices.Unsafe, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Extensions, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Handles, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.InteropServices, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.InteropServices.RuntimeInformation, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Loader, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Numerics, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Serialization.Formatters, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Serialization.Primitives, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Serialization.Xml, Version=4.1.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Security.AccessControl, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Security.Claims, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Security.Cryptography.Algorithms, Version=4.3.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Security.Cryptography.Primitives, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Security.Cryptography.X509Certificates, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Security.Principal, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Text.Encoding, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Text.Encoding.Extensions, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Text.Encodings.Web, Version=4.0.2.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Text.RegularExpressions, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Overlapped, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Tasks, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Tasks.Dataflow, Version=4.6.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Thread, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.ThreadPool, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Timer, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Xml.ReaderWriter, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Xml.XDocument, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Xml.XPath.XDocument, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
]
```

## Type

> Get information about available `Types` and what `Assembly` they belong to

### FullName

Query by:

> The fully qualified name of the type, including its namespace but not its assembly

* Azure Functions v1 (.NET Framework): https://azurefunctionsinfov1.azurewebsites.net/api/Type?FullName={FullName}
* Azure Functions v2 (.NET Core): https://azurefunctionsinfov2.azurewebsites.net/api/Type?FullName={FullName}

#### Azure Functions v1 (.NET Framework)

Example: https://azurefunctionsinfov1.azurewebsites.net/api/Type?FullName=System.Net.Http.HttpRequestMessageExtensions

> System.Net.Http.HttpRequestMessageExtensions was found in 2 assemblies

```json
[
    "System.Net.Http.Formatting, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
    "System.Web.Http, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
]
```

#### Azure Functions v2 (.NET Core)

Example: https://azurefunctionsinfov2.azurewebsites.net/api/Type?FullName=Microsoft.Azure.WebJobs.Extensions.Http.HttpRequestExtensions

> Microsoft.Azure.WebJobs.Extensions.Http.HttpRequestExtensions was found in 1 assemblies

```json
[
    "Microsoft.Azure.WebJobs.Extensions.Http, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null"
]
```

### Name

Query by:

> The simple name of the type

* Azure Functions v1 (.NET Framework): https://azurefunctionsinfov1.azurewebsites.net/api/Type?Name={Name}
* Azure Functions v2 (.NET Core): https://azurefunctionsinfov2.azurewebsites.net/api/Type?Name={Name}

#### Azure Functions v1 (.NET Framework)

Example: https://azurefunctionsinfov1.azurewebsites.net/api/Type?Name=TraceWriter

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

#### Azure Functions v2 (.NET Core)

Example: https://azurefunctionsinfov2.azurewebsites.net/api/Type?Name=TraceWriter

> TraceWriter matched 1 types

```json
[
    {
        "type": "Microsoft.Azure.WebJobs.Host.TraceWriter",
        "assembly": "Microsoft.Azure.WebJobs.Host, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null"
    }
]
```
