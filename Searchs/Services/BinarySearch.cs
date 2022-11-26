using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchs
{
    public class BinarySearch : SearchInterface
    {
        public int search(int numberSearch, int[] array)
        {
            return binarySearch(numberSearch, array, 0, array.Length);
        }

        public int binarySearch(int number, int[] array, int start, int end)
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
}
