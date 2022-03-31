using System;
using System.Collections.Generic;
using System.Text;

namespace Delegete_part2.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
