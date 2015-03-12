using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{

    public interface IMergeSort
    {
        IEnumerable<int> Sort(List<int> data);

        IEnumerable<int> MergeSortedList(List<int> sortedListA, List<int> sortedListB);
    }

    public class MergeSort : IMergeSort
    {
        public IEnumerable<int> Sort(List<int> list)
        {
            throw new Exception("not implemented");
        }


        public IEnumerable<int> MergeSortedList(List<int> sortedListA, List<int> sortedListB)
        {
            int aListCounter = 0;
            int bListCounter = 0;

            var mergedList = new List<int>();

            while (aListCounter < sortedListA.Count - 1 || bListCounter < sortedListB.Count - 1)
            { 
                if (sortedListA[aListCounter] < sortedListB[bListCounter])
                {
                    mergedList.Add(sortedListA[aListCounter]);
                    aListCounter++;
                }
                else
                {
                    mergedList.Add(sortedListB[bListCounter]);
                    bListCounter++;
                }
            }
            //merge if there's any thing left in the other lists
            for (int i = aListCounter; i < sortedListA.Count; i++)
            {
                mergedList.Add(sortedListA[i]);
            }

            for (int i = bListCounter; i < sortedListB.Count; i++)
            {
                mergedList.Add(sortedListB[i]);
            }

            return mergedList;
        }
    }
}
