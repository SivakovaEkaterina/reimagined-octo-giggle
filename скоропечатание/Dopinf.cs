using Newtonsoft.Json;

namespace скоропечатание
{
    internal class Dopinf
    {
        public int Strelka(int a, int z)
        {
            int p = 2;
            ConsoleKeyInfo k;
            int b = 3;
            int c = 1;
            while (c != 0)
            {
                k = Console.ReadKey();
                if (k.Key == ConsoleKey.DownArrow)
                {
                    b = p;
                    p ++;
                }
                if (k.Key == ConsoleKey.UpArrow)
                {
                    b = p;
                    p --;
                }
                if (k.Key == ConsoleKey.Enter)
                {
                    c = 0;
                }
                if (p == -1)
                {
                    p = 0;
                }
                if (p < a)
                {
                    p = a;
                    b = p + 1;
                }
                if (p > z)
                {
                    p = z;
                    b = p - 1;
                }
                Console.SetCursorPosition(0, p);
                Console.WriteLine("->");
                Console.SetCursorPosition(0, b);
                Console.WriteLine("  ");
            }
            return p;
        } 
        public void Infa()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Проверьте вашу раскладку. Игра начнётся через пару секунд.");
            Console.WriteLine("----------------------------------------------------------");
            Thread.Sleep(5000);
            Console.Clear();
        }
        public void Cerialaz(List<Class1> pleer)
        {
            List<Class1> pler = pleer.OrderByDescending(x => x.Insec).ToList();
            var json = JsonConvert.SerializeObject(pler, Formatting.Indented);
            File.WriteAllText("C:\\Users\\edlit\\OneDrive\\Рабочий стол\\Результаты.json", json);
        }
        public List<Class1> DeCer(int k)
        {
            string s = "C:\\Users\\edlit\\OneDrive\\Рабочий стол\\Результаты.json";
            if (!File.Exists(s))
            {
                File.Create(s).Close();
            }
            List<Class1> uchastnik = new List<Class1>();
            string json = File.ReadAllText("C:\\Users\\edlit\\OneDrive\\Рабочий стол\\Результаты.json");
            uchastnik = JsonConvert.DeserializeObject<List<Class1>>(json) ?? new List<Class1>();
            if ((k == 1) || (k == 2))
            {
                Console.WriteLine("Имя  --------- В мин -- В сек  ---------");
                int p = 2;
                if (k == 1)
                {
                    p = 2;
                }
                if (k == 2)
                {
                    p = 4;
                }
                foreach (var pleer in uchastnik)
                {
                    Console.WriteLine(pleer.Name);
                    Console.SetCursorPosition(15, p);
                    Console.WriteLine(pleer.Inmin);
                    Console.SetCursorPosition(24, p);
                    Console.WriteLine(pleer.Insec);
                    p++;
                }
            }
            return uchastnik;
        }
        public void Tekst()
        {
            Console.WriteLine("Тест на скоропечатание");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("  Начать тест");
            Console.WriteLine("  Посмотреть таблицу рекордов");
        }
    }
}
