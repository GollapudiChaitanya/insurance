using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using insuranceDA_lib.models;
namespace insuranceDA_lib.Repositories
{
    public class ClaimRepository : IRepositoryClaim<Claim>
    {
        SqlConnection con;
        public ClaimRepository()
        {
            con= new SqlConnection(ConnectionString);
            con.Open();
        }
        public string ConnectionString
        {
            get
            {
                return "Data Source=LTIN400008;Initial Catalog=project;Integrated Security=True";
            }
        }

        public List<Claim> GetClaimDetails()
        {
            throw new NotImplementedException();
        }

        public bool ProcessClaim(Claim entity)
        {
            throw new NotImplementedException();
        }

        public bool SubmitClaim(Claim entity)
        {
            throw new NotImplementedException();
        }
    }
}
