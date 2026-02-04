Ship Packages Within D Days
Problem Idea

We are given a list of package weights that must be shipped in order within a fixed number of days.
Each day, the ship can carry packages as long as the total weight does not exceed its capacity.

Our goal is to find the minimum ship capacity that allows all packages to be shipped within the given number of days.

Key Observation

The ship capacity cannot be smaller than the heaviest package.

The ship capacity does not need to be larger than the total weight of all packages.

So the answer lies within a numeric range.

Approach

We use Binary Search on the answer.

For a guessed ship capacity:

Simulate shipping day by day.

Count how many days are needed.

If the number of days is within the limit, try a smaller capacity.

Otherwise, increase the capacity.

Techniques Used

Binary Search

Greedy simulation

Time Complexity

O(n log S)

n: number of packages

S: range of possible capacities

Final Result

Binary Search helps us efficiently find the smallest valid ship capacity.