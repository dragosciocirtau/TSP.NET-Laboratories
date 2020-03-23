using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Laborator1
{
    class Program
    {
        static int n;
        
        static public bool is_prim(int arg)
        {
            if (arg <= 2 && arg > 0)
                return true;
            else
            {
                for (int i = 2; i < arg / 2; i++)
                {
                    if (arg % i == 0) return false;
                }
            }
            return true;
        }

        static async Task<int> max_prim1()
        {
            int maxim = -1;
            Console.WriteLine("Start fir: " + " 1 " + " Numar natural dat: " + n + " Timestamp: " + DateTime.Now + "\n");

            for (int i = n - 1; i > 0; i--)
            {
                if (is_prim(i))
                {
                    maxim = i;
                    break;
                }
            }
            Console.WriteLine("End fir: " + " 1 " + " Timestamp: " + DateTime.Now + " Numar prim = " + maxim + "\n");
            return maxim;
        }
        
        static async Task<int> max_prim2()
        {
            Console.WriteLine("Start fir: " + " 2 " + " Numar natural dat: " + n + " Timestamp: " + DateTime.Now + "\n");
            int max = 0;
            for (int i = 1; i < n; i++)
            {
                if (is_prim(i)) max = i;
            }

            Console.WriteLine("End fir: " + " 2 " + " Timestamp: " + DateTime.Now + " Numar prim = " + max + "\n");
            return max;
        }

        static async Task Main(string[] args)
        {
            Console.Write("Enter number: ");
            n = int.Parse(Console.ReadLine());

            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() => { max_prim1(); }));
            tasks.Add(Task.Run(() => { max_prim2(); }));
            Task.WaitAll(tasks.ToArray());
        }
    }
}
