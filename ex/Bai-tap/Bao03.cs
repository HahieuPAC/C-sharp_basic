namespace Bai03
{
    class BaiTap03
    {
         public void FindSNT()
        {
            
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            int SoNguyen;
            if (n <=2)
            {
                Console.WriteLine("Khong co so nguyen to nao nho hon so ban vua nhap");
            }
            else
            {
                Console.Write("Cac so nguyen to nho hon " + n + ": ");
                for (SoNguyen = 2; SoNguyen <n; SoNguyen++)
                {
                    bool SNT = true;
                    for (int j=2; j <= Math.Sqrt(SoNguyen); j++)
                    {
                        if (SoNguyen % j == 0)
                        {
                            SNT = false;
                            break;
                        }
                    }
                    if (SNT)
                    {
                        Console.Write($"{SoNguyen} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}