using AlgorithmNet.Shared;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Xml.Linq;

namespace AlgorithmNet
{
    public class Sorts
    {
        /// <summary>
        /// Given a array in the wrong order, swapping them, for sort it
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>sorted array</returns>
        public int[] BubbleSort(int[] arr)
        {
            if (arr.Count() == 0)
                return arr;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Given a array in the wrong order, swapping them, for sort it
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>sorted list</returns>
        public List<int> BubbleSort(List<int> arr)
        {
            if (arr.Count == 0)
                return arr;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = 0; j < arr.Count - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        /// <summary>
        /// Order by numeric field like Id, Age...
        /// </summary>
        public List<T> BubbleSort<T>(List<T> arr, string fieldName) where T : class
        {
            try
            {
                var genericMethods = new GenericMethods();
                if (arr.Count == 0)
                    return arr;
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    for (int j = 0; j < arr.Count - i - 1; j++)
                    {
                        var current = Int32.Parse(genericMethods.GetPropertyValue(arr[j], fieldName));
                        var next = Int32.Parse(genericMethods.GetPropertyValue(arr[j + 1], fieldName));
                        if (current > next)
                        {
                            var temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
                return arr;
            }
            catch
            {
                return arr;
            }
        }
        /// <summary>
        /// Given a array in the wrong order, swapping them, for sort it
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>sorted list</returns>
        public int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minimo])
                    {
                        minimo = j;
                    }
                }

                var temp = arr[i];
                arr[i] = arr[minimo];
                arr[minimo] = temp;
            }
            return arr;
        }
        /// <summary>
        /// Given a list in the wrong order, swapping them, for sort it
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>sorted list</returns>
        public List<int> SelectionSort(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j] < arr[minimo])
                    {
                        minimo = j;
                    }
                }

                var temp = arr[i];
                arr[i] = arr[minimo];
                arr[minimo] = temp;
            }
            return arr;
        }
        /// <summary>
        /// Order by numeric field like Id, Age...
        /// </summary>
        public List<T> SelectionSort<T>(List<T> arr, string fieldName) where T : class
        {
            try
            {

                var genericMethods = new GenericMethods();
                for (int i = 0; i < arr.Count; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < arr.Count; j++)
                    {
                        var current = Int32.Parse(genericMethods.GetPropertyValue(arr[j], fieldName));
                        var next = Int32.Parse(genericMethods.GetPropertyValue(arr[min], fieldName));
                        if (current < next)
                            min = j;
                    }

                    var temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
                return arr;
            }
            catch
            {
                return arr;
            }
        }
    }
}