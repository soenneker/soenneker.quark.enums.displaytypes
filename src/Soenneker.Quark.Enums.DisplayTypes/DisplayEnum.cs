using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DisplayEnum
{
    public static readonly DisplayEnum None = new("hidden");
    public static readonly DisplayEnum Inline = new("inline");
    public static readonly DisplayEnum InlineBlock = new("inline-block");
    public static readonly DisplayEnum Block = new("block");
    public static readonly DisplayEnum Flex = new("flex");
    public static readonly DisplayEnum InlineFlex = new("inline-flex");
    public static readonly DisplayEnum Grid = new("grid");
    public static readonly DisplayEnum InlineGrid = new("inline-grid");
    public static readonly DisplayEnum Table = new("table");
    public static readonly DisplayEnum TableCell = new("table-cell");
    public static readonly DisplayEnum TableRow = new("table-row");
}
