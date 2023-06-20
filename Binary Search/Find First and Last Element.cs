namespace DSA_LB_Series.Binary_Search
{
    //https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

    public class Find_First_and_Last_Element
    {
        //O(n) Approach
        public (int, int) SearchRange(int[] arr, int target)
        {
            int first = -1;
            int second = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    if (first == -1)
                    {
                        first = i;
                        second = i;
                    }
                    else
                    {
                        second = i;
                    }
                }
            }

            return (first, second);
        }

        //Approach 2 With Binary Search
        //Time Complexity = O(logn)
        public (int, int) Search(int[] arr, int target)
        {
            int first = FirstElement(arr, target);
            int second = LastElement(arr, target);

            return (first, second);
        }

        private int FirstElement(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            int ans = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    ans = mid;
                    end = mid - 1;
                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return ans;
        }

        private int LastElement(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            int ans = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    ans = mid;
                    start = mid + 1;
                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return ans;
        }
    }
}
