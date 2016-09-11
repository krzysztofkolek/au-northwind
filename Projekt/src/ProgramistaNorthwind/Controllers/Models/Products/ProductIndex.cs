namespace ProgramistaNorthwind.Controllers.Models.Products
{
    public class ProductIndex
    {
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double UnitPrice { get; set; }
        public bool IsInStock { get; set; }
    }
}
