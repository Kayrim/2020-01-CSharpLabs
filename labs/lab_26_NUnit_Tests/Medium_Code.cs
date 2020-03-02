using System;
using System.Collections.Generic;
using System.Text;

namespace lab_26_NUnit_Tests
{
    class Medium_Code
    {



        // Check when two numbers are multiplied together this generates an overflow exception
        // when the output exceeds the maximum value for a 32 bit integer

        public int Test_560_Throw_Exception_Test(int x, int y)
        {
            int output = 0;
            checked
            {
                output = x * y;

            }
            return output;
        }
    }
}
