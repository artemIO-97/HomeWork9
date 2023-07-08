using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp3
{
    public class UserExeption:Exception
    {
        public UserExeption()
        {
            
        }
        public UserExeption(string message) : base(message)
        {
            
        }
    }
}
