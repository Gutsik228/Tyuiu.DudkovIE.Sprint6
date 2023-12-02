
namespace Tyuiu.DudkovIE.Sprint6.Task0.V30
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
            this.TextBox_VarX_DIE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Help_DIE = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TextBox_Result_DIE = new System.Windows.Forms.TextBox();
            this.Button_Done_DIE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_VarX_DIE
            // 
            this.TextBox_VarX_DIE.Location = new System.Drawing.Point(27, 253);
            this.TextBox_VarX_DIE.Name = "TextBox_VarX_DIE";
            this.TextBox_VarX_DIE.Size = new System.Drawing.Size(100, 20);
            this.TextBox_VarX_DIE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите число X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вычислить выражение по формуле";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Условие:";
            // 
            // Button_Help_DIE
            // 
            this.Button_Help_DIE.Location = new System.Drawing.Point(268, 281);
            this.Button_Help_DIE.Name = "Button_Help_DIE";
            this.Button_Help_DIE.Size = new System.Drawing.Size(35, 31);
            this.Button_Help_DIE.TabIndex = 8;
            this.Button_Help_DIE.Text = "?";
            this.Button_Help_DIE.UseVisualStyleBackColor = true;
            this.Button_Help_DIE.Click += new System.EventHandler(this.Button_Help_DIE_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(309, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // TextBox_Result_DIE
            // 
            this.TextBox_Result_DIE.Location = new System.Drawing.Point(309, 253);
            this.TextBox_Result_DIE.Name = "TextBox_Result_DIE";
            this.TextBox_Result_DIE.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Result_DIE.TabIndex = 10;
            // 
            // Button_Done_DIE
            // 
            this.Button_Done_DIE.Location = new System.Drawing.Point(309, 279);
            this.Button_Done_DIE.Name = "Button_Done_DIE";
            this.Button_Done_DIE.Size = new System.Drawing.Size(99, 32);
            this.Button_Done_DIE.TabIndex = 11;
            this.Button_Done_DIE.Text = "Выполнить";
            this.Button_Done_DIE.UseVisualStyleBackColor = true;
            this.Button_Done_DIE.Click += new System.EventHandler(this.Button_Done_DIE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.Button_Done_DIE);
            this.Controls.Add(this.TextBox_Result_DIE);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Button_Help_DIE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_VarX_DIE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0| Вариант 30 | Дудков И.Е.  ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_VarX_DIE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Help_DIE;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TextBox_Result_DIE;
        private System.Windows.Forms.Button Button_Done_DIE;
    }
}

