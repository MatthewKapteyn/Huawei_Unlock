using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Huawei_Unlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("This is a change made within the original Huawei_Unlock project");

            Debug.WriteLine(Test.HW_ALGO_SELECTOR("This_is_a_15_digit_imei_jk"));
        }

        
    }
}
