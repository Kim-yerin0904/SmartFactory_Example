namespace example_250109
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
            this.addevent_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.callevent_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addevent_button
            // 
            this.addevent_button.Location = new System.Drawing.Point(162, 35);
            this.addevent_button.Name = "addevent_button";
            this.addevent_button.Size = new System.Drawing.Size(121, 98);
            this.addevent_button.TabIndex = 0;
            this.addevent_button.Text = "이벤트 추가";
            this.addevent_button.UseVisualStyleBackColor = true;
            this.addevent_button.Click += new System.EventHandler(this.addevent_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 226);
            this.textBox1.TabIndex = 1;
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(333, 35);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(115, 98);
            this.remove_button.TabIndex = 2;
            this.remove_button.Text = "이벤트 삭제";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // callevent_button
            // 
            this.callevent_button.Location = new System.Drawing.Point(511, 35);
            this.callevent_button.Name = "callevent_button";
            this.callevent_button.Size = new System.Drawing.Size(115, 98);
            this.callevent_button.TabIndex = 3;
            this.callevent_button.Text = "이벤트 실행";
            this.callevent_button.UseVisualStyleBackColor = true;
            this.callevent_button.Click += new System.EventHandler(this.callevent_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.callevent_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addevent_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addevent_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button callevent_button;
    }
}

