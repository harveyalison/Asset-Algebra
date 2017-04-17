using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Algebra
{
    [Serializable]
    public class Base_Token:Token
    {
        public string address;    // Base token issuer address
        public string description;    // Description e.g. ''Pay bearer one USD''
        public string hash; // Hash of legal text defining Token.
        public int silly_int; // comment on silly int.
    }
}
