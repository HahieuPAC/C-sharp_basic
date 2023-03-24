using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    public class BaiTap02
    {
        public void UCLN()
        {
            bool foundUCLN = false;
            Console.Write("Nhap so thu nhat: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"So thu nhat la: {a}");
            Console.Write("Nhap so thu hai: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"So thu hai la: {b}");

            double a_init = a;
            double b_init = b;

            if (a == 0 || b == 0)
            {
                Console.Write("hai so tim UCLN phai khac 0");
            }    
            while (a != b && foundUCLN==false)
            {
                if (a > b)
                {
                    double SoDu = a % b;
                    switch ( SoDu)
                    {
                        case 0: Console.WriteLine($"UCLN cua {a_init} va {b_init} la: {b}");
                            foundUCLN = true; 
                        break;

                        default: a = b;
                            b = SoDu;
                            break;
                    }
                }
                else 
                {
                    double SoDu = b % a;
                    switch (SoDu)
                    {
                        case 0:
                            Console.WriteLine($"UCLN cua {a_init} va {b_init} la: {a}");
                            foundUCLN = true;
                            break;
                        default: b = a;
                            a = SoDu;
                            break;
                    }
                } 
            }

        }

        public void BCNN()
        {

        }
    }
}
