/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

namespace BenBurgers.Binary.Exceptions;

/// <summary>
/// An exception that is thrown if a byte order is not supported.
/// </summary>
public sealed class BinaryEndiannessNotSupportedException : BinaryException
{
    /// <summary>
    /// Initializes a new instance of <see cref="BinaryEndiannessNotSupportedException" />.
    /// </summary>
    /// <param name="endianness">The byte order.</param>
    internal BinaryEndiannessNotSupportedException(BinaryEndianness endianness)
        : base(CreateExceptionMessage(endianness))
    {
    }

    private static string CreateExceptionMessage(BinaryEndianness endianness) =>
        string.Format(ExceptionMessages.EndiannessNotSupported, endianness);
}
