using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyser058Batch;

namespace MoodAnalyser05Batch
{

    //Class Employer
    public class Employee
    {
        //Fields of Employer
          int id;
          string name;

         //Constructor
         public Employee(int i, string n)
         {
              id = id;
              name = n;
         }

        //Applying the custom attribute
        //NewAttribute to the getId method
        [CustomAttribute("ID", "returns Employer Id")]
          public int getId()
          {
            return id;
          }

        //Applying  the custom attribute
        //NewAttribute to the getName method
        [Custom("Name", "returns Employer Name")]
        public string getName()
        {
            return name;
        }

        public string Test()
        {
            return name;

        }
    }
}
