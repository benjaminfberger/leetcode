/*
 Beats 9.53% of submissions with time complexity of O(nlogn) and space complexity of O(n)
 */
SELECT DISTINCT author_id AS id
FROM Views
WHERE viewer_id = author_id
ORDER BY author_id ASC