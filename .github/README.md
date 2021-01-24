# Get a Tag

A .NET CLI tool for creating tags using [z-base-32](https://en.wikipedia.org/wiki/Base32#z-base-32) data encoding.

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
