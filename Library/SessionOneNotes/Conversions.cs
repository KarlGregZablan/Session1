using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.SessionOneNotes
{
    internal class Conversions
    {
        public void Discussion()
        {
            //suppose you have these:
            int valueA = 123;
            string valueB = "123";


            //if we want to add the two values, can we do it? lets try.
            int valueC = valueA + valueB; //yikes, squiggly line.
            //this is expected since valueA is type int, and valueB is type string.
            //however this is not the end of the world lol. you can convert valueB to int.
            // you can do it in different ways;

            int option1 = int.Parse(valueB); 
  
            //option1 and option1 are quite troublesome if the value you are converting is not numeric.
            //int.TryParse however returns a value if you can convert the given input. you can get the result by placing an empty variable on its second parameter.

            //quick method syntax lecture:
            //void MyMethod(string parameter1, string parameter2) 
            //{ 
            //}

            //MyMethod is the method name,
            //(string parameter1, string parameter2) are the parameters requried by the method

            //you can also convert everything to string.
            //example;
            int integerValue = 0;
            string value = integerValue.ToString(); //"O";
        }
    }
}

//Write a program that gets two numbers then display true if the first number is greater than the second number or false if the first number is lesser than the second number

