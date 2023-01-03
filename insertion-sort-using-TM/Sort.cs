using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TMBand = insertion_sort_using_TM.TM;

namespace insertion_sort_using_TM
{
    public abstract class Sort
    {
        public int[] array { get; set; }
        public int c { get; set; }
        public string sum { get; set; }
        public abstract Tuple<string, List<string[]>> Sorting();
        
        public string[] Cevir(int j)
        {
            string[] strs = new string[j];
            for (int k = 0; k < j; k++)
            {
                strs[k] = "1";
            }
            return strs;
        }
        public List<string[]> StringSort()
        {
            List<string[]> str = new List<string[]>();

            for (int i = 0; i < array.Length; i++)
            {
                string[] s = Cevir(array[i]);
                str.Add(s);
            }
            c = str.Count;
            return str;
        }
}
}
