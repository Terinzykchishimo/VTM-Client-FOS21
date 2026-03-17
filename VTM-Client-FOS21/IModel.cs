using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTM_Client_FOS21
{
    internal interface IModel
    {
        string data { get; set; }
        void reader();
        void writer();
        
    }
}
