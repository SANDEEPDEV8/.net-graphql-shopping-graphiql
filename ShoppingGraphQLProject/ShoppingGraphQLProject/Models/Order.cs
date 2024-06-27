namespace ShoppingGraphQL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Quantity { get; set; }
        public string SpecialRequest { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
