
namespace Tyuiu.DudkovIE.Sprint6.Task1.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_StartStep_DIE = new System.Windows.Forms.TextBox();
            this.TextBox_EndStep_DIE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_Result_DIE = new System.Windows.Forms.TextBox();
            this.Button_Help_DIE = new System.Windows.Forms.Button();
            this.Button_Done_DIE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Старт шага:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Конец шага:";
            // 
            // TextBox_StartStep_DIE
            // 
            this.TextBox_StartStep_DIE.Location = new System.Drawing.Point(11, 307);
            this.TextBox_StartStep_DIE.Name = "TextBox_StartStep_DIE";
            this.TextBox_StartStep_DIE.Size = new System.Drawing.Size(112, 20);
            this.TextBox_StartStep_DIE.TabIndex = 3;
            this.TextBox_StartStep_DIE.Text = "-5";
            // 
            // TextBox_EndStep_DIE
            // 
            this.TextBox_EndStep_DIE.Location = new System.Drawing.Point(147, 307);
            this.TextBox_EndStep_DIE.Name = "TextBox_EndStep_DIE";
            this.TextBox_EndStep_DIE.Size = new System.Drawing.Size(112, 20);
            this.TextBox_EndStep_DIE.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Условие:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Протабулировать функцию на заданном диапазоне";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Результат вывести в виде таблицы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Вывод данных:";
            // 
            // TextBox_Result_DIE
            // 
            this.TextBox_Result_DIE.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Result_DIE.Location = new System.Drawing.Point(449, 56);
            this.TextBox_Result_DIE.Multiline = true;
            this.TextBox_Result_DIE.Name = "TextBox_Result_DIE";
            this.TextBox_Result_DIE.ReadOnly = true;
            this.TextBox_Result_DIE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Result_DIE.Size = new System.Drawing.Size(223, 248);
            this.TextBox_Result_DIE.TabIndex = 9;
            // 
            // Button_Help_DIE
            // 
            this.Button_Help_DIE.BackColor = System.Drawing.SystemColors.Highlight;
            this.Button_Help_DIE.Location = new System.Drawing.Point(272, 298);
            this.Button_Help_DIE.Name = "Button_Help_DIE";
            this.Button_Help_DIE.Size = new System.Drawing.Size(73, 37);
            this.Button_Help_DIE.TabIndex = 10;
            this.Button_Help_DIE.Text = "Справка";
            this.Button_Help_DIE.UseVisualStyleBackColor = false;
            this.Button_Help_DIE.Click += new System.EventHandler(this.Button_Help_DIE_Click);
            // 
            // Button_Done_DIE
            // 
            this.Button_Done_DIE.BackColor = System.Drawing.Color.LawnGreen;
            this.Button_Done_DIE.Location = new System.Drawing.Point(351, 298);
            this.Button_Done_DIE.Name = "Button_Done_DIE";
            this.Button_Done_DIE.Size = new System.Drawing.Size(92, 37);
            this.Button_Done_DIE.TabIndex = 11;
            this.Button_Done_DIE.Text = "Выполнить";
            this.Button_Done_DIE.UseVisualStyleBackColor = false;
            this.Button_Done_DIE.Click += new System.EventHandler(this.Button_Done_DIE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_Done_DIE);
            this.Controls.Add(this.Button_Help_DIE);
            this.Controls.Add(this.TextBox_Result_DIE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_EndStep_DIE);
            this.Controls.Add(this.TextBox_StartStep_DIE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_StartStep_DIE;
        private System.Windows.Forms.TextBox TextBox_EndStep_DIE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBox_Result_DIE;
        private System.Windows.Forms.Button Button_Help_DIE;
        private System.Windows.Forms.Button Button_Done_DIE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

