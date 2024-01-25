﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEx
{
    internal class QNB_Bank : IBank
    {
        public string WelcomeMessage(string username)
        {
            return $" Hello {username} in QNB_Bank "; 
        }
    }
}
