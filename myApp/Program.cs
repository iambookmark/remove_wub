using System;
using System.Collections.Generic;

namespace myApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string result = stringDecoder("WUBWEWUBAREWUBWUBTHEWUB BACKYARD WUBMYWUBFRIENDWUB");
        }
        public static string stringDecoder(string data)
        {
            string word = "WUB";
            string result1 = data.Replace(word, " ");
            string trimResult1 = result1.Trim();

            int i = 0;
            while (i <= trimResult1.Length)
            {
                int found = trimResult1.IndexOf("  ", i);
                if (found >= 0)
                {
                    trimResult1 = trimResult1.Replace("  ", " ");
                    i = found;
                }
                i++;
            }

            // Console.WriteLine(trimResult1);

            return trimResult1;
        }
    }
}