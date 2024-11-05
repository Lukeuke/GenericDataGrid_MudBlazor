using MudBlazorPlayground.ViewModels;

namespace MudBlazorPlayground.Helpers;

public static class ColumnTypeHelper
{
    public static EColumnDataType GetColumnType<TProperty>()
    {
        var type = typeof(TProperty);
        if (type == typeof(string)) return EColumnDataType.String;
        if (type == typeof(int)) return EColumnDataType.Int;
        if (type == typeof(bool)) return EColumnDataType.Bool;
        if (type == typeof(DateTime)) return EColumnDataType.DateTime;
        throw new NotSupportedException("Unsupported column data type.");
    }
}