/*
 Beats 26.54% of submissions with time complexity of O(n) and space complexity of O(n)
 */
SELECT tweet_id
FROM Tweets
WHERE LENGTH(content) > 15