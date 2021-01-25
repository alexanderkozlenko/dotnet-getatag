// © Alexander Kozlenko. Licensed under the MIT License.

using System;
using System.Security.Cryptography;
using System.Text;

using SimpleBase;

namespace Anemonis.GetATag
{
    public static class TagFactory
    {
        public static string Create(int size, string? text)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), size, "The value must be greater than zero.");
            }

            var bytes = text is { Length: > 0 } ? CreateFromText(size, text) : CreateFromRandomData(size);

            return Base32.ZBase32.Encode(bytes, padding: false);
        }

        private static ReadOnlySpan<byte> CreateFromText(int size, string text)
        {
            using var hashAlgorithm = HashAlgorithm.Create("SHA-256")!;

            var valueBytes = Encoding.Unicode.GetBytes(text);
            var valueHash = hashAlgorithm.ComputeHash(valueBytes);
            var valueSize = Math.Min(valueHash.Length, size);

            return new(valueHash, 0, valueSize);
        }

        private static ReadOnlySpan<byte> CreateFromRandomData(int size)
        {
            var randomBytes = new byte[size].AsSpan();

            RandomNumberGenerator.Fill(randomBytes);

            return randomBytes;
        }
    }
}
