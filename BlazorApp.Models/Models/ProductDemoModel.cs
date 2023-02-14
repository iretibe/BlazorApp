namespace BlazorApp.Models.Models
{
    public class ProductDemoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public List<ProductProDemoModel> ProductProperties { get; set; }
    }
}
