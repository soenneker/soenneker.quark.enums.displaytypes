using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the display enum.
/// </summary>
[EnumValue<string>]
public sealed partial class DisplayEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly DisplayEnum None = new("hidden");
    /// <summary>
    /// The inline.
    /// </summary>
    public static readonly DisplayEnum Inline = new("inline");
    /// <summary>
    /// The inline block.
    /// </summary>
    public static readonly DisplayEnum InlineBlock = new("inline-block");
    /// <summary>
    /// The block.
    /// </summary>
    public static readonly DisplayEnum Block = new("block");
    /// <summary>
    /// The flow root.
    /// </summary>
    public static readonly DisplayEnum FlowRoot = new("flow-root");
    /// <summary>
    /// The flex.
    /// </summary>
    public static readonly DisplayEnum Flex = new("flex");
    /// <summary>
    /// The inline flex.
    /// </summary>
    public static readonly DisplayEnum InlineFlex = new("inline-flex");
    /// <summary>
    /// The grid.
    /// </summary>
    public static readonly DisplayEnum Grid = new("grid");
    /// <summary>
    /// The inline grid.
    /// </summary>
    public static readonly DisplayEnum InlineGrid = new("inline-grid");
    /// <summary>
    /// The table.
    /// </summary>
    public static readonly DisplayEnum Table = new("table");
    /// <summary>
    /// The table caption.
    /// </summary>
    public static readonly DisplayEnum TableCaption = new("table-caption");
    /// <summary>
    /// The table column.
    /// </summary>
    public static readonly DisplayEnum TableColumn = new("table-column");
    /// <summary>
    /// The table column group.
    /// </summary>
    public static readonly DisplayEnum TableColumnGroup = new("table-column-group");
    /// <summary>
    /// The table footer group.
    /// </summary>
    public static readonly DisplayEnum TableFooterGroup = new("table-footer-group");
    /// <summary>
    /// The table header group.
    /// </summary>
    public static readonly DisplayEnum TableHeaderGroup = new("table-header-group");
    /// <summary>
    /// The table row group.
    /// </summary>
    public static readonly DisplayEnum TableRowGroup = new("table-row-group");
    /// <summary>
    /// The table cell.
    /// </summary>
    public static readonly DisplayEnum TableCell = new("table-cell");
    /// <summary>
    /// The table row.
    /// </summary>
    public static readonly DisplayEnum TableRow = new("table-row");
    /// <summary>
    /// The contents.
    /// </summary>
    public static readonly DisplayEnum Contents = new("contents");
    /// <summary>
    /// The list item.
    /// </summary>
    public static readonly DisplayEnum ListItem = new("list-item");
}
