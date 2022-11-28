namespace Searchs
{
    public class SequencialSearch : SearchInterface
    {
        public int search(int numberSearch, int[] array)
        {
            int position = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (numberSearch == array[i])
                    position = i;
            }


            return position;
        }
    }
}
