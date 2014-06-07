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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderChooser = new FolderBrowserDialog();
            if (folderChooser.ShowDialog() == DialogResult.OK)
            {
                String path1 = folderChooser.SelectedPath;
                Console.WriteLine(path1);
                MessageBox.Show("Now add second folder");
                if (folderChooser.ShowDialog() == DialogResult.OK)
                {
                    String path2 = folderChooser.SelectedPath;
                    Console.WriteLine(path2);
                    CheckBox foldPair1 = new CheckBox();
                    foldPair1.Text = path1 + " " + path2;
                }

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
