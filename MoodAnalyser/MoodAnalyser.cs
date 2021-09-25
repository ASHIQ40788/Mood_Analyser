using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser058Batch
{
    /// <summary>
    ///UC-1 Analzing user mood based on happy or sad word.
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
