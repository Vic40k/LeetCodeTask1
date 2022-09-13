using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace LeetCodeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // Linked list
            //List<int> ints = new() { 1, 2, 3, 4, 5 };
            //ListNode currNode = new();
            //ListNode node = currNode;
            //foreach (int i in ints)
            //{
            //    currNode.next = new ListNode() { val = i };
            //    currNode = currNode.next;
            //    //buff.next = 
            //}
            //node = node.next;

            // 13. Roman to Integer
            //Console.WriteLine(RomanToInt("MCMXCIV"));

            // 234. Palindrome Linked List
            //Console.WriteLine(IsPalindrome(new ListNode { val = 1, next = new ListNode { val = 2, next = new ListNode { val = 2, next = new ListNode { val = 1 } } } }));

            // 383. Ransom Note
            //Console.WriteLine(CanConstruct("abba", "abbbac"));

            // 412. Fizz Buzz
            //Console.WriteLine(FizzBuzz(15));

            // 876. Middle of the Linked List
            //Console.WriteLine(MiddleNode(node));

            // 1337.The K Weakest Rows in a Matrix
            //int[,] mat = new int[5,5];
            //int[,] mat = new int[,] { { 1,1,0,0,0 },{ 1,1,1,1,0 },{ 1,0,0,0,0 },{ 1,1,1,1,1 } };
            //int[][] mat = new int[5][];
            //mat[0] = new int[] { 1, 1, 0, 0, 0 };
            //mat[1] = new int[] { 1, 1, 1, 1, 0 };
            //mat[2] = new int[] { 1, 0, 0, 0, 0 };
            //mat[3] = new int[] { 1, 1, 0, 0, 0 };
            //mat[4] = new int[] { 1, 1, 1, 1, 1 };
            //Console.WriteLine(KWeakestRows(mat,3));

            // 1342. Number of Steps to Reduce a Number to Zero
            //Console.WriteLine(NumberOfSteps(14));

            // 1672. Richest Customer Wealth
            //int[][] mat = new int[3][];
            //mat[0] = new int[] { 1, 5 };
            //mat[1] = new int[] { 7, 3 };
            //mat[2] = new int[] { 3, 5 };
            //Console.WriteLine(MaximumWealth(mat));

            // 1. Two Sum
            //Console.WriteLine(TwoSum(new int[] {2,7,11,15},9));

            // 2. Add Two Numbers
            //ListNode param1 = new ListNode { val = 1, next = new ListNode { val = 2, next = new ListNode { val = 3, next = new ListNode { val = 4 } } } };
            //ListNode param2 = new ListNode { val = 5, next = new ListNode { val = 6, next = new ListNode { val = 7, next = new ListNode { val = 8 } } } };
            //ListNode param1 = new ListNode { val = 9, next = null };
            //ListNode param2 = new ListNode();
            //List<int> param2ints = new() {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            //ListNode currNode = new();
            //ListNode node = currNode;
            //foreach (int i in param2ints)
            //{
            //    currNode.next = new ListNode() { val = i };
            //    currNode = currNode.next;
            //}
            //param2 = node.next;
            //Console.WriteLine(AddTwoNumbers(param1, param2));

            // 3. Longest Substring Without Repeating Characters
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
        }

        // 2. Add Two Numbers
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //int sum1 = 0;
            //ListNode buff = l1;
            ////ListNode res = buff;
            //for (int i = 0; buff != null; i++)
            //{
            //    sum1 += buff.val * Convert.ToInt32(Math.Pow((double)10, (double)i));
            //    buff = buff.next;
            //}
            //int sum2 = 0;
            //buff = l2;
            //for (int i = 0; buff != null; i++)
            //{
            //    sum2 += buff.val * Convert.ToInt32(Math.Pow((double)10, (double)i));
            //    buff = buff.next;
            //}

            //int sum3 = sum1 + sum2;
            //int j = sum3.ToString().Count() - 1;
            //buff = new();
            //ListNode res = new();
            //for (int i = 0; i <= j; i++)
            //{
            //    if (i == 0)
            //    {
            //        buff = new ListNode { val = sum3 % 10, next = null };
            //        res = buff;
            //    }
            //    else
            //    {
            //        buff.next = new ListNode { val = (sum3 / Convert.ToInt32(Math.Pow((double)10, (double)(i)))) % 10, next = null };
            //        buff = buff.next;
            //    }

            //}
            //return res;

            string sum1 = String.Empty, buffString = String.Empty;
            ListNode buff = l1;
            while (buff != null)
            {
                sum1 += buff.val.ToString();
                buff = buff.next;
            }

            buffString = sum1;
            sum1 = String.Empty;
            for (int i = 0; i < buffString.Count(); i++)
            {
                sum1 += buffString[buffString.Count() - 1 - i];
            }

            string sum2 = String.Empty;
            buff = l2;
            while (buff != null)
            {
                sum2 += buff.val.ToString();
                buff = buff.next;
            }

            buffString = sum2;
            sum2 = String.Empty;
            for (int i = 0; i < buffString.Count(); i++)
            {
                sum2 += buffString[buffString.Count() - 1 - i];
            }

            string sum3 = (BigInteger.Parse(sum1) + BigInteger.Parse(sum2)).ToString();
            int j = sum3.ToString().Count() - 1;
            buff = new();
            ListNode res = new();
            for (int i = 0; i <= j; i++)
            {
                if (i == 0)
                {
                    buff = new ListNode { val = Int32.Parse(sum3[sum3.Count()-1].ToString()), next = null };
                    res = buff;
                }
                else
                {
                    buff.next = new ListNode { val = Int32.Parse(sum3[sum3.Count() -i - 1].ToString()), next = null };
                    buff = buff.next;
                }

            }
            return res;
        }

        // 1. Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            res[0] = i;
                            res[1] = j;
                        }
                    }
                }
            }
            return res;
        }

        // 1672. Richest Customer Wealth
        public static int MaximumWealth(int[][] accounts)
        {
            int res = 0;
            foreach (int[] account in accounts)
            {
                int sum = account.Sum();
                if (sum > res)
                    res = sum;
            }
            return res;
        }

        // 1342. Number of Steps to Reduce a Number to Zero
        public static int NumberOfSteps(int num)
        {
            int i = 0;
            while(num >0)
            {
                i++;
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
            }
            return i;
        }

        // 1337. The K Weakest Rows in a Matrix
        private class IdVal { public int Id; public int Val; }
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            List<IdVal> buff = new();
            int resLenght = k < mat.Length ? k : mat.Length;
            int[] result = new int[resLenght];

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (j == 0)
                    {
                        buff.Add(new IdVal() { Id = i, Val = 0});
                    }
                    buff[i].Val += mat[i][j];
                }
            }
            buff = buff.OrderBy(t => t.Val).ToList();
            if(k > buff.Count)
                k = buff.Count;
            for(int i = 0; i < resLenght; i++)
            {
                result[i] = buff[i].Id;
            }
            return result;
        }

        // 876. Middle of the Linked List
        public static ListNode MiddleNode(ListNode head)
        {
            int i = 0;
            ListNode p = head;
            while (p != null)
            {
                i++;
                p = p.next;
            }
            p = head;

            for (int c = 0; c < i / 2;c++)
            {
                p = p.next;
            }
            return p;
        }

        // 412. Fizz Buzz
        public static IList<string> FizzBuzz(int n)
        {
            IList<string> result = new List<string>();
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            for (int i = 1; i <= n; ++i)
            {
                bool threeDiv = i % 3 == 0;
                bool fiveDiv = i % 5 == 0;
                if (threeDiv && fiveDiv)
                    result.Add(fizz + buzz);
                else if (threeDiv)
                    result.Add(fizz);
                else if (fiveDiv)
                    result.Add(buzz);
                else
                    result.Add(i.ToString());
            }
            return result;
        }

        // 383. Ransom Note
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            char[] isChecked = new char[32];
            int j = 0;
            foreach (var item in ransomNote)
            {
                if (!isChecked.Contains(item))
                {
                    int ransCount = 0, magsCount = 0;

                    for (int i = 0; i < ransomNote.Length; ++i)
                    {
                        if (ransomNote[i] == item)
                            ransCount++;
                    }

                    for (int i = 0; i < magazine.Length; ++i)
                    {
                        if (magazine[i] == item)
                            magsCount++;
                    }

                    if (ransCount <= magsCount)
                    {
                        isChecked[j] = item;
                        j++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // 13. Roman to Integer
        public static int RomanToInt(string s)
        {
            int num = 0, nextChar;
            bool isSubstriction = false;
            bool isNotOverflow;
            foreach (var item in s.Select((value, i) => new { value, i }))
            {
                if (!isSubstriction)
                {
                    isNotOverflow = item.i + 1 < s.Length;
                    nextChar = item.i + 1;

                    //Subs
                    if (isNotOverflow && item.value.ToString() + s[nextChar] == "IV")
                    {
                        isSubstriction = true;
                        num += 4;
                    }
                    else if (isNotOverflow && item.value.ToString() + s[nextChar] == "IX")
                    {
                        isSubstriction = true;
                        num += 9;
                    }
                    else if (isNotOverflow && item.value.ToString() + s[nextChar] == "XL")
                    {
                        isSubstriction = true;
                        num += 40;
                    }
                    else if (isNotOverflow && item.value.ToString() + s[nextChar] == "XC")
                    {
                        isSubstriction = true;
                        num += 90;
                    }
                    else if (isNotOverflow && item.value.ToString() + s[nextChar] == "CD")
                    {
                        isSubstriction = true;
                        num += 400;
                    }
                    else if (isNotOverflow && item.value.ToString() + s[nextChar] == "CM")
                    {
                        isSubstriction = true;
                        num += 900;
                    }
                    // not sub
                    else if (item.value.ToString() == "I")
                    {
                        num += 1;
                    }
                    else if (item.value.ToString() == "V")
                    {
                        num += 5;
                    }
                    else if (item.value.ToString() == "X")
                    {
                        num += 10;
                    }
                    else if (item.value.ToString() == "L")
                    {
                        num += 50;
                    }
                    else if (item.value.ToString() == "C")
                    {
                        num += 100;
                    }
                    else if (item.value.ToString() == "D")
                    {
                        num += 500;
                    }
                    else if (item.value.ToString() == "M")
                    {
                        num += 1000;
                    }

                }
                else
                {
                    isSubstriction = false;
                }
            }
            return num;
        }

        // 234. Palindrome Linked List
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static bool IsPalindrome(ListNode head)
        {
            List<int> arr = new List<int>();
            ListNode node = head;
            for (int i = 0; node != null; i++)
            {
                arr.Add(node.val);
                node = node.next;
            }

            //int arrCount = arr.Count / 2;
            for (int i = 0; i < arr.Count / 2; ++i)
            {
                if (arr[i] != arr[arr.Count - i - 1])
                    return false;

            }
            return true;
        }

        // 3. Longest Substring Without Repeating Characters
        public static int LengthOfLongestSubstring(string s)
        {
            string buff = String.Empty;
            int lentgh = 0;
            //foreach (char subStr in s)
            //{
            //    foreach (var subStr2 in buff)
            //    {
            //        if (buff.Any(t => t == subStr2))
            //        {
            //            if (buff.Count() > lentgh)
            //            {
            //                lentgh = buff.Count();
            //            }
            //            buff = String.Empty;
            //        }
            //        buff += subStr.ToString();
            //        break;
            //    }

            //}
            return lentgh;
        }
    }
}
