/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

namespace BenBurgers.Binary.Buffers;

/// <summary>
/// Extension methods for a <see cref="Span{T}" />.
/// </summary>
public static class SpanExtensions
{
    /// <summary>
    /// Concatenates <paramref name="first" /> and <paramref name="second" /> into a single <see cref="Span{T}" />.
    /// </summary>
    /// <typeparam name="T">The type of the element.</typeparam>
    /// <param name="first">The <see cref="Span{T}" /> to concatenate before <paramref name="second" />.</param>
    /// <param name="second">The <see cref="Span{T}" /> to concatenate after <paramref name="first" />.</param>
    /// <returns>The concatenated <see cref="Span{T}" />.</returns>
    public static Span<T> Concat<T>(this Span<T> first, Span<T> second)
    {
        var totalLength = first.Length + second.Length;
        var result = new Span<T>(new T[totalLength]);
        first.CopyTo(result[0..first.Length]);
        second.CopyTo(result[first.Length..totalLength]);
        return result;
    }
}
