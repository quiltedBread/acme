using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            // temporary hard coded values to return populated customer instance
            if(customerId == 1)
            {
                customer.EmailAddress = "mharper@yahoo.com";
                customer.FirstName = "Matt";
                customer.LastName = "Harper";
                customer.Addresses = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
        public bool Save()
        {
            return true;
        }
    }
}
