namespace Bai04
{
    class BaiTap04
    {
        public void FindSNT()
        {
            Console.Write("Nhap so luong SNT dau tien: ");
            int SoNguyen = int.Parse(Console.ReadLine());
            if (SoNguyen == 1)
            {
                Console.WriteLine($"{SoNguyen} dau tien la : 2");
            }
            else if (SoNguyen < 1)
            {
                Console.WriteLine("So ban nhap khong hop le");
            }
            else
            {
                Console.Write($"{SoNguyen} so nguyen to dau tien la: ");
                int k = 1;
                for (int i = 2; k <= SoNguyen; i++ )
                {
                    bool SNT = true;
                    for (int j=2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            SNT = false;
                            break;
                        }
                    }
                    if (SNT)
                    {
                        Console.Write($"{i} ");
                        k++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}