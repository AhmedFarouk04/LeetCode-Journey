
# Linked List Cycle – LeetCode 141

**Idea:**

* Use **Slow & Fast Pointers**
* Slow moves **1 step at a time**, Fast moves **2 steps at a time**
* If Slow and Fast meet → **cycle exists**
* If Fast reaches `null` → **no cycle**

**Complexity:**

* **Time:** `O(n)`
* **Space:** `O(1)`

---

## Explaining the loop condition

```csharp
while(fast != null && fast.next != null)
```

### Why this condition is needed?

1️⃣ `fast != null` →

* Fast pointer might reach the end of the list.
* If Fast is null → we reached the end → **no cycle**.

2️⃣ `fast.next != null` →

* Fast moves **2 steps at a time** (`fast = fast.next.next`)
* Before doing that, we must make sure **fast.next exists**, otherwise `fast.next.next` would throw **NullReferenceException**.

---

### Visual Example

List without cycle:

```
1 → 2 → 3 → null
```

* Initial: `slow = 1`, `fast = 1`
* Step 1: `slow = 2`, `fast = 3`
* Step 2: `slow = 3`, `fast = null` → loop stops → **no cycle**

✅ That’s why we need both conditions in the while loop.

---

