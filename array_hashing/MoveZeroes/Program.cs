public class Program
{
    // Ideal Solution
    public static void MoveZeroes(int[] nums)
    {
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] != 0)
            {
                int temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;

                left++;
            }
        }
    }

    //     public static void MoveZeroes(int[] nums)
    // {
    //     int lastIndex = nums.Length - 1;
    //     int lastIndexLimit = lastIndex;
    //     for (int i = 0; i <= lastIndexLimit; i++)
    //     {
    //         if (nums[i] == 0)
    //         {
    //             ShiftElementsToLeftByOne(nums, i);
    //             nums[lastIndex] = 0;
    //             lastIndexLimit--;

    //             if(nums[i] == 0) i--;
    //         }
    //     }
    // }


    //! Last element and its left neighbor  becomes the same element
    public static void ShiftElementsToLeftByOne(int[] nums, int index)
    {
        for (int i = index; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
    }

    public static void Main(string[] args)
    {
        int[] nums1 = { 0, 1, 0, 3, 12 };

        int[] nums2 = { 0, };

        int[] nums3 = { 0, 0, 1 };

        Console.WriteLine(string.Join(",", nums1)); // Then print the modified array
        MoveZeroes(nums1);
        Console.WriteLine(string.Join(",", nums1)); // Then print the modified array
    }
}

