using System;

namespace DataStructureOAs2021
{
    public class MinimumDeletionsToObtainStringInRightFormat
    {
        
    }
    class Solution
    {
        public static int MinStep(String str)
        {
            var min = 0;
            var _Ys = 0;

            foreach (var ch in str)
            {
                if (ch == 'X')
                {
                    
                }
                else
                {
                    _Ys++;
                }
            }
            
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var str = "YXXXYXY";
            Console.WriteLine(Solution.MinStep(str));
        }
    }
}