/*
 Beats 27.63% of submissions with time complexity of O(n) and space complexity of O(n)
 */
SELECT name, population, area
FROM World
WHERE area >= 3000000
OR population >= 25000000