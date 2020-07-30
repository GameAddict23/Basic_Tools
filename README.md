# Table Of Contents
[Basic_Tools Overview](https://github.com/GameAddict23/Basic_Tools_Code/Basic_Tools Overview)
[Specifics](https://github.com/GameAddict23/Basic_Tools_Code/Specifics)
[Links](https://github.com/GameAddict23/Basic_Tools_Code/Links)

# Basic_Tools Overview

This project is essentially just a way to provide basic but helpful tools for me and possibly other people as well. These tools may or may not be useful, but that's up for you to decide. I appreciate any critique, even if it is harsh.

*7/29/2020(M/D/Y) This is my first time creating and managing a repository as well as using Github, so just keep that in mind.

# Specifics

As of 7/29/2020, this project will provide tools to print 1D arrays to a console/terminal, filter desired characters out of a string, order an array of numbers from least to greatest and greatest to least, finding numbers in an array, and convert 1D arrays to other types of arrays (currently int, double, decimal, string, and char). The code itself has quite a bit of documentation as well, although I will go over the main features here as well.

*All of these methods and classes are found under the namespace Toolkit.
*Basic_Tools is a public static class.

1. public static void printArray(array)
    This method will take single dimensional arrays of types int, double, float, decimal, char, and string and print them out to the console/terminal. 
    Implementations:
    
        Basic_Tools.printArray(new int[] {1, 2, 3, 4, 5, 6});
        Output: {1, 2, 3, 4, 5, 6}
        
        char[] letters = {'a', 'b', 'c', 'd', 'e', 'f'};
        Basic_Tools.printArray(letters);
        Output: {a, b, c, d, e, f}
        
2. public static string filterString(string rawString, char[] targets)
    This method will filter out the desired characters in the form of a char array out of the desired string and return that filtered string as a copy, not replacing the   original string. This method will only accept a string as the first parameter and a char array as the second parameter.
    Implementations:
        
        string newString = Basic_Tools.filterString("Hello", new char[] {'H'});
        Console.WriteLine(newString);
        Output: ello
        
        string originalString = "##?###$##n###a##$##m##$#e##?#";
        Console.WriteLine(Basic_Tools.filterString(originalString, new char[] {'#', '$', '?'}));
        Output: name
        
3. public static double[] orderNums(nums)
    This method will take single dimensional arrays of types double, float, int, and decimal and order the array from least to greatest and returns that ordered array as a copy of type double, not replacing the original array. There is another method called orderNumsReverse that will accept the same parameters, but will instead order the array from greatest to least.
    Implementations:
    
        double[] numberArray = {1, 9, 2, 8, 6, 3, 4, 5, 10};
        numberArray = Basic_Tools.orderNums(numberArray);
        Basic_Tools.printArray(numberArray)(numberArray);
        Output: {1, 2, 3, 4, 5, 6, 8, 9, 10}
        
4. public static string[] findNums(string target, source)
    This method will find the desired number as a string in a single dimensional array of types decimal, float, double, or int, and will return a string array revealing how many times the desired number was found and at what indexes it was found at.
    Implementations:
    
        int[] myArray = {10, 20, 30, 10, 40, 50, 60, 10, 70, 80, 10};
        string[] instances_of_10 = Basic_Tools.findNums("10", myArray); 
        Basic_Tools.printArray(instances_of_10);
        Output: {target (10) at index position 0, target (10) at index position 3, target (10) at index position 7, target (10) at index position 10, Total number of instances of target 10 are 4}
        
5. public static class ConvertArray
   {
   		public static decimal[] ToDecimalArray(array)
		public static double[] ToDoubleArray(array)
		public static int[] ToIntArray(array)
		public static string[] ToStringArray(array)
		public static char[] ToCharArray(array)
   }
   
   This class contains multiple methods that will accept one dimensional arrays of types decimal, float, double, int, string, and char and convert them into the respective type, of course with certain exceptions, like trying to convert a string like "Hello" to a char, as well as the inability to convert to float. The converted array will be returned as a copy, not replacing the original array. 

# Links

[Basic_Tools_Repository](https://github.com/GameAddict23/Basic_Tools_Code)
