int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
    int[] index = new int[2];

    for (int i = 0; i < nums.Length; i++)
    {
        int requiredNumber = target - nums[i];

        if (keyValuePairs.ContainsKey(nums[i]))
        {
            return new int[2] { keyValuePairs[nums[i]], i };
        }

        if (!keyValuePairs.ContainsKey(requiredNumber))
        {
            keyValuePairs.Add(requiredNumber, i);
        }
    }

    return index;
}
Console.WriteLine("Hello, World!");
