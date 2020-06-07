namespace TextBook_RusLanguage
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.YellowGreen;
            this.radButton1.ForeColor = System.Drawing.Color.White;
            this.radButton1.Location = new System.Drawing.Point(241, 275);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(228, 73);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Начать выполнение задания";
            this.radButton1.ThemeName = "TelerikMetro";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.Color.YellowGreen;
            this.radButton2.Enabled = false;
            this.radButton2.ForeColor = System.Drawing.Color.White;
            this.radButton2.Location = new System.Drawing.Point(491, 414);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(211, 42);
            this.radButton2.TabIndex = 0;
            this.radButton2.Text = "Отправить задание";
            this.radButton2.ThemeName = "TelerikMetro";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton3
            // 
            this.radButton3.BackColor = System.Drawing.Color.YellowGreen;
            this.radButton3.ForeColor = System.Drawing.Color.White;
            this.radButton3.Location = new System.Drawing.Point(4, 365);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(211, 39);
            this.radButton3.TabIndex = 0;
            this.radButton3.Text = "Выбрать отправляемое задание";
            this.radButton3.ThemeName = "TelerikMetro";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTextBox1.Location = new System.Drawing.Point(221, 380);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(481, 24);
            this.radTextBox1.TabIndex = 1;
            this.radTextBox1.ThemeName = "TelerikMetro";
            this.radTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.radRichTextEditor1.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radRichTextEditor1.Location = new System.Drawing.Point(5, 12);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            // 
            // 
            // 
            this.radRichTextEditor1.RootElement.FocusBorderColor = System.Drawing.Color.White;
            this.radRichTextEditor1.RootElement.ShadowColor = System.Drawing.Color.White;
            this.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.radRichTextEditor1.SelectionStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radRichTextEditor1.Size = new System.Drawing.Size(697, 257);
            this.radRichTextEditor1.TabIndex = 2;
            this.radRichTextEditor1.Text = resources.GetString("radRichTextEditor1.Text");
            this.radRichTextEditor1.ThemeName = "Windows8";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 468);
            this.Controls.Add(this.radRichTextEditor1);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaskForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполнение задания";
            this.ThemeName = "TelerikMetro";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
