
namespace Tyuiu.DudkovIE.Sprint6.Task2.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TextBox_StartStep_DIE = new System.Windows.Forms.TextBox();
            this.TextBox_EndStep_DIE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DataGridView_DIE = new System.Windows.Forms.DataGridView();
            this.Column_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chart_Result_DIE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_Done_DIE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DIE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Result_DIE)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_StartStep_DIE
            // 
            this.TextBox_StartStep_DIE.Location = new System.Drawing.Point(33, 375);
            this.TextBox_StartStep_DIE.Name = "TextBox_StartStep_DIE";
            this.TextBox_StartStep_DIE.Size = new System.Drawing.Size(100, 20);
            this.TextBox_StartStep_DIE.TabIndex = 0;
            // 
            // TextBox_EndStep_DIE
            // 
            this.TextBox_EndStep_DIE.Location = new System.Drawing.Point(186, 375);
            this.TextBox_EndStep_DIE.Name = "TextBox_EndStep_DIE";
            this.TextBox_EndStep_DIE.Size = new System.Drawing.Size(100, 20);
            this.TextBox_EndStep_DIE.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ввод данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Старт шага:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Конец шага:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(302, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ввод данных:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Протабулировать функцию на заданном диапазоне";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Результат вывести в DataGridView и построить график функции";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Вывод данных:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Результат";
            // 
            // DataGridView_DIE
            // 
            this.DataGridView_DIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_DIE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_X,
            this.Column_Fx});
            this.DataGridView_DIE.Location = new System.Drawing.Point(468, 79);
            this.DataGridView_DIE.Name = "DataGridView_DIE";
            this.DataGridView_DIE.RowHeadersVisible = false;
            this.DataGridView_DIE.Size = new System.Drawing.Size(103, 271);
            this.DataGridView_DIE.TabIndex = 11;
            // 
            // Column_X
            // 
            this.Column_X.HeaderText = "X";
            this.Column_X.Name = "Column_X";
            this.Column_X.Width = 50;
            // 
            // Column_Fx
            // 
            this.Column_Fx.HeaderText = "F(X)";
            this.Column_Fx.Name = "Column_Fx";
            this.Column_Fx.Width = 50;
            // 
            // Chart_Result_DIE
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_Result_DIE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_Result_DIE.Legends.Add(legend1);
            this.Chart_Result_DIE.Location = new System.Drawing.Point(577, 63);
            this.Chart_Result_DIE.Name = "Chart_Result_DIE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_Result_DIE.Series.Add(series1);
            this.Chart_Result_DIE.Size = new System.Drawing.Size(529, 300);
            this.Chart_Result_DIE.TabIndex = 12;
            this.Chart_Result_DIE.Text = "chart1";
            // 
            // Button_Done_DIE
            // 
            this.Button_Done_DIE.BackColor = System.Drawing.Color.Chartreuse;
            this.Button_Done_DIE.Location = new System.Drawing.Point(383, 364);
            this.Button_Done_DIE.Name = "Button_Done_DIE";
            this.Button_Done_DIE.Size = new System.Drawing.Size(75, 41);
            this.Button_Done_DIE.TabIndex = 13;
            this.Button_Done_DIE.Text = "Выполнить";
            this.Button_Done_DIE.UseVisualStyleBackColor = false;
            this.Button_Done_DIE.Click += new System.EventHandler(this.Button_Done_DIE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.Button_Done_DIE);
            this.Controls.Add(this.Chart_Result_DIE);
            this.Controls.Add(this.DataGridView_DIE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_EndStep_DIE);
            this.Controls.Add(this.TextBox_StartStep_DIE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 1 | Дудков И.Е.";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DIE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Result_DIE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_StartStep_DIE;
        private System.Windows.Forms.TextBox TextBox_EndStep_DIE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DataGridView_DIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Fx;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Result_DIE;
        private System.Windows.Forms.Button Button_Done_DIE;
    }
}

