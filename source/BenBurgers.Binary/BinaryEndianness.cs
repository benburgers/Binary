/*
 * © 2023 Ben Burgers and contributors.
 * Licensed under GNU Affero General Public License version 3.0
 */

namespace BenBurgers.Binary;

/// <summary>
/// The byte order of binary data.
/// </summary>
public enum BinaryEndianness
{
    /// <summary>
    /// Use the system's processor architecture's endianness.
    /// </summary>
    System,
    
    /// <summary>
    /// Use Big Endian byte order.
    /// </summary>
    BigEndian,

    /// <summary>
    /// Use Little Endian byte order.
    /// </summary>
    LittleEndian
}
