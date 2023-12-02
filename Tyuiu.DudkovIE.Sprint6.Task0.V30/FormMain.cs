using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DudkovIE.Sprint6.Task0.V30.Lib;
namespace Tyuiu.DudkovIE.Sprint6.Task0.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Button_Help_DIE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-23-1 Дудков Игорь Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_Done_DIE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBox_Result_DIE.Text = ds.Calculate(Convert.ToInt32(TextBox_VarX_DIE.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        
    }
}
