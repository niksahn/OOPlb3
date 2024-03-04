using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1lb
{
    internal class ArrayExeption: ArgumentOutOfRangeException
    {

        public String Index;
        public ArrayExeption() : base() { }
        public ArrayExeption(string message) : base(message) { }

        public ArrayExeption(string message, String index): base(message) { Index = index; }
        public ArrayExeption(string message, Exception innerException) : base(message, innerException) { }
    }
}
