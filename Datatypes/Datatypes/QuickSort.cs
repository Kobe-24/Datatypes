using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class QuickSort
    {
        public int[] Sort(int[] data)
        {
            Partition(data, 0, data.Length - 1);
            return data;
        }

        private void Partition(int[] data, int from, int to)
        {
            if (to - from < 1) return;
            var random = new Random();
            var pivot = data[random.Next(from, to)];
            int dataStart = from;
            int dataEnd = to;
            while (from < to)
            {
                while (data[from] < pivot)
                {
                    from++;
                }
                while (data[to] > pivot)
                {
                    to--;
                }
                Swap(ref data[from], ref data[to]);
            }
            Partition(data, dataStart, from);
            Partition(data, from + 1, dataEnd);
        }

        private void Swap(ref int a, ref int b)
        {
            // just a try to swap without temp variable ;)
            // doesn't work when using ref and same variable...
            // a = a - b;
            // b = a + b;
            // a = b - a;
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
