using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSRGS
{
    class InputStream
    {
        
        private string text;
        private int pos;

        public InputStream(string text)
        {
            this.text = text;
            this.pos = 0;
        }
        public string Next()
        {
            return text[pos++].ToString();
        }
        public string Peek()
        {
            return text.Length > pos ? text[pos].ToString() : "";
        }
        public bool Eof()
        {
            return this.Peek() == "";
        }
        public void Croak(string msg)
        {
            throw new Exception(msg);
        }
    }
}
