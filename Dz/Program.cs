using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Дз 2
            int a = int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            if (a==b){a=0; b=0;}
            else if (a>b){
                b=a; 
                a=b;
            }
            else
            {
                a=b;
                b=a;
               
            }
            Console.WriteLine($"{a} {b}");
           
            
            /*Дз 3
            double operand1 = double.Parse(Console.ReadLine());
            double operand2 = double.Parse(Console.ReadLine());
            string sing = Console.ReadLine();
            switch (sing)
            {
                case "+": Console.WriteLine(operand1 + operand2); break;
                case "-": Console.WriteLine(operand1 - operand2); break;
                case "*": Console.WriteLine(operand1 * operand2); break;
                case "/":
                {
                if (operand2 == 0)
                Console.WriteLine("На ноль делить нельзя");
                else {
                    Console.WriteLine(operand1/operand2);
                }
                } break;  
              */
              /*ДЗ 4
                  double N= double.Parse(Console.ReadLine());
                  if(N>=0 && N<=14) Console.WriteLine("[0-14]");
                  else if(N>=15 && N<=35)Console.WriteLine("[15-30]");
                  else if(N>=36 && N<=50)Console.WriteLine("[36-50]");
                else 
                Console.WriteLine("[50-100]");
            */
            }


        }
    }

