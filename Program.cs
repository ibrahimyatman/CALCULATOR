using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entNum1 = 0;
            int entNum2 = 0;
            int result = 0;
            bool endApp = true;    
            math math = new math();
            Console.WriteLine("Welcome to the c# calculator app");
            while (endApp)
            {
                math.DoOperation();
                string op =Console.ReadLine();
                switch (op)
                {
                    case "1":
                        {
                            Console.WriteLine("Type a number, and then press Enter:");
                            entNum1 =Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Type another number, and then press Enter: ");
                            entNum2 =Convert.ToInt32(Console.ReadLine());
                           result= math.CollecOp(entNum1,entNum2);
                            Console.WriteLine("subtraction result =" + ""+ result);
                            break;
                            

                        }
                        case "2":

                        {
                            Console.WriteLine("Type a number, and then press Enter:");
                            entNum1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Type another number, and then press Enter: ");
                            entNum2 = Convert.ToInt32(Console.ReadLine());
                            result=math.ExtractOp(entNum1,entNum2);
                            Console.WriteLine("result of multiplication =" + "" + result);
                            break;


                        }
                        case"3":
                        {
                            Console.WriteLine("Type a number, and then press Enter:");
                            entNum1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Type another number, and then press Enter: ");
                            entNum2 = Convert.ToInt32(Console.ReadLine());
                           result=math.MultipOp(entNum1,entNum2);
                            Console.WriteLine("sum of entered numbers =" + "" + result);
                            break;


                        }
                        case"4":
                        {

                            Console.WriteLine("Type a number, and then press Enter:");
                            entNum1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Type another number, and then press Enter: ");
                            entNum2 = Convert.ToInt32(Console.ReadLine());
                           double result1 = math.DivisionOp(entNum1, entNum2);
                            Console.WriteLine("result of division =" + "" + result1);
                            break;
                        }
                        case"q":
                        {
                            Console.WriteLine("Good day");
                            endApp = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid character");
                            break;
                        }


                }
                Console.WriteLine("************************************");
            }
            

        }
    }
}
