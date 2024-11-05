namespace MudBlazorPlayground.DTOs;

public class UserDto : BaseDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public bool IsAdmin { get; set; }
    public DateTime CreatedAt { get; set; }
}