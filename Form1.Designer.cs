namespace TextExtractor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_open = new System.Windows.Forms.Button();
            this.button_recognize = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(12, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(380, 32);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_recognize
            // 
            this.button_recognize.Location = new System.Drawing.Point(408, 12);
            this.button_recognize.Name = "button_recognize";
            this.button_recognize.Size = new System.Drawing.Size(380, 32);
            this.button_recognize.TabIndex = 1;
            this.button_recognize.Text = "Recognize";
            this.button_recognize.UseVisualStyleBackColor = true;
            this.button_recognize.Click += new System.EventHandler(this.button_recognize_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 50);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(776, 388);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            this.outputTextBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.button_recognize);
            this.Controls.Add(this.button_open);
            this.Name = "Form1";
            this.Text = "Text Extractor";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_open;
        private Button button_recognize;
        private RichTextBox outputTextBox;
    }
}