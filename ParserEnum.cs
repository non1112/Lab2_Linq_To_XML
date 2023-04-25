using Lab2_Linq_To_XML.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Linq_To_XML
{
    class ParserEnum
    {
        public static CarTechnicalCondition TechnicalCondition(string value)
        {
            CarTechnicalCondition technicalConditional;
            Enum.TryParse(value, out technicalConditional);
            return technicalConditional;
        }
     
        public static CarBodyType BodyType(string value)
        {
            CarBodyType bodyType;
            Enum.TryParse(value, out bodyType);
            return bodyType;
        }
    }
}
