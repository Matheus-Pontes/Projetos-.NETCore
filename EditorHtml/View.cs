using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class View
    {
        public static void Show(string text) 
        {
            Console.Clear();
            Console.WriteLine("----------");
            Console.WriteLine("Viwer Mode");
            Console.WriteLine("----------");

            ReplaceText(text);
            // Console.WriteLine("----------");

            Console.ReadKey(); // espera o enter
            Menu.Show();
        }


        public static void ReplaceText(string text) 
        {
            // fazer um array, para todas as tags
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");

            // separando o texto por espaços
            var words = text.Split(' '); 

            for(var i=0; i < words.Length; i++) 
            {
                Console.WriteLine(words[i]);
                if(strong.IsMatch(words[i]))
                {
                    Console.WriteLine("teste");

                    Console.ForegroundColor = ConsoleColor.Blue;

                    var textoStrong = 
                    words[i].Substring(
                        words[i].IndexOf('>') + 1, 
                        (
                            (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')    
                        )
                    );

                    Console.Write(textoStrong);

                    // Console.Write(" ");
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}