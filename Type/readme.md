# Type

## FullName

https://azurefunctionsinfo.azurewebsites.net/api/Type?FullName={FullName}

`curl https://azurefunctionsinfo.azurewebsites.net/api/Type?FullName={FullName}`

Example: https://azurefunctionsinfo.azurewebsites.net/api/Type?FullName=System.Net.Http.HttpRequestMessageExtensions

> System.Net.Http.HttpRequestMessageExtensions was found in 2 assemblies

```json
[
  "System.Web.Http, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
  "System.Net.Http.Formatting, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
]
```

## Name

https://azurefunctionsinfo.azurewebsites.net/api/Type?Name={Name}

`curl https://azurefunctionsinfo.azurewebsites.net/api/Type?Name={Name}`

Example: https://azurefunctionsinfo.azurewebsites.net/api/Type?Name=TraceWriter

> TraceWriter matched 2 types

```json
[
  {
    "Type": "System.Diagnostics.EventSchemaTraceListener+TraceWriter",
    "Assembly": "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
  },
  {
    "Type": "Microsoft.Azure.WebJobs.Host.TraceWriter",
    "Assembly": "Microsoft.Azure.WebJobs.Host, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
  }
]
```
