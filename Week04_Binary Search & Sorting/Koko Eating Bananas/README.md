
---

## Koko Eating Bananas

### Problem

Koko loves bananas.
There are `piles` of bananas, where `piles[i]` is the number of bananas in the i-th pile.
Koko can eat **k bananas per hour**.

Return the **minimum integer k** such that Koko can eat all the bananas within `h` hours.

---

### Key Idea

* We are **not searching in the array**
* We are searching for the **minimum valid eating speed**
* If Koko can eat all bananas with speed `k`,
  then she can also eat them with any speed **greater than k**

➡️ This creates a **monotonic condition**
➡️ Perfect for **Binary Search on Answer**

---

### Pattern

* Binary Search on Answer
* Monotonic condition (valid / invalid)

---

### Search Space

* **Minimum speed:** `1`
* **Maximum speed:** `max(piles)`

---

### Complexity

* **Time:** `O(n log m)`

  * `n` = number of piles
  * `m` = max bananas in a pile
* **Space:** `O(1)`

---

### Approach

1. Binary search on eating speed `k`
2. For each `k`, calculate total hours needed
3. If hours ≤ `h` → speed is valid, try smaller
4. If hours > `h` → speed is too slow, increase it
5. Return the minimum valid speed



### Why Binary Search Works

* Speed `k` is **valid or invalid**
* Validity is **monotonic**
* We want the **minimum valid value**

---

### Interview Tip

> If the problem asks for
> **minimum / maximum answer**
> and you can **check validity**,
> think **Binary Search on Answer**.

---

