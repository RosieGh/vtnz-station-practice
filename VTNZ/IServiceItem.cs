using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{
    public interface IServiceItem
    {
        string ServiceName { get; set; }
        decimal ServicePrice { get; set; }

        string ShowService();
    }
}
