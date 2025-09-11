using Soenneker.Tests.Unit;
using Xunit;

namespace Soenneker.Quark.Enums.DisplayTypes.Tests;

public sealed class DisplayTypeTests : UnitTest
{
    [Fact]
    public void None_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.None;

        // Assert
        Assert.Equal("none", result.Value);
    }

    [Fact]
    public void Inline_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Inline;

        // Assert
        Assert.Equal("inline", result.Value);
    }

    [Fact]
    public void Block_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Block;

        // Assert
        Assert.Equal("block", result.Value);
    }

    [Fact]
    public void InlineBlock_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.InlineBlock;

        // Assert
        Assert.Equal("inline-block", result.Value);
    }

    [Fact]
    public void Flex_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Flex;

        // Assert
        Assert.Equal("flex", result.Value);
    }

    [Fact]
    public void Grid_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Grid;

        // Assert
        Assert.Equal("grid", result.Value);
    }

    [Fact]
    public void InlineFlex_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.InlineFlex;

        // Assert
        Assert.Equal("inline-flex", result.Value);
    }

    [Fact]
    public void InlineGrid_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.InlineGrid;

        // Assert
        Assert.Equal("inline-grid", result.Value);
    }

    [Fact]
    public void Table_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Table;

        // Assert
        Assert.Equal("table", result.Value);
    }

    [Fact]
    public void TableCell_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.TableCell;

        // Assert
        Assert.Equal("table-cell", result.Value);
    }

    [Fact]
    public void TableRow_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.TableRow;

        // Assert
        Assert.Equal("table-row", result.Value);
    }

    [Fact]
    public void TableHeaderGroup_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.TableHeaderGroup;

        // Assert
        Assert.Equal("table-header-group", result.Value);
    }

    [Fact]
    public void TableFooterGroup_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.TableFooterGroup;

        // Assert
        Assert.Equal("table-footer-group", result.Value);
    }

    [Fact]
    public void TableRowGroup_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.TableRowGroup;

        // Assert
        Assert.Equal("table-row-group", result.Value);
    }

    [Fact]
    public void TableColumn_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.TableColumn;

        // Assert
        Assert.Equal("table-column", result.Value);
    }

    [Fact]
    public void TableColumnGroup_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.TableColumnGroup;

        // Assert
        Assert.Equal("table-column-group", result.Value);
    }

    [Fact]
    public void TableCaption_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.TableCaption;

        // Assert
        Assert.Equal("table-caption", result.Value);
    }

    [Fact]
    public void InlineTable_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.InlineTable;

        // Assert
        Assert.Equal("inline-table", result.Value);
    }

    [Fact]
    public void ListItem_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.ListItem;

        // Assert
        Assert.Equal("list-item", result.Value);
    }

    [Fact]
    public void InlineListItem_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.InlineListItem;

        // Assert
        Assert.Equal("inline-list-item", result.Value);
    }

    [Fact]
    public void Contents_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Contents;

        // Assert
        Assert.Equal("contents", result.Value);
    }

    [Fact]
    public void Ruby_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Ruby;

        // Assert
        Assert.Equal("ruby", result.Value);
    }

    [Fact]
    public void RubyBase_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.RubyBase;

        // Assert
        Assert.Equal("ruby-base", result.Value);
    }

    [Fact]
    public void RubyText_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.RubyText;

        // Assert
        Assert.Equal("ruby-text", result.Value);
    }

    [Fact]
    public void RubyBaseContainer_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.RubyBaseContainer;

        // Assert
        Assert.Equal("ruby-base-container", result.Value);
    }

    [Fact]
    public void RubyTextContainer_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.RubyTextContainer;

        // Assert
        Assert.Equal("ruby-text-container", result.Value);
    }

    [Fact]
    public void RunIn_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.RunIn;

        // Assert
        Assert.Equal("run-in", result.Value);
    }

    [Fact]
    public void Flow_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Flow;

        // Assert
        Assert.Equal("flow", result.Value);
    }

    [Fact]
    public void FlowRoot_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.FlowRoot;

        // Assert
        Assert.Equal("flow-root", result.Value);
    }

    [Fact]
    public void Subgrid_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Subgrid;

        // Assert
        Assert.Equal("subgrid", result.Value);
    }

    [Fact]
    public void Inherit_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Inherit;

        // Assert
        Assert.Equal("inherit", result.Value);
    }

    [Fact]
    public void Initial_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Initial;

        // Assert
        Assert.Equal("initial", result.Value);
    }

    [Fact]
    public void Unset_ShouldReturnCorrectValue()
    {
        // Act
        var result = DisplayType.Unset;

        // Assert
        Assert.Equal("unset", result.Value);
    }

    [Fact]
    public void AllDisplayTypes_ShouldHaveUniqueValues()
    {
        // Arrange
        var displayTypes = new[]
        {
            DisplayType.None,
            DisplayType.Inline,
            DisplayType.Block,
            DisplayType.InlineBlock,
            DisplayType.Contents,
            DisplayType.ListItem,
            DisplayType.InlineListItem,
            DisplayType.Table,
            DisplayType.InlineTable,
            DisplayType.TableRowGroup,
            DisplayType.TableHeaderGroup,
            DisplayType.TableFooterGroup,
            DisplayType.TableRow,
            DisplayType.TableCell,
            DisplayType.TableColumnGroup,
            DisplayType.TableColumn,
            DisplayType.TableCaption,
            DisplayType.Ruby,
            DisplayType.RubyBase,
            DisplayType.RubyText,
            DisplayType.RubyBaseContainer,
            DisplayType.RubyTextContainer,
            DisplayType.RunIn,
            DisplayType.Flow,
            DisplayType.FlowRoot,
            DisplayType.Flex,
            DisplayType.InlineFlex,
            DisplayType.Grid,
            DisplayType.InlineGrid,
            DisplayType.Subgrid,
            DisplayType.Inherit,
            DisplayType.Initial,
            DisplayType.Unset
        };

        // Act
        var values = displayTypes.Select(dt => dt.Value).ToList();

        // Assert
        Assert.Equal(values.Count, values.Distinct().Count());
    }
}
