using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DudkovIE.Sprint6.Task7.V12.Lib;
using System.IO;

namespace Tyuiu.DudkovIE.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_DIE.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
            saveFileDialogMatrix_DIE.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
        }

        static string OpenFilePath;
        DataService ds = new DataService();

        private void Button_SaveFile_DIE_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_DIE.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_DIE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_DIE.ShowDialog();

            string path = saveFileDialogMatrix_DIE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = DataGridView_Ouput_DIE.RowCount;
            int columns = DataGridView_Ouput_DIE.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + DataGridView_Ouput_DIE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + DataGridView_Ouput_DIE.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void Button_Done_DIE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(OpenFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DataGridView_Ouput_DIE.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            Button_SaveFile_DIE.Enabled = true;
        }

        static int rows;
        static int columns;

        public static int[,] LoadFromFileDta(string FilePath)
        {
            string fileDta = File.ReadAllText(FilePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void Button_SearchFiles_DIE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DIE.ShowDialog();
            OpenFilePath = openFileDialogTask_DIE.FileName;

            int[,] arrayValues = LoadFromFileDta(OpenFilePath);
            DataGridView_Input_DIE.ColumnCount = columns;
            DataGridView_Input_DIE.RowCount = rows;
            DataGridView_Ouput_DIE.ColumnCount = columns;
            DataGridView_Ouput_DIE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                DataGridView_Input_DIE.Columns[i].Width = 25;
                DataGridView_Ouput_DIE.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DataGridView_Input_DIE.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(OpenFilePath);
            Button_Done_DIE.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DataGridView_Input_DIE.ColumnCount = 50;
            DataGridView_Ouput_DIE.ColumnCount = 50;
            DataGridView_Input_DIE.RowCount = 50;
            DataGridView_Ouput_DIE.RowCount = 50;
            for (int i = 0; i < 50; i++)
            {
                DataGridView_Input_DIE.Columns[i].Width = 25;
                DataGridView_Ouput_DIE.Columns[i].Width = 25;
            }
        }
    }
}
