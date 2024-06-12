
//11. Container With Most Water
//https://leetcode.com/problems/container-with-most-water/description/

using LeetCodeProblems.Medium;

//ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();
//int[] height = { 10, 8, 6, 2, 5, 9, 8, 3, 8 };
//Console.WriteLine(containerWithMostWater.MaxArea(height));
//Console.ReadLine();

//15. 3Sum
//https://leetcode.com/problems/3sum/description/
Three3Sum three3Sum = new Three3Sum();
// Example 1
int[] nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
IList<IList<int>> result1 = three3Sum.ThreeSum(nums1);
Console.WriteLine("Example 1:");
Three3Sum.PrintResult(result1);

// Example 2
int[] nums2 = new int[] { 0, 1, 1 };
IList<IList<int>> result2 = three3Sum.ThreeSum(nums2);
Console.WriteLine("Example 2:");
Three3Sum.PrintResult(result2);

// Example 3
int[] nums3 = new int[] { 0, 0, 0 };
IList<IList<int>> result3 = three3Sum.ThreeSum(nums3);
Console.WriteLine("Example 3:");
Three3Sum.PrintResult(result3);


