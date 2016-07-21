using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSRGS
{
    class Token
    {
        string Name;
        string Val;
        string ValType;

        public Token(string name, string val, string valType="string")
        {
            this.Name = name;
            this.Val = val;
            this.ValType = valType;
        }
    }
}
