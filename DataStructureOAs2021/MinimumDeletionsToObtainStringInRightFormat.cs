using System;

namespace DataStructureOAs2021
{
    /**
     * Given a string with only characters X and Y.
     * Find the minimum number of characters to remove from the string such that there is no interleaving of character X and Y and all the Xs appear before any Y.
     * 
     */
    
    class MinimumDeletionsToObtainStringInRightFormat
    {
        public static int MinStep(String str)
        {
            var min = 0;
            var _Ys = 0;

            foreach (var ch in str)
            {
                if (ch == 'X')
                {
                    min = Math.Min(_Ys, min + 1);
                }
                else
                {
                    _Ys++;
                }
            }
            
            return min;
        }
    }

    
}