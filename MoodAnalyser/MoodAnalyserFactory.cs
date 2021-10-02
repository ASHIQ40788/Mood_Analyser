using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace MoodAnalyser058Batch
{

    /// UC4-is to create object by using reflector and use default constructor
    /// <summary>
    /// Creating MoodAnalyserFactory class
    /// </summary>
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// UC4-is to create object by using reflector and use default constructor
        /// </summary>
        /// <param name="className">Name of the class</param>
        /// <param name="constructor">The constructor.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyser058Batch.CustomMoodAnalyserException ">
        /// class not found
        /// constructor not found
        /// </exception>
        
        //Created an method which is written in object.
        //My object is to create an object of mood analyser class with he help of reflection.
        public Object CreateMoodAnalyserObject(string className, string constructor)
        {
                //MoodAnalyserBatch058Batch.MoodAnalyser.
                string pattern = "." + constructor + "$";
               //if it matches the  we have to extract information from assembly.
                Match result = Regex.Match(className, pattern);

                if (result.Success)
                {
                    try
                    {
                    //extract from here if it matches.
                        Assembly assembly = Assembly.GetExecutingAssembly();
                    //checking what type of class is there.
                        Type moodAnalyserType = assembly.GetType(className);
                    // Activator. CreateInstance method creates an instance of a specified type using the constructor.
                    var res = Activator.CreateInstance(moodAnalyserType);
                        return res;
                    }

                    catch (Exception ex)
                    {
                        throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CLASS_NOT_FOUND, "class not found");
                    }
                }
                else
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");
                }
         }
    }
}



                
