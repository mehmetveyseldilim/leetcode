bool ContainsDuplicate(int[] nums) 
{
    HashSet<int> uniqueNumbers = new HashSet<int>();

    for(int i = 0; i < nums.Length; i++)
    {
        if(uniqueNumbers.Contains(nums[i])) return true;

        uniqueNumbers.Add(nums[i]);
    }

    return false;
}

int[] numbers = {1, 2, 3, 4};
Console.WriteLine(ContainsDuplicate(numbers));
