using System;
using System.Collections.Generic;
using Question2_And_3;

namespace Question2_And_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Question 1
            Console.WriteLine("Question 1: Longest Substring Without Repeating Characters");
            Console.WriteLine($"Length of longest substring for 'bcdddad': {StaticMethods.LengthOfLongestSubstring("bcdddad")}");// Output: 3
            Console.WriteLine($"Length of longest substring for 'aaaaa': {StaticMethods.LengthOfLongestSubstring("aaaaa")}");// Output: 1
            Console.WriteLine($"Length of longest substring for 'orjrrj': {StaticMethods.LengthOfLongestSubstring("orjrrj")}");// Output: 3
            Console.WriteLine($"Length of longest substring for '': {StaticMethods.LengthOfLongestSubstring("")}");// Output: 0

            Console.WriteLine();

            // Question 2
            // Example 1: Valid transformation sequence
            var wordList1 = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
            var length1 = StaticMethods.LadderLength("hit", "cog", wordList1);
            if (length1 > 0)
            {
                Console.WriteLine($"Example 1");
                Console.WriteLine($"Input:");
                Console.WriteLine($"startWord: \"hit\"");
                Console.WriteLine($"endWord: \"cog\"");
                Console.WriteLine($"wordList: [{string.Join(", ", wordList1)}]");
                Console.WriteLine($"Output: {length1}");
                Console.WriteLine($"The shortest transformation sequence is \"hit\" → \"hot\" → \"dot\" → \"dog\" → \"cog\", which is {length1} steps.");
            }
            else
            {
                Console.WriteLine($"Example 1");
                Console.WriteLine($"Input:");
                Console.WriteLine($"startWord: \"hit\"");
                Console.WriteLine($"endWord: \"cog\"");
                Console.WriteLine($"wordList: [{string.Join(", ", wordList1)}]");
                Console.WriteLine($"Output: {length1}");
                Console.WriteLine($"The endWord \"cog\" is not reachable from \"hit\" with the given wordList.");
            }

            // Example 2: No valid transformation path
            var wordList2 = new List<string> { "hot", "dot", "dog", "lot", "log" };
            var length2 = StaticMethods.LadderLength("hit", "cog", wordList2);
            if (length2 > 0)
            {
                Console.WriteLine($"Example 2");
                Console.WriteLine($"Input:");
                Console.WriteLine($"startWord: \"hit\"");
                Console.WriteLine($"endWord: \"cog\"");
                Console.WriteLine($"wordList: [{string.Join(", ", wordList2)}]");
                Console.WriteLine($"Output: {length2}");
                Console.WriteLine($"The shortest transformation sequence is \"hit\" → \"hot\" → \"dot\" → \"dog\" → \"cog\", which is {length2} steps.");
            }
            else
            {
                Console.WriteLine($"Example 2");
                Console.WriteLine($"Input:");
                Console.WriteLine($"startWord: \"hit\"");
                Console.WriteLine($"endWord: \"cog\"");
                Console.WriteLine($"wordList: [{string.Join(", ", wordList2)}]");
                Console.WriteLine($"Output: {length2}");
                Console.WriteLine($"The endWord \"cog\" is not in the wordList, so no transformation sequence exists.");
            }
        }
    }

}
