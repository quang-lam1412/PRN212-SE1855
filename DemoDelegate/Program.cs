using System.Text;

namespace DemoDelegate
{
    internal class Program
    {
        public delegate int MyDelegate(int x, int y);
        static int cong(int x, int y)
        {
            return x + y;
        }
        static int tru(int x, int y)
        {
            return x - y;
        }

        public delegate int[] MyDelegate2(int n);
        static int[] DanhSachSoChan(int n)
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= n; i += 2)
            {
                list.Add(i);
            }
            return list.ToArray();
        }

        static int[] ListOfPrimeNumbers(int n)
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MyDelegate d1 = new MyDelegate(cong);
            Console.WriteLine("Tổng của 5 và 8 =" + d1(5, 8));
            MyDelegate d0 = new MyDelegate(tru);
            Console.WriteLine("Hiệu của 5 và 8 =" + d0(5, 8));
            MyDelegate2 d2 = new MyDelegate2(DanhSachSoChan);
            int[] arr = d2(10);
            Console.WriteLine("Danh sách số chẵn từ 1 đến 10 là: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            d2 = new MyDelegate2(ListOfPrimeNumbers);
            arr = d2(10);
            Console.WriteLine("\nDanh sách sô nguyen tố: ");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }

        }
    }
}
