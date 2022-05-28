public class SearchsService
{
    public static void searchSequencialService(int number, int[] array)
    {
        var sequencialSearchReturn = sequencialSearch(number, array);
        if (sequencialSearchReturn != -1)
            Console.WriteLine("Encontramos o {0} na posição {1}", number, sequencialSearchReturn);
        else
            Console.WriteLine("Não encontramos o número {0}", number);
    }

    public static void binarySearchService(int number, int[] array)
    {
        var binarySearchIndex = binarySearch(number, array, 0, array.Length);

        if (binarySearchIndex != -1)
            Console.WriteLine("Encontramos o {0} na posição {1}", number, binarySearchIndex);
        else
            Console.WriteLine("Não encontramos o número {0}", number);
    }

    private static int sequencialSearch(int number, int[] array)
    {
        int position = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
                position = i;
        }

        return position;
    }

    private static int binarySearch(int number, int[] array, int start, int end)
    {
        if (start <= end)
        {
            int middlePosition = (start + end) / 2;

            if (number == array[middlePosition])
                return middlePosition;
            if (number < array[middlePosition])
                return binarySearch(number, array, start, middlePosition - 1);
            else
                return binarySearch(number, array, middlePosition + 1, end);
        }
        else
            return -1;
    }
}