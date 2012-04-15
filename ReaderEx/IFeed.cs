using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReaderEx
{
    public interface IFeed
    {
        string Title { get; set; }
        string Url { get; set; }
        string Description { get; set; }
        string PubTime { get; set; }
    }
}
