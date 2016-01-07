using System.ComponentModel;
using System.Windows.Forms;

namespace SVTranscoder
{
    sealed partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FindFileBtn = new System.Windows.Forms.Button();
            this.FindFolderBtn = new System.Windows.Forms.Button();
            this.TranscodeBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FindFileBtn
            // 
            this.FindFileBtn.Location = new System.Drawing.Point(12, 38);
            this.FindFileBtn.Name = "FindFileBtn";
            this.FindFileBtn.Size = new System.Drawing.Size(125, 23);
            this.FindFileBtn.TabIndex = 1;
            this.FindFileBtn.Text = "Find File";
            this.FindFileBtn.UseVisualStyleBackColor = true;
            this.FindFileBtn.Click += new System.EventHandler(this.FindFileBtn_Click);
            // 
            // FindFolderBtn
            // 
            this.FindFolderBtn.Location = new System.Drawing.Point(147, 38);
            this.FindFolderBtn.Name = "FindFolderBtn";
            this.FindFolderBtn.Size = new System.Drawing.Size(125, 23);
            this.FindFolderBtn.TabIndex = 2;
            this.FindFolderBtn.Text = "Find Folder";
            this.FindFolderBtn.UseVisualStyleBackColor = true;
            this.FindFolderBtn.Click += new System.EventHandler(this.FindFolderBtn_Click);
            // 
            // TranscodeBtn
            // 
            this.TranscodeBtn.Location = new System.Drawing.Point(12, 64);
            this.TranscodeBtn.Name = "TranscodeBtn";
            this.TranscodeBtn.Size = new System.Drawing.Size(125, 23);
            this.TranscodeBtn.TabIndex = 3;
            this.TranscodeBtn.Text = "Encode/Decode";
            this.TranscodeBtn.UseVisualStyleBackColor = true;
            this.TranscodeBtn.Click += new System.EventHandler(this.TranscodeBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Windom SV Mode"});
            this.comboBox1.Location = new System.Drawing.Point(147, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(12, 12);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(260, 20);
            this.PathTextBox.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(15, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Batch Transcode Specific Files";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = ".bmp|.dds|.jpg|.png|.x";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 145);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FindFolderBtn);
            this.Controls.Add(this.TranscodeBtn);
            this.Controls.Add(this.FindFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Transcoder 0.0.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FindFileBtn;
        private Button FindFolderBtn;
        private Button TranscodeBtn;
        private ComboBox comboBox1;
        private TextBox PathTextBox;
        private CheckBox checkBox1;
        private TextBox textBox1;
    }
}

