
namespace Tyuiu.DudkovIE.Sprint6.Task6.V17
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GroupBox_MainButtons_DIE = new System.Windows.Forms.GroupBox();
            this.Button_SearchFiles_DIE = new System.Windows.Forms.Button();
            this.Button_Done_DIE = new System.Windows.Forms.Button();
            this.Button_Help_DIE = new System.Windows.Forms.Button();
            this.GroupBox_Condition_DIE = new System.Windows.Forms.GroupBox();
            this.TextBox_Condition_DIE = new System.Windows.Forms.TextBox();
            this.GroupBox_Input_DIE = new System.Windows.Forms.GroupBox();
            this.GroupBox_Output_DIE = new System.Windows.Forms.GroupBox();
            this.TextBox_Input_DIE = new System.Windows.Forms.TextBox();
            this.TextBox_Output_DIE = new System.Windows.Forms.TextBox();
            this.OpenFileDialog_DIE = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip_DIE = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox_MainButtons_DIE.SuspendLayout();
            this.GroupBox_Condition_DIE.SuspendLayout();
            this.GroupBox_Input_DIE.SuspendLayout();
            this.GroupBox_Output_DIE.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_MainButtons_DIE
            // 
            this.GroupBox_MainButtons_DIE.Controls.Add(this.Button_Help_DIE);
            this.GroupBox_MainButtons_DIE.Controls.Add(this.Button_Done_DIE);
            this.GroupBox_MainButtons_DIE.Controls.Add(this.Button_SearchFiles_DIE);
            this.GroupBox_MainButtons_DIE.Location = new System.Drawing.Point(0, 3);
            this.GroupBox_MainButtons_DIE.Name = "GroupBox_MainButtons_DIE";
            this.GroupBox_MainButtons_DIE.Size = new System.Drawing.Size(799, 57);
            this.GroupBox_MainButtons_DIE.TabIndex = 0;
            this.GroupBox_MainButtons_DIE.TabStop = false;
            // 
            // Button_SearchFiles_DIE
            // 
            this.Button_SearchFiles_DIE.Image = ((System.Drawing.Image)(resources.GetObject("Button_SearchFiles_DIE.Image")));
            this.Button_SearchFiles_DIE.Location = new System.Drawing.Point(12, 9);
            this.Button_SearchFiles_DIE.Name = "Button_SearchFiles_DIE";
            this.Button_SearchFiles_DIE.Size = new System.Drawing.Size(59, 48);
            this.Button_SearchFiles_DIE.TabIndex = 0;
            this.ToolTip_DIE.SetToolTip(this.Button_SearchFiles_DIE, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.Button_SearchFiles_DIE.UseVisualStyleBackColor = true;
            this.Button_SearchFiles_DIE.Click += new System.EventHandler(this.Button_SearchFiles_DIE_Click);
            // 
            // Button_Done_DIE
            // 
            this.Button_Done_DIE.Image = ((System.Drawing.Image)(resources.GetObject("Button_Done_DIE.Image")));
            this.Button_Done_DIE.Location = new System.Drawing.Point(86, 9);
            this.Button_Done_DIE.Name = "Button_Done_DIE";
            this.Button_Done_DIE.Size = new System.Drawing.Size(59, 48);
            this.Button_Done_DIE.TabIndex = 1;
            this.ToolTip_DIE.SetToolTip(this.Button_Done_DIE, " Использовать программу и получить результат");
            this.Button_Done_DIE.UseVisualStyleBackColor = true;
            this.Button_Done_DIE.Click += new System.EventHandler(this.Button_Done_DIE_Click);
            // 
            // Button_Help_DIE
            // 
            this.Button_Help_DIE.Image = ((System.Drawing.Image)(resources.GetObject("Button_Help_DIE.Image")));
            this.Button_Help_DIE.Location = new System.Drawing.Point(729, 9);
            this.Button_Help_DIE.Name = "Button_Help_DIE";
            this.Button_Help_DIE.Size = new System.Drawing.Size(59, 48);
            this.Button_Help_DIE.TabIndex = 2;
            this.ToolTip_DIE.SetToolTip(this.Button_Help_DIE, "Информация о разработчике");
            this.Button_Help_DIE.UseVisualStyleBackColor = true;
            this.Button_Help_DIE.Click += new System.EventHandler(this.Button_Help_DIE_Click);
            // 
            // GroupBox_Condition_DIE
            // 
            this.GroupBox_Condition_DIE.Controls.Add(this.TextBox_Condition_DIE);
            this.GroupBox_Condition_DIE.Location = new System.Drawing.Point(0, 66);
            this.GroupBox_Condition_DIE.Name = "GroupBox_Condition_DIE";
            this.GroupBox_Condition_DIE.Size = new System.Drawing.Size(799, 86);
            this.GroupBox_Condition_DIE.TabIndex = 1;
            this.GroupBox_Condition_DIE.TabStop = false;
            this.GroupBox_Condition_DIE.Text = "Условие";
            // 
            // TextBox_Condition_DIE
            // 
            this.TextBox_Condition_DIE.Location = new System.Drawing.Point(6, 19);
            this.TextBox_Condition_DIE.Multiline = true;
            this.TextBox_Condition_DIE.Name = "TextBox_Condition_DIE";
            this.TextBox_Condition_DIE.ReadOnly = true;
            this.TextBox_Condition_DIE.Size = new System.Drawing.Size(787, 61);
            this.TextBox_Condition_DIE.TabIndex = 0;
            this.TextBox_Condition_DIE.Text = resources.GetString("TextBox_Condition_DIE.Text");
            // 
            // GroupBox_Input_DIE
            // 
            this.GroupBox_Input_DIE.Controls.Add(this.TextBox_Input_DIE);
            this.GroupBox_Input_DIE.Location = new System.Drawing.Point(6, 152);
            this.GroupBox_Input_DIE.Name = "GroupBox_Input_DIE";
            this.GroupBox_Input_DIE.Size = new System.Drawing.Size(380, 286);
            this.GroupBox_Input_DIE.TabIndex = 2;
            this.GroupBox_Input_DIE.TabStop = false;
            this.GroupBox_Input_DIE.Text = "Ввод:";
            // 
            // GroupBox_Output_DIE
            // 
            this.GroupBox_Output_DIE.Controls.Add(this.TextBox_Output_DIE);
            this.GroupBox_Output_DIE.Location = new System.Drawing.Point(392, 152);
            this.GroupBox_Output_DIE.Name = "GroupBox_Output_DIE";
            this.GroupBox_Output_DIE.Size = new System.Drawing.Size(380, 292);
            this.GroupBox_Output_DIE.TabIndex = 3;
            this.GroupBox_Output_DIE.TabStop = false;
            this.GroupBox_Output_DIE.Text = "Вывод:";
            // 
            // TextBox_Input_DIE
            // 
            this.TextBox_Input_DIE.Location = new System.Drawing.Point(0, 13);
            this.TextBox_Input_DIE.Multiline = true;
            this.TextBox_Input_DIE.Name = "TextBox_Input_DIE";
            this.TextBox_Input_DIE.ReadOnly = true;
            this.TextBox_Input_DIE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Input_DIE.Size = new System.Drawing.Size(374, 279);
            this.TextBox_Input_DIE.TabIndex = 0;
            // 
            // TextBox_Output_DIE
            // 
            this.TextBox_Output_DIE.Location = new System.Drawing.Point(0, 13);
            this.TextBox_Output_DIE.Multiline = true;
            this.TextBox_Output_DIE.Name = "TextBox_Output_DIE";
            this.TextBox_Output_DIE.ReadOnly = true;
            this.TextBox_Output_DIE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Output_DIE.Size = new System.Drawing.Size(374, 273);
            this.TextBox_Output_DIE.TabIndex = 1;
            // 
            // OpenFileDialog_DIE
            // 
            this.OpenFileDialog_DIE.FileName = "openFileDialog1";
            // 
            // ToolTip_DIE
            // 
            this.ToolTip_DIE.Tag = "";
            this.ToolTip_DIE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip_DIE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox_Output_DIE);
            this.Controls.Add(this.GroupBox_Input_DIE);
            this.Controls.Add(this.GroupBox_Condition_DIE);
            this.Controls.Add(this.GroupBox_MainButtons_DIE);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 17 | Дудков И.Е.";
            this.GroupBox_MainButtons_DIE.ResumeLayout(false);
            this.GroupBox_Condition_DIE.ResumeLayout(false);
            this.GroupBox_Condition_DIE.PerformLayout();
            this.GroupBox_Input_DIE.ResumeLayout(false);
            this.GroupBox_Input_DIE.PerformLayout();
            this.GroupBox_Output_DIE.ResumeLayout(false);
            this.GroupBox_Output_DIE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_MainButtons_DIE;
        private System.Windows.Forms.Button Button_Help_DIE;
        private System.Windows.Forms.Button Button_Done_DIE;
        private System.Windows.Forms.Button Button_SearchFiles_DIE;
        private System.Windows.Forms.GroupBox GroupBox_Condition_DIE;
        private System.Windows.Forms.TextBox TextBox_Condition_DIE;
        private System.Windows.Forms.GroupBox GroupBox_Input_DIE;
        private System.Windows.Forms.TextBox TextBox_Input_DIE;
        private System.Windows.Forms.GroupBox GroupBox_Output_DIE;
        private System.Windows.Forms.TextBox TextBox_Output_DIE;
        private System.Windows.Forms.ToolTip ToolTip_DIE;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_DIE;
    }
}

