using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boundary
{
    class Exception: ApplicationException
    {
        public override string Message
        {
            get { return "You clicked the wrong button!"; }
        }
    }
}
