using System;

namespace StopWatch
{
    class Program
    {

        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("S = SEGUNDOS => 10s = 10 segundos");
            Console.WriteLine("S = SEGUNDOS => 10m = 10 minutos");
            Console.WriteLine("Digite 0 para Sair do programa");
            Console.WriteLine(" ");
            Console.WriteLine("Agora, digite o tempo que deseja cronometrar");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {

            Console.Clear();
            Console.WriteLine("ready..");
            Thread.Sleep(1000);
            Console.WriteLine("set..");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
            Thread.Sleep(2500);

            Start(time);



        }


        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Contador (Stopwatch) finalizado!");
            Thread.Sleep(2500);
            Menu();

        }
    }
}