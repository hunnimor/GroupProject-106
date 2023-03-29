using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class ConstantValues
    {
        [DisplayName("константа")]
        public string Name
        {
            get; set;
        }
        [DisplayName("значение")]
        public double Value
        {
            get; set;
        }
        public override string ToString()
        {
            return $"{Name}={Value}";

        }
    }
}
