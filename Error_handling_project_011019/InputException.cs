using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_handling_project_011019
{
    class InputExceptions : Exception //manto no klases Exception (iebuveta klase)
    {
        public InputExceptions(string message)
            : base (message) // manto no iebūvētā konstruktora base
        {

        }
    }
}
