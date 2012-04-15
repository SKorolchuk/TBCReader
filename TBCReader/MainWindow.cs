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

        private void RemoveChannelBtn_Click(object sender, EventArgs e)
        {

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
                 richTextBox1.Text = selectedItem.Description;
             }
             if (selectedItem is Item)
             { 
                 label4.Visible = true;
                 label4.Text = ((Item)selectedItem).Category;
                 richTextBox1.Text = selectedItem.Description;
             }
        }
    }
}
