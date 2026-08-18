using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.Directions;

/// <summary>
/// Identifies whether a communication, event, or data flow is inbound or outbound relative to the system.
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class Direction
{
    /// <summary>
    /// The item is received by or entering the system.
    /// </summary>
    public static readonly Direction Incoming = new(nameof(Incoming));

    /// <summary>
    /// The item is sent by or leaving the system.
    /// </summary>
    public static readonly Direction Outgoing = new(nameof(Outgoing));
}
