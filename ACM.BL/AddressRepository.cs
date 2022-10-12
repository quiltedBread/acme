using System.Collections;
using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            // temporary hard coded values to return populated address instance
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "415 S 9th";
                address.StreetLine2 = "Apt. 1";
                address.City = "Houston";
                address.State = "Texas";
                address.Country = "USA";
                address.PostalCode = "123";
            }
            return address;
        }
        public  IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>
            {
                new Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "400 Oak St.",
                    StreetLine2 = "Unit 1",
                    City = "Cincinnati",
                    State = "OH",
                    PostalCode = "123",
                    Country = "US"

                },
                new Address(2)
                {
                    AddressType = 1,
                    StreetLine1 = "401 Oak St.",
                    StreetLine2 = "Unit 1",
                    City = "Cincinnati",
                    State = "OH",
                    PostalCode = "123",
                    Country = "US"

                }
            };
            return addressList;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
