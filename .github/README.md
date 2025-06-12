# jcdcdev.Umbraco.PackageTemplate

[![License](https://img.shields.io/github/license/jcdcdev/jcdcdev.Umbraco.PackageTemplate?color=8AB803&label=License&logo=github)](https://github.com/jcdcdev/jcdcdev.Umbraco.PackageTemplate?tab=MIT-1-ov-file)
[![NuGet Downloads](https://img.shields.io/nuget/dt/jcdcdev.Umbraco.PackageTemplate?color=cc9900&label=Downloads&logo=nuget)](https://www.nuget.org/packages/jcdcdev.Umbraco.PackageTemplate)
[![Project Website](https://img.shields.io/badge/Project%20Website-jcdc.dev-jcdcdev?style=flat&color=3c4834&logo=data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxNiIgaGVpZ2h0PSIxNiIgZmlsbD0id2hpdGUiIGNsYXNzPSJiaSBiaS1wYy1kaXNwbGF5IiB2aWV3Qm94PSIwIDAgMTYgMTYiPgogIDxwYXRoIGQ9Ik04IDFhMSAxIDAgMCAxIDEtMWg2YTEgMSAwIDAgMSAxIDF2MTRhMSAxIDAgMCAxLTEgMUg5YTEgMSAwIDAgMS0xLTF6bTEgMTMuNWEuNS41IDAgMSAwIDEgMCAuNS41IDAgMCAwLTEgMG0yIDBhLjUuNSAwIDEgMCAxIDAgLjUuNSAwIDAgMC0xIDBNOS41IDFhLjUuNSAwIDAgMCAwIDFoNWEuNS41IDAgMCAwIDAtMXpNOSAzLjVhLjUuNSAwIDAgMCAuNS41aDVhLjUuNSAwIDAgMCAwLTFoLTVhLjUuNSAwIDAgMC0uNS41TTEuNSAyQTEuNSAxLjUgMCAwIDAgMCAzLjV2N0ExLjUgMS41IDAgMCAwIDEuNSAxMkg2djJoLS41YS41LjUgMCAwIDAgMCAxSDd2LTRIMS41YS41LjUgMCAwIDEtLjUtLjV2LTdhLjUuNSAwIDAgMSAuNS0uNUg3VjJ6Ii8+Cjwvc3ZnPg==)](https://jcdc.dev/umbraco-packages/package-template)


An opinionated template for creating Umbraco packages hosted on GitHub.

## Quick Start

### Prerequisites

1. A basic understanding of NuGet package development
    - A NuGet API key - [Create an API key](https://learn.microsoft.com/en-us/nuget/nuget-org/publish-a-package)
2. A git repository on GitHub
    - Your repository name must match the project name e.g. `Demo.Package`
    - [GitHub Action Secret](https://docs.github.com/en/actions/security-guides/using-secrets-in-github-actions) - `NUGET_API_KEY`
      with your NuGet API key

3. Install template

    ```powershell
    dotnet new install jcdcdev.Umbraco.PackageTemplate
    ```

### Create package

1. Create new project

    #### dotnet CLI

    ```powershell
    dotnet new jcdcdev-umb-package -o Demo.Package --ghUsername jcdcdev --title "My Demo Package" --description "An empty Umbraco package" --addClient    
    ```
   
   #### Visual Studio
    - Open Visual Studio
    - Create a new project
    - Search for `jcdcdev-umb-package`
    - Click `Next`
    - Fill in the project title, description, and other details
    - Click `Create`

2. Open project in your IDE
3. Build and run project
4. Congratulations! You have created an empty Umbraco package 🎉

Now you can implement your package features.

1. Update `README.md` with your package details
2. Update `umbraco-marketplace.json` with your package details

### Publish

1. Push your code to GitHub
2. Create a pull request into the `main` branch
3. Merge the pull request
4. A new release will be created

## Configuration

## Template Parameters

[Documentation](https://github.com/jcdcdev/jcdcdev.Umbraco.PackageTemplate?tab=readme-ov-file#template-parameters)


## Contributing

Contributions to this package are most welcome! Please visit the [Contributing](https://github.com/jcdcdev/jcdcdev.Umbraco.PackageTemplate/contribute) page.



