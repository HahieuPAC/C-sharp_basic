namespace Bai05
{
    class BaiTap05
    {
        public void SNT()
        {
            for (int i = 10000; i <=99999; i++ )
            {
                bool SNT = true;
                for (int j=2; j <= Math.Sqrt(i); j++)
                    {
                        if (SoNguyen % j == 0)
                        {
                            SNT = false;
                            break;
                        }
                    }
                 if (SNT)
                    {
                        Console.Write($"{i} ");
                    }
            }
        }
    }
}