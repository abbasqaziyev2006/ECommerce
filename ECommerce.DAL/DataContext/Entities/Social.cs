using ECommerce.DAL.DataContext.Entities;

public class Social : Entity
{
    public required string Name { get; set; }
    public required string Class { get; set; }
    public string? Url { get; set; }
}
