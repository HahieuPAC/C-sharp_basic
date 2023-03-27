using Bai01;
using Bai02;
using Bai03;
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
                Console.WriteLine("3 - Bai tap 03 (Viet tat ca cac so nguyn to nho hon n)");
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
                    BaiTap02 ucln = new BaiTap02();
                    ucln.UCLN();
                    break;

                    case 3 :
                    BaiTap03 snt = new BaiTap03();
                    snt.FindSNT();
                    break;
                }

            } while (chon >=1);     

        }
    }
}