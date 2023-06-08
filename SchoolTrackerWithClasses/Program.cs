using System;
using System.Collections.Generic;

namespace SchoolTrackerWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Survey> survey = new List<Survey>();

            do
            {
                survey.Add(Survey.AskStudentDetails());
            } while (Survey.NewStudent());


            foreach( Survey student in survey)
            {
                Survey.Display(student);
            }
        }
    }
}