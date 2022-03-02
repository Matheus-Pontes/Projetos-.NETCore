using System;

namespace EditorHtml
{
    public static class Menu 
    {
        public static void Show() 
        {
            Console.Clear();

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen() 
        {
            int columns = 70;
            int lines = 15;

            Console.Write("+");
            for(int i=0; i <= columns; i++) 
                Console.Write("-");
            Console.WriteLine("+");

            for(int k=0; k <= lines; k++) 
            {
                Console.Write("|");
                for(int i=0; i <= columns; i++) 
                    Console.Write(" ");
                Console.WriteLine("|");
            }

            Console.Write("+");
            for(int j=0; j <= columns; j++) 
                Console.Write("-");
            Console.WriteLine("+");
            
        }
    
        public static void WriteOptions() 
        {
            int positionX = 5;
            Console.SetCursorPosition(positionX, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(positionX, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(positionX, 4);
            Console.WriteLine("Selecione a opção abaixo: ");
            Console.SetCursorPosition(positionX, 6);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(positionX, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(positionX, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(positionX, 10);
            Console.Write("Opção: ");


        }
    
        public static void HandleMenuOption(short option) 
        {
            switch(option) 
            {
                case 1: Editor.Show(); break; 
                case 2: Console.Write("View"); break; 
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }  
                default: Show(); break;;
            }
        }
    }
}