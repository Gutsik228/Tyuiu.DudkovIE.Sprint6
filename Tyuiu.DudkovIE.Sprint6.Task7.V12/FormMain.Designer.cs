
namespace Tyuiu.DudkovIE.Sprint6.Task7.V12
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
            this.GroupBox_Output_DIE = new System.Windows.Forms.GroupBox();
            this.DataGridView_Ouput_DIE = new System.Windows.Forms.DataGridView();
            this.GroupBox_Input_DIE = new System.Windows.Forms.GroupBox();
            this.DataGridView_Input_DIE = new System.Windows.Forms.DataGridView();
            this.GroupBox_Condition_DIE = new System.Windows.Forms.GroupBox();
            this.TextBox_Condition_DIE = new System.Windows.Forms.TextBox();
            this.GroupBox_MainButtons_DIE = new System.Windows.Forms.GroupBox();
            this.Button_SearchFiles_DIE = new System.Windows.Forms.Button();
            this.Button_Help_DIE = new System.Windows.Forms.Button();
            this.Button_SaveFile_DIE = new System.Windows.Forms.Button();
            this.Button_Done_DIE = new System.Windows.Forms.Button();
            this.openFileDialogTask_DIE = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_DIE = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_DIE = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox_Output_DIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Ouput_DIE)).BeginInit();
            this.GroupBox_Input_DIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Input_DIE)).BeginInit();
            this.GroupBox_Condition_DIE.SuspendLayout();
            this.GroupBox_MainButtons_DIE.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Output_DIE
            // 
            this.GroupBox_Output_DIE.Controls.Add(this.DataGridView_Ouput_DIE);
            this.GroupBox_Output_DIE.Location = new System.Drawing.Point(393, 154);
            this.GroupBox_Output_DIE.Name = "GroupBox_Output_DIE";
            this.GroupBox_Output_DIE.Size = new System.Drawing.Size(380, 292);
            this.GroupBox_Output_DIE.TabIndex = 7;
            this.GroupBox_Output_DIE.TabStop = false;
            this.GroupBox_Output_DIE.Text = "Вывод:";
            // 
            // DataGridView_Ouput_DIE
            // 
            this.DataGridView_Ouput_DIE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataGridView_Ouput_DIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Ouput_DIE.Location = new System.Drawing.Point(11, 19);
            this.DataGridView_Ouput_DIE.Name = "DataGridView_Ouput_DIE";
            this.DataGridView_Ouput_DIE.Size = new System.Drawing.Size(369, 261);
            this.DataGridView_Ouput_DIE.TabIndex = 1;
            // 
            // GroupBox_Input_DIE
            // 
            this.GroupBox_Input_DIE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox_Input_DIE.Controls.Add(this.DataGridView_Input_DIE);
            this.GroupBox_Input_DIE.Location = new System.Drawing.Point(7, 154);
            this.GroupBox_Input_DIE.Name = "GroupBox_Input_DIE";
            this.GroupBox_Input_DIE.Size = new System.Drawing.Size(380, 286);
            this.GroupBox_Input_DIE.TabIndex = 6;
            this.GroupBox_Input_DIE.TabStop = false;
            this.GroupBox_Input_DIE.Text = "Ввод:";
            // 
            // DataGridView_Input_DIE
            // 
            this.DataGridView_Input_DIE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DataGridView_Input_DIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Input_DIE.Location = new System.Drawing.Point(5, 19);
            this.DataGridView_Input_DIE.Name = "DataGridView_Input_DIE";
            this.DataGridView_Input_DIE.Size = new System.Drawing.Size(369, 261);
            this.DataGridView_Input_DIE.TabIndex = 0;
            // 
            // GroupBox_Condition_DIE
            // 
            this.GroupBox_Condition_DIE.Controls.Add(this.TextBox_Condition_DIE);
            this.GroupBox_Condition_DIE.Location = new System.Drawing.Point(1, 68);
            this.GroupBox_Condition_DIE.Name = "GroupBox_Condition_DIE";
            this.GroupBox_Condition_DIE.Size = new System.Drawing.Size(799, 86);
            this.GroupBox_Condition_DIE.TabIndex = 5;
            this.GroupBox_Condition_DIE.TabStop = false;
            this.GroupBox_Condition_DIE.Text = "Условие";
            // 
            // TextBox_Condition_DIE
            // 
            this.TextBox_Condition_DIE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Condition_DIE.Location = new System.Drawing.Point(6, 19);
            this.TextBox_Condition_DIE.Multiline = true;
            this.TextBox_Condition_DIE.Name = "TextBox_Condition_DIE";
            this.TextBox_Condition_DIE.ReadOnly = true;
            this.TextBox_Condition_DIE.Size = new System.Drawing.Size(787, 61);
            this.TextBox_Condition_DIE.TabIndex = 0;
            this.TextBox_Condition_DIE.Text = resources.GetString("TextBox_Condition_DIE.Text");
            // 
            // GroupBox_MainButtons_DIE
            // 
            this.GroupBox_MainButtons_DIE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBox_MainButtons_DIE.Controls.Add(this.Button_SearchFiles_DIE);
            this.GroupBox_MainButtons_DIE.Controls.Add(this.Button_Help_DIE);
            this.GroupBox_MainButtons_DIE.Controls.Add(this.Button_SaveFile_DIE);
            this.GroupBox_MainButtons_DIE.Controls.Add(this.Button_Done_DIE);
            this.GroupBox_MainButtons_DIE.Location = new System.Drawing.Point(1, 5);
            this.GroupBox_MainButtons_DIE.Name = "GroupBox_MainButtons_DIE";
            this.GroupBox_MainButtons_DIE.Size = new System.Drawing.Size(799, 57);
            this.GroupBox_MainButtons_DIE.TabIndex = 4;
            this.GroupBox_MainButtons_DIE.TabStop = false;
            // 
            // Button_SearchFiles_DIE
            // 
            this.Button_SearchFiles_DIE.Image = ((System.Drawing.Image)(resources.GetObject("Button_SearchFiles_DIE.Image")));
            this.Button_SearchFiles_DIE.Location = new System.Drawing.Point(11, 9);
            this.Button_SearchFiles_DIE.Name = "Button_SearchFiles_DIE";
            this.Button_SearchFiles_DIE.Size = new System.Drawing.Size(59, 48);
            this.Button_SearchFiles_DIE.TabIndex = 5;
            this.Button_SearchFiles_DIE.UseVisualStyleBackColor = true;
            this.Button_SearchFiles_DIE.Click += new System.EventHandler(this.Button_SearchFiles_DIE_Click);
            // 
            // Button_Help_DIE
            // 
            this.Button_Help_DIE.Image = ((System.Drawing.Image)(resources.GetObject("Button_Help_DIE.Image")));
            this.Button_Help_DIE.Location = new System.Drawing.Point(734, 9);
            this.Button_Help_DIE.Name = "Button_Help_DIE";
            this.Button_Help_DIE.Size = new System.Drawing.Size(59, 48);
            this.Button_Help_DIE.TabIndex = 4;
            this.Button_Help_DIE.UseVisualStyleBackColor = true;
            this.Button_Help_DIE.Click += new System.EventHandler(this.Button_Help_DIE_Click);
            // 
            // Button_SaveFile_DIE
            // 
            this.Button_SaveFile_DIE.Enabled = false;
            this.Button_SaveFile_DIE.Image = ((System.Drawing.Image)(resources.GetObject("Button_SaveFile_DIE.Image")));
            this.Button_SaveFile_DIE.Location = new System.Drawing.Point(162, 9);
            this.Button_SaveFile_DIE.Name = "Button_SaveFile_DIE";
            this.Button_SaveFile_DIE.Size = new System.Drawing.Size(63, 48);
            this.Button_SaveFile_DIE.TabIndex = 3;
            this.Button_SaveFile_DIE.UseVisualStyleBackColor = true;
            this.Button_SaveFile_DIE.Click += new System.EventHandler(this.Button_SaveFile_DIE_Click);
            // 
            // Button_Done_DIE
            // 
            this.Button_Done_DIE.Enabled = false;
            this.Button_Done_DIE.Image = ((System.Drawing.Image)(resources.GetObject("Button_Done_DIE.Image")));
            this.Button_Done_DIE.Location = new System.Drawing.Point(86, 9);
            this.Button_Done_DIE.Name = "Button_Done_DIE";
            this.Button_Done_DIE.Size = new System.Drawing.Size(59, 48);
            this.Button_Done_DIE.TabIndex = 1;
            this.Button_Done_DIE.UseVisualStyleBackColor = true;
            this.Button_Done_DIE.Click += new System.EventHandler(this.Button_Done_DIE_Click);
            // 
            // openFileDialogTask_DIE
            // 
            this.openFileDialogTask_DIE.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox_Output_DIE);
            this.Controls.Add(this.GroupBox_Input_DIE);
            this.Controls.Add(this.GroupBox_Condition_DIE);
            this.Controls.Add(this.GroupBox_MainButtons_DIE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 12 | Дудков И.Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupBox_Output_DIE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Ouput_DIE)).EndInit();
            this.GroupBox_Input_DIE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Input_DIE)).EndInit();
            this.GroupBox_Condition_DIE.ResumeLayout(false);
            this.GroupBox_Condition_DIE.PerformLayout();
            this.GroupBox_MainButtons_DIE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Output_DIE;
        private System.Windows.Forms.GroupBox GroupBox_Input_DIE;
        private System.Windows.Forms.GroupBox GroupBox_Condition_DIE;
        private System.Windows.Forms.TextBox TextBox_Condition_DIE;
        private System.Windows.Forms.GroupBox GroupBox_MainButtons_DIE;
        private System.Windows.Forms.Button Button_Done_DIE;
        private System.Windows.Forms.DataGridView DataGridView_Input_DIE;
        private System.Windows.Forms.DataGridView DataGridView_Ouput_DIE;
        private System.Windows.Forms.Button Button_SaveFile_DIE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DIE;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_DIE;
        private System.Windows.Forms.Button Button_Help_DIE;
        private System.Windows.Forms.Button Button_SearchFiles_DIE;
        private System.Windows.Forms.ToolTip toolTip_DIE;
    }
}

