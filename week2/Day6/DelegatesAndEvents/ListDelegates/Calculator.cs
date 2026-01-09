using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesList
{
    public delegate void delCal(int a, int b);
    public class Calculator
    {
        public void add(int c, int d)
        {
            int result = c + d;
            Console.WriteLine(result);
        }
		public void sub(int c, int d)
		{
			int result = c - d;
			Console.WriteLine(result);
		}
		public void mul(int c, int d)
		{
			int result = c * d;
			Console.WriteLine(result);
		}


	}
}
