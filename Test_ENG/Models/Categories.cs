using Microsoft.EntityFrameworkCore;

namespace Test_ENG.Models
{
    [PrimaryKey(nameof(CategoryId))]
    public class Categories
    {
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Products>? Products { get; set; }
    }
}
