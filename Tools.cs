using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit_Experimental
{
    class Tools
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public Hashtable findInArray(string[] targets, int[] array)
        {
            Hashtable targetIndexes = new Hashtable();
            int targetCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < targets.Length; j++)
                {
                    if (Convert.ToString(array[i]) == targets[j])
                    {
                        targetIndexes[targetCount] = (array[i], i);
                    }
                }
            }

            return targetIndexes;
        } 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="originalString"></param>
        /// <returns></returns>
        public string filterString(char[] filters, string originalString)
        {
            string newString = "";
            for (int i = 0; i < originalString.Length; i++)
            {
                for (int j = 0; j < filters.Length; j++)
                {
                    if (originalString[i] != filters[j])
                    {
                        newString += originalString[i];
                    }
                }
            }

            return newString;
        }

        public string filterString(int[] indexes, string originalString)
        {
            string newString = "";
            int count;

            for (int i = 0; i < originalString.Length; i++)
            {
                count = 0;
                for (int j = 0; j < indexes.Length; j++)
                {
                    if (i != indexes[j])
                    {
                        count++;
                    }
                    if (count == indexes.Length)
                    {
                        newString += originalString[i];
                    }
                }
            }

            return newString;
        }
            
        /// <summary>
        /// 
        /// </summary>
        class ConvertArray
        {

        }
    }
}