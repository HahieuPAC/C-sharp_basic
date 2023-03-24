namespace Bai01
{
     class GiaiPTB2
    {
        /* Giai phuong trinh bac hai ax2+bx+c=0
         * @param a: he so bac 2
         * @param b: he so bac 1
         * @param c: so hang tu do
        */
        public void GiaiPT ()
        {
            Console.WriteLine("Nhap so a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so c");
            double c = double.Parse(Console.ReadLine());
            if (a==0)
            {
                if (b==0)
                {
                    Console.WriteLine($"Phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine($"nghiem cua phuong trinh la: x = {0}", (-c / b));
                }
            }

            //Tinh delta 
            Double delta = (b * b) - (4 * a * c);
            Double x1;
            Double x2;

            // Tinh nghiem
            if (delta < 0)
            {
                Console.WriteLine($"Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                x1 = -(b / (2 * a));
                Console.WriteLine($"Phuong trinh co nghiem kep x1 = x2 = {x1}");
            }
            else
            {
                x1 = (Double) (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (Double)(-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Nghiem cua phuong trinh la: x1 = {x1}, x2 = {x2}");
            }
        }
    }
}