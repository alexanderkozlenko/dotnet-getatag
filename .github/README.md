# Get a Tag

A .NET CLI tool for creating tags using [z-base-32](https://en.wikipedia.org/wiki/Base32#z-base-32) data encoding.

| | Release | Current |
|---|---|---|
| Artifacts | [![nuget.org](https://img.shields.io/nuget/vpre/dotnet-getatag.svg?style=flat-square)](https://www.nuget.org/packages/dotnet-getatag) | [![feedz.io](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Ff.feedz.io%2Falexander-kozlenko%2Fanemonis%2Fshield%2Fdotnet-getatag%2Flatest&label=feedz&logo=_&color=lightgrey&style=flat-square)](https://f.feedz.io/alexander-kozlenko/anemonis/packages/dotnet-getatag/latest/download) |
| Build Status | | [![dev.azure.com](https://img.shields.io/azure-devops/build/alexanderkozlenko/github-pipelines/7?label=main&style=flat-square)](https://dev.azure.com/alexanderkozlenko/github-pipelines/_build?definitionId=13&_a=summary) |

## Usage Examples

### Creating a random tag

- Create a tag using the command:
    ```
    getatag --size=32
    ```
- Use the tag in a email address:
    ```
    mailto:username+ucjqkdy@domain.com
    ```

### Creating a text-based tag

- Create a tag using the command:
    ```
    getatag "domain.com" --size=32
    ```
- Use the tag in a email address:
    ```
    mailto:username+ybmroye@domain.com
    ```

## Quicklinks

- [Contributing Guidelines](./CONTRIBUTING.md)
- [Code of Conduct](./CODE_OF_CONDUCT.md)
