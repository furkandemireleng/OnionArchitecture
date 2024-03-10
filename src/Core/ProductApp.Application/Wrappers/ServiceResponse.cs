namespace ProductApp.Application.Wrappers;

public class ServiceResponse<T> // Generic Type disaridan value alabilir
{
    
    public T Value { get; set; }

    public ServiceResponse(T value)
    {
        Value = value;
    }

    public ServiceResponse()
    {
        
    }
    
}