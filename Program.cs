namespace problem2
{
    internal class Program
    {
        static void Main()
        {
            /* a soni berilgan.  0 dan a gacha bo'lgan
               sonlaryig'indisini toping  va yig'indini konsolga chiqaring.
               a sonini ham hisobga oling. */
            while (true)
            {
                Console.Write("Sonni kiriting=> "); int.TryParse(Console.ReadLine(), out int n);
                int sum = 0;
                for (int i = 1; i <= n; i++) sum += i;
                Console.WriteLine("Total sum: " + sum);
            }
        }
    }
}