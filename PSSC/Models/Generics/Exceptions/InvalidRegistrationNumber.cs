﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    class InvalidRegistrationNumber : Exception
    {
        public InvalidRegistrationNumber(string message): base(message)
        {
        }
    }
}
