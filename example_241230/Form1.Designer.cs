namespace example_241230
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changePrint = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(91, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "~ 자판기 ~ ";
            // 
            // inputMoney
            // 
            this.inputMoney.Location = new System.Drawing.Point(112, 135);
            this.inputMoney.Name = "inputMoney";
            this.inputMoney.Size = new System.Drawing.Size(100, 25);
            this.inputMoney.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = " 투입 금액";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "거스름 돈";
            // 
            // changePrint
            // 
            this.changePrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changePrint.Location = new System.Drawing.Point(112, 178);
            this.changePrint.Name = "changePrint";
            this.changePrint.ReadOnly = true;
            this.changePrint.Size = new System.Drawing.Size(100, 25);
            this.changePrint.TabIndex = 4;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(32, 224);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(247, 189);
            this.resultBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "커피 : 1200원";
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(229, 135);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(51, 23);
            this.inputButton.TabIndex = 7;
            this.inputButton.Text = "투입";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.changePrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputMoney);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changePrint;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button inputButton;
    }
}

