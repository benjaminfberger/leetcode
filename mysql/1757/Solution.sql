/*
 Beats 29.36% of submissions with time complexity of O(n) and space complexity of O(n)
 */
SELECT product_id
FROM Products
WHERE low_fats = 'Y'
AND recyclable = 'Y'