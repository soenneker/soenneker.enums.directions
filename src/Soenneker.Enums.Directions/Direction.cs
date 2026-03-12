using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.Directions;

/// <summary>
/// An enumeration for directions
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class Direction
{
    public static readonly Direction Incoming = new(nameof(Incoming));

    public static readonly Direction Outgoing = new(nameof(Outgoing));
}
