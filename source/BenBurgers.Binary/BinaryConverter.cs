/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

using BenBurgers.Binary.Exceptions;
using System.Buffers.Binary;

namespace BenBurgers.Binary;

/// <summary>
/// Converts binary data to primitives.
/// </summary>
public sealed partial class BinaryConverter
{
    /// <summary>
    /// A binary converter that uses the system's byte order.
    /// </summary>
    public static readonly Lazy<BinaryConverter> System =
        new(() => new BinaryConverter(BinaryEndianness.System));

    /// <summary>
    /// A binary converter that uses Big Endian byte order.
    /// </summary>
    public static readonly Lazy<BinaryConverter> BigEndian =
        new(() => new BinaryConverter(BinaryEndianness.BigEndian));

    /// <summary>
    /// A binary converter that uses Little Endian byte order.
    /// </summary>
    public static readonly Lazy<BinaryConverter> LittleEndian =
        new(() => new BinaryConverter(BinaryEndianness.LittleEndian));
    
    private readonly BinaryEndianness endianness;

    /// <summary>
    /// Initializes a new instance of <see cref="BinaryConverter" />.
    /// </summary>
    /// <param name="endianness">The byte order of the binary data.</param>
    private BinaryConverter(BinaryEndianness endianness)
    {
        this.endianness = endianness;

        this.ReadInt16 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.ReadInt16BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.ReadInt16LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.ReadInt16LittleEndian
                    : BinaryPrimitives.ReadInt16BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.ReadInt32 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.ReadInt32BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.ReadInt32LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.ReadInt32LittleEndian
                    : BinaryPrimitives.ReadInt32BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.ReadInt64 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.ReadInt64BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.ReadInt64LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.ReadInt64LittleEndian
                    : BinaryPrimitives.ReadInt64BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.ReadUInt16 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.ReadUInt16BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.ReadUInt16LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.ReadUInt16LittleEndian
                    : BinaryPrimitives.ReadUInt16BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.ReadUInt32 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.ReadUInt32BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.ReadUInt32LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.ReadUInt32LittleEndian
                    : BinaryPrimitives.ReadUInt32BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.ReadUInt64 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.ReadUInt64BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.ReadUInt64LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.ReadUInt64LittleEndian
                    : BinaryPrimitives.ReadUInt64BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.WriteInt16 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.WriteInt16BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.WriteInt16LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.WriteInt16LittleEndian
                    : BinaryPrimitives.WriteInt16BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.WriteInt32 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.WriteInt32BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.WriteInt32LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.WriteInt32LittleEndian
                    : BinaryPrimitives.WriteInt32BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.WriteInt64 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.WriteInt64BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.WriteInt64LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.WriteInt64LittleEndian
                    : BinaryPrimitives.WriteInt64BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.WriteUInt16 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.WriteUInt16BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.WriteUInt16LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.WriteUInt16LittleEndian
                    : BinaryPrimitives.WriteUInt16BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.WriteUInt32 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.WriteUInt32BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.WriteUInt32LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.WriteUInt32LittleEndian
                    : BinaryPrimitives.WriteUInt32BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };

        this.WriteUInt64 = endianness switch
        {
            BinaryEndianness.BigEndian => BinaryPrimitives.WriteUInt64BigEndian,
            BinaryEndianness.LittleEndian => BinaryPrimitives.WriteUInt64LittleEndian,
            BinaryEndianness.System =>
                BitConverter.IsLittleEndian
                    ? BinaryPrimitives.WriteUInt64LittleEndian
                    : BinaryPrimitives.WriteUInt64BigEndian,
            _ => throw new BinaryEndiannessNotSupportedException(endianness)
        };
    }

    /// <summary>
    /// Gets the byte order of the binary data.
    /// </summary>
    public BinaryEndianness Endianness => this.endianness;
}
