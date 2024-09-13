using LeetCodeProblems.Easy;
using LeetCodeProblems.Medium;

#region 11. Container With Most Water
//https://leetcode.com/problems/container-with-most-water/description/

//ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();
//int[] height = { 10, 8, 6, 2, 5, 9, 8, 3, 8 };
//Console.WriteLine(containerWithMostWater.MaxArea(height));
//Console.ReadLine();
#endregion

#region 15. 3Sum
//https://leetcode.com/problems/3sum/description/
//Three3Sum three3Sum = new Three3Sum();
//// Example 1
//int[] nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
//IList<IList<int>> result1 = three3Sum.ThreeSum(nums1);
//Console.WriteLine("Example 1:");
//Three3Sum.PrintResult(result1);

//// Example 2
//int[] nums2 = new int[] { 0, 1, 1 };
//IList<IList<int>> result2 = three3Sum.ThreeSum(nums2);
//Console.WriteLine("Example 2:");
//Three3Sum.PrintResult(result2);

//// Example 3
//int[] nums3 = new int[] { 0, 0, 0 };
//IList<IList<int>> result3 = three3Sum.ThreeSum(nums3);
//Console.WriteLine("Example 3:");
//Three3Sum.PrintResult(result3);
#endregion

#region Number of 1 Bits
//https://leetcode.com/problems/number-of-1-bits/description/
//NumberOf1Bits numberOf1Bits = new NumberOf1Bits();

//// Example 1
//int input1 = 11;
//int result1 = numberOf1Bits.HammingWeight(input1);
//Console.WriteLine($"Input: {input1}, Output: {result1}"); // Output: 3

//// Example 2
//int input2 = 128;
//int result2 = numberOf1Bits.HammingWeight(input2);
//Console.WriteLine($"Input: {input2}, Output: {result2}"); // Output: 1

//// Example 3
//int input3 = 2147483645;
//int result3 = numberOf1Bits.HammingWeight(input3);
//Console.WriteLine($"Input: {input3}, Output: {result3}"); // Output: 30
#endregion

#region 338. Counting Bits
//https://leetcode.com/problems/counting-bits/description/
//CountingBits countingBits = new CountingBits();
//int[] result = countingBits.CountBits(5);
//Console.WriteLine(string.Join(",", result)); // Output: 0,1,1,2,1,2
#endregion

#region 268. Missing Number
//https://leetcode.com/problems/missing-number/description/
//MissingNumberSolution missingNumberSolution = new MissingNumberSolution();

//// Example 1
//int[] nums1 = { 3, 0, 1 };
//Console.WriteLine("Missing number in [3, 0, 1] is: " + missingNumberSolution.MissingNumber(nums1)); // Output: 2

//// Example 2
//int[] nums2 = { 0, 1 };
//Console.WriteLine("Missing number in [0, 1] is: " + missingNumberSolution.MissingNumber(nums2)); // Output: 2

//// Example 3
//int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
//Console.WriteLine("Missing number in [9, 6, 4, 2, 3, 5, 7, 0, 1] is: " + missingNumberSolution.MissingNumber(nums3)); // Output: 8

#endregion

#region 190. Reverse Bits
//ReverseBitsSolution solution = new ReverseBitsSolution();

//uint input1 = 43261596; // Binary: 00000010100101000001111010011100
//uint output1 = solution.reverseBits(input1);
//Console.WriteLine($"Input: {input1}, Reversed Output: {output1}");

//uint input2 = 4294967293; // Binary: 11111111111111111111111111111101
//uint output2 = solution.reverseBits(input2);
//Console.WriteLine($"Input: {input2}, Reversed Output: {output2}");

//// Keep the console window open
//Console.WriteLine("Press any key to exit.");
//Console.ReadKey();
#endregion

#region 70. Climbing Stairs
////https://leetcode.com/problems/climbing-stairs/
//ClimbingStairs climbingStairs = new ClimbingStairs();
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(climbingStairs.ClimbStairs(i));
//}
#endregion

#region 322. Coin Change
//https://leetcode.com/problems/coin-change/
//CoinChangeSolution coinChangeSolution = new CoinChangeSolution();
//int[] coins = [1,2,5] ;
//var amount = 11;
//int result = coinChangeSolution.CoinChange(coins, amount);
//Console.WriteLine(result);
#endregion

#region 300. Longest Increasing Subsequence
//https://leetcode.com/problems/longest-increasing-subsequence/description/
//LongestIncreasingSubsequence solution = new LongestIncreasingSubsequence();

//Console.WriteLine(solution.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 })); // Output: 4
//Console.WriteLine(solution.LengthOfLIS(new int[] { 0, 1, 0, 3, 2, 3 }));           // Output: 4
//Console.WriteLine(solution.LengthOfLIS(new int[] { 7, 7, 7, 7, 7, 7, 7 }));

#endregion

#region 14. Longest Common Prefix
//LongestCommonPrefixSolution longestCommonPrefixSolution = new LongestCommonPrefixSolution();
//string[] strs1 = { "flower", "flow", "flight" };
//Console.WriteLine(longestCommonPrefixSolution.LongestCommonPrefix(strs1));  // Output: "fl"

//string[] strs2 = { "dog", "racecar", "car" };
//Console.WriteLine(longestCommonPrefixSolution.LongestCommonPrefix(strs2));  // Output: ""

#endregion

#region 1. Two Sum

TwoSum twoSum = new TwoSum();
// Sample input for testing
int[] nums = { 2, 7, 11, 15 };
int target = 9;

// Call the TwoSum function and get the result
int[] result = twoSum.TwoSumMethod(nums, target);

// Print the result
if (result.Length == 2)
{
    Console.WriteLine($"Indices: {result[0]}, {result[1]}");
}
else
{
    Console.WriteLine("No solution found!");
}

// Keep the console window open
Console.ReadLine();
#endregion
