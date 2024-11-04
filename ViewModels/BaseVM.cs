using System.Linq.Expressions;

namespace MudBlazorPlayground.ViewModels;

/// <summary>
/// Define your columns https://mudblazor.com/api/PropertyColumn%602#properties
/// </summary>
/// <typeparam name="T"></typeparam>
public class ColumnConfig<T>
{
    public Expression<Func<T, object>> Property { get; set; } = _ => default!;
    public string Title { get; set; } = string.Empty;
}

public abstract class BaseVM<T>
{
    public List<T> Items { get; set; } = new List<T>();
    public List<ColumnConfig<T>> Columns { get; set; } = new List<ColumnConfig<T>>();
}