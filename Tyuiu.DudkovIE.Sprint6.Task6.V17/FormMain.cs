using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DudkovIE.Sprint6.Task6.V17.Lib;
using System.IO;
namespace Tyuiu.DudkovIE.Sprint6.Task6.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string OpenFilePath;
        DataService ds = new DataService();

        private void Button_Done_DIE_Click(object sender, EventArgs e)
        {
            TextBox_Output_DIE.Text = ds.CollectTextFromFile(OpenFilePath);
        }

        private void Button_Help_DIE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void Button_SearchFiles_DIE_Click(object sender, EventArgs e)
        {
            OpenFileDialog_DIE.ShowDialog();
            OpenFilePath = OpenFileDialog_DIE.FileName;
            TextBox_Input_DIE.Text = File.ReadAllText(OpenFilePath);
            GroupBox_Output_DIE.Text = GroupBox_Output_DIE.Text + " " + OpenFileDialog_DIE.FileName;
            Button_Done_DIE.Enabled = true;
        }
    }
}
