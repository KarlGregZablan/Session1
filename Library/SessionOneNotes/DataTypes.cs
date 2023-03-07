using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.SessionOneNotes
{
    internal class DataTypes
    {
        public void Discussion()
        {
            int integer = 0; //used for whole signed numbers
            integer = 1;
            //example
            int positive = 1;
            int negative = -1;
            int iCantStoreDecimals = 1.1; //see the squiggly red line under the value, that means that you cannot set that value on your variable. Learn to read the error.
                                          //We'll discuss this more later.

            //If you want something that can store decimals, you can use:
            double canStoreDecimals = 3.14;
            decimal canAlsoStoreDecimals = 1.23M; //add M as suffix for your value to set it as decimal
            float canAlsoStoreDecimalsAsWell = 4.52F; //add F for float

            //use bool for boolean types
            //boolean? If you as google, its a result that can only have one of two possible values: true or false.
            bool isTrue = true;

            //if you want to store a specific character, you can use.
            char character = 'a'; //use single quotes for character.

            //but if you want to store texts, you can use:
            string iCanStoreTexts = "See I can do it. lol";

            //note that a string is a collection of characters. So you can get a specific character from a string.
            string test = "Can you get letter A?";
            char target = test[19]; //this should return 'A'. Try checking using console.log.

            //how about dates?
            DateTime useMe = new DateTime(2013, 1, 1);
        }
    }

    internal class Variables
    {
        public void OnVariables()
        {
            //CREATING VARIABLES
            string thisIsAVariable = "this is the value";
            //basically consists of the type followed by the variable name, then = sign, then lastly the value.
        }

        //Please learn to name variable. Great developers take time to name their variables correctly. It is important so that the reader can easily understand it.
        //To Demonstrate:

        //method 1
        static string w(string x, string yy)
        {
            string z = x + " " + yy;
            return z;
        }

        //method 2
        static string GetFullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        //which one do you understand better?

        //Also Character casing is important so that the reader can classify if the name is a variable or a class or a function.
        //We will use two character casing rules for our course:
        //1. PascalCase (the first letter of every word is in upper case.
        //2. camelCase (the first letter of every word is in upper case, EXCEPT the first word)
    }

    internal class VariableNaming //PascalCase for class name
    {
        private string _field; // underscore followed by camel case for private fields. (fields & variables are the same. We call them different due to their scope)
        //well, fields are variables created within the class. meaning the methods inside the class can use this.
        public int Field { get; set; } //PascalCase for properties
        //1000 lines of code here
        public string MyMethod(string parameter, int anotherParameter) //PascalCase for the method name, camel case for the parameters
        {
            string theValue = "value"; //pascalCase for local variables (variables created inside a method). other methods cannot use this.
            //100 lines of code here
            _field = "value";
            return theValue;
        }
    }

    //Activity One
}
