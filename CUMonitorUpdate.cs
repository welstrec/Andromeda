using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda
{
    public class CUMonitorUpdate
    {
        public static int DEV_TYPE_CPU = 0;
        public static int DEV_TYPE_GPU = 0;
        public int deviceType;
        public int tjmax;
        public String devName;
        public int load;
        public int temp;
        public int ramUsage;
        public int clk;
    }
}
