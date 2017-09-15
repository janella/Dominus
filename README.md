# dominus
Web-based implementation of Dominion

## Requirements
* .NET Core 2.0

## How to run
Dominus is built as a .NET Core Web Application.

```
> cd project/Dominus.web

> dotnet restore

Restoring packages for D:\Dev\Dominus\project\Dominus.Web\Dominus.Web.csproj...
[...]
Restore completed in 1.82 sec for D:\Dev\Dominus\project\Dominus.Web\Dominus.Web.csproj.
  
> dotnet run

Using launch settings from D:\Dev\Dominus\project\Dominus.Web\Properties\launchSettings.json...
[...]
Hosting environment: Development
Content root path: D:\Dev\Dominus\project\Dominus.Web
Now listening on: http://localhost:51388
Application started. Press Ctrl+C to shut down.
```

Navigate to `http://loclahost:51388` on your browser (or whatever port the application is listening on above), and there's our site!
