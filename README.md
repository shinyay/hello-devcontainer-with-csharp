# Hello Dev Containers with C#

## Description

## Demo/Tutorial

### Blazor App

#### Create a template for Blazor App

```shell
dotnet new blazor -n HelloBlazor
```

The following files are created:

```shell
HelloBlazor
├── appsettings.Development.json
├── appsettings.json
├── Components
│   ├── App.razor -----------------> Root Component
│   ├── _Imports.razor
│   ├── Layout ----------------------> Layout Components
│   │   ├── MainLayout.razor
│   │   ├── MainLayout.razor.css
│   │   ├── NavMenu.razor
│   │   └── NavMenu.razor.css
│   ├── Pages ----------------------> Page Components
│   │   ├── Counter.razor
│   │   ├── Error.razor
│   │   ├── Home.razor
│   │   └── Weather.razor
│   └── Routes.razor -----------------> Routing Configuration
├── HelloBlazor.csproj --------------> Project File
├── obj
│   ├── HelloBlazor.csproj.nuget.dgspec.json
│   ├── HelloBlazor.csproj.nuget.g.props
│   ├── HelloBlazor.csproj.nuget.g.targets
│   ├── project.assets.json
│   └── project.nuget.cache
├── Program.cs
├── Properties
│   └── launchSettings.json ---------> Launch Settings
└── wwwroot
    ├── app.css
    ├── bootstrap
    │   ├── bootstrap.min.css
    │   └── bootstrap.min.css.map
    └── favicon.png
```

#### Challenge Copilot 1

```razor
@* Display current dotnet runtime version *@
```

#### Challenge Copilot 2

Open `Pages/Counter.razor`.

And open Inline Copilot Chat with `Ctrl + i` and ask the following question:

```plaintext
/explain Explain what the code does.
```

## Features

- feature:1
- feature:2

## Requirement

## Usage

## Installation

## References

## Licence

Released under the [MIT license](https://gist.githubusercontent.com/shinyay/56e54ee4c0e22db8211e05e70a63247e/raw/f3ac65a05ed8c8ea70b653875ccac0c6dbc10ba1/LICENSE)

## Author

- github: <https://github.com/shinyay>
- twitter: <https://twitter.com/yanashin18618>
- mastodon: <https://mastodon.social/@yanashin>
