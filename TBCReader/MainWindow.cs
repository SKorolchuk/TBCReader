using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReaderEx;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TBCReader
{
	public partial class MainWindow : Form
    {

        public List<string> SavedLinks;
        public List<NewsTrack> Trackers;

        public MainWindow(List<string> links)
        {
          InitializeComponent();
          SavedLinks = links;
          Trackers = new List<NewsTrack>();
					loadRSSChannelToolStripMenuItem_Click(null,null);
	        this.Closed += this.UpdatePaths;
	        UpdatePaths(null, null);
        }
				
				public void UpdatePaths(object sender, EventArgs e)
				{
					int pathIndex = 0;
					foreach (string path in from track in Trackers select track.Path)
					{
						if (path != SavedLinks[pathIndex]) SavedLinks[pathIndex] = path;
						pathIndex++;
					}
				}

        private void LoadChannel(string Path)
        {
            NewsTrack tracker = new NewsTrack(Path);
            Trackers.Add(tracker);
            tracker.Name = tracker.RssChannel.Title;
            List<TreeNode> tempMas = new List<TreeNode>();
            foreach (string i in from s in tracker.RssChannel.News select s.Title)
                tempMas.Add(new TreeNode(i));
            TreeNode Theme = new TreeNode(tracker.Name, tempMas.ToArray());
            this.ChannelView.Nodes.Add(Theme);
        }

        private void loadRSSChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChannelView.Nodes.Clear();
            Trackers.Clear();
            foreach (string s in SavedLinks)                
                   LoadChannel(s);
        }

        private void AddChannelBtn_Click(object sender, EventArgs e)
        {
            AddLinkForm dial = new AddLinkForm();
            if (dial.ShowDialog() == DialogResult.OK) SavedLinks.Add(dial.Link);
				}

        private void ChannelView_AfterSelect(object sender, TreeViewEventArgs e)
        {
             Title.Text = ChannelView.SelectedNode.Text;
             IFeed selectedItem = NewsTrack.FindObj(ChannelView.SelectedNode.Text, Trackers);
             PubDate.Text = selectedItem.PubTime;
             label2.Text = selectedItem.Url;             
             if (selectedItem is Channel)
             {
                 label4.Visible = false;
                 FeedContent.DocumentText = selectedItem.Description;
             }
             if (selectedItem is Item)
             { 
                 label4.Visible = true;
                 label4.Text = ((Item)selectedItem).Category;
                 FeedContent.DocumentText = selectedItem.Description;
             }
        }

				private void RemoveChannel(object sender, EventArgs e)
				{
					IFeed selectedItem = NewsTrack.FindObj(ChannelView.SelectedNode.Text, Trackers);
					if (selectedItem is Channel)
					{
						NewsTrack selectedTrack = this.Trackers.FirstOrDefault(x => x.Name == ((Channel)selectedItem).Title);
						SavedLinks.Remove(selectedTrack.Path);
					}
					else
					{
						return;
					}
					loadRSSChannelToolStripMenuItem_Click(sender, e);
				}

				private void GoToNewsBtn_Click(object sender, EventArgs e)
				{
					Process firefox = new Process();
					firefox.StartInfo.FileName = "firefox.exe";
					firefox.StartInfo.Arguments = label2.Text;
					firefox.Start();
				}

				private void closeToolStripMenuItem_Click(object sender, EventArgs e)
				{
					this.Close();
				}
    }
}
