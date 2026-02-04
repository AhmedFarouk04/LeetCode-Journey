Search in Rotated Sorted Array
Problem

Given a rotated sorted array with no duplicates, find the index of a target value.
If the target does not exist, return -1.

Key Idea

Although the array is rotated, one half is always sorted.
We use Binary Search and decide which half to continue searching in.

Approach

Use Binary Search.

Check which half (left or right) is sorted.

Decide if the target lies inside the sorted half.

Move left or right accordingly.

Time & Space Complexity

Time: O(log n)

Space: O(1)

Example
Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4

Pattern

Binary Search

Search in Rotated Sorted Array