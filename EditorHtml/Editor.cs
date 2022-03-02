using System;
using System.Text;

namespace EditorHtml 
{
    public static class Editor 
    {
        public static void Show() 
        {
            Console.Clear();
            Console.WriteLine("Editor Mode");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start() 
        {
            var file = new StringBuilder();

            do 
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            View.Show(file.ToString());
            
            Console.WriteLine("-----------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            // Faz uma condição e salvar a ideia
        }
    
    }


}