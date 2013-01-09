using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ReaderEx
{
	using System.Xml;

	/// <summary>
    /// Class which encapsulate one News Channel
    /// </summary>
    public class Channel : IFeed
    {
        public List<Item> News { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string PubTime { get; set; }

        public Channel()
        {
            News = new List<Item>();
        }

        public override string ToString()
        {
            return Title;
        }


        /// <summary>
        /// Create new instance of RSS Channel by using Path to file in internet or on local computer
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static Channel Deserializate(string Path)
        {
						XmlTextReader reader = new XmlTextReader(Path);
						XDocument doc = XDocument.Load(reader);
            Channel temp = new Channel();

            var ItemQuery = from i in doc.Descendants("item") select i;
            temp.Description = doc.Element("rss").Element("channel").Element("description").Value;
            temp.Url = doc.Element("rss").Element("channel").Element("link").Value;
            temp.Title = doc.Element("rss").Element("channel").Element("title").Value;
            temp.Language = doc.Element("rss").Element("channel").Element("title").Value;
            temp.PubTime = doc.Element("rss").Element("channel").Element("pubDate").Value;

            foreach (var i in ItemQuery)
            {
                temp.News.Add(
                    new Item(){
                        Title = (i.Element("title") != null ? i.Element("title").Value : ""),
												Url = (i.Element("link") != null ? i.Element("link").Value : ""),
												Category = (i.Element("category") != null ? i.Element("category").Value : ""),
												Description = (i.Element("description") != null ? i.Element("description").Value : ""),
												PubTime = (i.Element("pubDate") != null ? i.Element("pubDate").Value : "")
                    });
            }

            return temp;
        }
    }
}
