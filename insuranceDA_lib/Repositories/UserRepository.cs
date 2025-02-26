using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using insuranceDA_lib.models;
namespace insuranceDA_lib.Repositories
{
    public class UserRepository : IRepositoryUser<User>
    {
        SqlConnection con;
        public UserRepository()
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
        public List<User> GetUserProfile()
        {
            throw new NotImplementedException();
        }

        public bool LoginUser(User entity)
        {
            throw new NotImplementedException();
        }

        public bool RegisterUser(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
