namespace LeetCodeTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test cases
            string case0 = "abba", case1 = "egge";
            bool result = IsIsomorphic(case0, case1);
            Console.WriteLine(result);

        }
        //Isomorphic 
        public static bool IsIsomorphic(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, char> map = new Dictionary<char, char>();
            HashSet<char> usedChars = new HashSet<char>();

            for(int i = 0; i < s.Length; i++)
            {
                char sc = s[i];
                char tc = t[i];

                if (map.ContainsKey(sc))
                {
                    if (map[sc] != tc)
                    {
                        return false;
                    }
                }
                else
                {
                    if (usedChars.Contains(tc))
                    {
                        return false;
                    }

                    map[sc] = tc;
                    usedChars.Add(tc);
                }
            }

            return true;
        }

        //Result: 
    }
}