using System;

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, -34, -2, 40, 6, -10, 56, 12, -1, -15, 10, 4 };

            int size = arr.Length;
            int max_so_far = int.MinValue;
            int max_ending_here = 0;

            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < size; i++)
            {
                var item = arr[i];

                max_ending_here = max_ending_here + arr[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    endIndex = i;
                }


                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    startIndex = i + 1;
                }

            }

            Console.Write($"For given vector start index is {startIndex}, end index {endIndex} and Maximum contiguous sum is " + max_so_far);
        }
    }
}
