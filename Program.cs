namespace LeetCodeTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test cases
            string s0 = "babad";
            string s1 = "cbbd";
            string s2 = "cc";
            string s3 = "ac";

            string palidrom = LongestPalindrome(s3);
            Console.WriteLine(palidrom);
        }
        // Find longest polindromic substring
        public static string LongestPalindrome(string s)
        {
            if (s == null || s.Length == 0)
            {
                return ""; 
            }

            if(s.Length == 2 && s[0] != s[1])
            {
                return s[0].ToString();
            }

            int start = 0, end = 0;

            // Here I will use custom method ExpandAroundCenter
            for(int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if(len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len/2;
                }
            }
            return s.Substring(start, end - start + 1);
        }

        // So what does this method do: It iterates over each position in the string and expands the palindrome in both directions, starting at the current position
        private static int ExpandAroundCenter(string s, int left, int right)
        {
            while(left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }

        //Result: Runtime > 78.31%; Memory >  73.7%
    }
}