using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Algorithms
{
    class Solution
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> scores = new List<int>() { 0, 0 };


            for (int i = 0; i < a.Count; i++) // Loop through List with for
            {
                if (a[i] > b[i]) scores[0]++;
                else if (a[i] < b[i]) scores[1]++;
            }
            return scores;

        }

        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;

        }


        /*
    * Complete the 'diagonalDifference' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts 2D_INTEGER_ARRAY arr as parameter.
    */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumright = 0;
            int sumleft = 0;
            int length = arr[0].Count;

            for (int i = 0; i < length; i++)
            {
                sumright += arr[i][0 + i];
                sumleft += arr[i][length - i - 1];
            }
            return Math.Abs(sumright - sumleft);

        }


        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            decimal positives = 0;
            decimal negatives = 0;
            decimal zeros = 0;
            decimal length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] < 0) negatives++;
                else if (arr[i] > 0) positives++;
                else zeros++;

            }
            Console.WriteLine($"{positives / length:F6}");
            Console.WriteLine($"{ negatives / length:F6}");
            Console.WriteLine($"{zeros / length:F6}");

        }


        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (y >= x)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
                /*
                    #     
                    ##    
                    ###   
                    ####  
                    ##### 
                    ######
                 */
            }

        }

        // Complete the staircase function below.
        static void staircases(int n)
        {
            for (int y = n - 1; y >= 0; y--)
            {
                for (int x = 0; x < n; x++)
                {
                    if (x >= y)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
           /*   #
                ##
                ###
                ####
                #####
                ######

            */

        }



        // Complete the miniMaxSum function below.
        //Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers
        static void miniMaxSum(int[] arr)
        {
           cd


        }

           /*
          * Complete the 'birthdayCakeCandles' function below.
          *
          * The function is expected to return an INTEGER.
          * The function accepts INTEGER_ARRAY candles as parameter.
          */

        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.First();
            int count = 1;

            for (int i = 1; i < candles.Count; i++)
            {
                if (candles[i] > max)
                {
                    max = candles[i];
                    count = 1;
                }
                else if (candles[i] == max)
                {
                    count++;
                }

            }
            return count;
        }

        /*
   * Complete the timeConversion function below to 24 hours format.
   */
        static string timeConversion(string s)
        {
            bool successfulConversion = DateTime.TryParse(s, out DateTime time);
            if (successfulConversion) return time.ToString("HH:mm:ss");
            else return "Invalid Date Provided";

        }

        //Given three integers,t1 ,t2 , and n, compute and print the nth  term of a modified Fibonacci sequence.
        //Ti = Ti + (Ti + 1)^2 raise to power 2

        static BigInteger fibonacciModified(int t1, int t2, int n)
        {

            BigInteger first = (BigInteger)t1;
            BigInteger second = (BigInteger)t2;
            BigInteger third = 0;

            for (int i = 1; i <= n - 2; i++)
            {
                third = first + (second * second);
                
                first = second;
                second = third;


            }
            return third;
        


        }


        //hackerrank quick sort
        /* 
        int n = int.Parse(Console.ReadLine());
        string[] a = new string[n];

        for (int i = 0; i<n; ++i) a[i] = Console.ReadLine();

        Array.Sort(a, (s1, s2) =>
        {
            int l = s1.Length - s2.Length;
            return (l != 0) ? l : string.Compare(s1, s2, StringComparison.OrdinalIgnoreCase);
        });

        for (int i = 0; i<n; ++i) Console.WriteLine(a[i]);
        */

 public static string Order(string words)
        {
            char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string result = "";
            string[] name = null;
            name = words.Split(" ");
           
            Console.WriteLine(name);
            
            if (words == "")
            {
                return "";
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j].Contains(nums[i]))
                    {
                        result = result + name[j] + " ";
                    }
                }
            }
            return result.TrimEnd();

        }

//codewars
        public static bool IsPangram(string str)
        {
        
        return str.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26;

        }


     
        //GET MIDDLE codewars
        public static string GetMiddle(string s)
        {
            return (s.Length%2 == 1) ? s.Substring((s.Length / 2), 1) : s.Substring((s.Length-1) / 2, 2);

        }


        //Are they the same???? codewars
      using System;
class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if (a == null || b == null) { return false; }
    if (a.Length != b.Length) { return false; }
    if (a.Length == 0 && b.Length == 0) { return true; }
    int[] aSquared = new int[a.Length];
    int[] bS = b;
    for(int i =0; i<a.Length; i++)
    {
      aSquared[i] = Convert.ToInt32(Math.Pow(a[i], 2));
    }
    Array.Sort(aSquared);
    Array.Sort(bS);
    for(int i=0; i< bS.Length; i++)
    {
      if(aSquared[i] != bS[i])
      {
        return false;
      }
    }
    return true;
  }
}
    
    
      Expand (29 lines)
      Collapse
    
  
  


        //towerbuilder codewars
        public static string[] TowerBuilder(int nFloors)
            {
              string[] temp = new string[nFloors];
              int noOfStars = nFloors*2 -1;
              int pad = 0;
              for(int i = 0; i< nFloors; i++)
              {
                temp[i] = "".PadLeft(pad, ' ').PadRight(pad+noOfStars, '*').PadRight(pad+noOfStars+pad, ' ');
                ++pad;
                noOfStars -= 2;
              }
              Array.Reverse(temp);
              return temp;
    }

            //find the shortest word in a sentence
            using System;
            using System.Linq;

            public class Kata
            {
                public static int FindShort(string s)
                {
                return s.Split(' ').Min(s1 => s1.Length);
                }
    }

    //codewars split string

                    //using System.Collections.Generic;
                    //using System.Linq;

        public class SplitString
    
        public static string[] Solution(string str)
        {
            if (str.Length % 2 == 1)
                str += "_";

            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i += 2)
            {
                list.Add(str[i].ToString() + str[i + 1]);
            }

            return list.ToArray();
        }
}



