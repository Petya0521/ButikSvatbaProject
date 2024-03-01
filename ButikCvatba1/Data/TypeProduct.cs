namespace ButikCvatba1.Data
{
    public class TypeProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DataUpdate { get; set; } = DateTime.Now;



        public ICollection<Product> Products { get; set; }
    }
}
