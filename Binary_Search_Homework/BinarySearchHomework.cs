using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element

            //! START
            int third_index1 = start + ((end - start) / 3);
            int third_index2 = end - ((end - start) / 3);
            if (start > end || key > arr[arr.Length - 1] || key < arr[0]) return -1;

            if (arr[third_index1] == key)
            {
                return third_index1;
            }
            if (arr[third_index2] == key)
            {
                return third_index2;
            }

            if (key < arr[third_index1])
            {
                return TernarySearch(arr, key, start, third_index1 - 1);
            }
            if (key > arr[third_index2])
            {
                return TernarySearch(arr, key, third_index2 + 1, end);
            }

            return TernarySearch(arr, key, third_index1 + 1, third_index2 - 1);

            //! END 

        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance

            //! START

            if (start > end || key > arr[arr.Length - 1] || key < arr[0]) return -1;

            int third_index1 = start + ((end - start) / 3);
            int third_index2 = end - ((end - start) / 3);
            if (is_first)
            {
                if (arr[third_index1] == key)
                {
                    if (third_index1 == 0 || arr[third_index1 - 1] != key)
                    {
                        return third_index1;
                    }
                    return BinarySearchForCalculatingRepeated(arr, key, true, start, third_index1 - 1);
                }
                if (arr[third_index2] == key)
                {
                    if (third_index2 == 0 || arr[third_index2 - 1] != key)
                    {
                        return third_index2;
                    }
                    return BinarySearchForCalculatingRepeated(arr, key, true, start, third_index2 - 1);
                }

                if (key < arr[third_index1])
                {
                    return BinarySearchForCalculatingRepeated(arr, key, true, start, third_index1 - 1);
                }

                if (key > arr[third_index2])
                {
                    return BinarySearchForCalculatingRepeated(arr, key, true, third_index2 + 1, end);
                }

                return BinarySearchForCalculatingRepeated(arr, key, true, third_index1 + 1, third_index2 - 1);
            }

            //! if is last 

            if (arr[third_index1] == key)
            {
                if (third_index1 == arr.Length - 1 || arr[third_index1 + 1] != key)
                {
                    return third_index1;
                }
                return BinarySearchForCalculatingRepeated(arr, key, false, third_index1 + 1, end);
            }
            if (arr[third_index2] == key)
            {
                if (third_index2 == arr.Length - 1 || arr[third_index2 + 1] != key)
                {
                    return third_index2;
                }
                return BinarySearchForCalculatingRepeated(arr, key, false, start, third_index2 - 1);
            }

            if (key < arr[third_index1])
            {
                return BinarySearchForCalculatingRepeated(arr, key, false, start, third_index1 - 1);
            }

            if (key > arr[third_index2])
            {
                return BinarySearchForCalculatingRepeated(arr, key, false, third_index2 + 1, end);
            }

            return BinarySearchForCalculatingRepeated(arr, key, false, third_index1 + 1, third_index2 - 1);

            //! END 

        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method

            //! START

            int first = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            Console.WriteLine("the first is : " + first);
            if (first == -1) return 0;

            int end = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);
            Console.WriteLine("the index end is : " + end);
            return end - first + 1;

            //! END 
        }
    }
}
