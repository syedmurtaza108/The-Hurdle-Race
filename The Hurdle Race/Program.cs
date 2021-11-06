using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Hurdle_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);
            Console.WriteLine(result);
        }

        static int hurdleRace(int k, int[] height)
        {
            int max = height.Max();
            int ans = max - k;
            ans = ans < 0 ? 0 : ans;
            return ans;

        }
    }
}
