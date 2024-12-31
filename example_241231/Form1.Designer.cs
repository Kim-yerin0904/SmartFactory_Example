namespace example_241231
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.player_label = new System.Windows.Forms.Label();
            this.monster_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player_strength = new System.Windows.Forms.TextBox();
            this.user_attack_label = new System.Windows.Forms.TextBox();
            this.monster_strength_label = new System.Windows.Forms.TextBox();
            this.monster_attack_label = new System.Windows.Forms.TextBox();
            this.attack_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "체력";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "체력";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "공격력";
            // 
            // player_label
            // 
            this.player_label.AutoSize = true;
            this.player_label.Location = new System.Drawing.Point(237, 62);
            this.player_label.Name = "player_label";
            this.player_label.Size = new System.Drawing.Size(48, 15);
            this.player_label.TabIndex = 4;
            this.player_label.Text = "Player";
            // 
            // monster_label
            // 
            this.monster_label.AutoSize = true;
            this.monster_label.Location = new System.Drawing.Point(545, 62);
            this.monster_label.Name = "monster_label";
            this.monster_label.Size = new System.Drawing.Size(60, 15);
            this.monster_label.TabIndex = 5;
            this.monster_label.Text = "Monster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "공격력";
            // 
            // player_strength
            // 
            this.player_strength.Location = new System.Drawing.Point(198, 92);
            this.player_strength.Name = "player_strength";
            this.player_strength.Size = new System.Drawing.Size(132, 25);
            this.player_strength.TabIndex = 7;
            // 
            // user_attack_label
            // 
            this.user_attack_label.Location = new System.Drawing.Point(198, 128);
            this.user_attack_label.Name = "user_attack_label";
            this.user_attack_label.Size = new System.Drawing.Size(132, 25);
            this.user_attack_label.TabIndex = 8;
            // 
            // monster_strength_label
            // 
            this.monster_strength_label.Location = new System.Drawing.Point(506, 91);
            this.monster_strength_label.Name = "monster_strength_label";
            this.monster_strength_label.Size = new System.Drawing.Size(132, 25);
            this.monster_strength_label.TabIndex = 9;
            // 
            // monster_attack_label
            // 
            this.monster_attack_label.Location = new System.Drawing.Point(506, 128);
            this.monster_attack_label.Name = "monster_attack_label";
            this.monster_attack_label.Size = new System.Drawing.Size(132, 25);
            this.monster_attack_label.TabIndex = 10;
            // 
            // attack_button
            // 
            this.attack_button.Location = new System.Drawing.Point(213, 197);
            this.attack_button.Name = "attack_button";
            this.attack_button.Size = new System.Drawing.Size(94, 48);
            this.attack_button.TabIndex = 11;
            this.attack_button.Text = "공격!!";
            this.attack_button.UseVisualStyleBackColor = true;
            this.attack_button.Click += new System.EventHandler(this.attack_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.attack_button);
            this.Controls.Add(this.monster_attack_label);
            this.Controls.Add(this.monster_strength_label);
            this.Controls.Add(this.user_attack_label);
            this.Controls.Add(this.player_strength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monster_label);
            this.Controls.Add(this.player_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label player_label;
        private System.Windows.Forms.Label monster_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player_strength;
        private System.Windows.Forms.TextBox user_attack_label;
        private System.Windows.Forms.TextBox monster_strength_label;
        private System.Windows.Forms.TextBox monster_attack_label;
        private System.Windows.Forms.Button attack_button;
    }
}

