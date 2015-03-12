using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class BubbleSort
    {
        public int[] Sort(int[] data)
        {
            if (data.Length == 1) return data;
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int k = 0; k < data.Length - 1; k++)
                {
                    if (data[k] > data[k + 1])
                    {
                        //swap
                        int temp = data[k];
                        data[k] = data[k + 1];
                        data[k + 1] = temp;
                    }
                }
            }
            return data;
        }

    }
}
