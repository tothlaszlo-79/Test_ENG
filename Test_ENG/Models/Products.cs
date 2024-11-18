using Microsoft.EntityFrameworkCore;

namespace Test_ENG.Models
{
    [PrimaryKey(nameof(ProductId))]
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }  
    }
}
