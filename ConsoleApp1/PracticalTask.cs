using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PracticalTask : Content
    {
        public string LinkToTask { get; set; }
        public string LinkToSolution { get; set; }

        public PracticalTask(string description, string linkToTask, string linkToSolution) : base(description)
        {
            this.LinkToTask = linkToTask;
            this.LinkToSolution = linkToSolution;
        }

        public PracticalTask()
        {
        }

        public PracticalTask CreateContent(string description = null, string linkToTask = null, string linkToSolution = null)
        {
            PracticalTask practicalTask = new(description, linkToTask, linkToSolution);
            return practicalTask;
        }

        public override bool IsPractical()
        {
            return true;
        }
    }
}
