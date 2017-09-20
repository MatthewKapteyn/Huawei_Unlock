using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huawei_Unlock
{
    public class Test
    {
        public static long HW_ALGO_SELECTOR(string IMEI)
        {
            string Code = "";

            // No idea if this works - it's something I toyed with for 5 minutes and never tested
            for (int i = 0; i < 15; i++)
            {
                Code = Code + ((int)IMEI[i] + (i + 1)) * (i + 1);
            }

            long RealCode = Int64.Parse(Code);

            return (RealCode % 7);
        }
    }
}
