using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{
    public interface IServiceType
    {
        string ServiceName { get; set; }
        decimal ServicePrice { get; set; }

        string ShowServiceDetail();
    }
}
