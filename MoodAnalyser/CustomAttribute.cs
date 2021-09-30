using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser058Batch
{
    public class CustomAttribute : Attribute

    {
        //Private fields
        private string title;
        private string description;

        //Parameterised Constructor
        public CustomAttribute(string t, string d)
        {
            title = t;
            description = d;
        }
        
        //Method to shiw the Fields
        //of the NewAttribure
        //using reflection
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Method of class {0}, classType.Name");

            //Array to store all method of a class
            //to which the attribute may be applied

            MethodInfo[] methods = classType.GetMethods();

            //for loop to read through all methods

            for (int i = 0; i < methods.GetLength(0); i++)
            {
                //Creating object array to receive
                //method attribute returned
                //by the GetCustomAttributed method

                object[] attributesArray = methods[i].GetCustomAttributes(true);

                //foreach loop to read through
                // all attributes of the method
                foreach (Attribute item in attributesArray)
                {
                    if (item is CustomAttribute)
                    {
                        //Display the field of the CustomAttribute
                        CustomAttribute attributeObject = (CustomAttribute)item;
                        Console.WriteLine("{0} - {1}, {2}", methods[i].Name,
                         attributeObject.title, attributeObject.description);
                    }
                }
            }
        }
    }
}
