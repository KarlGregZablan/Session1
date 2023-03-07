using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.SessionOneNotes
{
    internal class BasicOperations
    {
        public void Discussion() 
        {
            //Operators
            //you can do several operations depending on the types. Lets discuss the common operations you can do:

            //For numeric types(int, double, decimal, etc.) you can do the arithmetic operations.
            //example:
            decimal result = 1 * 2 - 3 / 4;
            //add +
            //subtract -
            //multiply *;
            //divide /
            //there are also other operators you can use. feel free to google.
            // you can also increment numeric types by using +=

            int value = 0;
            
            value += 1;
            //value this time is equal to 1;
            // you can also decrement using +=
            value -= 1;
            //value this time is equal to O;

            //strings also have an operator. you can combine strings. example:
            string a = "Omega";
            string b = "lul";
            string c = a + b; //thats right, c = "Omegalul";

            //there are also specific operators used for boolean;
            //comparing values will return a boolean result. we call these as boolean expressions
            //example
            bool basicComparison = 1 == 1; //true
            basicComparison = 1 == 0; //false

            /*
             the syntax is:
                value1 operator value2
                v1 == v2

            here are some operators that you can use. We call them relational operators btw,
             */
            int valueA = 0;
            int valueB = 0;

            bool isEqual = valueA == valueB;
            bool isNotEqual = valueA != valueB;
            bool isGreaterThan = valueA > valueB;
            bool isGreaterThanOrEqual = valueA >= valueB;
            bool isLessThan = valueA < valueB;
            bool isLessThanOrEqual = valueA <= valueB;

            //you can also combine several boolean expressions to make a more complex boolean expression. we call these Logical operators.
            //example
            string x = "";
            string y = "A";
            string z = "B";
            bool w = false;

            bool aComplexExpression = x == y && y == z;
            bool ex1 = false;
            bool ex2 = true;

            //or you can inverse a boolean value;
            bool inverse = !w; //true

            //here are some logical operators you can use;
            bool and = ex1 && ex2;
            bool or = ex1 || ex2;
            bool not = !ex1;

            //TIP:
            /*
             * In naming boolean variable, make sure that it sounds like it is a question. Quick hack is to add 'is' before the variableName
             * example:
             *  isFinished
             *  isAvailable
             *  isCorrect
             *  isInvalid
             */
        }
    }
}