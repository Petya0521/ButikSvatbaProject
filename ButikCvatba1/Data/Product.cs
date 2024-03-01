using System.ComponentModel.DataAnnotations.Schema;

namespace ButikCvatba1.Data
{
    public class Product
    {
        public int Id { get; set; }
        public int CatalogNum { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public DateTime DataUpdate { get; set; } = DateTime.Now;

        public int TypeProductId { get; set; }
        public TypeProduct TypeProducts { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
