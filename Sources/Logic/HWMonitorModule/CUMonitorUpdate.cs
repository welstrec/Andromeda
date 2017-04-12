using System;

namespace Andromeda
{
    public class CUMonitorUpdate
    {
        public String fullName;
        public static int DEV_TYPE_CPU = 0;
        public static int DEV_TYPE_GPU = 0;
        public int deviceType;
        public int tjmax;
        public String devName;
        public int load;
        public int temp;
        public int ramUsage;
        public int clk;

        public int getIconInfo()
        {
            int type = 0;
            if(fullName.Contains("NVIDIA"))
            {
                type = 1;
            }
            else if(fullName.Contains("ATI"))
            {
                type = 2;
            }
            else if(fullName.Contains("Intel"))
            {
                if(fullName.Contains("i3"))
                {
                    type = 3;
                }
                if (fullName.Contains("i5"))
                {
                    type = 4;
                }
                if(fullName.Contains("i7"))
                {
                    type = 5;
                }                
            }
            else
            {
                type = 6;
            }
            return type;
        }
    }
}
