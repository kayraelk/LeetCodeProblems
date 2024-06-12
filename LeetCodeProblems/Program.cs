﻿
//11. Container With Most Water
//https://leetcode.com/problems/container-with-most-water/description/

using LeetCodeProblems.Easy;
using LeetCodeProblems.Medium;

//ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();
//int[] height = { 10, 8, 6, 2, 5, 9, 8, 3, 8 };
//Console.WriteLine(containerWithMostWater.MaxArea(height));
//Console.ReadLine();

//15. 3Sum
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


//191. Number of 1 Bits
//https://leetcode.com/problems/number-of-1-bits/description/
NumberOf1Bits numberOf1Bits = new NumberOf1Bits();

// Example 1
int input1 = 11;
int result1 = numberOf1Bits.HammingWeight(input1);
Console.WriteLine($"Input: {input1}, Output: {result1}"); // Output: 3

// Example 2
int input2 = 128;
int result2 = numberOf1Bits.HammingWeight(input2);
Console.WriteLine($"Input: {input2}, Output: {result2}"); // Output: 1

// Example 3
int input3 = 2147483645;
int result3 = numberOf1Bits.HammingWeight(input3);
Console.WriteLine($"Input: {input3}, Output: {result3}"); // Output: 30

