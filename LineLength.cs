using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparsionProblem
{
    public class LineLength
    {
        public static void cal_len()
        {
            double Len = 0.0;
            System.Console.WriteLine("Calculating length of two points of x,y Co-ordinates : \n");
            System.Console.WriteLine("Enter x1 y1 x2 y2 value of first point : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Len = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            System.Console.WriteLine(" The length of two points is : " + Len);
        }
    }
}
