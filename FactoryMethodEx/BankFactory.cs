using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEx
{
    internal class BankFactory : IBankFactory
    {
        public IBank GetBank(string code )
        {
            switch (code)
            {
                case "123456" : return new QNB_Bank();
                case "246810": return new ElAhly_Bank();
            }
            return null;
        }
    }
}
