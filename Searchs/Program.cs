namespace Searchs
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] array = { 5, 6, 8, 4, 25, 521564, 45, 85, 2, 3 };
            int optionSearch;
            var search = new Search();

            do
            {   Console.WriteLine("===============================");
                Console.WriteLine("   Dos números [5, 6, 8, 4, 25, 521564, 45, 85, 2, 3]");
                Console.WriteLine("===============================");
                Console.WriteLine("Informe o número a ser buscado: ");
                var number = Convert.ToInt16(Console.ReadLine());

                Util.menu();

                Console.Write("Sua opção: ");
                optionSearch = Convert.ToInt16(Console.ReadLine());

                switch (optionSearch)
                {
                    case (int)Enum_Searchs.Sequencial:
                        search.setSearch(new SequencialSearch());
                        Console.WriteLine($"O número {number} se encontra na posição {search.SearchIndexNumber(number, array)}");
                        break;
                    case (int)Enum_Searchs.Binary:
                        search.setSearch(new BinarySearch());
                        Util.bubbleSort(array);
                        Console.WriteLine($"O número {number} se encontra na posição {search.SearchIndexNumber(number, array)}");
                        break;
                }
            } while (optionSearch != (int)Enum_Out.OUT_PROGRAM);
        }
    }
}
