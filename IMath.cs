
namespace ConsoleApp10
{
    public interface IMath
    {
        public int Max(int[] num);
        public int Min(int[] num);
        public float Avg(int[] num);
        public bool Search(int[] num, int valueToSearch);
    }
}
