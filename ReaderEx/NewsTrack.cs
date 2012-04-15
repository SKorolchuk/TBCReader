using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReaderEx
{
    /// <summary>
    /// Class which encapsulate one RSS feed
    /// </summary>
    public class NewsTrack
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Channel RssChannel { get; set; }

        public NewsTrack(string path)
        {
            Path = path;
            RssChannel = Channel.Deserializate(Path);
        }

        public override string ToString()
        {
            return Name;
        }

        public static IFeed FindObj(string key, List<NewsTrack> news)
        {
            foreach (var i in from o in news select o.RssChannel)
            {
                if (i.Title == key) return i;
                else
                {
                    foreach (var j in from o in i.News select o)
                    {
                        if (j.Title == key) return j;
                    }
                }
            }

            return null;
        }
    }
}
