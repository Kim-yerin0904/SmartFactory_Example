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
            this.change_button = new System.Windows.Forms.Button();
            this.strength_change_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name_change_label = new System.Windows.Forms.Label();
            this.name_change_box = new System.Windows.Forms.TextBox();
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
            this.player_strength.ReadOnly = true;
            this.player_strength.Size = new System.Drawing.Size(132, 25);
            this.player_strength.TabIndex = 7;
            // 
            // user_attack_label
            // 
            this.user_attack_label.Location = new System.Drawing.Point(198, 128);
            this.user_attack_label.Name = "user_attack_label";
            this.user_attack_label.ReadOnly = true;
            this.user_attack_label.Size = new System.Drawing.Size(132, 25);
            this.user_attack_label.TabIndex = 8;
            // 
            // monster_strength_label
            // 
            this.monster_strength_label.Location = new System.Drawing.Point(506, 91);
            this.monster_strength_label.Name = "monster_strength_label";
            this.monster_strength_label.ReadOnly = true;
            this.monster_strength_label.Size = new System.Drawing.Size(132, 25);
            this.monster_strength_label.TabIndex = 9;
            // 
            // monster_attack_label
            // 
            this.monster_attack_label.Location = new System.Drawing.Point(506, 128);
            this.monster_attack_label.Name = "monster_attack_label";
            this.monster_attack_label.ReadOnly = true;
            this.monster_attack_label.Size = new System.Drawing.Size(132, 25);
            this.monster_attack_label.TabIndex = 10;
            // 
            // attack_button
            // 
            this.attack_button.Location = new System.Drawing.Point(340, 196);
            this.attack_button.Name = "attack_button";
            this.attack_button.Size = new System.Drawing.Size(94, 48);
            this.attack_button.TabIndex = 11;
            this.attack_button.Text = "공격!!";
            this.attack_button.UseVisualStyleBackColor = true;
            this.attack_button.Click += new System.EventHandler(this.attack_button_Click);
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(129, 381);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(85, 23);
            this.change_button.TabIndex = 12;
            this.change_button.Text = "변경";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // strength_change_box
            // 
            this.strength_change_box.Location = new System.Drawing.Point(109, 350);
            this.strength_change_box.Name = "strength_change_box";
            this.strength_change_box.Size = new System.Drawing.Size(132, 25);
            this.strength_change_box.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "체력";
            // 
            // name_change_label
            // 
            this.name_change_label.AutoSize = true;
            this.name_change_label.Location = new System.Drawing.Point(66, 319);
            this.name_change_label.Name = "name_change_label";
            this.name_change_label.Size = new System.Drawing.Size(37, 15);
            this.name_change_label.TabIndex = 15;
            this.name_change_label.Text = "이름";
            // 
            // name_change_box
            // 
            this.name_change_box.Location = new System.Drawing.Point(109, 319);
            this.name_change_box.Name = "name_change_box";
            this.name_change_box.Size = new System.Drawing.Size(132, 25);
            this.name_change_box.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.name_change_box);
            this.Controls.Add(this.name_change_label);
            this.Controls.Add(this.strength_change_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.change_button);
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
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.TextBox strength_change_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label name_change_label;
        private System.Windows.Forms.TextBox name_change_box;
    }
}

