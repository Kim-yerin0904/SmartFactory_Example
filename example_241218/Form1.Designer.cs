namespace example_241218
{
    partial class Form1
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonFalse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxResult.Location = new System.Drawing.Point(91, 193);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(428, 155);
            this.textBoxResult.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "result";
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(91, 90);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(100, 25);
            this.textBox_input.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "input";
            // 
            // radioButtonTrue
            // 
            this.radioButtonTrue.AutoSize = true;
            this.radioButtonTrue.Location = new System.Drawing.Point(91, 147);
            this.radioButtonTrue.Name = "radioButtonTrue";
            this.radioButtonTrue.Size = new System.Drawing.Size(52, 19);
            this.radioButtonTrue.TabIndex = 8;
            this.radioButtonTrue.TabStop = true;
            this.radioButtonTrue.Text = "true";
            this.radioButtonTrue.UseVisualStyleBackColor = true;
            this.radioButtonTrue.CheckedChanged += new System.EventHandler(this.radioButtonTrue_CheckedChanged);
            // 
            // radioButtonFalse
            // 
            this.radioButtonFalse.AutoSize = true;
            this.radioButtonFalse.Location = new System.Drawing.Point(212, 147);
            this.radioButtonFalse.Name = "radioButtonFalse";
            this.radioButtonFalse.Size = new System.Drawing.Size(59, 19);
            this.radioButtonFalse.TabIndex = 9;
            this.radioButtonFalse.TabStop = true;
            this.radioButtonFalse.Text = "false";
            this.radioButtonFalse.UseVisualStyleBackColor = true;
            this.radioButtonFalse.CheckedChanged += new System.EventHandler(this.radioButtonFalse_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonFalse);
            this.Controls.Add(this.radioButtonTrue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.RadioButton radioButtonFalse;
    }
}

