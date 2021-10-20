using System;

namespace Two_Pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasTwoPairsEqualsTarget(new int[] { 1,2,3,4,5,6 }, 6));
        }
        static bool HasTwoPairsEqualsTarget(int[] array, int target)
        {
            Array.Sort(array);
            int pointer1 = 0, pointer2 = array.Length - 1;
            while (pointer1 < pointer2)
            {
                var sum = array[pointer1] + array[pointer2];
                if (sum == target) return true;

                if (sum < target)
                    pointer1++;
                else
                    pointer2--;
            }

            return false;
        }
    }
}
