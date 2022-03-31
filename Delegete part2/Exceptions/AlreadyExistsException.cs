using System;
using System.Collections.Generic;
using System.Text;

namespace Delegete_part2.Exceptions
{
    internal class AlreadyExistsException:Exception
    {
        public AlreadyExistsException(string messaga):base(messaga)
        {

        }
    }
}
