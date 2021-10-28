using System;

namespace DataStructureOAs2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "YXXXYXY";
            Console.WriteLine(MinimumDeletionsToObtainStringInRightFormat.MinStep(str)==2);
        }
    }
}