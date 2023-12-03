using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint6.Task2.V1.Lib;
using System.Windows.Forms;

namespace Tyuiu.DudkovIE.Sprint6.Task2.V1
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
                int startStep = Convert.ToInt32(TextBox_StartStep_DIE.Text);
                int stopStep = Convert.ToInt32(TextBox_EndStep_DIE.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.Chart_Result_DIE.Titles.Add("График функции");
                this.Chart_Result_DIE.ChartAreas[0].AxisX.Title = "Ось X";
                this.Chart_Result_DIE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.DataGridView_DIE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.Chart_Result_DIE.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Halp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task2 выполнил студент группы СМАРТб,-23-1 Дудков Игорь Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
