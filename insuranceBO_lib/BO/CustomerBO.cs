using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using insuranceDA_lib.models;
using insuranceDA_lib.Repositories;
namespace insuranceBO_lib.BO
{

    public class CustomerBO
    {
         static CustomerRepository corepo = new CustomerRepository();
        public static void AddCustomer(insuranceBO_lib.models.Customer customer)
        {
            insuranceDA_lib.models.Customer cst = new insuranceDA_lib.models.Customer()
            {
                //CustomerId = customer.CustomerId,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                Address = customer.Address,

            };

            if (corepo.AddCustomer(cst))
            {
                Console.WriteLine("Customer Details are Added !");
            }
            else
            {
                Console.WriteLine("Customer Details could not be Added !");
            }

        }


    }
}
