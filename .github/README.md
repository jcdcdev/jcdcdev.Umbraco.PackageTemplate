# jcdcdev.Umbraco.PackageTemplate

[![Umbraco Version](https://img.shields.io/badge/Umbraco-10.4+-%233544B1?style=flat&logo=umbraco)](https://umbraco.com/products/umbraco-cms/)
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

    ```powershell
    dotnet new jcdcdev-umb-package -o Demo.Package --gh-username jcdcdev --title "My Demo Package" --description "An empty Umbraco package" --author-name "James C" --author-description "Lead .NET Developer" --author-url "https://jcdc.dev" --author-image-url "https://github.com/jcdcdev.png"
    ```

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

## Template Parameters

| Name                   | Description                                                                     | Example Value                    | Required |
|------------------------|---------------------------------------------------------------------------------|----------------------------------|----------|
| `--gh-username`        | GitHub username - Used for project url and github actions.                      | jcdcdev                          | **Yes**  |
| `--title`              | Package title - Used for NuGet metadata, README & `umbraco-marketplace.json`    | `My Demo Package`                | **Yes**  |
| `--description`        | Package description - Used for NuGet metadata & `umbraco-marketplace.json`      | `An empty Umbraco package`       | **Yes**  |
| `--author-name`        | Author name - Used for `umbraco-marketplace.json`                               | `James C`                        | **Yes**  |
| `--author-description` | Author description - Used for `umbraco-marketplace.json`                        | `Lead .NET Developer`            | No       |
| `--author-url`         | Author URL - Used for `umbraco-marketplace.json`                                | `https://jcdc.dev`               | No       |
| `--author-image-url`   | Author image URL - Used for `umbraco-marketplace.json`                          | `https://github.com/jcdcdev.png` | No       |
| `--package-type`       | Package type - Used for `umbraco-marketplace.json`                              | `Package`                        | No       |
| `--category`           | Package category - Used for `umbraco-marketplace.json`                          | `Developer Tools`                | No       |
| `--add-client`         | Add a Front End project using Lit.js and TypeScript. Configured for Umbraco UI. | `true`                           | No       |

## Test Sites

The solution includes a test site for testing your package features against the following Umbraco versions:

- 10.4.0
- 12.0.0
- 13.0.0

Your package project is automatically referenced in each test site.

### Running Locally

On first boot each test site will:

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