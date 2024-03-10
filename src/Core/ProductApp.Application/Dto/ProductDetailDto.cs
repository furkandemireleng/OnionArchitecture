namespace ProductApp.Application.Dto;

public class ProductDetailDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public decimal Value { get; set; }

    public int Quantity { get; set; }

    public DateTime CreateDate { get; set; }
}