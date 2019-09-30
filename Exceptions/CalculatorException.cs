using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class CalculatorException : Exception //manto no klases Exception (iebuveta klase)
    {
        public CalculatorException(string message) //veidojam konstruktoru : ctor+ tab tab
            : base(message) // manto no iebuveta konstruktora base
        {

        }

    }
}
