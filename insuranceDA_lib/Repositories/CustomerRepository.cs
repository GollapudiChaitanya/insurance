using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using insuranceDA_lib.models;
namespace insuranceDA_lib.Repositories
{
    public class CustomerRepository : IRepositoryCustomer<Customer>
    {
        SqlConnection con;
        public CustomerRepository()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            
        }
        public string ConnectionString
        {
            get
            {
                return "Data Source=LTIN400008;Initial Catalog=project;Integrated Security=True";
            }
        }
        public bool AddCustomer(Customer entity)
        {
            bool b = false;
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer values(@p1,@p2,@p3,@p4)", con);
                //cmd.Parameters.Add("@p1", entity.CustomerId);
                cmd.Parameters.Add("@p1", entity.Name);
                cmd.Parameters.Add("@p2", entity.Email);
                cmd.Parameters.Add("@p3", entity.Phone);
                cmd.Parameters.Add("@p4", entity.Address);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    b = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert Operation Failed -"+ex.Message);
                b=false;
            }
            return b;
        }

        public List<Customer> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
