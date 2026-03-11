Remove Nth Node From End – LeetCode 19

Idea

Use Two Pointers:

Move fast pointer n steps ahead.

Move slow and fast together.

When fast reaches the end, slow will be before the node to remove.

Complexity

Time: O(n)
Space: O(1)