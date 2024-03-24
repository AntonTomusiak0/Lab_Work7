namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ICalc calc = new Calc();
            IShow show = new Calc();
            IShow show1 = new BadCalc();
            show.Show(7,5);
            show1.Show(5, 7);
            BadCalc bad = new BadCalc();
            Calc calc = new Calc();
            */
            IOutput outp1 = new Array();
            IMath math1 = new Array();
            ISort sort1 = new Array();
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 4, 1, 3, 5, 2, 6 };
            string str1 = "Massage";
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-3 or 4 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        outp1.Show(arr);
                        outp1.Show(arr,str1);
                        break;
                    case 2:
                        math1.Max(arr);
                        math1.Min(arr);
                        math1.Avg(arr);
                        math1.Search(arr, 2);
                        break;
                    case 3:
                        sort1.SortAsc(arr2);
                        Console.WriteLine("\n");
                        sort1.SortDesc(arr2);
                        Console.WriteLine("\n");
                        sort1.SortByParam(arr2, true);
                        Console.WriteLine("\n");
                        sort1.SortByParam(arr2, false);
                        break;
                    case 4:
                        whil = 1;
                        break;
                }
            }
        }
    }
}