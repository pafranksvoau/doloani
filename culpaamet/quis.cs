public class Program
{
    public static void Main(string[] args)
    {
        var builder = new ApiRequestBuilder();
        builder.WithUrl("https://api.example.com/resource")
               .AddQueryParameter("key", "value")
               .AddBodyParameter("data", "example")
               .Build();
    }
}
