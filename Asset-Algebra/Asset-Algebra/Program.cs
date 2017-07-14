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

            List_Token lt1 = new List_Token();

            lt1.tokens.Add(my_token);

            List_Token lt2 = new List_Token();


            List<Token> tokens = new List<Token> { my_token, my_token, my_token, my_token};

            lt2.tokens.AddRange(tokens);

            Function_Token ft = new Function_Token();
            ft.datetime = new DateTime(2016,3,24);

            ft.token = lt1;

            List_Token lt3 = new List_Token();

            lt3.tokens.Add(ft);
            lt3.tokens.Add(lt1);

            Serialization_Helper.SerializeObject(my_token, "mytoken.xml");


            Serialization_Helper.SerializeObject(lt1, "myserializedobject1.xml");

            Serialization_Helper.SerializeObject(lt2, "myserializedobject2.xml");

            Serialization_Helper.SerializeObject(lt3, "myserializedobject3.xml");

            var newobj = Serialization_Helper.DeSerializeObject<List_Token>("myserializedobject3.xml");

            Console.WriteLine("First entry: " + newobj.tokens.Count);



            Console.WriteLine("Token address: " + my_token.address);
            Console.WriteLine("Token description: " + my_token.description);
            Console.WriteLine("Token hash: " + my_token.hash);
            Console.WriteLine("Silly integer is " + my_token.silly_int);
            Console.WriteLine("Press key to exit");

            Console.ReadKey();
        }
    }
}
