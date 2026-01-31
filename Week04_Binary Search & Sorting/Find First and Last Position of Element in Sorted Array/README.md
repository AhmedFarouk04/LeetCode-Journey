

## Find First and Last Position of Element in Sorted Array

### Problem

Given a **sorted array** of integers `nums` and a `target`, return the **first and last index** of `target`.
If the target does not exist, return `[-1, -1]`.

---

### Key Idea

* The array is **sorted**
* We need the **boundaries** of the target, not just to find it
* Use **Binary Search twice**:

  * One for the **first occurrence**
  * One for the **last occurrence**

---

### Pattern

* Binary Search
* Lower Bound / Upper Bound
* Search for boundaries

---

### Complexity

* **Time:** `O(log n)`
* **Space:** `O(1)`

---

### Approach

1. Run Binary Search to find the **first position**
2. Run Binary Search again to find the **last position**
3. Store the index when `target` is found and keep searching

---


### Interview Tip

> If the problem asks for **first**, **last**, or **range**,
> think about **Binary Search on boundaries**, not just finding the value.


