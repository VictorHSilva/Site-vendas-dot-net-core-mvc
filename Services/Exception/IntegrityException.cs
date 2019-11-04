using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteVendas.Services.Exception
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string messege) : base(messege)
        {

        }
    }
}
