
namespace Slang.NET
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_Talk = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Resume = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(16, 15);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(321, 213);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "";
            // 
            // btn_Talk
            // 
            this.btn_Talk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Talk.Location = new System.Drawing.Point(15, 232);
            this.btn_Talk.Name = "btn_Talk";
            this.btn_Talk.Size = new System.Drawing.Size(75, 23);
            this.btn_Talk.TabIndex = 1;
            this.btn_Talk.Text = "Talk";
            this.btn_Talk.UseVisualStyleBackColor = true;
            this.btn_Talk.Click += new System.EventHandler(this.btn_Talk_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Pause.Location = new System.Drawing.Point(97, 231);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(75, 23);
            this.btn_Pause.TabIndex = 2;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            // 
            // btn_Resume
            // 
            this.btn_Resume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Resume.Location = new System.Drawing.Point(179, 231);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.Size = new System.Drawing.Size(75, 23);
            this.btn_Resume.TabIndex = 3;
            this.btn_Resume.Text = "Resume";
            this.btn_Resume.UseVisualStyleBackColor = true;
            // 
            // btn_Quit
            // 
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Quit.Location = new System.Drawing.Point(261, 231);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(75, 23);
            this.btn_Quit.TabIndex = 4;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 263);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Resume);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Talk);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.Text = "Slang.NET";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.Button btn_Talk;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Resume;
        private System.Windows.Forms.Button btn_Quit;
    }
}

