using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public void Method(int num)
        {
            bool res = false;
            for (int i = 1;i <=num;i*=2)
            {
                if (i == num)
                {
                    res = true;
                }
            }
            if (res)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
