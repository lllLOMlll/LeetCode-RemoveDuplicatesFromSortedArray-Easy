class Program
{
    public int RemoveDuplicates(int[] nums)
    {
        int numsLength = nums.Length;
        List<int> duplicates = new List<int>();
        int uniqueElement = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!duplicates.Contains(nums[i]))
            {
                duplicates.Add(nums[i]);
                uniqueElement += 1;
            }
        }

        return uniqueElement;
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        int[] nums1 = [1, 1, 2];
        Console.WriteLine("2 -> " + p.RemoveDuplicates(nums1));

        int[] nums2 = [0,0,1,1,1,2,2,3,3,4];
        Console.WriteLine("4 -> " + p.RemoveDuplicates(nums2)); 
    }
}

