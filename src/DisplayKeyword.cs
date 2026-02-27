using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An enumeration for Quark, representing HTML display style values.
/// This enum contains all valid CSS display property values for use in HTML/CSS styling.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public partial class DisplayKeyword
{
    /// <summary>
    /// The element is completely removed from the document flow and does not take up any space.
    /// </summary>
    public static readonly DisplayKeyword None = new("none");

    /// <summary>
    /// The element generates an inline-level box. It flows with the text content and does not start on a new line.
    /// </summary>
    public static readonly DisplayKeyword Inline = new("inline");

    /// <summary>
    /// The element generates a block-level box. It starts on a new line and takes up the full width available.
    /// </summary>
    public static readonly DisplayKeyword Block = new("block");

    /// <summary>
    /// The element generates a block-level box that flows with surrounding content as if it were a single inline box. 
    /// </summary>
    public static readonly DisplayKeyword InlineBlock = new("inline-block");

    /// <summary>
    /// The element itself does not generate any boxes, but its children and pseudo-elements still generate boxes as normal.
    /// </summary>
    public static readonly DisplayKeyword Contents = new("contents");

    /// <summary>
    /// The element generates a block-level box for the list item marker and a principal block-level box for the contents.
    /// </summary>
    public static readonly DisplayKeyword ListItem = new("list-item");

    /// <summary>
    /// The element generates an inline-level box for the list item marker and a principal inline-level box for the contents.
    /// </summary>
    public static readonly DisplayKeyword InlineListItem = new("inline-list-item");

    /// <summary>
    /// The element generates a block-level table box.
    /// </summary>
    public static readonly DisplayKeyword Table = new("table");

    /// <summary>
    /// The element generates an inline-level table box.
    /// </summary>
    public static readonly DisplayKeyword InlineTable = new("inline-table");

    /// <summary>
    /// The element generates a table row group box.
    /// </summary>
    public static readonly DisplayKeyword TableRowGroup = new("table-row-group");

    /// <summary>
    /// The element generates a table header group box.
    /// </summary>
    public static readonly DisplayKeyword TableHeaderGroup = new("table-header-group");

    /// <summary>
    /// The element generates a table footer group box.
    /// </summary>
    public static readonly DisplayKeyword TableFooterGroup = new("table-footer-group");

    /// <summary>
    /// The element generates a table row box.
    /// </summary>
    public static readonly DisplayKeyword TableRow = new("table-row");

    /// <summary>
    /// The element generates a table cell box.
    /// </summary>
    public static readonly DisplayKeyword TableCell = new("table-cell");

    /// <summary>
    /// The element generates a table column group box.
    /// </summary>
    public static readonly DisplayKeyword TableColumnGroup = new("table-column-group");

    /// <summary>
    /// The element generates a table column box.
    /// </summary>
    public static readonly DisplayKeyword TableColumn = new("table-column");

    /// <summary>
    /// The element generates a table caption box.
    /// </summary>
    public static readonly DisplayKeyword TableCaption = new("table-caption");

    /// <summary>
    /// The element generates a ruby base box.
    /// </summary>
    public static readonly DisplayKeyword Ruby = new("ruby");

    /// <summary>
    /// The element generates a ruby base box.
    /// </summary>
    public static readonly DisplayKeyword RubyBase = new("ruby-base");

    /// <summary>
    /// The element generates a ruby text box.
    /// </summary>
    public static readonly DisplayKeyword RubyText = new("ruby-text");

    /// <summary>
    /// The element generates a ruby base container box.
    /// </summary>
    public static readonly DisplayKeyword RubyBaseContainer = new("ruby-base-container");

    /// <summary>
    /// The element generates a ruby text container box.
    /// </summary>
    public static readonly DisplayKeyword RubyTextContainer = new("ruby-text-container");

    /// <summary>
    /// The element generates a run-in box, which can be either block or inline depending on context.
    /// </summary>
    public static readonly DisplayKeyword RunIn = new("run-in");

    /// <summary>
    /// The element generates a flow box that participates in normal flow layout.
    /// </summary>
    public static readonly DisplayKeyword Flow = new("flow");

    /// <summary>
    /// The element generates a block-level box that establishes a new block formatting context.
    /// </summary>
    public static readonly DisplayKeyword FlowRoot = new("flow-root");

    /// <summary>
    /// The element generates a block-level flex container box.
    /// </summary>
    public static readonly DisplayKeyword Flex = new("flex");

    /// <summary>
    /// The element generates an inline-level flex container box.
    /// </summary>
    public static readonly DisplayKeyword InlineFlex = new("inline-flex");

    /// <summary>
    /// The element generates a block-level grid container box.
    /// </summary>
    public static readonly DisplayKeyword Grid = new("grid");

    /// <summary>
    /// The element generates an inline-level grid container box.
    /// </summary>
    public static readonly DisplayKeyword InlineGrid = new("inline-grid");

    /// <summary>
    /// The element generates a subgrid container box that participates in the grid layout of its parent.
    /// </summary>
    public static readonly DisplayKeyword Subgrid = new("subgrid");
}
