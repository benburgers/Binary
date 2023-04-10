/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

namespace BenBurgers.Binary;

/// <summary>
/// The implementing structure or object is (de)serializable to/from binary data.
/// </summary>
public interface IBinarySerializable
{
    /// <summary>
    /// Serializes the structure or object to the <paramref name="span" /> as binary data.
    /// </summary>
    /// <param name="span">The span to serialize the structure or object to.</param>
    virtual void Serialize(Span<byte> span)
    {
    }

    /// <summary>
    /// Serializes the structure or object to the <paramref name="memory" /> as binary data.
    /// </summary>
    /// <param name="memory">The memory that will contain the binary data.</param>
    /// <param name="cancellationToken">An optional cancellation token.</param>
    /// <returns>An awaitable task.</returns>
    virtual Task SerializeAsync(
        Memory<byte> memory,
        CancellationToken cancellationToken = default) =>
        Task.Run(() => Serialize(memory.Span), cancellationToken);
}

/// <summary>
/// The implementing structure or object is (de)serializable to/from binary data.
/// </summary>
/// <typeparam name="T">The type of (de)serializable structure or object.</typeparam>
public interface IBinarySerializable<T> : IBinarySerializable
    where T : IBinarySerializable<T>
{
    /// <summary>
    /// Deserializes a structure or object of type <typeparamref name="T" />.
    /// </summary>
    /// <param name="span">The span that contains the binary data.</param>
    /// <returns>The deserialized structure or object of type <typeparamref name="T" />.</returns>
    static abstract T Deserialize(ReadOnlySpan<byte> span);

    /// <summary>
    /// Deserializes a structure or object of type <typeparamref name="T" />.
    /// </summary>
    /// <param name="memory">The memory that contains the binary data.</param>
    /// <param name="cancellationToken">An optional cancellation token.</param>
    /// <returns>An awaitable task that returns the deserialized <typeparamref name="T" />.</returns>
    static virtual Task<T> DeserializeAsync(
        ReadOnlyMemory<byte> memory,
        CancellationToken cancellationToken = default) =>
        Task.Run(() => T.Deserialize(memory.Span), cancellationToken);
}

/// <summary>
/// The implementing structure or object is (de)serializable to/from binary data, with a specified byte order.
/// </summary>
/// <typeparam name="T">The type of (de)serializable structure or object.</typeparam>
public interface IBinarySerializableVariableEndianness<T> : IBinarySerializable
    where T : IBinarySerializableVariableEndianness<T>
{
    /// <summary>
    /// Deserializes a structure or object of type <typeparamref name="T" />.
    /// </summary>
    /// <param name="span">The span that contains the binary data.</param>
    /// <param name="binaryConverter">Converts from and to binary data.</param>
    /// <returns>The deserialized structure or object of type <typeparamref name="T" />.</returns>
    static abstract T Deserialize(
        ReadOnlySpan<byte> span,
        BinaryConverter binaryConverter);

    /// <summary>
    /// Deserializes a structure or object of type <typeparamref name="T" />.
    /// </summary>
    /// <param name="memory">The memory that contains the binary data.</param>
    /// <param name="cancellationToken">An optional cancellation token.</param>
    /// <returns>An awaitable task that returns the deserialized <typeparamref name="T" />.</returns>
    static Task<T> DeserializeAsync(
        ReadOnlyMemory<byte> memory,
        CancellationToken cancellationToken = default) =>
        Task.Run(() => T.Deserialize(memory.Span, BinaryConverter.System.Value), cancellationToken);

    /// <summary>
    /// Deserializes a structure or object of type <typeparamref name="T" />.
    /// </summary>
    /// <param name="memory">The memory that contains the binary data.</param>
    /// <param name="binaryConverter">Converts from and to binary data.</param>
    /// <param name="cancellationToken">An optional cancellation token.</param>
    /// <returns>An awaitable task that returns the deserialized <typeparamref name="T" />.</returns>
    static virtual Task<T> DeserializeAsync(
        ReadOnlyMemory<byte> memory,
        BinaryConverter binaryConverter,
        CancellationToken cancellationToken = default) =>
        Task.Run(() => T.Deserialize(memory.Span, binaryConverter), cancellationToken);

    /// <summary>
    /// Serializes the structure or object to the <paramref name="span" /> as binary data.
    /// </summary>
    /// <param name="span">The span to serialize the structure or object to.</param>
    new void Serialize(Span<byte> span) =>
        this.Serialize(span, BinaryConverter.System.Value);

    /// <summary>
    /// Serializes the structure or object to the <paramref name="span" /> as binary data.
    /// </summary>
    /// <param name="span">The span to serialize the structure or object to.</param>
    /// <param name="converter">Converts from and to binary data.</param>
    void Serialize(
        Span<byte> span,
        BinaryConverter converter);

    /// <summary>
    /// Serializes the structure or object to the <paramref name="memory" /> as binary data.
    /// </summary>
    /// <param name="memory">The memory that will contain the binary data.</param>
    /// <param name="converter">Converts from and to binary data.</param>
    /// <param name="cancellationToken">An optional cancellation token.</param>
    /// <returns>An awaitable task.</returns>
    virtual Task SerializeAsync(
        Memory<byte> memory,
        BinaryConverter converter,
        CancellationToken cancellationToken = default) =>
        Task.Run(() => Serialize(memory.Span), cancellationToken);
}