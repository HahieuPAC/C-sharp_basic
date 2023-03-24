using Bai01;
using Bai02;
using System.Runtime.CompilerServices;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] Args)
        {
            int chon;
            do
            {
                Console.WriteLine("Moi chon bai tap");
                Console.WriteLine("1 - Bai tap 01 (Chuong trinh giai phuong trinh bac 2)");
                Console.WriteLine("2 - Bai tap 02 (Chuong trinh tim UCLN va BCNN)");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1 : 
                    {
                        GiaiPTB2 giaiPhuongTrinh = new GiaiPTB2();
                            giaiPhuongTrinh.GiaiPT();
                    }
                    break;
                        case 2 :
                        do
                        {
                            Console.WriteLine("Moi chon bai tap");
                            Console.WriteLine("1 - Tim UCLN");
                            Console.WriteLine("2 - Tim BCNN");
                            int chon_2 = int.Parse(Console.ReadLine());
                            

                            switch (chon_2)
                            {
                                case 1:
                                    BaiTap02 ucln = new BaiTap02();

                                    ucln.UCLN();
                                    break;

                                case 2:

                            }    
                        }
                        while (chon >= 1);
                            

                        
                        break;
                }

            } while (chon >=1);     

        }
    }
}