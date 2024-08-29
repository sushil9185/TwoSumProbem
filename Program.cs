using System.Security.AccessControl;

namespace TwoSumProbem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 6, 5, 8, 11 };
            int k = 19;
            Console.WriteLine(FindTwoSum2(myArray, k));
        }


        static string FindTwoSum2(int[] a, int k)
        {
            int n = a.Length;
            int left = 0, right = n - 1;
            Array.Sort(a);
            while (left < right)
            {
                int sum = a[right] + a[left];
                if(sum == k)
                { 
                    return "Yes";
                }
                else if(sum > k)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return "No";
        }

        //better
        static string FindTwoSum1(int[] a, int k)
        {
            int n = a.Length;
            Dictionary<int, int > map = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int diff = k - a[i];
                if (map.ContainsKey(diff))
                    return "Yes";
                map[a[i]] = i;
            }

            return "No";
        }

        //Brute Approach
        static string FindTwoSum(int[] a, int k)
        {
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (a[i] + a[j] == k)
                        return "Yes";
                }

            }


            return "No";
        }
    }
}
