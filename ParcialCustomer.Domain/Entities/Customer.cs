//using ParcialProductAPI.Models.Aggregates;
using ParcialCustomer.Domain.ValueObjects;


namespace ParcialCustomer.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        //public List<Order> Orders { get; set; }
        public bool IsDeleted { get; set; }
    }
}
