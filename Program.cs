// See https://aka.ms/new-console-template for more information
int[] nums = { 2, 7, 11, 15 };
int target = 9;
int[] new_arr;
for (int i = 0; i <nums.Length; i++)
{
    for (int j = i+1; j <= nums.Length; j++)
    {
        if (nums[j] == target - nums[i])
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
            int[] arr = new int[2] { i, j };
            Console.WriteLine(arr);
        }
    }
}