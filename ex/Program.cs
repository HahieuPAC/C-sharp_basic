using System.Numerics;
namespace PTBac2
{
    class Program
    {
        static void Main(string[] Args)
        {

        }
    }

    class GiaiPTB2
    {
        /* Giai phuong trinh bac hai ax2+bx+c=0
         * @param a: he so bac 2
         * @param b: he so bac 1
         * @param c: so hang tu do
        */
        public void GiaiPT (float a, float b, float c)
        {
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
            float delta = (b * b) - (4 * a * c);
            float x1;
            float x2;

            // Tinh nghiem
            if (delta < 0)
            {
                Console.WriteLine($"Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                x1 = -(b / (2 * a));
                Console.WriteLine($"Phuong trinh co nghiem kep x1 = x2 = {0}", x1);
            }
            else
            {
                x1 = (float) (-b + Math.Sqrt(delta)) / (2 * a);
                x1 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
            }
        }
    }
}