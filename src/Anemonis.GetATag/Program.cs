// © Alexander Kozlenko. Licensed under the MIT License.

using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;

namespace Anemonis.GetATag
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var rootCommand = new RootCommand("Creates a tag using z-base-32 data encoding.");

            rootCommand.AddArgument(
                new Argument<string?>("text", () => string.Empty, "The text to create a tag from."));
            rootCommand.AddOption(
                new Option<int>("--size", "The size of the tag data in bits: 8, 16, 32, 64, 128, or 256.")
                {
                    IsRequired = true,
                    Argument = new Argument<int>()
                });

            rootCommand.Handler = CommandHandler.Create<int, string?>(HandleCommand);
            rootCommand.Invoke(args);
        }

        private static void HandleCommand(int size, string? text)
        {
            if ((size != 008) && (size != 016) && (size != 032) &&
                (size != 064) && (size != 128) && (size != 256))
            {
                throw new InvalidOperationException("The specified size of tag data is not supported.");
            }

            Console.Write(TagFactory.Create(size / 8, text));
        }
    }
}
