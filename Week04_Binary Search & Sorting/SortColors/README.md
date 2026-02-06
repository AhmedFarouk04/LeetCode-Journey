Problem: Sort Colors (LeetCode 75)

Idea:
المصفوفة فيها أرقام 0 و 1 و 2 فقط.
نقسمها لثلاث مناطق باستخدام 3 مؤشرات:

low : مكان الـ 0s

mid : العنصر اللي بنفحصه

high : مكان الـ 2s

Rules:

لو الرقم 0 → نبدّله مع low

لو الرقم 1 → نعدّي

لو الرقم 2 → نبدّله مع high

Why it works:
كل رقم بيروح مكانه الصح في مرور واحد فقط.

Time Complexity: O(n)
Space Complexity: O(1)