using MudBlazorPlayground.DTOs;

namespace MudBlazorPlayground.ViewModels;

public class UserVM : BaseVM<UserDto>
{
    public UserVM()
    {
        Items = new List<UserDto>
        {
            new UserDto { Name = "John", Surname = "Doe" },
            new UserDto { Name = "Jane", Surname = "Smith" }
        };

        Columns = new List<ColumnConfig<UserDto>>
        {
            new ColumnConfig<UserDto> { Property = x => x.Name, Title = "Name" },
            new ColumnConfig<UserDto> { Property = x => x.Surname, Title = "Surname" }
        };
    }
}