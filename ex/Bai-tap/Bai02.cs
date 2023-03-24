using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    public class BaiTap02
    {
        public void UCLN(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                Console.Write("hai so tim UCLN phai khac 0");
            }    
            while (a != b)
            {
                if (a > b)
                {
                    int SoDu = a % b;
                    switch ( SoDu)
                    {
                        case 0: Console.WriteLine($"UCLN cua {a} va {b} la: {b}");
                        
                        break;

                        default: a = b;
                            b = SoDu;
                            break;
                    }
                }
                else
                {
                    int SoDu = a % b;
                    switch (SoDu)
                    {
                        case 0:
                            Console.WriteLine($"UCLN cua {a} va {b} la: {a}");
                            break;
                        default: b = a;
                            a = SoDu;
                            break;
                    }
                }
            }

        }
    }
}
