using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using insuranceBO_lib.BO;
using insuranceBO_lib.models;
namespace insuranceapp
{
   public class Program
    {
        public  static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("1. Add Customers");
                Console.WriteLine("2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
               switch(option)
                {
                    case 1:
                        Console.WriteLine(" Wish to Enter the Customer details? Press Y");
                        string ans=Console.ReadLine();
                        while (ans.ToUpper()[0]=='Y')
                        {
                            Console.WriteLine("Enter Name, email, Phone and Address");
                            insuranceBO_lib.models.Customer c=new insuranceBO_lib.models.Customer()
                            {
                                //CustomerId=Convert.ToInt32(Console.ReadLine()),
                                Name=Console.ReadLine(),
                                Email=Console.ReadLine(),   
                                Phone=Console.ReadLine(),   
                                Address=Console.ReadLine(),
                            };
                            CustomerBO.AddCustomer(c);





                            Console.WriteLine("Wish to add more customer details? Press Y");
                            ans= Console.ReadLine();    


                        }
                        break;
                    case 2:
                        Console.WriteLine("Terminating...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter the  correct option");
                        break;
                }
            }
        }
    }
}
