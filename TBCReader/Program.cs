using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace TBCReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<string> strings = new List<string>();
						try
						{
							using (StreamReader reader = new StreamReader("config.txt"))
							{
								while (!reader.EndOfStream)
								{
									strings.Add(reader.ReadLine());
								}
							}
						}
						catch (FileNotFoundException e)
						{
							MessageBox.Show("Config file not found. It will be created now...");
							using (StreamWriter writer = new StreamWriter("config.txt", false))
							{
							}
						}
            
            MainWindow mfw = new MainWindow(strings);
            Application.Run(mfw);
            using (StreamWriter writer = new StreamWriter("config.txt", false))
            {
                foreach (string s in mfw.SavedLinks)
                {
                    writer.WriteLine(s);
                }
            }
        }
    }
}
