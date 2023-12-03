
namespace Tyuiu.DudkovIE.Sprint6.Task3.V18
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridView_Matrix_DIE = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox_Result_DIE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Done_DIE = new System.Windows.Forms.Button();
            this.Button_Help_DIE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Matrix_DIE)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridView_Matrix_DIE);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // DataGridView_Matrix_DIE
            // 
            this.DataGridView_Matrix_DIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Matrix_DIE.Location = new System.Drawing.Point(246, 19);
            this.DataGridView_Matrix_DIE.Name = "DataGridView_Matrix_DIE";
            this.DataGridView_Matrix_DIE.Size = new System.Drawing.Size(240, 218);
            this.DataGridView_Matrix_DIE.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(219, 218);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Дана матрица 5 на 5\r\n-19 -19   1  18   7\r\n\r\n   5   3  -4  -6 -12\r\n\r\n -15   6   2 " +
    "  2 -14\r\n\r\n  -9 -10  15  -5  -6\r\n\r\n -13 -15  -9   7   1\r\nзаменить четные числа в" +
    " четвертой строке на 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox_Result_DIE);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(510, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных:";
            // 
            // TextBox_Result_DIE
            // 
            this.TextBox_Result_DIE.Location = new System.Drawing.Point(10, 45);
            this.TextBox_Result_DIE.Name = "TextBox_Result_DIE";
            this.TextBox_Result_DIE.ReadOnly = true;
            this.TextBox_Result_DIE.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Result_DIE.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результат:";
            // 
            // Button_Done_DIE
            // 
            this.Button_Done_DIE.Location = new System.Drawing.Point(601, 267);
            this.Button_Done_DIE.Name = "Button_Done_DIE";
            this.Button_Done_DIE.Size = new System.Drawing.Size(75, 23);
            this.Button_Done_DIE.TabIndex = 2;
            this.Button_Done_DIE.Text = "Выполнить";
            this.Button_Done_DIE.UseVisualStyleBackColor = true;
            this.Button_Done_DIE.Click += new System.EventHandler(this.Button_Done_DIE_Click);
            // 
            // Button_Help_DIE
            // 
            this.Button_Help_DIE.Location = new System.Drawing.Point(520, 267);
            this.Button_Help_DIE.Name = "Button_Help_DIE";
            this.Button_Help_DIE.Size = new System.Drawing.Size(75, 23);
            this.Button_Help_DIE.TabIndex = 3;
            this.Button_Help_DIE.Text = "?";
            this.Button_Help_DIE.UseVisualStyleBackColor = true;
            this.Button_Help_DIE.Click += new System.EventHandler(this.Button_Help_DIE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 311);
            this.Controls.Add(this.Button_Help_DIE);
            this.Controls.Add(this.Button_Done_DIE);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 18 | Дудков И.Е. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Matrix_DIE)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridView_Matrix_DIE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBox_Result_DIE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Done_DIE;
        private System.Windows.Forms.Button Button_Help_DIE;
    }
}

