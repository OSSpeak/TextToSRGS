using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSRGS
{
    class TokenStream
    {

        private InputStream Input;
        private int Pos;
        private Token Current;

        public TokenStream(InputStream input)
        {
            this.Input = input;
            this.Pos = 0;
            this.Current = null;
        }

        private string ReadWhile(Func<string, bool> predicate)
        {
            var str = "";
            while (!Input.Eof() && predicate(Input.Peek()))
                str += Input.Next();
            return str;
        }

        private Token ReadNext()
        {
            return new Token("ad", "ad");
        }
        
        public Token Next()
        {
            var tok = Current;
            Current = null;
            return tok != null ? tok : ReadNext();
        }
        public Token Peek()
        {
            if (Current != null) return Current;
            Current = ReadNext();
            return Current;
        }
        public bool Eof()
        {
            return Peek() == null;
        }
        public void Croak(string msg)
        {
            Input.Croak(msg);
        }
     
    }
}
