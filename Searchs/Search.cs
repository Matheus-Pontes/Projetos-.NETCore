
namespace Searchs
{
    public class Search
    {
        private SearchInterface search;

        public Search() { }

        public Search(SearchInterface search)
        {
            this.search = search;
        }

        public void setSearch(SearchInterface search)
        {
            this.search = search;
        }

        public int SearchIndexNumber(int numberSearch, int[] array)
        {
            return this.search.search(numberSearch, array);
        }
    }
}