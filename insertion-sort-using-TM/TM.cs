using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort_using_TM
{
    class TM
    {
        public List<string> TMBand { get; set; }
        public string[] A { get; set; }
        public string[] B { get; set; }
        public int IndexforSeperation { get; set; }
        public TM()
        {
            TMBand = new List<string>();

        }
        public void Compare()
        {
            TMBand.Add("B");
            TMBand.AddRange(A);
            TMBand.Add("0");
            IndexforSeperation = TMBand.FindIndex(x => x.StartsWith("0"));
            TMBand.AddRange(B);
            TMBand.Add("B");
            int i = 1;
            while (i >= 0 && TMBand[i] != TMBand[IndexforSeperation] && TMBand[TMBand.Count - 2] != "X")
            {
                TMBand[i] = "X";
                TMBand[IndexforSeperation + i] = "X";
                i++;
            }

        }
    }
}
