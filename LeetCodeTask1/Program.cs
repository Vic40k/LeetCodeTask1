using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // 13. Roman to Integer
            //Console.WriteLine(RomanToInt("MCMXCIV"));
            // 234. Palindrome Linked List
            //Console.WriteLine(IsPalindrome(new ListNode { val = 1, next = new ListNode { val = 2, next = new ListNode { val = 2, next = new ListNode { val = 1 } } } }));
            // 383. Ransom Note
            //Console.WriteLine(CanConstruct("abba", "abbbac"));
            // 412. Fizz Buzz
            Console.WriteLine(FizzBuzz(15));
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
    }
}
