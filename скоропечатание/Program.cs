using System;
using System.Diagnostics;
using System.Threading;
using Newtonsoft.Json;

namespace скоропечатание
{
    internal class Program
    {
        public static int t = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Thread tim = new Thread(() =>
                {
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Thread.Sleep(60000);
                    stopWatch.Stop();
                    Console.Clear();
                    
                    t++;
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Игра окончена! Нажмите Enter что бы увидеть результаты.");
                    Console.WriteLine("-------------------------------------------------------");
                });
                Thread timer = new Thread(() =>
                {
                    int h = 60;
                    while (h != 0)
                    {
                        Console.SetCursorPosition(32, 2);
                        Console.WriteLine("Осталось " + h +" секунд");
                        Console.SetCursorPosition(0, 0);
                        Thread.Sleep(1000);
                        h--;
                    }
                    
                    
                });
                    Dopinf dop = new Dopinf();
                dop.Tekst();
                int v = dop.Strelka(2, 3);
                Class1 pleer = new Class1();
                pleer.Name = "";
                pleer.Inmin = 0;
                pleer.Insec = 0;
                if (v == 2)
                {
                    Console.Clear();
                    pleer.Name = Iformation();
                    dop.Infa();
                    tim.Start();
                    timer.Start();
                    Bukovki bukovki = new Bukovki();
                    int[] a = new int[2];
                    int d = 0;
                    int h = 0;
                    while (t == 0)
                    {
                        a = bukovki.Logika(d, h);
                        d = a[0];
                        h = a[1];
                        if (t == 1)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    
                    Console.WriteLine("Ваш результат:");
                    Console.WriteLine("За 10 секунд: " + Math.Round((d / 6.00), 2) + ". В секунду: " + Math.Round((d / 60.00), 2) + ". В минуту: " + d + ". Кол-во ошибок: " + h);
                    Console.WriteLine("Нажмите ESC или любую другую кнопку что бы вернуться.");
                    pleer.Inmin = d;
                    pleer.Insec = Math.Round((d / 60.00), 2);
                    List<Class1> uchastnik = dop.DeCer(0);
                    uchastnik.Add(pleer);
                    dop.Cerialaz(uchastnik);
                    dop.DeCer(2);
                    Console.ReadKey();
                    Console.Clear();
                }
                if (v == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Нажмите ESC или любую другую кнопку что бы вернуться.");
                    dop.DeCer(1);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            
        }
        static string Iformation()
        {
            Console.WriteLine("Как вас зовут?");
            string n = Console.ReadLine();
            return n;
        }

    }
}