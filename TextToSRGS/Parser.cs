using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSRGS
{
    class Parser
    {

        private string Input;
        private TokenStream Stream;

        public Parser(string input)
        {
            this.Input = input;
        }
        public void Parse()
        {
            var inputStream = new InputStream(Input);
            this.Stream = new TokenStream(inputStream);
            while (!Stream.Eof())
            {
                var t = this.Stream.Next();

            }
        }
    }
}
