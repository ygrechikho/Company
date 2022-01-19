using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lection : Content
    {
        public string Topic { get; set; }

        public Lection(string description, string topic) : base(description)
        {
            this.Topic = topic;
        }

        public Lection()
        {
        }

        public Lection CreateContent(string description = null, string topic = null)
        {
            Lection lection = new(description, topic);
            return lection;
        }

        public override bool IsPractical()
        {
            return false;
        }
    }
}
