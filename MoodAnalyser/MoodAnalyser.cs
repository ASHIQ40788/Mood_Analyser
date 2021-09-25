using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser058Batch
{
    /// <summary>
    ///UC-2 Null exception returning happy mood.
    /// </summary>
    public class MoodAnalyser
    {
       //Iam in Happy mood
        public string message;
        public MoodAnalyser(string message)
        {
            
            this.message = message;
        }
        
        //create Analyse method for analyser mood of the user
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                return "happy";
                
            }
        }
    }
}
