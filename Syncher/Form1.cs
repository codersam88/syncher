using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string fName,desFName;
        bool dirExists = false;
        public Form1()
        {
            InitializeComponent();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            String appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            System.IO.DirectoryInfo apD = new System.IO.DirectoryInfo("@" + "\"" + appDirectory + "\"");
            System.IO.DirectoryInfo[] subDirs = apD.GetDirectories();
            foreach (System.IO.DirectoryInfo dI in subDirs)
            {
                if (dI.Name.Equals("dataFiles"))
                {
                    dirExists = true;
                }
            }
            String dataDir = "@" + "\"" + appDirectory + "\\dataFiles" + "\"";
            if (dirExists == false)
            {
                System.IO.Directory.CreateDirectory(dataDir);
            }
            
            Console.WriteLine("app directory "+"@"+"\""+appDirectory+"\"");
            //System.IO.DirectoryInfo[] subDir = appDirectory.
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderChooser = new FolderBrowserDialog();
            if (folderChooser.ShowDialog() == DialogResult.OK)
            {
                String frmpath1 = makePath(folderChooser.SelectedPath);
                Console.WriteLine(frmpath1);
                MessageBox.Show("Now add second folder");
                if (folderChooser.ShowDialog() == DialogResult.OK)
                {
                    String topath2 = makePath(folderChooser.SelectedPath);
                    addFolderPair(frmpath1,topath2);
                    sync(frmpath1, topath2);
                    
                }

            }
        }

        void sync(String frm, String to)
        {
            string[] files = System.IO.Directory.GetFiles(frm);
            System.IO.DirectoryInfo toDir = new System.IO.DirectoryInfo(to);
            System.IO.DirectoryInfo frmDir = new System.IO.DirectoryInfo(frm);
            System.IO.DirectoryInfo[] subDirs = frmDir.GetDirectories();

            foreach (string fil in files)
            {
                fName = System.IO.Path.GetFileName(fil);
                desFName = System.IO.Path.Combine(to, fName);
                System.IO.File.Copy(fil, desFName, true);
            }

        }
        String makePath(String pth)
        {
            //return pth = "@" + "\"" + pth + "\"";
            return pth;
        }

        private void addFolderPair(String f1, String f2)
        {
            CheckBox foldPair1 = new CheckBox();
            foldPair1.AutoSize = true;
            foldPair1.Text = f1 + " " + f2;
            foldPair1.Location = new System.Drawing.Point(16, 75);
            this.Controls.Add(foldPair1);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
