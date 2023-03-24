using Bai01;
using Bai02;

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
                Console.WriteLine("1 - Bai tap 01 (Chuong trinh gia phuong trinh bac 2)");
                Console.WriteLine("2 - Bai tap 02 (Chuong trinh tim UCLN va BCNN)");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1 : 
                    {
                        Console.WriteLine("Nhap so a");
                        Double a = double.Parse(Console.ReadLine()); 
                        Console.WriteLine("Nhap so b");
                        Double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so c");
                        Double c = double.Parse(Console.ReadLine());

                        GiaiPTB2 giaiPhuongTrinh = new GiaiPTB2();

                        giaiPhuongTrinh.GiaiPT(a,b,c);
                    }
                    break;
                        case 2 :
                        Console.WriteLine("Nhap so thu nhat: ");
                        int d = int.Parse(Console.ReadLine());
                        Console.Write("Nhap so thu nhat la: ");
                        Console.WriteLine("Nhap so thu hai: ");
                        int e = int.Parse(Console.ReadLine());
                        Console.Write("Nhap so thu hai la: ");

                        BaiTap02 ucln = new BaiTap02();

                        ucln.UCLN(d, e);
                        break;
                }

            } while (chon >=1);     

        }
    }
}