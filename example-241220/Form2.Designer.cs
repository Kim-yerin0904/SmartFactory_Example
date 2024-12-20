namespace example_241220
{
    partial class Form2
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
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonScissors
            // 
            this.buttonScissors.Location = new System.Drawing.Point(108, 87);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(75, 23);
            this.buttonScissors.TabIndex = 0;
            this.buttonScissors.Text = "가위";
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // buttonRock
            // 
            this.buttonRock.Location = new System.Drawing.Point(203, 87);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(75, 23);
            this.buttonRock.TabIndex = 1;
            this.buttonRock.Text = "바위";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(302, 87);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(75, 23);
            this.buttonPaper.TabIndex = 2;
            this.buttonPaper.Text = "보";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "안 내면 진거 가위~ 바위~ 보~";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(63, 133);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(490, 244);
            this.textBoxResult.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.buttonScissors);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}