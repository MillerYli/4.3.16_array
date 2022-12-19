using System;

namespace mynamespase
{
    class program
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int count = 0;
            
            foreach(int i in arr)
            {
                if(i >= 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Кол-вот положительных элеменов: {0}", count);
                
               
               
           
        }
    }
}