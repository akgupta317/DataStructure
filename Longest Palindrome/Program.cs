using System;

namespace Longest_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int[] currentLongestIndex = {0,1};
            for (int i = 1; i < str.Length; i++)
            {
                
                int[] oddIndex = giveLongestIndex(str,i-1,i+1);
                int[] evenIndex= giveLongestIndex(str,i-1,i);
                int[] longOne =oddIndex[1]-oddIndex[0]>evenIndex[1]-evenIndex[0]? oddIndex:evenIndex;
                currentLongestIndex =(currentLongestIndex[1]-currentLongestIndex[0]>longOne[1]-longOne[0])?currentLongestIndex:longOne; //compare
            }
            Console.WriteLine(str.Substring(currentLongestIndex[0],currentLongestIndex[1]-currentLongestIndex[0]));
        }

        private static int[] giveLongestIndex(string str, int left, int right)
        {
            while (left>=0 && right <str.Length)
            {
                if(str[left]!=str[right]){
                    break;
                }
                left--;
                right++;
            }
            return new int[] {left+1,right};
        }
    }
}
