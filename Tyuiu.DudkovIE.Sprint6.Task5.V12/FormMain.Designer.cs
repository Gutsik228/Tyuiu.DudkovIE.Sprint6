
namespace Tyuiu.DudkovIE.Sprint6.Task5.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TextBox_Condition_DIE = new System.Windows.Forms.TextBox();
            this.GroupBox_Condition_DIE = new System.Windows.Forms.GroupBox();
            this.DataGridView_Result_DIE = new System.Windows.Forms.DataGridView();
            this.GroupBox_Result_DIE = new System.Windows.Forms.GroupBox();
            this.Button_Help_DIE = new System.Windows.Forms.Button();
            this.Button_Done_DIE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chart_Result_DIE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_OpenFile_DIE = new System.Windows.Forms.Button();
            this.GroupBox_Condition_DIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Result_DIE)).BeginInit();
            this.GroupBox_Result_DIE.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Result_DIE)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Condition_DIE
            // 
            this.TextBox_Condition_DIE.Location = new System.Drawing.Point(6, 19);
            this.TextBox_Condition_DIE.Multiline = true;
            this.TextBox_Condition_DIE.Name = "TextBox_Condition_DIE";
            this.TextBox_Condition_DIE.ReadOnly = true;
            this.TextBox_Condition_DIE.Size = new System.Drawing.Size(363, 62);
            this.TextBox_Condition_DIE.TabIndex = 0;
            this.TextBox_Condition_DIE.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView\r\n все числа " +
    "не кратные 5. Построить диаграмму по этим значениям.";
            // 
            // GroupBox_Condition_DIE
            // 
            this.GroupBox_Condition_DIE.Controls.Add(this.TextBox_Condition_DIE);
            this.GroupBox_Condition_DIE.Location = new System.Drawing.Point(6, 12);
            this.GroupBox_Condition_DIE.Name = "GroupBox_Condition_DIE";
            this.GroupBox_Condition_DIE.Size = new System.Drawing.Size(375, 88);
            this.GroupBox_Condition_DIE.TabIndex = 3;
            this.GroupBox_Condition_DIE.TabStop = false;
            this.GroupBox_Condition_DIE.Text = "Условие";
            // 
            // DataGridView_Result_DIE
            // 
            this.DataGridView_Result_DIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Result_DIE.Location = new System.Drawing.Point(6, 19);
            this.DataGridView_Result_DIE.Name = "DataGridView_Result_DIE";
            this.DataGridView_Result_DIE.Size = new System.Drawing.Size(188, 307);
            this.DataGridView_Result_DIE.TabIndex = 0;
            // 
            // GroupBox_Result_DIE
            // 
            this.GroupBox_Result_DIE.Controls.Add(this.DataGridView_Result_DIE);
            this.GroupBox_Result_DIE.Location = new System.Drawing.Point(12, 106);
            this.GroupBox_Result_DIE.Name = "GroupBox_Result_DIE";
            this.GroupBox_Result_DIE.Size = new System.Drawing.Size(200, 332);
            this.GroupBox_Result_DIE.TabIndex = 5;
            this.GroupBox_Result_DIE.TabStop = false;
            this.GroupBox_Result_DIE.Text = "Вывод";
            // 
            // Button_Help_DIE
            // 
            this.Button_Help_DIE.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_Help_DIE.Location = new System.Drawing.Point(259, 19);
            this.Button_Help_DIE.Name = "Button_Help_DIE";
            this.Button_Help_DIE.Size = new System.Drawing.Size(95, 39);
            this.Button_Help_DIE.TabIndex = 6;
            this.Button_Help_DIE.Text = "Справка";
            this.Button_Help_DIE.UseVisualStyleBackColor = false;
            this.Button_Help_DIE.Click += new System.EventHandler(this.Button_Help_DIE_Click);
            // 
            // Button_Done_DIE
            // 
            this.Button_Done_DIE.BackColor = System.Drawing.Color.Lime;
            this.Button_Done_DIE.Location = new System.Drawing.Point(17, 19);
            this.Button_Done_DIE.Name = "Button_Done_DIE";
            this.Button_Done_DIE.Size = new System.Drawing.Size(100, 39);
            this.Button_Done_DIE.TabIndex = 4;
            this.Button_Done_DIE.Text = "Выполнить";
            this.Button_Done_DIE.UseVisualStyleBackColor = false;
            this.Button_Done_DIE.Click += new System.EventHandler(this.Button_Done_DIE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_OpenFile_DIE);
            this.groupBox1.Controls.Add(this.Button_Done_DIE);
            this.groupBox1.Controls.Add(this.Button_Help_DIE);
            this.groupBox1.Location = new System.Drawing.Point(387, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Chart_Result_DIE
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart_Result_DIE.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_Result_DIE.Legends.Add(legend2);
            this.Chart_Result_DIE.Location = new System.Drawing.Point(251, 106);
            this.Chart_Result_DIE.Name = "Chart_Result_DIE";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart_Result_DIE.Series.Add(series2);
            this.Chart_Result_DIE.Size = new System.Drawing.Size(511, 300);
            this.Chart_Result_DIE.TabIndex = 6;
            this.Chart_Result_DIE.Text = "chart1";
            // 
            // Button_OpenFile_DIE
            // 
            this.Button_OpenFile_DIE.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_OpenFile_DIE.Location = new System.Drawing.Point(140, 19);
            this.Button_OpenFile_DIE.Name = "Button_OpenFile_DIE";
            this.Button_OpenFile_DIE.Size = new System.Drawing.Size(95, 39);
            this.Button_OpenFile_DIE.TabIndex = 7;
            this.Button_OpenFile_DIE.Text = "Открыть файл";
            this.Button_OpenFile_DIE.UseVisualStyleBackColor = false;
            this.Button_OpenFile_DIE.Click += new System.EventHandler(this.Button_OpenFile_DIE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Chart_Result_DIE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_Result_DIE);
            this.Controls.Add(this.GroupBox_Condition_DIE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 12 | Дудков И.Е.";
            this.GroupBox_Condition_DIE.ResumeLayout(false);
            this.GroupBox_Condition_DIE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Result_DIE)).EndInit();
            this.GroupBox_Result_DIE.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Result_DIE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Condition_DIE;
        private System.Windows.Forms.GroupBox GroupBox_Condition_DIE;
        private System.Windows.Forms.DataGridView DataGridView_Result_DIE;
        private System.Windows.Forms.GroupBox GroupBox_Result_DIE;
        private System.Windows.Forms.Button Button_Help_DIE;
        private System.Windows.Forms.Button Button_Done_DIE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Result_DIE;
        private System.Windows.Forms.Button Button_OpenFile_DIE;
    }
}

