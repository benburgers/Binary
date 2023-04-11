/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

namespace BenBurgers.Binary.Buffers;

/// <summary>
/// Extension methods for <see cref="Memory{T}" />.
/// </summary>
public static class MemoryExtensions
{
    /// <summary>
    /// Concatenates <paramref name="first" /> and <paramref name="second" /> into a single <see cref="Memory{T}" />.
    /// </summary>
    /// <typeparam name="T">The type of element.</typeparam>
    /// <param name="first">The <see cref="Memory{T}" /> to concatenate before <paramref name="second" />.</param>
    /// <param name="second">The <see cref="Memory{T}" /> to concatenate after <paramref name="first" />.</param>
    /// <returns>The concatenated <see cref="Memory{T}" />.</returns>
    public static Memory<T> Concat<T>(this Memory<T> first, Memory<T> second)
    {
        var totalLength = first.Length + second.Length;
        var result = new Memory<T>(new T[totalLength]);
        first.CopyTo(result[0..first.Length]);
        second.CopyTo(result[first.Length..totalLength]);
        return result;
    }
}
