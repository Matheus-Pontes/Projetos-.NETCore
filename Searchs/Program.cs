namespace Searchs
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            int optionSearch;

            do
            {   Console.WriteLine("===============================");
                Console.Write("Informe o valor a ser buscado: ");
                var number = Convert.ToInt16(Console.ReadLine());

                Util.menu();

                Console.Write("Sua opção: ");
                optionSearch = Convert.ToInt16(Console.ReadLine());

                switch (optionSearch)
                {
                    case (int)Enum_Searchs.Sequencial:
                        SearchsService.searchSequencialService(number, array);
                        break;
                    case (int)Enum_Searchs.Binary:
                        SearchsService.binarySearchService(number, array);
                        break;
                }
            } while (optionSearch != (int)Enum_Out.OUT_PROGRAM);
        }
    }
}
