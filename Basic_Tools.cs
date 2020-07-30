using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// A class to access basic tools.
    /// </summary>
    public static class Basic_Tools
    {

        public static void printArray(int[] array)
        {
             string text = "";

            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    text = array[i] + "";
                else
                    text = array[i] + ", ";

                Console.Write(text);
            }
            Console.WriteLine("}"); 

        }
        public static void printArray(double[] array)
        {
            string text = "";

            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    text = array[i] + "";
                else
                    text = array[i] + ", ";

                Console.Write(text);
            }
            Console.WriteLine("}");
        }
        public static void printArray(float[] array)
        {
            string text = "";

            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    text = array[i] + "";
                else
                    text = array[i] + ", ";

                Console.Write(text);
            }
            Console.WriteLine("}");
        }
        public static void printArray(decimal[] array)
        {
            string text = "";

            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    text = array[i] + "";
                else
                    text = array[i] + ", ";

                Console.Write(text);
            }
            Console.WriteLine("}");
        }
        public static void printArray(string[] array)
        {
            string text = "";

            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    text = array[i] + "";
                else
                    text = array[i] + ", ";

                Console.Write(text);
            }
            Console.WriteLine("}");
        }
        public static void printArray(char[] array)
        {
            string text = "";

            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    text = array[i] + "";
                else
                    text = array[i] + ", ";

                Console.Write(text);
            }
            Console.WriteLine("}"); 
        }

        public static void printArray(int[,] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                for (int j = 0; j < array.Length / (array.Length / 2); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
        public static void printArray(double[,] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                for (int j = 0; j < array.Length / (array.Length / 2); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
        public static void printArray(float[,] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                for (int j = 0; j < array.Length / (array.Length / 2); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
        public static void printArray(decimal[,] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                for (int j = 0; j < array.Length / (array.Length / 2); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
        public static void printArray(string[,] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                for (int j = 0; j < array.Length / (array.Length / 2); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
        public static void printArray(char[,] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                for (int j = 0; j < array.Length / (array.Length / 2); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
        /// <summary>
        /// Case sensitive, filters desired characters out of deisred string.
        /// </summary>
        /// <param name="rawString">String to be filtered.</param>
        /// <param name="targets">Array of characters (case sensitive) to be removed from "rawString".</param>
        /// <returns>A new filtered string.</returns>
        public static string filterString(string rawString, char[] targets)
        {
            string newString = "";

            for (int i = 0; i < rawString.Length; i++)
            {
                int targetCount = 0;

                for (int j = 0; j < targets.Length; j++)
                {
                    if (rawString[i] == targets[j])
                    {
                        targetCount++;
                    }
                }

                if (targetCount == 0)
                {
                    newString += rawString[i];
                }
            }

            return newString;
        }

        /// <summary>
        /// Orders an array of numbers from least to greatest.
        /// </summary>
        /// <param name="nums">The array of numbers [must be decimals] that will be ordered.</param>
        /// <returns>A new ordered copy of the original array as a decimal array.</returns>
        public static double[] orderNums(double[] nums)
        {
            double[] orderedNums = { };
            int count = 0;

            orderedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        count++;
                    }
                }

                orderedNums[(nums.Length - 1) - count] = nums[i];

            }

            for (int i = 0; i < orderedNums.Length; i++)
            {
                if (orderedNums[i] == 0)
                {
                    bool f = false;
                    for (int x = i; f == false; x++)
                    {
                        if (orderedNums[x] != 0)
                        {
                            orderedNums[i] = orderedNums[x];
                            f = true;
                        }
                    }
                }
            }
            return orderedNums;
        }

        public static double[] orderNums(float[] numsarray)
        {
            double[] nums = ConvertArray.ToDoubleArray(numsarray);
            double[] orderedNums = { };
            int count = 0;

            orderedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        count++;
                    }
                }

                orderedNums[(nums.Length - 1) - count] = nums[i];

            }

            for (int i = 0; i < orderedNums.Length; i++)
            {
                if (orderedNums[i] == 0)
                {
                    bool f = false;
                    for (int x = i; f == false; x++)
                    {
                        if (orderedNums[x] != 0)
                        {
                            orderedNums[i] = orderedNums[x];
                            f = true;
                        }
                    }
                }
            }
            return orderedNums;
        }

        public static double[] orderNums(int[] numsarray)
        {
            double[] nums = ConvertArray.ToDoubleArray(numsarray);
            double[] orderedNums = { };
            int count = 0;

            orderedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        count++;
                    }
                }

                orderedNums[(nums.Length - 1) - count] = nums[i];

            }

            for (int i = 0; i < orderedNums.Length; i++)
            {
                if (orderedNums[i] == 0)
                {
                    bool f = false;
                    for (int x = i; f == false; x++)
                    {
                        if (orderedNums[x] != 0)
                        {
                            orderedNums[i] = orderedNums[x];
                            f = true;
                        }
                    }
                }
            }
            return orderedNums;
        }

        public static double[] orderNums(decimal[] numsarray)
        {
            double[] nums = ConvertArray.ToDoubleArray(numsarray);
            double[] orderedNums = { };
            int count = 0;

            orderedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        count++;
                    }
                }

                orderedNums[(nums.Length - 1) - count] = nums[i];

            }

            for (int i = 0; i < orderedNums.Length; i++)
            {
                if (orderedNums[i] == 0)
                {
                    bool f = false;
                    for (int x = i; f == false; x++)
                    {
                        if (orderedNums[x] != 0)
                        {
                            orderedNums[i] = orderedNums[x];
                            f = true;
                        }
                    }
                }
            }
            return orderedNums;
        }

        /// <summary>
        /// Orders an array of numbers from greatest to least.
        /// </summary>
        /// <param name="nums">The array of numbers that will be ordered.</param>
        /// <returns>A new ordered copy of the original array as a double array.</returns>
        public static double[] orderNumsReverse(double[] nums)
        {
            double[] orderedNums = { };
            int count = 0;

            orderedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        count++;
                    }
                }

                orderedNums[count] = nums[i];

            }

            for (int i = orderedNums.Length - 1; i > 0; i--)
            {
                if (orderedNums[i] == 0)
                {
                    bool f = false;
                    for (int x = i; f == false; x--)
                    {
                        if (orderedNums[x] != 0)
                        {
                            orderedNums[i] = orderedNums[x];
                            f = true;
                        }
                    }
                }
            }

            return orderedNums;
        }

        public static double[] orderNumsReverse(int[] numsarray)
        {
            double[] nums = ConvertArray.ToDoubleArray(numsarray);
            double[] orderedNums = { };
            int count = 0;

            orderedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        count++;
                    }
                }

                orderedNums[count] = nums[i];

            }

            for (int i = orderedNums.Length - 1; i > 0; i--)
            {
                if (orderedNums[i] == 0)
                {
                    bool f = false;
                    for (int x = i; f == false; x--)
                    {
                        if (orderedNums[x] != 0)
                        {
                            orderedNums[i] = orderedNums[x];
                            f = true;
                        }
                    }
                }
            }

            return orderedNums;
        }

        public static double[] orderNumsReverse(float[] numsarray)
        {
            double[] nums = ConvertArray.ToDoubleArray(numsarray);
            double[] orderedNums = { };
            int count = 0;

            orderedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        count++;
                    }
                }

                orderedNums[count] = nums[i];

            }

            for (int i = orderedNums.Length - 1; i > 0; i--)
            {
                if (orderedNums[i] == 0)
                {
                    bool f = false;
                    for (int x = i; f == false; x--)
                    {
                        if (orderedNums[x] != 0)
                        {
                            orderedNums[i] = orderedNums[x];
                            f = true;
                        }
                    }
                }
            }

            return orderedNums;
        }

        public static double[] orderNumsReverse(decimal[] numsarray)
        {
            double[] nums = ConvertArray.ToDoubleArray(numsarray);
            double[] orderedNums = { };
            int count = 0;

            orderedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        count++;
                    }
                }

                orderedNums[count] = nums[i];

            }

            for (int i = orderedNums.Length - 1; i > 0; i--)
            {
                if (orderedNums[i] == 0)
                {
                    bool f = false;
                    for (int x = i; f == false; x--)
                    {
                        if (orderedNums[x] != 0)
                        {
                            orderedNums[i] = orderedNums[x];
                            f = true;
                        }
                    }
                }
            }

            return orderedNums;
        }

        /// <summary>
        /// Finds desired number [as a string] in an array.
        /// </summary>
        /// <param name="target">Number to find [as a string].</param>
        /// <param name="source">Array to be searched.</param>
        /// <returns></returns>
        public static string[] findNums(string target, decimal[] source)
        {
            string[] targetIndexes = new string[source.Length + 1];
            int targetCount = 0;

            int j = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (Convert.ToString(source[i]) == target)
                {
                    targetCount++;
                    targetIndexes[j] = "target (" + target + ") at index position " + Convert.ToString(i);
                    j++;
                }
            }

            targetIndexes[j] = "Total number of instances of target " + target + " are " + Convert.ToString(targetCount);

            string[] newTargetIndexes = new string[j + 1];

            for (int i = 0; i < j + 1; i++)
            {
                newTargetIndexes[i] = targetIndexes[i];
            }

            return newTargetIndexes;
        }

        public static string[] findNums(string target, double[] source)
        {
            string[] targetIndexes = new string[source.Length + 1];
            int targetCount = 0;

            int j = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (Convert.ToString(source[i]) == target)
                {
                    targetCount++;
                    targetIndexes[j] = "target (" + target + ") at index position " + Convert.ToString(i);
                    j++;
                }
            }

            targetIndexes[j] = "Total number of instances of target " + target + " are " + Convert.ToString(targetCount);

            string[] newTargetIndexes = new string[j+1];

            for (int i = 0; i < j+1; i++)
            {
                newTargetIndexes[i] = targetIndexes[i];
            }

            return newTargetIndexes;
        }

        public static string[] findNums(string target, float[] source)
        {
            string[] targetIndexes = new string[source.Length + 1];
            int targetCount = 0;

            int j = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (Convert.ToString(source[i]) == target)
                {
                    targetCount++;
                    targetIndexes[j] = "target (" + target + ") at index position " + Convert.ToString(i);
                    j++;
                }
            }

            targetIndexes[j] = "Total number of instances of target " + target + " are " + Convert.ToString(targetCount);

            string[] newTargetIndexes = new string[j + 1];

            for (int i = 0; i < j + 1; i++)
            {
                newTargetIndexes[i] = targetIndexes[i];
            }

            return newTargetIndexes;
        }

        public static string[] findNums(string target, int[] source)
        {
            string[] targetIndexes = new string[source.Length + 1];
            int targetCount = 0;

            int j = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (Convert.ToString(source[i]) == target)
                {
                    targetCount++;
                    targetIndexes[j] = "target (" + target + ") at index position " + Convert.ToString(i);
                    j++;
                }
            }

            targetIndexes[j] = "Total number of instances of target " + target + " are " + Convert.ToString(targetCount);

            string[] newTargetIndexes = new string[j + 1];

            for (int i = 0; i < j + 1; i++)
            {
                newTargetIndexes[i] = targetIndexes[i];
            }

            return newTargetIndexes;
        }

        /// <summary>
        /// A class containing methods to convert single dimensional arrays
        /// from one data type to another (with the exception of converting to float).
        /// </summary>
        public static class ConvertArray
        {
            public static decimal[] ToDecimalArray(int[] array)
            {
                decimal[] newArray = new decimal[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDecimal(array[i]);
                }

                return newArray;
            }

            public static decimal[] ToDecimalArray(double[] array)
            {
                decimal[] newArray = new decimal[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDecimal(array[i]);
                }

                return newArray;
            }

            public static decimal[] ToDecimalArray(float[] array)
            {
                decimal[] newArray = new decimal[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDecimal(array[i]);
                }

                return newArray;
            }

            public static decimal[] ToDecimalArray(string[] array)
            {
                decimal[] newArray = new decimal[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDecimal(array[i]);
                }

                return newArray;
            }

            public static decimal[] ToDecimalArray(char[] array)
            {
                decimal[] newArray = new decimal[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDecimal(array[i]);
                }
                
                return newArray;
            }

            public static int[] ToIntArray(double[] array)
            {
                int[] newArray = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToInt32(array[i]);
                }

                return newArray;
            }

            public static int[] ToIntArray(float[] array)
            {
                int[] newArray = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToInt32(array[i]);
                }

                return newArray;
            }

            public static int[] ToIntArray(decimal[] array)
            {
                int[] newArray = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToInt32(array[i]);
                }

                return newArray;
            }

            public static int[] ToIntArray(string[] array)
            {
                int[] newArray = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToInt32(array[i]);
                }

                return newArray;
            }

            public static int[] ToIntArray(char[] array)
            {
                int[] newArray = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToInt32(array[i]);
                }

                return newArray;
            }

            public static double[] ToDoubleArray(int[] array)
            {
                double[] newArray = new double[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDouble(array[i]);
                }

                return newArray;
            }

            public static double[] ToDoubleArray(float[] array)
            {
                double[] newArray = new double[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDouble(array[i]);
                }

                return newArray;
            }

            public static double[] ToDoubleArray(decimal[] array)
            {
                double[] newArray = new double[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDouble(array[i]);
                }

                return newArray;
            }

            public static double[] ToDoubleArray(string[] array)
            {
                double[] newArray = new double[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDouble(array[i]);
                }

                return newArray;
            }

            public static double[] ToDoubleArray(char[] array)
            {
                double[] newArray = new double[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToDouble(array[i]);
                }

                return newArray;
            }

            public static string[] ToStringArray(int[] array)
            {
                string[] newArray = new string[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToString(array[i]);
                }

                return newArray;
            }

            public static string[] ToStringArray(double[] array)
            {
                string[] newArray = new string[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToString(array[i]);
                }

                return newArray;
            }

            public static string[] ToStringArray(float[] array)
            {
                string[] newArray = new string[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToString(array[i]);
                }

                return newArray;
            }

            public static string[] ToStringArray(decimal[] array)
            {
                string[] newArray = new string[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToString(array[i]);
                }

                return newArray;
            }

            public static string[] ToStringArray(char[] array)
            {
                string[] newArray = new string[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToString(array[i]);
                }

                return newArray;
            }

            public static char[] ToCharArray(int[] array)
            {
                char[] newArray = new char[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToChar(array[i]);
                }

                return newArray;
            }

            public static char[] ToCharArray(double[] array)
            {
                char[] newArray = new char[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToChar(array[i]);
                }

                return newArray;
            }

            public static char[] ToCharArray(float[] array)
            {
                char[] newArray = new char[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToChar(array[i]);
                }

                return newArray;
            }

            public static char[] ToCharArray(decimal[] array)
            {
                char[] newArray = new char[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToChar(array[i]);
                }

                return newArray;
            }

            public static char[] ToCharArray(string[] array)
            {
                char[] newArray = new char[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = Convert.ToChar(array[i]);
                }

                return newArray;
            }
        }
    }
}