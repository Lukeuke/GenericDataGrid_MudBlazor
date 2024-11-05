using MudBlazorPlayground.DTOs;

namespace MudBlazorPlayground.ViewModels;

public class UserVM : BaseVM<UserDto>
{
    public UserVM()
    {
        Items = new List<UserDto>
        {
            new UserDto { Id = Guid.NewGuid(), Name = "John", Surname = "Doe", Age = 5, IsAdmin = true, CreatedAt = DateTime.Now },
            new UserDto { Id = Guid.NewGuid(), Name = "Jane", Surname = "Smith", Age = 18, IsAdmin = false, CreatedAt = DateTime.Now }
        };

        Columns = new List<ColumnConfig<UserDto>>
        {
            new ColumnConfig<UserDto> { Property = x => x.Name, Title = "Name" },
            new ColumnConfig<UserDto> { Property = x => x.Surname, Title = "Surname" },
            new ColumnConfig<UserDto> { PropertyInt = x => x.Age, Title = "Age" },
            new ColumnConfig<UserDto> { PropertyBool = x => x.IsAdmin, Title = "Admin" },
            new ColumnConfig<UserDto> { PropertyDate = x => x.CreatedAt, Title = "Created At" },
        };
    }
}