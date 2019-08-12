using System;
using System.Collections;
using System.Collections.Generic;

namespace Linq
{
    public class  Params: IEnumerable<int>
    {
        private int a, b, c;

        public Params(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Params(1, 2, 3);
            foreach (var x in p)
            {
                Console.WriteLine(x);
            }
        }
    }
}