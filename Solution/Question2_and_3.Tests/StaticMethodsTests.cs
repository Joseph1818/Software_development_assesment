using NUnit.Framework;

namespace Question2_And_3.Tests
{
    [TestFixture]
    public class StaticMethodsTests
    {   // Question 2 - Tests
        [Test]
        public void LengthOfLongestSubstring_Test1()
        {
            Assert.That(StaticMethods.LengthOfLongestSubstring("abcabcbb"), Is.EqualTo(3));
        }

        [Test]
        public void LengthOfLongestSubstring_Test2()
        {
            Assert.That(StaticMethods.LengthOfLongestSubstring("bbbbb"), Is.EqualTo(1));
        }

        [Test]
        public void LengthOfLongestSubstring_Test3()
        {
            Assert.That(StaticMethods.LengthOfLongestSubstring("pwwkew"), Is.EqualTo(3));
        }

        [Test]
        public void LengthOfLongestSubstring_Test4()
        {
            Assert.That(StaticMethods.LengthOfLongestSubstring(""), Is.EqualTo(0));
        }

        [Test]
        public void LengthOfLongestSubstring_Test5()
        {
            Assert.That(StaticMethods.LengthOfLongestSubstring("abcde"), Is.EqualTo(5));
        }

        [Test]
        public void LengthOfLongestSubstring_Test6()
        {
            Assert.That(StaticMethods.LengthOfLongestSubstring("abcdefgabcdefg"), Is.EqualTo(7));
        }
        // Question 3 - Tests
        [Test]
        public void LadderLength_Example1()
        {
            var wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
            int result = StaticMethods.LadderLength("hit", "cog", wordList);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void LadderLength_Example2()
        {
            var wordList = new List<string> { "hot", "dot", "dog", "lot", "log" };
            int result = StaticMethods.LadderLength("hit", "cog", wordList);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
