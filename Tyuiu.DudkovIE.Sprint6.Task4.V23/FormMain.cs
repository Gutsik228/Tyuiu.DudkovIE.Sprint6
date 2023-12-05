using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DudkovIE.Sprint6.Task4.V23.Lib;
using System.IO;
namespace Tyuiu.DudkovIE.Sprint6.Task4.V23
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
            int startStep = Convert.ToInt32(TextBox_StartValue_DIE.Text);
            int endStep = Convert.ToInt32(TextBox_EndValue_DIE.Text);

            double[] valueArr = ds.GetMassFunction(startStep, endStep);

            this.Chart_Result_DIE.ChartAreas[0].AxisX.Title = "Ось X";
            this.Chart_Result_DIE.ChartAreas[0].AxisY.Title = "Ось Y";

            TextBox_Result_DIE.Text = "";

            Chart_Result_DIE.Series[0].Points.DataBindY(valueArr); // Обновление графика

            for (int i = 0; i < valueArr.Length; i++)
            {
                TextBox_Result_DIE.AppendText(valueArr[i] + Environment.NewLine);
            }
        }

        private void Button_Help_DIE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб 23-1 Дудков Игорь Евгеньевич");
        }

        private void Button_Save_DIE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, TextBox_Result_DIE.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно ! \n открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
