using ParcialOrder.Domain.ValueObjects;
using ParcialOrder.Domain.Interfaces;

namespace ParcialOrder.Domain.Aggregates
{
    public class Order 

    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Customer Customer { get; set; }
        public Address Address { get; set; }
        //public List<Product> Products { get; set; }
        public decimal TotalAmount { get; set; }
        //public List<OrderItem> OrderItems { get; set; }
        public bool IsDeleted { get; set; }
    }
    
}
