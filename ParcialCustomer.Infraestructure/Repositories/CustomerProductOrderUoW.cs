using ParcialCustomer.Infraestructure.Data;

using ParcialCustomer.Domain.Interfaces;


namespace ParcialCustomer.Infraestructure.Repositories
{
    public class CustomerProductOrderUoW
    {
        private readonly ApplicationDbConext _dbContext;
        //private IProductRepository _productRepository;
        private ICustomerRepository _customerRepository;
        //private IOrderRepository _orderRepository;
        public CustomerProductOrderUoW(ApplicationDbConext dbContext)
        {
            _dbContext = dbContext;
            _customerRepository = new CustomerRepository(dbContext);
            //_productRepository = new ProductRepository(dbContext);
            //_orderRepository = new OrderRepository(dbContext);
        
        }


        public void Save() 
        {
            _dbContext.SaveChanges(); 
        }
    }
}
