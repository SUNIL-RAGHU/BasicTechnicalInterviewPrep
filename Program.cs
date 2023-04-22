using System;
using System.Text;
using System.Text.RegularExpressions;

namespace basic
{
    class main
    {

        public static void Main(string[] args)
        {


            Swap(10, 20);

            reverseInt(567);
            stringSwap("string", "swap");
            PalidromeNumber(909);
            PalidromeString("Sunil");
            Maxofanumber(10, 20, 30);

            fibonnaciinumber(10);

            Printnprimes(10);

            checkprime(20);

            generaterandomNumber();

            generaterandomtext();

            factorialnumber(10);
            int[] arr = { 0, 1, 2, 3, 4, 5 };
            int[] arr1 = { 10, 20, 40, 50 };
            sumofArray(arr);
            sumofevenoroddarray(arr);

            equalarray(arr, arr1);

            RemoveSpecialCharacters("abcdef38713270______-1@#$@# 080");
            RemoveWhiteSpaces("Hi buddy how are you");
            CountOccuranceofaChar("abbaaabbba", 'a');

            CountNumberOfWordsInString("Hi from sunil kya bhaiya");

            revcompletestring("Hi from sunil kya bhaiya");
            MissingNumber(arr);
            MaxandMinNumber(arr);
            DuplicateNumber(arr);
            LinearSearch(arr, 2);
            BinarySearch(arr, 6);
        }

        private static void CountNumberOfWordsInString(string v)
        {
            int count = 1;

            for(int i = 0; i < v.Length - 1; i++)
            {
                if (v[i]==' ' && v[i+1]!=' ')
                {
                    count++;
                }
            }

            Console.WriteLine("The number of occurance of words in a string is {0}", count);
        }

        private static void CountOccuranceofaChar(string v1, char v2)
        {
            int count = 0;
            for(int i = 0; i < v1.Length; i++)
            {
                if (v1[i] == v2)
                {

                    count++;
                }
            }

            Console.WriteLine("The number of occurance of {0} is {1}", v2, count);

        }

        private static void RemoveWhiteSpaces(string v)
        {
            //Console.WriteLine(v.Replace(" ", ""));
            StringBuilder sc = new();
            for(int i = 0; i < v.Length; i++)
            {
                if (v[i]!=' ')
                {
                    sc.Append(v[i]);
                }
            }
            Console.WriteLine(sc.ToString());
        }

        private static void RemoveSpecialCharacters(string a)
        {
            
            StringBuilder sc = new();
            for(int i = 0; i < a.Length; i++) {

                //if (char.IsLetterOrDigit(a[i]))
                //{
                //    sc.Append(a[i]);
                //}


                if (a[i] > 64 && a[i] <= 122)
                {
                    sc.Append(a[i]);
                }

            }
            Console.WriteLine(sc.ToString());

        }

        private static void BinarySearch(int[] arr, int v)
        {
            int left = 0;
            int right = arr.Length-1;
            bool b = false;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == v)
                {
                    Console.WriteLine("The target index of the array is {0}", mid);
                    b = true;
                    break;
                }
                else if (arr[mid] > v)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            if (!b)
            {

                Console.WriteLine("Index not found");
            }
        }

