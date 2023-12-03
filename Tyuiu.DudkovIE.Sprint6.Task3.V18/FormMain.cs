using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DudkovIE.Sprint6.Task3.V18.Lib;

namespace Tyuiu.DudkovIE.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -19,-19, 1, 18, 7},
                                         { 5, -3, -4, -6, -12},
                                         { -15, 6,2, 2, -14},
                                         { -9, -10, 15,-5,-6 },
                                         { -13,-15, -9, 7, 1} };
        private void Button_Done_DIE_Click(object sender, EventArgs e)
        {
            int[,] matr = ds.Calculate(matrix);
            int rows = matr.GetUpperBound(0) + 1;
            int columns = matr.Length / rows;

            DataGridView_Matrix_DIE.ColumnCount = columns;
            DataGridView_Matrix_DIE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                DataGridView_Matrix_DIE.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DataGridView_Matrix_DIE.Rows[i].Cells[j].Value = Convert.ToString(matr[i, j]);
                }
            }
        }

        private void Button_Help_DIE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Дудков Игорь Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            DataGridView_Matrix_DIE.ColumnCount = columns;
            DataGridView_Matrix_DIE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                DataGridView_Matrix_DIE.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DataGridView_Matrix_DIE.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
