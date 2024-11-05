using System.Linq.Expressions;

namespace MudBlazorPlayground.ViewModels;

/// <summary>
/// Define your columns https://mudblazor.com/api/PropertyColumn%602#properties
/// </summary>
/// <typeparam name="T"></typeparam>
public class ColumnConfig<T>
{
    public Expression<Func<T, string>>? Property { get; set; }
    public Expression<Func<T, int>>? PropertyInt { get; set; }
    public Expression<Func<T, bool>>? PropertyBool { get; set; }
    public Expression<Func<T, DateTime>>? PropertyDate { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool Filterable { get; set; } = true;
}

public enum EColumnDataType
{
    String,
    Int,
    Bool,
    DateTime,
}

public abstract class BaseVM<T>
{
    public List<T> Items { get; set; } = new List<T>();
    public List<ColumnConfig<T>> Columns { get; set; } = new List<ColumnConfig<T>>();
}