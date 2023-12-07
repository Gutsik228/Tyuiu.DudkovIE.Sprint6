using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.DudkovIE.Sprint6.Task6.V17
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void Button_Ok_DIE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
