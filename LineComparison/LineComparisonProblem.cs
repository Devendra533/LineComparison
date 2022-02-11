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
            int x3;
            int y3;
            int x4;
            int y4;
            int length1;
            int length2;

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

            Console.WriteLine("Enter the coordinates for line number 2");
            Console.WriteLine();

            Console.WriteLine("Enter Value of x3");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value of y3");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value of x4");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value of y4");
            y4 = Convert.ToInt32(Console.ReadLine());

            length1 =(int) Math.Sqrt(Math.Pow((x2 - x1), 2) * (int)Math.Pow((y2 - y1), 2)); 
            Console.WriteLine("Length of line is:: " + length1);

            length2 = (int)Math.Sqrt(Math.Pow((x4 - x3), 2) * (int)Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of line is:: " + length2);


            if (length1 == length2)
                Console.WriteLine(" lines are of equal");
            else if (length1 > length2)
                Console.WriteLine(" line1 is greater than line2");
            else
                Console.WriteLine("line 1 is less than line 2");
      

        }
    }

}