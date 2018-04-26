using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFwithSingleton.Helper.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumFieldTextAttribute : Attribute
    {
        private string _enumFieldText;

        public EnumFieldTextAttribute(string enumFieldText)
        {
            _enumFieldText = enumFieldText;
        }

        public string EnumFieldText
        {
            get { return _enumFieldText; }
            set { _enumFieldText = value; }
        }
    }
}
