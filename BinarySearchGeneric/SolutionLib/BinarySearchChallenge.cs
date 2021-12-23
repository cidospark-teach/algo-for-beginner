using System;
using System.Collections.Generic;

namespace SolutionLib
{
    public class BinarySearchChallenge
    {
        public static T Search<T>(T[] arr, T searchTerm)
        {
            if (arr.Length < 1 || arr.Length == 1 && !arr[0].Equals(searchTerm))
                return default(T);

            // convert arr into list and sort
            var list = new List<T>(arr);
            list.Sort();

            // get the middle index
            int middleIndex = list.Count / 2;

            // check if search term == middle item
            var middleItem = list[middleIndex];
            if (middleItem.Equals(searchTerm))
                return middleItem;

            // check if item is the first or last
            if (searchTerm.Equals(list[0]))
                return list[0];
            if (searchTerm.Equals(list[list.Count - 1]))
                return list[list.Count - 1];

            return default(T);

            var listToCompare = new List<T>();
            listToCompare.Add(middleItem);
            listToCompare.Add(searchTerm);
            int comparison = CompareItems(new List<T>(listToCompare), middleItem);
            List<T> sublist = null;

            // if middle item is less than search term then pick right side array range
            if (comparison == 1)
            {
                sublist = list.GetRange(middleIndex + 1, (list.Count - (middleIndex + 1) - 1));
            }
            else if (comparison == 2)
            {
                // if middle item is greater than search term then pick left side array range
                sublist = list.GetRange(1, middleIndex - 1);
            }

            return Search(sublist.ToArray(), searchTerm); // recursively call this method to repeat process

        }

        private static int CompareItems<T>(List<T> items, T middleItem)
        {
            items.Sort();
            if (middleItem.Equals(items[0]))
                return 1; // means less
            else if (middleItem.Equals(items[1]))
                return 2; // means greater
            else
                return 0; // means equals

        }
    }
}
