
namespace скоропечатание
{
    internal class Bukovki
    {
        public string[] word = new string[] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
        public Random rn = new Random();

        public int[] Logika(int d, int h)
        {
            
            int ss = rn.Next(0, 32);
            string pr = word[ss];
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("=============================");
            Console.WriteLine(pr);
            Console.WriteLine("=============================");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("=============================");
            Console.SetCursorPosition(0, 3);
            ConsoleKeyInfo k = Console.ReadKey();
            string b = k.KeyChar.ToString();
            if (b == pr)
            {
                d++;
            }
            else
            {
                h++;
            }
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("      ");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("      ");
            
            int[] ints = new int[] {d, h};
            return ints;
        }
        
    }
}
