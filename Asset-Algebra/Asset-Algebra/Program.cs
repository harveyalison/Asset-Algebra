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
            my_token.silly_int = 5;

            Console.WriteLine("Token address: " + my_token.address);
            Console.WriteLine("Token description: " + my_token.description);
            Console.WriteLine("Token hash: " + my_token.hash);
            Console.WriteLine("Silly integer is " + my_token.silly_int);
            Console.WriteLine("Press key to exit");

            Console.ReadKey();
        }
    }
}
