
using System;
using System.Collections.Generic;

namespace Question2_And_3
{
    public static class StaticMethods
    {
        // Question 1
        public static int LengthOfLongestSubstring(string s)
        {
            if (s == null || s.Length == 0) return 0;

            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int maxLength = 0;
            int start = 0;

            for (int end = 0; end < s.Length; end++)
            {
                if (charIndexMap.ContainsKey(s[end]))
                {
                    start = Math.Max(charIndexMap[s[end]] + 1, start);
                }
                charIndexMap[s[end]] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }

        // Question 2
        public static int LadderLength(string startWord, string endWord, IList<string> wordList)
        {
            if (startWord == endWord) return 1;
            var wordSet = new HashSet<string>(wordList);
            if (!wordSet.Contains(endWord)) return 0;

            var queue = new Queue<(string word, int length)>();
            queue.Enqueue((startWord, 1));

            while (queue.Count > 0)
            {
                var (currentWord, currentLength) = queue.Dequeue();

                foreach (var nextWord in GetNextWords(currentWord, wordSet))
                {
                    if (nextWord == endWord) return currentLength + 1;
                    queue.Enqueue((nextWord, currentLength + 1));
                    wordSet.Remove(nextWord);
                }
            }

            return 0;
        }

        private static IEnumerable<string> GetNextWords(string word, HashSet<string> wordSet)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var nextWords = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                var originalChar = word[i];
                foreach (var c in alphabet)
                {
                    if (c == originalChar) continue;

                    var newWord = word.Substring(0, i) + c + word.Substring(i + 1);
                    if (wordSet.Contains(newWord))
                    {
                        nextWords.Add(newWord);
                    }
                }
            }

            return nextWords;
        }
    }
}