        private static void LinearSearch(int[] arr, int a)
        {
            bool b=false;
             for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    Console.WriteLine("The target index of the array is {0}", i);
                    b = true;
                    break;
                }
            }
            if (!b)
            {

                Console.WriteLine("Index not found");
            }


        }

        private static void DuplicateNumber(int[] arr)
        {
            HashSet<int> hs = new();

            for(int i = 0; i < arr.Length; i++)
            {
                if (hs.Contains(arr[i]))
                {
                    Console.WriteLine("Imposter found -> {0}", arr[i]);
                }
                hs.Add(arr[i]);
            }
        }

        private static void MaxandMinNumber(int[] arr)
        {
            int Max = Int32.MinValue;
            int min = Int32.MaxValue;

            for(int i = 0; i < arr.Length; i++)
            {
                min = Math.Min(min, arr[i]);
                Max = Math.Max(Max, arr[i]);
            }

            Console.WriteLine("The Maximum number in the array is {0}", Max);
            Console.WriteLine("The Minimum number in the array is {0}", min);
        }

        private static void MissingNumber(int[] arr)
        {
            int a = 0;
            int b = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                a = a ^ arr[i];
            }

            for (int i = 0; i <= arr.Length; i++)
            {
                b = b^i;
            }

            Console.Write(a^b);
        }

        private static void equalarray(int[] arr, int[] arr1)
        {
            Console.WriteLine("The build-in Method to check whether true or False is  "+arr.SequenceEqual(arr1));

            for(int i=0;i<arr.Length  && i < arr1.Length; i++)
            {
                if (arr[i] != arr1[i])
                {
                    Console.WriteLine("False");
                }
            }
            Console.WriteLine("True");
        }

        private static void sumofevenoroddarray(int[] arr)
        {
            int even = 0;
            int odd = 0;

            for(int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    even = even + arr[i];
                }
                else
                {
                    odd = odd + arr[i];
                }
            }

            Console.WriteLine("Sum of even number is {0}", even);
            Console.WriteLine("Sum of odd number is {0}", odd);
        }

        private static void sumofArray(int[] arr)
        {
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("The sum of array is {0}", sum);
        }

        private static void factorialnumber(int v)
        {
            int fact = 1;
           for(int i = 1; i < v; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("The factorial of the number is {0}", fact);
        }

        private static void generaterandomtext()
        {
            Random random = new();
            string a = "abcdefghijklmnopqrstuvwxyz";

            string ran = "";

            for(int i = 0; i < 10; i++)
            {
               int ss= random.Next(26);

                ran = ran + a[ss];
            }

            Console.WriteLine("Random word Generated is {0}", ran);
        }

        private static void generaterandomNumber()
        {
            Random random = new();

            Console.WriteLine(random.Next(10, 20));
        }

        private static void checkprime(int v)
        {
            int count = 0;
           for(int i = 1; i <=v; i++)
            {
                if (v % i == 0)
                {

                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("It is a Prime number");
            }
            else
            {
                Console.WriteLine("It is not a Prime number");
            }
        }

        private static void Printnprimes(int n)
        {

            Console.WriteLine("The numbers of primes are");
            for (int k = 0; k < n; k++)

            {
                int count = 0;
                for (int i = 1; i < n; i++)
                {
                    if (k % i == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.Write(k + " ");
                
                }
               

            }
        }

        private static void fibonnaciinumber(int v)
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine("Fibonnaci of number using variable");
            Console.Write(n1 +"" + n2);

            for(int i = 2; i < v; i++) {

                int sum = n1 + n2;
                Console.Write(" " + sum);
                n1 = n2;
                n2 = sum;
            }

            int[] arr = new int[v];

            arr[0] = 0;
            arr[1] = 1;

  

            for(int i = 2; i < v; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            Console.WriteLine("The fibonnaci of a number using array is ");

            foreach(var s in arr)
            {
                Console.Write(s+",");
            }


        }

        private static void Maxofanumber(int v1, int v2, int v3)
        {
            Console.WriteLine("The Max of a number is:{0}",Math.Max(v1, Math.Max(v2, v3)));
        }


        



        private static void PalidromeString(string v)
        {
            //string d = v.Reverse().ToString();

            string d = revstring(v);

            if (d.Equals(v))
            {
                Console.WriteLine("It is a Palindrome String");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome String");
            }
        }

        public static void revcompletestring(string a)
        {
            StringBuilder c = new();
            foreach(var d in a.Split(' '))
            {

                c.Append(revstring(d)+" ");
            }
            Console.WriteLine(c.ToString());

        } 

        private static string  revstring(string a)
        {

            StringBuilder sc = new();

        


            for(int i = a.Length-1; i>=0; i--)
            {
                sc.Append(a[i]);
            }

            Console.WriteLine("Reverse of a String is {0}",sc);

            return sc.ToString();
        }

        private static void PalidromeNumber(int v)
        {
            int a = reverseInt(v);

            if (a == v)
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {

                Console.WriteLine("It is not a Palindrome");
            }
        }

        private static int reverseInt(int v)
        {
            int rev = 0;
            int Count = 0;
            int even = 0;
            int odd = 0;

            int sum = 0;
            while (v > 0)
            {
                int num = v % 10;

                sum = sum + num;

                rev = rev * 10 + num;

                Count++;

                if (Count % 2 == 0)
                {

                    even++;
                }
                else
                {
                    odd++;
                }

                v = v / 10;

            }
            Console.WriteLine("The sum of number is {0}", sum);
            Console.WriteLine("The number of even digits are {0}", even);
            Console.WriteLine("The number of odd digits are {0}", odd);
            Console.WriteLine("The count of a number is {0}",Count);
            return rev;

            Console.WriteLine("Reversed Number is {0}", rev);

            Console.WriteLine("Using StringReverse function");

            String D = v.ToString();

            string Reverse = new String(D.Reverse().ToArray());

            Console.Write(Reverse);

        }

        static void stringSwap(string a,string b) {

            Console.WriteLine("------Basic using three variables");
            string c = b;
            b = a;
            a = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("Basic using two variables");

            a = a + b;

            b = a.Substring(0, a.Length - b.Length);

            a = a.Substring(b.Length);

            Console.WriteLine(a);
            Console.WriteLine(b);

        }



        static void Swap(int a,int b)
        {


            Console.WriteLine("------Basic using three variables");
            int c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("------------------------");


            Console.WriteLine("Basic using two variables");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("------------------------");


            Console.WriteLine("Basic using xOR variables");

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("------------------------");
        }
    }
}
