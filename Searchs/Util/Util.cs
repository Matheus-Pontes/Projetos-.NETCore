namespace Searchs
{
    public class Util
    {
        public static void menu()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Opções de busca:\n 1 - Sequencial \n 2 - Binária \n 0 - Sair");
            Console.WriteLine("===================");
        }

        public static void bubbleSort(int[] array)
        {
            if (array == null) return;

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array.Length - 1 - i; k++)
                {
                    if (array[k] > array[k + 1])
                    {
                        change(k, array);
                    }
                }
            }
        }

        public static void change(int position, int[] array)
        {
            int positionTemp = array[position];
            array[position] = array[position + 1];
            array[position + 1] = positionTemp;
        }
    }
}


