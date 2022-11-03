using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'maxMin' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY arr
         */

        public static int maxMin(int k, List<int> arr)
        {
            int minUnfair = int.MaxValue;
            List<int> list = new List<int>();
            arr.Sort();

            for (int i = 0; i < arr.Count-k+1; i++)
            {
                minUnfair = (arr[i+k-1] - arr[i]) < minUnfair ? (arr[i+k-1] - arr[i]) : minUnfair;
            }

            return minUnfair;
        }
    }
}