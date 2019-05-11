using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    class BubbleSort
    {
        int length;
        int[] arr;
        IOutput output;
        public BubbleSort(IOutput outt)
        {
            length = 10;
            output = outt;
        }
        public BubbleSort(int length,IOutput outt)
        {
            this.length = length;
            output = outt;
        }
        public void Evaluate()
        {
            arr = new int[length];
            GenerateArray();
            ShowArray();
            SortArray();
            ShowArray();
        }

        private void GenerateArray()
        {
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rand.Next(1, length * 2);
            }
        }

        private void ShowArray()
        {
            for (int i = 0; i < length; i++)
            {
                output.Write(arr[i] + " ");
            }
            output.WriteLine("");
        }

        private void SortArray()
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    int prev = arr[j];
                    int next = arr[j + 1];
                    if (next < prev)
                    {
                        arr[j] = next;
                        arr[j + 1] = prev;
                    }
                }
            }
        }
    }
}









