using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteVendas.Services.Exception
{
    public class NotFoudException : ApplicationException
    {
               
     public NotFoudException(string message) : base(message)
        {

        }       
    }
}
