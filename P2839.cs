using System;

namespace P2839
{
    internal class P2839
    {
        static int[] result = new int[5001];
        static void Main(string[] args)
        {
            result[1] = -1;
            result[2] = -1;
            result[3] = 1;
            result[4] = -1;
            result[5] = 1;
            int input = int.Parse(Console.ReadLine());
            for(int i = 6; i <= input; i++)
            {
                int tmp_res = -1;
                if (result[i - 5] != -1)
                {
                    tmp_res = result[i - 5] + 1;
                }
                if (result[i - 3] != -1)
                {
                    if ((tmp_res > (result[i - 3] + 1)) ||
                        (tmp_res == -1))
                    {
                        tmp_res = result[i - 3] + 1;
                    }
                }
                result[i] = tmp_res;
            }
            Console.WriteLine(result[input]);
        }
    }
}
