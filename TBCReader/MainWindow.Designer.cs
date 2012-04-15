namespace TBCReader
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChannelView = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.AddChannelBtn = new System.Windows.Forms.Button();
            this.RemoveChannelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadRSSChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PubDate = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TBCReader.Properties.Resources.rss_no_drop;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(547, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRSSChannelToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ChannelView
            // 
            this.ChannelView.Location = new System.Drawing.Point(12, 46);
            this.ChannelView.Name = "ChannelView";
            this.ChannelView.Size = new System.Drawing.Size(198, 294);
            this.ChannelView.TabIndex = 3;
            this.ChannelView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ChannelView_AfterSelect);
            
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Go to Full News";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddChannelBtn
            // 
            this.AddChannelBtn.Location = new System.Drawing.Point(25, 346);
            this.AddChannelBtn.Name = "AddChannelBtn";
            this.AddChannelBtn.Size = new System.Drawing.Size(75, 23);
            this.AddChannelBtn.TabIndex = 7;
            this.AddChannelBtn.Text = "Add";
            this.AddChannelBtn.UseVisualStyleBackColor = true;
            this.AddChannelBtn.Click += new System.EventHandler(this.AddChannelBtn_Click);
            // 
            // RemoveChannelBtn
            // 
            this.RemoveChannelBtn.Location = new System.Drawing.Point(106, 346);
            this.RemoveChannelBtn.Name = "RemoveChannelBtn";
            this.RemoveChannelBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveChannelBtn.TabIndex = 8;
            this.RemoveChannelBtn.Text = "Remove";
            this.RemoveChannelBtn.UseVisualStyleBackColor = true;
            this.RemoveChannelBtn.Click += new System.EventHandler(this.RemoveChannelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Channels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(236, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(481, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // loadRSSChannelToolStripMenuItem
            // 
            this.loadRSSChannelToolStripMenuItem.Name = "loadRSSChannelToolStripMenuItem";
            this.loadRSSChannelToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.loadRSSChannelToolStripMenuItem.Text = "Load RSS Channels";
            this.loadRSSChannelToolStripMenuItem.Click += new System.EventHandler(this.loadRSSChannelToolStripMenuItem_Click);
            // 
            // PubDate
            // 
            this.PubDate.AutoSize = true;
            this.PubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PubDate.Location = new System.Drawing.Point(234, 66);
            this.PubDate.Name = "PubDate";
            this.PubDate.Size = new System.Drawing.Size(61, 16);
            this.PubDate.TabIndex = 13;
            this.PubDate.Text = "PubDate";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(234, 46);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(34, 16);
            this.Title.TabIndex = 12;
            this.Title.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(403, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Category";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(237, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(540, 167);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 377);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PubDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveChannelBtn);
            this.Controls.Add(this.AddChannelBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ChannelView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "To Be Clever Reader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView ChannelView;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddChannelBtn;
        private System.Windows.Forms.Button RemoveChannelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem loadRSSChannelToolStripMenuItem;
        private System.Windows.Forms.Label PubDate;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

