using System;

namespace ProjectDi
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // input string as int and switch case it
            Console.WriteLine("Enter a number between 1 and 5");
            var input = Console.ReadLine();
            var number = int.Parse(input);
            switch (number)
            {
                case 1:
                    // input 2 number and sum pow 3
                    Console.WriteLine("Enter a number");
                    var input1 = Console.ReadLine();
                    var number1 = int.Parse(input1);
                    Console.WriteLine("Enter a number");
                    var input2 = Console.ReadLine();
                    var number2 = int.Parse(input2);
                    var result = Math.Pow(number1 + number2, 3);
                    Console.WriteLine(result);
                    break;
                case 2:
                    // input 3 numbers and print sum
                    Console.WriteLine("Enter a number");
                    var input3 = Console.ReadLine();
                    var number3 = int.Parse(input3);
                    Console.WriteLine("Enter a number");
                    var input4 = Console.ReadLine();
                    var number4 = int.Parse(input4);
                    Console.WriteLine("Enter a number");
                    var input5 = Console.ReadLine();
                    var number5 = int.Parse(input5);
                    var result2 = number3 + number4 + number5;
                    Console.WriteLine(result2);
                    break;
                case 3:
                    // init a b c d as static int. input x as int calc a*x*x-b*x+c+d
                    Console.WriteLine("Enter a number");
                    var input6 = Console.ReadLine();
                    var number6 = int.Parse(input6);
                    var a = 1;
                    var b = 2;
                    var c = 3;
                    var d = 4;
                    var result3 = a * number6 * number6 - b * number6 + c + d;
                    Console.WriteLine(result3);
                    break;
                case 4:
                    // input r and l as double. calc=pi*r*l
                    Console.WriteLine("Enter a Radius");
                    var input7 = Console.ReadLine();
                    var number7 = double.Parse(input7);
                    Console.WriteLine("Enter a Length");
                    var input8 = Console.ReadLine();
                    var number8 = double.Parse(input8);
                    var result4 = Math.PI * number7 * number8;
                    Console.WriteLine(result4);
                    break;
                case 5:
                    // S=a*h/2 calc S input a and h
                    Console.WriteLine("Enter A");
                    var input9 = Console.ReadLine();
                    var number9 = double.Parse(input9);
                    Console.WriteLine("Enter a high");
                    var input10 = Console.ReadLine();
                    var number10 = double.Parse(input10);
                    var result5 = number9 * number10 / 2;
                    Console.WriteLine(result5);
                    break;
                default:
                    Console.WriteLine("You entered a number outside the range of 1 to 5");
                    break;
            }
        }
    }
}