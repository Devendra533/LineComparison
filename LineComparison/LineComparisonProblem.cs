using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineComparisonProblem
    {
        public void FindLength()
        {
            int x1;
            int x2;
            int y1;
            int y2;
            int length;

            Console.WriteLine("Enter the coordinates for line number 1");
            Console.WriteLine();

            Console.WriteLine("Enter Value of x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value of y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value of x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value of y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            length =(int) Math.Sqrt(Math.Pow((x2 - x1), 2) * (int)Math.Pow((y2 - y1), 2)); 
            Console.WriteLine("Length of line is:: " + length);

        }
    }

}