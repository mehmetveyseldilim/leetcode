int Search(int[] nums, int target)
{
    int leftIndex = 0;
    int rightIndex = nums.Length - 1;

    while (leftIndex != rightIndex)
    {
        int midIndex = leftIndex + ((rightIndex - leftIndex) / 2);
        int midNumber = nums[midIndex];

        if (midNumber == target)
        {
            return midIndex;
        }
        else if (midNumber > target)
        {
            rightIndex = midIndex -1;
        }
        else if (midNumber < target)
        {
            leftIndex = midIndex + 1;
        }
    }

    return -1;
}

int[] nums = {-1,0,3,5,9,12};
// See https://aka.ms/new-console-template for more information
Console.WriteLine(Search(nums, 9));
