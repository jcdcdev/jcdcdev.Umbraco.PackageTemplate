# jcdcdev.Umbraco.PackageTemplate

[![NuGet](https://img.shields.io/nuget/vpre/jcdcdev.Umbraco.PackageTemplate?color=0273B3)](https://www.nuget.org/packages/jcdcdev.Umbraco.PackageTemplate)
[![GitHub license](https://img.shields.io/github/license/jcdcdev/jcdcdev.Umbraco.PackageTemplate?color=8AB803)](../LICENSE)
[![Downloads](https://img.shields.io/nuget/dt/jcdcdev.Umbraco.PackageTemplate?color=cc9900)](https://www.nuget.org/packages/jcdcdev.Umbraco.PackageTemplate/)

An opinionated template for creating Umbraco packages hosted on Github.

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
2. Update `README_nuget.md` with your package details
3. Update `umbraco-marketplace.json` with your package details

### Publish

1. Push your code to GitHub
2. Create a pull request into the `main` branch
3. Merge the pull request
4. A new release will be created

## Template Parameters

| Long Name         | Short Name | Description                                                                        | Datatype | Default Value                       | Required |
|-------------------|------------|------------------------------------------------------------------------------------|----------|-------------------------------------|----------|
| ghUsername        | u          | GitHub Username - Used for generating Package, Author, Documentation & Issues URLs | string   |                                     | Yes      |
| title             | t          | Package Title - Used for generating NuGet package title                            | string   |                                     | Yes      |
| description       | d          | Package Description - Used for generating NuGet package description and README.md  | string   |                                     | Yes      |
| authorName        | an         | Package Author - Used for generating NuGet Author and Copyright                    | string   |                                     | No       |
| authorDescription | ad         | Package Author Description - Used for umbraco-marketplace.json                     | string   |                                     | No       |
| authorUrl         | au         | Package Author URL - Used for umbraco-marketplace.json                             | string   | `https://github.com/ghUsername`     | No       |
| authorImageUrl    | aiu        | Package Author Image URL - Used for umbraco-marketplace.json                       | string   | `https://github.com/ghUsername.png` | No       |
| packageType       | pt         | Package Type - Used for umbraco-marketplace.json                                   | choice   | Package                             | No       |
| category          | c          | Package Category - Used for umbraco-marketplace.json                               | choice   | Developer Tools                     | No       |
| addClient         | ac         | Includes a client project for the package (Lit.js & TypeScript)                    | bool     | false                               | No       |

## Test Sites

The solution includes a test site for testing your package features.

### Running Locally

On first boot the test site will:

- Create a SQLite database
- Create an admin user
  - Username: `admin@example.com`
  - Password: `1234567890`
- Run a uSync import to add starter content

## Need help?

- [Raise an issue](https://github.com/jcdcdev/jcdcdev.Umbraco.PackageTemplate/issues)
- [Contact me](https://jcdc.dev/contact)

## Contributing

Contributions to this package are most welcome! Please read the [Contributing Guidelines](CONTRIBUTING.md).

## Acknowledgments (thanks!)

- LottePitcher - [opinionated-package-starter](https://github.com/LottePitcher/opinionated-package-starter)