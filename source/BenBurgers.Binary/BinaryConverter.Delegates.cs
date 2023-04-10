/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

namespace BenBurgers.Binary;

public sealed partial class BinaryConverter
{
    /// <summary>
    /// A method that converts binary data to a signed 16-bit integer.
    /// </summary>
    /// <param name="source">The binary data.</param>
    /// <returns>The signed 16-bit integer.</returns>
    public delegate short ReadInt16Delegate(ReadOnlySpan<byte> source);

    /// <summary>
    /// A method that converts binary data to a signed 32-bit integer.
    /// </summary>
    /// <param name="source">The binary data.</param>
    /// <returns>The signed 32-bit integer.</returns>
    public delegate int ReadInt32Delegate(ReadOnlySpan<byte> source);

    /// <summary>
    /// A method that converts binary data to a signed 64-bit integer.
    /// </summary>
    /// <param name="source">The binary data.</param>
    /// <returns>The signed 64-bit integer.</returns>
    public delegate long ReadInt64Delegate(ReadOnlySpan<byte> source);

    /// <summary>
    /// A method that converts binary data to an unsigned 16-bit integer.
    /// </summary>
    /// <param name="source">The binary source.</param>
    /// <returns>The unsigned 16-bit integer.</returns>
    public delegate ushort ReadUInt16Delegate(ReadOnlySpan<byte> source);

    /// <summary>
    /// A method that converts binary data to an unsigned 32-bit integer.
    /// </summary>
    /// <param name="source">The binary source.</param>
    /// <returns>The unsigned 32-bit integer.</returns>
    public delegate uint ReadUInt32Delegate(ReadOnlySpan<byte> source);

    /// <summary>
    /// A method that converts binary data to an unsigned 64-bit integer.
    /// </summary>
    /// <param name="source">The binary source.</param>
    /// <returns>The unsigned 64-bit integer.</returns>
    public delegate ulong ReadUInt64Delegate(ReadOnlySpan<byte> source);

    /// <summary>
    /// A method that writes a signed 16-bit integer to binary data.
    /// </summary>
    /// <param name="destination">The destination binary data.</param>
    /// <param name="value">The value to write.</param>
    public delegate void WriteInt16Delegate(Span<byte> destination, short value);

    /// <summary>
    /// A method that writes a signed 32-bit integer to binary data.
    /// </summary>
    /// <param name="destination">The destination binary data.</param>
    /// <param name="value">The value to write.</param>
    public delegate void WriteInt32Delegate(Span<byte> destination, int value);

    /// <summary>
    /// A method that writes a signed 64-bit integer to binary data.
    /// </summary>
    /// <param name="destination">The destination binary data.</param>
    /// <param name="value">The value to write.</param>
    public delegate void WriteInt64Delegate(Span<byte> destination, long value);

    /// <summary>
    /// A method that writes an unsigned 16-bit integer to binary data.
    /// </summary>
    /// <param name="destination">The destination binary data.</param>
    /// <param name="value">The value to write.</param>
    public delegate void WriteUInt16Delegate(Span<byte> destination, ushort value);

    /// <summary>
    /// A method that writes an unsigned 32-bit integer to binary data.
    /// </summary>
    /// <param name="destination">The destination binary data.</param>
    /// <param name="value">The value to write.</param>
    public delegate void WriteUInt32Delegate(Span<byte> destination, uint value);

    /// <summary>
    /// A method that writes an unsigned 64-bit integer to binary data.
    /// </summary>
    /// <param name="destination">The destination binary data.</param>
    /// <param name="value">The value to write.</param>
    public delegate void WriteUInt64Delegate(Span<byte> destination, ulong value);
}
