/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

namespace BenBurgers.Binary;

public sealed partial class BinaryConverter
{
    /// <summary>
    /// The method that reads a signed 16-bit integer.
    /// </summary>
    public readonly ReadInt16Delegate ReadInt16;

    /// <summary>
    /// The method that reads a signed 32-bit integer.
    /// </summary>
    public readonly ReadInt32Delegate ReadInt32;

    /// <summary>
    /// The method that reads a signed 64-bit integer.
    /// </summary>
    public readonly ReadInt64Delegate ReadInt64;

    /// <summary>
    /// The method that reads an unsigned 16-bit integer.
    /// </summary>
    public readonly ReadUInt16Delegate ReadUInt16;

    /// <summary>
    /// The method that reads an unsigned 32-bit integer.
    /// </summary>
    public readonly ReadUInt32Delegate ReadUInt32;

    /// <summary>
    /// The method that reads an unsigned 64-bit integer.
    /// </summary>
    public readonly ReadUInt64Delegate ReadUInt64;

    /// <summary>
    /// The method that writes a signed 16-bit integer.
    /// </summary>
    public readonly WriteInt16Delegate WriteInt16;

    /// <summary>
    /// The method that writes a signed 32-bit integer.
    /// </summary>
    public readonly WriteInt32Delegate WriteInt32;

    /// <summary>
    /// The method that writes a signed 64-bit integer.
    /// </summary>
    public readonly WriteInt64Delegate WriteInt64;

    /// <summary>
    /// The method that writes an unsigned 16-bit integer.
    /// </summary>
    public readonly WriteUInt16Delegate WriteUInt16;

    /// <summary>
    /// The method that writes an unsigned 32-bit integer.
    /// </summary>
    public readonly WriteUInt32Delegate WriteUInt32;

    /// <summary>
    /// The method that writes an unsigned 64-bit integer.
    /// </summary>
    public readonly WriteUInt64Delegate WriteUInt64;
}
