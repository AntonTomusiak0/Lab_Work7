
namespace ConsoleApp10
{
    public interface ICalc
    {
        public int Sum(int x, int y);
    }
    public interface IShow
    { 
        public void Show(int x, int y);
    }
    public class Calc : ICalc, IShow
    {
        public static string Test => "Test";
        public int Sum(int x,int y)
        {
            return x + y;
        }
        public void Show(int x, int y)
        {
            Console.WriteLine($"Sum: {Sum(x, y)}");
        }
    }
    public class BadCalc : ICalc, IShow
    {
        public static string Test => "Test";
        public int Sum(int x, int y)
        {
            return x - y;
        }
        public void Show(int x, int y)
        {
            Console.WriteLine($"Sum: {Sum(x, y)}");
        }
    }
}
