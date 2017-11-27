using System;

namespace LatticePaths
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FindSpecificPascalLevel(40);
        }
        public static long[] FindSpecificPascalLevel(int level){
            long[] pascalLevel = new long[] {0,1,0};
            for (int i = 1; i <= level; i++){
                pascalLevel = FindNextPascalLevel(pascalLevel);
                foreach(long number in pascalLevel) {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            return pascalLevel;
        }
        public static long[] FindNextPascalLevel(long[] previousPascalLevel){
            long[] nextPascalLevel = new long[previousPascalLevel.Length + 1];
            nextPascalLevel[0] = 0;
            nextPascalLevel[previousPascalLevel.Length - 1] = 0;
            for (int i = 1; i < previousPascalLevel.Length; i++) {
                nextPascalLevel[i] = previousPascalLevel[i] + previousPascalLevel[i - 1];
            }
            return nextPascalLevel;
        }
    }
}
