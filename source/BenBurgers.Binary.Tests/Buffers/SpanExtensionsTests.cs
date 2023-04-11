/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

using BenBurgers.Binary.Buffers;

namespace BenBurgers.Binary.Tests.Buffers;

public sealed class SpanExtensionsTests
{
    public static readonly IEnumerable<object?[]> ConcatenateParameters =
        new[]
        {
            new object?[]
            {
                new Memory<byte>(new byte[] { 1, 2, 3 }),
                new Memory<byte>(new byte[] { 4, 5, 6 }),
                new Memory<byte>(new byte[] { 1, 2, 3, 4, 5, 6 })
            },
            new object?[]
            {
                new Memory<byte>(new byte[] { 6, 5, 4, 3, 2, 1 }),
                new Memory<byte>(new byte[] { 12, 11, 10, 9, 8, 7 }),
                new Memory<byte>(new byte[] { 6, 5, 4, 3, 2, 1, 12, 11, 10, 9, 8, 7 })
            }
        };

    [Theory(DisplayName = $"{nameof(SpanExtensions)} :: {nameof(SpanExtensions.Concat)}")]
    [MemberData(nameof(ConcatenateParameters))]
    public void ConcatenateTests(Memory<byte> first, Memory<byte> second, Memory<byte> expected)
    {
        // Arrange
        var firstSpan = first.Span;
        var secondSpan = second.Span;

        // Act
        var actualSpan = firstSpan.Concat(secondSpan);

        // Assert
        Assert.True(expected.Span.SequenceEqual(actualSpan));
    }
}
