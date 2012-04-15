using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReaderEx
{
    /// <summary>
    /// Class which encapsulate one Feed from News Channel
    /// </summary>
    public class Item : IFeed
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string PubTime { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
