using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismaa
{
    public class math
    {

        public void DoOperation()
        {
            Console.WriteLine("Please select the action you want to take");
            Console.WriteLine("Press 1 for addition(+) operations");
            Console.WriteLine("Read 2 for subtract(-) processors");
            Console.WriteLine("Press the 3 key for multiplication(*) operations");
            Console.WriteLine("Press 4 for division(/) operations");
            Console.WriteLine("Press q to exit");
            
        }
        
        
        public int MultipOp(int num1, int num2)
        {
            return num1 * num2;
        }
        public double DivisionOp(double num1, double num2)
        {
            return num1 / num2;
        }
        public int ExtractOp(int num1, int num2) 
        {
            return num1 - num2;
        }

        public int CollecOp(int num1,int num2)
        {
            return num1 + num2;
        }


    }
}
