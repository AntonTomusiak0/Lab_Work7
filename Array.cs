using System.Diagnostics;

namespace ConsoleApp10
{
    public class Array : IOutput, IMath, ISort
    {
        public void Show(int[] num)
        {
            foreach (int i in num) { Console.Write(i + " "); }
        }
        public void Show(int[] num, string info)
        {
            Console.WriteLine("\nInfo: " + info);
            foreach (int i in num) { Console.Write(i + " "); }
        }

        public int Max(int[] num)
        {
            int temp = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if(num[i] > temp) {  temp = num[i]; }
            }
            Console.WriteLine(temp);
            return temp;
        }
        public int Min(int[] num)
        {
            int temp = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < temp ) { temp = num[i]; }
            }
            Console.WriteLine(temp);
            return temp;
        }
        public float Avg(int[] num)
        {
            int temp = 0;
            for (int i = 0; i < num.Length; i++)
            {
                temp += num[i];
            }
            Console.WriteLine(temp/ num.Length);
            return temp / num.Length;
        }
        public bool Search(int[] num, int valueToSearch)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == valueToSearch)
                {
                    Console.WriteLine(true);
                }
                else Console.WriteLine(false);
            }
            return false;
        }

        public void SortAsc(int[] num)
        {
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            foreach (int i in num) { Console.Write(i + " "); }
        }
        public void SortDesc(int[] num)
        {
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            foreach (int i in num) { Console.Write(i + " "); }
        }
        public void SortByParam(int[] num, bool isAsc)
        {
            if (isAsc == true)
            {
                for (int i = 0; i < num.Length - 1; i++)
                {
                    for (int j = i + 1; j < num.Length; j++)
                    {
                        if (num[i] > num[j])
                        {
                            int temp = num[i];
                            num[i] = num[j];
                            num[j] = temp;
                        }
                    }
                }
                foreach (int i in num) { Console.Write(i + " "); }
            }
            else if (isAsc == false)
            {
                for (int i = 0; i < num.Length - 1; i++)
                {
                    for (int j = i + 1; j < num.Length; j++)
                    {
                        if (num[i] < num[j])
                        {
                            int temp = num[i];
                            num[i] = num[j];
                            num[j] = temp;
                        }
                    }
                }
                foreach (int i in num) { Console.Write(i + " "); }
            }
        }
    }
}
