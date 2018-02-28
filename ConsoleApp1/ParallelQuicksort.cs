using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /**
     * https://www.cs.cmu.edu/~scandal/nesl/alg-sequence.htm
     * This is a parallel version of Quicksort. It has expected work of O(n log n) and an expected depth of O(log n).
     * 
     * function quicksort(a) =
     * if (#a < 2) then a
     * else
     * let pivot   = a[#a/2];
     * lesser  = {e in a| e < pivot};
     * equal   = {e in a| e == pivot};
     * greater = {e in a| e > pivot};
     * result  = {quicksort(v): v in [lesser,greater]};
     * in result[0] ++ equal ++ result[1];
     * 
     * quicksort([8, 14, -8, -9, 5, -9, -3, 0, 17, 19]);
     */
    class ParallelQuicksort
    {
    }
}
