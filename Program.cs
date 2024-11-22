class Program
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int indexToWrite = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[indexToWrite] = nums[i];
                indexToWrite += 1;
            }
        }
        return indexToWrite;
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        int[] nums1 = [1, 1, 2];
        Console.WriteLine("2 -> " + p.RemoveDuplicates(nums1));

        int[] nums2 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        Console.WriteLine("5 -> " + p.RemoveDuplicates(nums2));
    }
}

