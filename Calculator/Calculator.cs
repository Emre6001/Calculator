using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static int Add (int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int answer = number1 + number2;
            return answer;
        }

        public static int Substract(int x,int y) 
        {
            int number1 = x;
            int number2 = y;
            int answer = number1 - number2;
            return answer;
        }

        public static int Multiply(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int answer = number1 * number2;
            return answer;
        }

        public static int Division(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int answer = number1/ number2;
            return answer;
        }

        public static int Modulus(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int answer = (number1 % number2);
            return answer;
        }

    }
}
