using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Algebra
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: inset your code for playing with assets here...

            Base_Token my_token = new Base_Token();
            my_token.address = "some address";
            my_token.description = "an example token";
            my_token.hash = "some hash";

            Console.WriteLine("Token address: " + my_token.address);
            Console.WriteLine("Token description: " + my_token.description);
            Console.WriteLine("Token hash: " + my_token.hash);

            Console.WriteLine("Press key to exit");

            Console.ReadKey();
        }
    }
}
