using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace SVNChangeCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CopyPath();
        }
        private void CopyPath(string selectedFile)
        {
            string _path = selectedFile;//"D:/Users/ronaik/Desktop/paths.txt";
            string[] filePaths=File.ReadAllLines(_path);
            string newPathRoot = textBox1.Text;
            string oldPathRoot = textBox2.Text;
            foreach(string filepath in filePaths)
            {
                string newfullfilepath=oldPathRoot+"//"+filepath;
                
                if (File.Exists(newfullfilepath))
                {
                    if (filepath.Contains('/'))
                    {
                        Directory.CreateDirectory(newPathRoot + "//" + filepath.Substring(0, filepath.LastIndexOf('/')));
                    }
                    File.Copy(newfullfilepath, newPathRoot + "//" + filepath,true);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void File_Selected(object sender, CancelEventArgs e)
        {
            //CopyPath(openFileDialog1.FileName);
            label3.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CopyPath(label3.Text);
            label4.Text = "File has been copied";
        }
    }
}
