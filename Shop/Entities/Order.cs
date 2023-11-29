namespace Shop.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Provider CurrentProvider { get; set; }
        public int SumOrder { get; set; }
        public Dictionary<Product,int> Products { get; set; }
    }
}
