
namespace Tyuiu.DudkovIE.Sprint6.Task4.V23
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GroupBox_Condition_DIE = new System.Windows.Forms.GroupBox();
            this.TextBox_Condition_DIE = new System.Windows.Forms.TextBox();
            this.GroupBox_InputData_DIE = new System.Windows.Forms.GroupBox();
            this.Label_DataStartValue_DIE = new System.Windows.Forms.Label();
            this.Label_DataEndValue_DIE = new System.Windows.Forms.Label();
            this.TextBox_StartValue_DIE = new System.Windows.Forms.TextBox();
            this.TextBox_EndValue_DIE = new System.Windows.Forms.TextBox();
            this.Button_Done_DIE = new System.Windows.Forms.Button();
            this.Button_Save_DIE = new System.Windows.Forms.Button();
            this.Button_Help_DIE = new System.Windows.Forms.Button();
            this.GroupBox_Result_DIE = new System.Windows.Forms.GroupBox();
            this.TextBox_Result_DIE = new System.Windows.Forms.TextBox();
            this.Chart_Result_DIE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GroupBox_Condition_DIE.SuspendLayout();
            this.GroupBox_InputData_DIE.SuspendLayout();
            this.GroupBox_Result_DIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Result_DIE)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_Condition_DIE
            // 
            this.GroupBox_Condition_DIE.Controls.Add(this.TextBox_Condition_DIE);
            this.GroupBox_Condition_DIE.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Condition_DIE.Name = "GroupBox_Condition_DIE";
            this.GroupBox_Condition_DIE.Size = new System.Drawing.Size(375, 88);
            this.GroupBox_Condition_DIE.TabIndex = 0;
            this.GroupBox_Condition_DIE.TabStop = false;
            this.GroupBox_Condition_DIE.Text = "Условие";
            // 
            // TextBox_Condition_DIE
            // 
            this.TextBox_Condition_DIE.Location = new System.Drawing.Point(6, 19);
            this.TextBox_Condition_DIE.Multiline = true;
            this.TextBox_Condition_DIE.Name = "TextBox_Condition_DIE";
            this.TextBox_Condition_DIE.ReadOnly = true;
            this.TextBox_Condition_DIE.Size = new System.Drawing.Size(363, 62);
            this.TextBox_Condition_DIE.TabIndex = 0;
            this.TextBox_Condition_DIE.Text = "Протабулировать функцию 4 - 2 * x + (2 + cos(x)) / (2 * x - 2) на диапазоне от -5" +
    " до 5\r\nПостроить график, ответ вывести в TextBox, сохранить в файл OutPutFIleTas" +
    "k4.txt";
            // 
            // GroupBox_InputData_DIE
            // 
            this.GroupBox_InputData_DIE.Controls.Add(this.Button_Help_DIE);
            this.GroupBox_InputData_DIE.Controls.Add(this.Button_Save_DIE);
            this.GroupBox_InputData_DIE.Controls.Add(this.Button_Done_DIE);
            this.GroupBox_InputData_DIE.Controls.Add(this.TextBox_EndValue_DIE);
            this.GroupBox_InputData_DIE.Controls.Add(this.TextBox_StartValue_DIE);
            this.GroupBox_InputData_DIE.Controls.Add(this.Label_DataEndValue_DIE);
            this.GroupBox_InputData_DIE.Controls.Add(this.Label_DataStartValue_DIE);
            this.GroupBox_InputData_DIE.Location = new System.Drawing.Point(393, 12);
            this.GroupBox_InputData_DIE.Name = "GroupBox_InputData_DIE";
            this.GroupBox_InputData_DIE.Size = new System.Drawing.Size(407, 81);
            this.GroupBox_InputData_DIE.TabIndex = 1;
            this.GroupBox_InputData_DIE.TabStop = false;
            this.GroupBox_InputData_DIE.Text = "Ввод данных";
            // 
            // Label_DataStartValue_DIE
            // 
            this.Label_DataStartValue_DIE.AutoSize = true;
            this.Label_DataStartValue_DIE.Location = new System.Drawing.Point(6, 22);
            this.Label_DataStartValue_DIE.Name = "Label_DataStartValue_DIE";
            this.Label_DataStartValue_DIE.Size = new System.Drawing.Size(67, 13);
            this.Label_DataStartValue_DIE.TabIndex = 0;
            this.Label_DataStartValue_DIE.Text = "Старт шага:";
            // 
            // Label_DataEndValue_DIE
            // 
            this.Label_DataEndValue_DIE.AutoSize = true;
            this.Label_DataEndValue_DIE.Location = new System.Drawing.Point(109, 22);
            this.Label_DataEndValue_DIE.Name = "Label_DataEndValue_DIE";
            this.Label_DataEndValue_DIE.Size = new System.Drawing.Size(69, 13);
            this.Label_DataEndValue_DIE.TabIndex = 1;
            this.Label_DataEndValue_DIE.Text = "Конец шага:";
            // 
            // TextBox_StartValue_DIE
            // 
            this.TextBox_StartValue_DIE.Location = new System.Drawing.Point(9, 38);
            this.TextBox_StartValue_DIE.Name = "TextBox_StartValue_DIE";
            this.TextBox_StartValue_DIE.Size = new System.Drawing.Size(100, 20);
            this.TextBox_StartValue_DIE.TabIndex = 2;
            // 
            // TextBox_EndValue_DIE
            // 
            this.TextBox_EndValue_DIE.Location = new System.Drawing.Point(115, 38);
            this.TextBox_EndValue_DIE.Name = "TextBox_EndValue_DIE";
            this.TextBox_EndValue_DIE.Size = new System.Drawing.Size(100, 20);
            this.TextBox_EndValue_DIE.TabIndex = 3;
            // 
            // Button_Done_DIE
            // 
            this.Button_Done_DIE.BackColor = System.Drawing.Color.Lime;
            this.Button_Done_DIE.Location = new System.Drawing.Point(221, 19);
            this.Button_Done_DIE.Name = "Button_Done_DIE";
            this.Button_Done_DIE.Size = new System.Drawing.Size(60, 39);
            this.Button_Done_DIE.TabIndex = 4;
            this.Button_Done_DIE.Text = "Выполнить";
            this.Button_Done_DIE.UseVisualStyleBackColor = false;
            this.Button_Done_DIE.Click += new System.EventHandler(this.Button_Done_DIE_Click);
            // 
            // Button_Save_DIE
            // 
            this.Button_Save_DIE.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_Save_DIE.Location = new System.Drawing.Point(277, 19);
            this.Button_Save_DIE.Name = "Button_Save_DIE";
            this.Button_Save_DIE.Size = new System.Drawing.Size(64, 39);
            this.Button_Save_DIE.TabIndex = 5;
            this.Button_Save_DIE.Text = "Сохранить";
            this.Button_Save_DIE.UseVisualStyleBackColor = false;
            this.Button_Save_DIE.Click += new System.EventHandler(this.Button_Save_DIE_Click);
            // 
            // Button_Help_DIE
            // 
            this.Button_Help_DIE.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_Help_DIE.Location = new System.Drawing.Point(341, 19);
            this.Button_Help_DIE.Name = "Button_Help_DIE";
            this.Button_Help_DIE.Size = new System.Drawing.Size(54, 39);
            this.Button_Help_DIE.TabIndex = 6;
            this.Button_Help_DIE.Text = "Справка";
            this.Button_Help_DIE.UseVisualStyleBackColor = false;
            this.Button_Help_DIE.Click += new System.EventHandler(this.Button_Help_DIE_Click);
            // 
            // GroupBox_Result_DIE
            // 
            this.GroupBox_Result_DIE.Controls.Add(this.TextBox_Result_DIE);
            this.GroupBox_Result_DIE.Location = new System.Drawing.Point(18, 106);
            this.GroupBox_Result_DIE.Name = "GroupBox_Result_DIE";
            this.GroupBox_Result_DIE.Size = new System.Drawing.Size(200, 332);
            this.GroupBox_Result_DIE.TabIndex = 2;
            this.GroupBox_Result_DIE.TabStop = false;
            this.GroupBox_Result_DIE.Text = "Вывод";
            // 
            // TextBox_Result_DIE
            // 
            this.TextBox_Result_DIE.Location = new System.Drawing.Point(7, 20);
            this.TextBox_Result_DIE.Multiline = true;
            this.TextBox_Result_DIE.Name = "TextBox_Result_DIE";
            this.TextBox_Result_DIE.ReadOnly = true;
            this.TextBox_Result_DIE.Size = new System.Drawing.Size(187, 306);
            this.TextBox_Result_DIE.TabIndex = 0;
            // 
            // Chart_Result_DIE
            // 
            chartArea6.Name = "ChartArea1";
            this.Chart_Result_DIE.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.Chart_Result_DIE.Legends.Add(legend6);
            this.Chart_Result_DIE.Location = new System.Drawing.Point(250, 126);
            this.Chart_Result_DIE.Name = "Chart_Result_DIE";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.Chart_Result_DIE.Series.Add(series6);
            this.Chart_Result_DIE.Size = new System.Drawing.Size(517, 300);
            this.Chart_Result_DIE.TabIndex = 3;
            this.Chart_Result_DIE.Text = "chart1";
            title6.Name = "Title1";
            title6.Text = "График функции";
            this.Chart_Result_DIE.Titles.Add(title6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Chart_Result_DIE);
            this.Controls.Add(this.GroupBox_Result_DIE);
            this.Controls.Add(this.GroupBox_InputData_DIE);
            this.Controls.Add(this.GroupBox_Condition_DIE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 23 | Дудков И.Е.";
            this.GroupBox_Condition_DIE.ResumeLayout(false);
            this.GroupBox_Condition_DIE.PerformLayout();
            this.GroupBox_InputData_DIE.ResumeLayout(false);
            this.GroupBox_InputData_DIE.PerformLayout();
            this.GroupBox_Result_DIE.ResumeLayout(false);
            this.GroupBox_Result_DIE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Result_DIE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Condition_DIE;
        private System.Windows.Forms.TextBox TextBox_Condition_DIE;
        private System.Windows.Forms.GroupBox GroupBox_InputData_DIE;
        private System.Windows.Forms.Button Button_Help_DIE;
        private System.Windows.Forms.Button Button_Save_DIE;
        private System.Windows.Forms.Button Button_Done_DIE;
        private System.Windows.Forms.TextBox TextBox_EndValue_DIE;
        private System.Windows.Forms.TextBox TextBox_StartValue_DIE;
        private System.Windows.Forms.Label Label_DataEndValue_DIE;
        private System.Windows.Forms.Label Label_DataStartValue_DIE;
        private System.Windows.Forms.GroupBox GroupBox_Result_DIE;
        private System.Windows.Forms.TextBox TextBox_Result_DIE;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Result_DIE;
    }
}

