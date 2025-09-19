using System;

namespace MyProject
{
    class Program
    {
        //Given an array of integers 'nums' and an integer 'target', return 'indices' of the two numbers such that they add up to target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.You can return the answer in any order.

        //Example:
        //    Input: nums = [3,2,4], target = 6
        //    Output: [1,2]

        static void Main(string[] args)
        {
            int[] testArray1 = { 2, 11, 15, 25, 7 };

            int target1 = 9;
            int target2 = 27;

            int[] indices = TwoSum(testArray1, target1);

            Console.WriteLine("Test 1 result");
            Console.WriteLine($"Output:[{indices[0]},{indices[1]}] ");


            int[] indice2 = TwoSum(testArray1, target2);

            Console.WriteLine("\nTest 2 result");
            Console.WriteLine($"Output:[{indice2[0]},{indice2[1]}] ");
        }

        static int[] TwoSum(int[] nums, int target)
        {
            int[] result = {-1,-1};

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }

            return result;
        }

    }

}