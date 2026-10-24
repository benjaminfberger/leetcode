/*
 Beats 47.22% of submissions with time complexity of O(n) and space complexity of O(n)
 */
SELECT name
FROM Customer
WHERE referee_id != 2
OR referee_id IS null