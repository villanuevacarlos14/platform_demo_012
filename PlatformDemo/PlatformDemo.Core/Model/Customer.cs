namespace PlatformDemo.Core.Model;

public class Customer: BaseModel
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    
    public ICollection<Order> Orders { get; set; }
}