using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEx
{
    internal interface IBankFactory
    {
        public IBank GetBank(string code);
    }
}
