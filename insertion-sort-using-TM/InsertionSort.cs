using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMBand = insertion_sort_using_TM.TM;

namespace insertion_sort_using_TM
{
    public class InsertionSort : Sort
    {
        
        public override Tuple<string, List<string[]>> Sorting()
        {
            List<string[]> lw = new List<string[]>();
            List<string[]> str = new List<string[]>();
            str=StringSort();

            for (int i = 0; i < c - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    TM t = new TM();
                    t.A = str[j];
                    t.B = str[j - 1];
                    t.Compare();
                    string ss = "";
                    foreach (string s in t.TMBand)
                    {
                        ss += s;
                    }
                    string[] arr = new string[3];
                    arr[0] = t.A.Length.ToString();
                    arr[1] = t.B.Length.ToString();
                    arr[2] = ss;
                    lw.Add(arr);
                    if (t.TMBand[t.IndexforSeperation - 1] == "X" && t.TMBand[t.TMBand.Count - 2] != "X")
                    {
                        string[] key = str[j - 1];
                        str[j - 1] = str[j];
                        str[j] = key;
                    }
                    else if (t.TMBand[t.IndexforSeperation - 1] == "X" && t.TMBand[t.TMBand.Count - 2] == "X")
                    {
                        c--;
                        str.RemoveAt(j);
                        j++;
                    }
                }
                
            }
            foreach (string[] s in str)
            {
                sum += s.Length + " ";
            }
            return new Tuple<string, List<string[]>>(sum, lw);
        }

    } 
}
