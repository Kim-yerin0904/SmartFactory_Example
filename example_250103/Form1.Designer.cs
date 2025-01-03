namespace example_250103
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
            this.fileopen_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileopen_button
            // 
            this.fileopen_button.Location = new System.Drawing.Point(47, 35);
            this.fileopen_button.Name = "fileopen_button";
            this.fileopen_button.Size = new System.Drawing.Size(149, 23);
            this.fileopen_button.TabIndex = 0;
            this.fileopen_button.Text = "File Open";
            this.fileopen_button.UseVisualStyleBackColor = true;
            this.fileopen_button.Click += new System.EventHandler(this.fileopen_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(205, 121);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(126, 25);
            this.textBox_id.TabIndex = 2;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(347, 121);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 67);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(205, 163);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.Size = new System.Drawing.Size(126, 25);
            this.textBox_pw.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileopen_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileopen_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Label label2;
    }
}

