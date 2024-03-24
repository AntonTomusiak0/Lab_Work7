
namespace ConsoleApp10
{
    public interface ISort
    {
        public void SortAsc(int[] num);
        public void SortDesc(int[] num);
        public void SortByParam(int[] num,bool isAsc);
    }
}
