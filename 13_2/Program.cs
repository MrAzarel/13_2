using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(Print1);
        Thread thread2 = new Thread(Print2);

        thread1.Start();
        thread2.Start();

        void Print1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Первый поток: {i}");
                Thread.Sleep(300);
            }
        }

        void Print2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Второй поток: {i}");
                Thread.Sleep(400);
            }          
        }
    }
}
