namespace _3LArchitecture.Common.DTO;

public class ProductDTO
{
    public Guid UUID { get; set; }
    
    public string Name { get; set; }
    
    public double Price { get; set; }
    
    public AgeLimitDTO AgeLimit { get; set; }
}