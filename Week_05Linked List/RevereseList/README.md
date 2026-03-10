
---

# Reverse Linked List

Solution for **Reverse Linked List**

## Idea

The idea is to **reverse the direction of the pointers** in the linked list.

We iterate through the list and for each node:

1. Save the next node.
2. Reverse the current node pointer.
3. Move the pointers forward.

We use three pointers:

* `prev` → previous node
* `curr` → current node
* `next` → next node (to avoid losing the rest of the list)

Example:

```
1 → 2 → 3 → null
```

Becomes:

```
3 → 2 → 1 → null
```

## Complexity

Time Complexity

```
O(n)
```

We traverse the list once.

Space Complexity

```
O(1)
```

No extra memory is used.
