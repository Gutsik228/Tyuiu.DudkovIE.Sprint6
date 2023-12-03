using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DudkovIE.Sprint6.Task1.V20.Lib;

namespace Tyuiu.DudkovIE.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void Button_Done_DIE_Click(object sender, EventArgs e)
        {
            try
            {

            
                int startstep = Convert.ToInt32(TextBox_StartStep_DIE.Text);
                int stopstep = Convert.ToInt32(TextBox_EndStep_DIE.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;
                double[] func = new double[len];
                func = ds.GetMassFunction(startstep, stopstep);
                TextBox_Result_DIE.Text = "";
                TextBox_Result_DIE.AppendText("+---------------------------- +" + Environment.NewLine);
                TextBox_Result_DIE.AppendText("|    x     |     f(x)    |" + Environment.NewLine);
                TextBox_Result_DIE.AppendText("+-----------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 8:f2}    |", startstep, func[i]);
                    TextBox_Result_DIE.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                TextBox_Result_DIE.AppendText("+----------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Help_DIE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-23-1 Дудков Игорь Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
