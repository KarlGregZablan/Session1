using System; //The using keyword is used for including the namespaces in the program.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.SessionOneNotes // namespace is designed for providing a way to keep one set of names separate from another. 
{
    public class CodeStructure //class keyword is used for declaring a class.
    {
        public void MyMethod() //method
        {
            //comment  //well, a comment

            //Ways to comment:
            //this one
            /* 
               or this one
               if your comment
               is in multiple lines 
            */

            string variables = "value"; //variables

            foreach (var item in variables) //loops
            {
                //code here
            }

            //... and many more as we discuss further
        }
    }
}
