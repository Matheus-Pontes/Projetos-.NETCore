// See https://aka.ms/new-console-template for more information

using System.Threading;

namespace Stopwatch 
{
    class Program
    {
        static void Main(string[] args) 
        {
            menu();    
        }

        static void menu() 
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            
            // Pegando pedaço da string
            char type = char.Parse(data.Substring(data.Length - 1 ,1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplicador = 1;

            if(type == 'm') 
                multiplicador = 60;
            if(type == 0)
                // Finaliza o programa
                System.Environment.Exit(0);

            preStart(time * multiplicador);
        }

        static void preStart(int time) 
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(500);
            Console.WriteLine("Set...");
            Thread.Sleep(500);
            Console.WriteLine("Go...");
            Thread.Sleep(500);

            start(time);
        }

        static void start(int time) 
        {
            int currentTime = 0;

            while(currentTime != time) 
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                
                // Espera 1 segundo
                Thread.Sleep(1000);            
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(500);
            menu();
        }
    }
}