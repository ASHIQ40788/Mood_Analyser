using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace MoodAnalyser058Batch
{
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

        /// <summary>
        /// UC5- Creating parameterised constructor.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructor"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public object CreateMoodAnalyserParameterisedObject(string className, string constructor, string message)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                if (type.Name.Equals(className) || type.FullName.Equals(className))
                {
                    if (type.Name.Equals(constructor))
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                        var obj = constructorInfo.Invoke(new object[] { message });
                        return obj;
                    }
                    else
                        throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor is not found");
                }
                else
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CLASS_NOT_FOUND, "className is not found");

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// UC6-Reflection to invoke Method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public string InvokeAnalyserMethod(string message, string methodName)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                MethodInfo methodInfo = type.GetMethod(methodName);
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                object moodAnalyserObject = factory.CreateMoodAnalyserParameterisedObject("MoodAnalyserFor058Batch.MoodAnalyser", "MoodAnalyser", message);
                object info = methodInfo.Invoke(moodAnalyserObject, null);
                return info.ToString();

            }
            catch (NullReferenceException)
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "method not found");
            }
        }

    }
}



                
