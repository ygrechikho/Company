using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICloneable
    {
        object Clone();
    }
    public class Training : Content, ICloneable 
    {
        public List<Content> Contents { get; set; }

        public Training()
        {
            this.Contents = new List<Content>();
        }
        public void AddContent(Content content)
        {
            Contents.Add(content);
        }
        public override bool IsPractical()
        {
            foreach (Content c in Contents)
            {
                if (c.IsPractical())
                {
                    return true;
                }
            }
            return false;
        }

        public object Clone()
        {
            return new Training
            {
                Contents = this.Contents
            };
        }
    }
}
