using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> boxing = new List<object>();
            boxing.Add(7);
            boxing.Add(28);
            boxing.Add(-1);
            boxing.Add(true);
            boxing.Add("chair");
            int sum = 0;
            foreach(var item in boxing){
                
                Console.WriteLine(item);
                if(item is int){
                    sum += (int)item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
