
---

## Problem Name

**Magnetic Force Between Two Balls**
(LeetCode 1552 – Medium)

---

## Idea of the Solution

We want to place **m balls** in given positions such that the **minimum distance between any two balls is as large as possible**.

* We **binary search on the answer** (the minimum distance).
* The smallest possible distance = `0`
* The largest possible distance = `max(position) - min(position)`
* For each distance `mid`, we **check if we can place all m balls** with at least this distance using a greedy approach.

If we can place them:

* Try a **bigger distance**

If we cannot:

* Try a **smaller distance**

---

## Technique Used

* **Binary Search on Answer**
* **Greedy check (CanPlace function)**

---

## Time Complexity

**O(n log S)**

Where:

* `n` = number of positions
* `S` = range of distances (`maxPosition - minPosition`)

---

