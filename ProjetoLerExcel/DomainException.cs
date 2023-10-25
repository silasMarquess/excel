using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLerExcel
{
    class DomainException : ApplicationException
    {
        public DomainException(string messagem) : base(messagem) { }
      
    }
}
