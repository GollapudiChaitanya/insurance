using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using insuranceDA_lib.models;
namespace insuranceDA_lib.Repositories
{
    public class PolicyRepository : IRepositoryPolicy<Policy>
    {
        SqlConnection con;
        public PolicyRepository()
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
        public bool CreatePolicy(Policy entity)
        {
            throw new NotImplementedException();
        }

        public bool DeletePolicy(Policy entity)
        {
            throw new NotImplementedException();
        }

        public List<Policy> GetPolicy(Policy entity)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePolicy(Policy entity)
        {
            throw new NotImplementedException();
        }
    }
}

