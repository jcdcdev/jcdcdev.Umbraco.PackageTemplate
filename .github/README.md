# jcdcdev.Umbraco.PackageTemplate

[![Umbraco Version](https://img.shields.io/badge/Umbraco-10.4+-%233544B1?style=flat&logo=umbraco)](https://umbraco.com/products/umbraco-cms/)
[![NuGet](https://img.shields.io/nuget/vpre/jcdcdev.Umbraco.PackageTemplate?color=0273B3)](https://www.nuget.org/packages/jcdcdev.Umbraco.PackageTemplate)
[![GitHub license](https://img.shields.io/github/license/jcdcdev/jcdcdev.Umbraco.PackageTemplate?color=8AB803)](../LICENSE)
[![Downloads](https://img.shields.io/nuget/dt/jcdcdev.Umbraco.PackageTemplate?color=cc9900)](https://www.nuget.org/packages/jcdcdev.Umbraco.PackageTemplate/)

An opinionated template for creating Umbraco packages hosted on Github.

## Quick Start

1. Create a git repository on GitHub and clone it locally

**Your github repository name must match the project name!**

2. Install template

```powershell
dotnet new -i jcdcdev.Umbraco.PackageTemplate
```

3. Create new project

```powershell
dotnet new jcdcdev-umb-package -o Demo.Package --gh-username jcdcdev --title "My Demo Package" --description "An empty Umbraco package" --author-name "James C" --author-description "Lead .NET Developer" --author-url "https://jcdc.dev" --author-image-url "https://github.com/jcdcdev.png"
```

4. Open project in Visual Studio/Rider
5. Build and run project
6. Push your code and run a build GitHub Action


## Template Parameters


| Name | Description | Example Value | Required |
| --- | --- | --- | --- |
| `--gh-username` | GitHub username - Used for project url and github actions. | jcdcdev | **Yes** |
| `--title` | Package title - Used for NuGet metadata, README & `umbraco-marketplace.json` | `My Demo Package` | **Yes** |
| `--description` | Package description - Used for NuGet metadata & `umbraco-marketplace.json` | `An empty Umbraco package` | **Yes** |
| `--author-name` | Author name - Used for `umbraco-marketplace.json`| `James C` | No |
| `--author-description` | Author description - Used for `umbraco-marketplace.json` | `Lead .NET Developer` | No |
| `--author-url` | Author URL - Used for `umbraco-marketplace.json` | `https://jcdc.dev` | No |
| `--author-image-url` | Author image URL - Used for `umbraco-marketplace.json` | `https://github.com/jcdcdev.png` | No |

## Need help?

- [Raise an issue](https://github.com/jcdcdev/jcdcdev.Umbraco.PackageTemplate/issues)
- [Contact me](https://jcdc.dev/contact)

## Contributing

Contributions to this package are most welcome! Please read the [Contributing Guidelines](CONTRIBUTING.md).

## Acknowledgments (thanks!)

- LottePitcher - [opinionated-package-starter](https://github.com/LottePitcher/opinionated-package-starter)