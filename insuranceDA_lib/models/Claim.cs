using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace insuranceDA_lib.models
{
   public class Claim
    {
        public int ClaimId { get; set; }
        public int PolicyId {  get; set; }  
        public decimal ClaimAmount { get; set; }    
      public string ClaimStatus {  get; set; }   
       public DateTime SubmissionDate {  get; set; }    

      public DateTime SettlementDate {  get; set; } 
    }
}
