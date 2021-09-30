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
        /// Creates the mood analyser object.
        /// </summary>
        /// <param name="className">Name of the class</param>
        /// <param name="constructor">The constructor.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyser058Batch.CustomMoodAnalyserException ">
        /// class not found
        /// constructor not found
        /// </exception>
        public Object CreateMoodAnalyserObject(string className, string constructor)
        {
            //MoodAnalyserBatch058Batch.MoodAnalyse
            string pattern = "." + constructor + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
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



                
