namespace ParcialCustomer.Infraestructure.Dtos
{
    public class OrderCustomerDto
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public int OrderNumber { get; set; }
        public string OrderStreet { get; set; }
        public string OrderCity { get; set; }
        public string OrderState { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
