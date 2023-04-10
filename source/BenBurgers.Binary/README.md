# Ben Burgers Binary

Thank you for choosing the Ben Burgers Binary package.
This package will facilitate the processing of binary data.

## Usage

Whenever a `struct` or a `class` implements `IBinarySerializable`, it can be serialized or deserialized to binary data in a `Memory<byte>` or a `Span<byte>`.

The `BinaryConverter` can read or write binary data from `Span<byte>` while respecting the preferred byte order.