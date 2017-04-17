using System;
using System.Xml.Serialization;

namespace Asset_Algebra
{
    [XmlInclude(typeof(Base_Token))]
    [XmlInclude(typeof(List_Token))]
    [XmlInclude(typeof(Function_Token))]
    [Serializable]
    public class Token
    {
    }
}