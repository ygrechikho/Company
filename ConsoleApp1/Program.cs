using System;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            const string lectionDescription = "Generic description for My Lection";
            const string practicalTaskDescription = "Generic description for My Practical Task";
            const string topic = "More QA";
            const string linkToTask = "https://task1.com";
            const string linkToSolution = "https://solution1.com";

            Training training = new Training();
            Lection lection = new();
            var lectionContent = lection.CreateContent(lectionDescription, topic);
            PracticalTask practicalTask = new();
            var practicalTaskContent = practicalTask.CreateContent(practicalTaskDescription, linkToTask, linkToSolution);
           
            training.AddContent(lectionContent);
            training.AddContent(practicalTaskContent);

            Training training2 = new();
            PracticalTask practicalTask2 = new();
            var practicalTaskContent2 = practicalTask.CreateContent(practicalTaskDescription, linkToTask, linkToSolution);
            training2.AddContent(practicalTask2);
            
            Training training3 = new();
            training3.AddContent(training2);
            training2.IsPractical();
            training.IsPractical();
            Training clonedTraining = (Training)training.Clone();
        }
    }
}
