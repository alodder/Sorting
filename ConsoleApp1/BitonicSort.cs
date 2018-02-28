using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /**
     * https://www.cs.cmu.edu/~scandal/nesl/alg-sequence.htm
     * Here is Batcher's bitonic sort. It has total work O(n log^2 n) and depth O(log^2 n).
     * 
     * function bitonic_sort(a) =
     * if (#a == 1) then a
     * else
     * let
     * bot = subseq(a,0,#a/2);
     * top = subseq(a,#a/2,#a);
     * mins = {min(bot,top):bot;top};
     * maxs = {max(bot,top):bot;top};
     * in flatten({bitonic_sort(x) : x in [mins,maxs]});
     * 
     * function batcher_sort(a) =
     * if (#a == 1) then a
     * else
     * let b = {batcher_sort(x) : x in bottop(a)};
     * in bitonic_sort(b[0]++reverse(b[1]));
     * 
     * batcher_sort([8, 14, -8, -9, 5, -9, 17, 19]);
     */
    class BitonicSort
    {
    }
}
