using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_V1.Classes
{
    public class Home
    {
        public static void Main()
        {
            int[] nums = { 2, 1, 23, 11, -100, 5 };

            var result = Algo.BinrayConvert(21);


        } 
    }

    public class Algo
    {

        // O(n^2)
        public static void InsertionSort(int[] nums)
        {
            int n = nums.Length;

            for(int i = 1; i < n; ++i)
            {
                int key = nums[i];
                int j = i - 1;


                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }

                nums[j + 1] = key;
            }
        }

        // O(n)
        public static int BinrayConvert(int number)
        {
            var sum = 0;

            while(number > 0)
            {
                int r = number % 2;

                sum = sum * 10 + r;
                number /= 2;

                
            }

            return sum;
        }
    }
}
