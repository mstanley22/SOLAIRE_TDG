using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesAccess.Extensions
{
    public static class DataExtensions
    {
        public static string EnumDescription(this Enum enumeration)
        {
            if (enumeration == null) return string.Empty;
            string value = enumeration.ToString();
            Type type = enumeration.GetType();
            //Use reflection to try and get the description attribute for the enumeration
            DescriptionAttribute[] descAttribute = (DescriptionAttribute[])type.GetField(value).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return descAttribute.Length > 0 ? descAttribute[0].Description : value;
        }
    }
}
