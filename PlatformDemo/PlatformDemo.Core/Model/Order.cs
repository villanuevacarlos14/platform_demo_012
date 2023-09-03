namespace PlatformDemo.Core.Model;

public class Order: BaseModel
{
    public int OrderNumber { get; set; }
    public decimal Amount { get; set; }
    
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}