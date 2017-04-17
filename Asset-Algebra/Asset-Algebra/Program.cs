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

            Function_Token ft = new Function_Token();
            List_Token lt = new List_Token();

            lt.tokens.Add(my_token);

            List_Token lt2 = new List_Token();


            List<Token> tokens = new List<Token> { my_token, my_token, my_token, my_token};

            lt2.tokens.AddRange(tokens);

            Serialization_Helper.SerializeObject(lt2, "myserializedobject.xml");
            
            Console.WriteLine("Token address: " + my_token.address);
            Console.WriteLine("Token description: " + my_token.description);
            Console.WriteLine("Token hash: " + my_token.hash);
            Console.WriteLine("Silly integer is " + my_token.silly_int);
            Console.WriteLine("Press key to exit");

            Console.ReadKey();
        }
    }
}
