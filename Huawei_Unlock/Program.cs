﻿using System;
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
            Debug.WriteLine("Hello World, this is a change made in the project named SubmoduleTest");

            Debug.WriteLine(Test.HW_ALGO_SELECTOR("This_is_a_15_digit_imei_jk"));

            Debug.WriteLine(Test.HW_ALGO_SELECTOR("and now we do this, without submodules"));

            Debug.WriteLine("This is a second change made via SubmoduleTest.");

            Debug.WriteLine("This is a third change made via SubmoduleTest. See what's so big about GiTower");
        }

        
    }
}
