/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

namespace BenBurgers.Binary.Exceptions;

/// <summary>
/// An exception that is thrown during the processing of binary data.
/// </summary>
public abstract class BinaryException : Exception
{
    /// <summary>
    /// Initializes a new instance of <see cref="BinaryException" />.
    /// </summary>
    /// <param name="message">The exception message.</param>
    /// <param name="innerException">An optional inner exception.</param>
    protected internal BinaryException(string message, Exception? innerException = null)
        : base(message, innerException)
    {
    }
}