//move zeroes to the back codewars
using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        int counter = 0;
        List<int> newarr = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] != 0)
            {
                arr[counter] = arr[i];
                counter++;
                //newlist.Add(arr);
            }
        }

        while (counter < arr.Length)
        {
            arr[counter] = 0;
            counter++;
        }


        for (int i = 0; i < arr.Length; i++)
        {
            newarr.Add(arr[i]);
        }
        return newarr.ToArray();
    }

//rot13

public static string Rot13(string message)
{
    string result = "";
    foreach (var s in message)
    {
        if ((s >= 'a' && s <= 'm') || (s >= 'A' && s <= 'M'))
            result += Convert.ToChar((s + 13)).ToString();
        else if ((s >= 'n' && s <= 'z') || (s >= 'N' && s <= 'Z'))
            result += Convert.ToChar((s - 13)).ToString();
        else result += s;
    }
    return result;
}


CountChange
 int[] ways = new int[money + 1];
            //    ways[0] = 1;

            //    for (int i = 0; i < coins.Length; i++)
            //    {
            //        for (int j = coins[i]; j <= money; j++)
            //        {
            //            ways[j] += ways[j - coins[i]];
            //        }
            //    }
            //    return ways[money];


























}










}
0


codewars valid braces

  public static bool ValidBraces(String braces) {
      int count = braces.Length;
      
      for(int i = 0; i < count / 2; i++){
        braces = Regex.Replace(braces, @"(\(\)|\[\]|\{\})","");
      }
      return !braces.Any();
}


sjf codewars
 public static int Sjf( int[] jobs,int index )
  {
    var sum = 0;
    
    for(int i = 0; i < jobs.Length; i++){
      if(jobs[i] < jobs[index])
        sum += jobs[i];
      
      if(jobs[i] == jobs[index] && i <= index)
        sum += jobs[i];
      
    }
    
    return sum;
  }












TrailingZeros 
int xx = 0;
  
    while(n > 0){
      double ans = n / 5;
       n= (int)Math.Floor(ans);
      xx += n;
    }
    return xx;




Assume "#" is like a backspace in string. This means that string "a#bc#d" actually is "bd"
Your task is to process a string with "#" symbols.

 String res = "";

            Stack<char> Charact = new Stack<char>();

            foreach (char character in s)
            {
                if ( character != '#')
                {
                    Charact.Push(character);
                }
                else if(character == '#' && Charact.Count > 0) {
                    Charact.Pop();
                }
            }
            while (Charact.Count > 0)
            {
                res = Charact.Pop() + res;
            }
            return res;



public class Solution {
    public int CountBinarySubstrings(string s) {
        
        if(String.IsNullOrEmpty(s)) return 0;
        
        var countzeroes = 0;
        var countones = 0;
        var result = 0;
        
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '0'){
                if(i - 1 >= 0 && s[i - 1] == '1') countzeroes = 0;
                countzeroes++;
                if(countzeroes <= countones) result++;
            }else{
                if(i - 1 >= 0 && s[i - 1] == '0') countones = 0;
                countones++;
                if(countones <= countzeroes) result++;
            }
        }
        return result;
        
    }
}




//getlengthofmissingarray
using System.Linq;

public class Kata
{
    public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
    {
        
        if (arrayOfArrays == null || arrayOfArrays.Length == 0) return 0;
        foreach (var array in arrayOfArrays)
        {
            if (array == null || array.Length == 0) return 0;
        }

       
        int[] sorted = arrayOfArrays
                        .Select(array => array.Count())
                        .OrderBy(count => count)
                        .ToArray<int>();

       
        for (int i = 0; i < sorted.Length - 1; i++)
        {
            if (sorted[i + 1] != sorted[i] + 1) 
                return sorted[i] + 1;
        }

        return 0;
    }
}



findoutlier codewars


            int oddnumberscount = 0;
            int evennumberscount = 0;
            int number = 0;

            for (int x = 0; x < 3; x++)
            {
                if (integers[x] % 2 == 0) evenCount++;
                else oddCount++;
            }

            if(oddnumberscount > evennumberscount)
            {
                for(int y = 0; y < integers.Length; y++)
                {
                    if (integers[y] % 2 == 0)
                    {
                        number = integers[y];
                        break;
                    }
                }
            }
            else
            {
                for(int z = 0; z < integers.Length; z++)
                {
                    if(integers[z] % 2 != 0)
                    {
                        number = integers[z];
                        break;
                    }
                }

            }
            return number;

        }

Reverse LinkedList

Public LinkedList ReverseLinkedList(LinkedList head){
	LinkedList previous = null;
	LinkedList curr= head;

	while(curr != null){
	LinkedList nextN = curr.Next;
	curr.Next = previous;
	previous = curr;
	curr = nextN;
	}
	return previous;	

}


