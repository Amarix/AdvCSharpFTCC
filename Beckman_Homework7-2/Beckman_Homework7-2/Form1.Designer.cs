namespace Beckman_Homework7_2
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
            this.displayMonsterBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.monsterNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.healthLabel = new System.Windows.Forms.Label();
            this.staminaLabel = new System.Windows.Forms.Label();
            this.manaLabel = new System.Windows.Forms.Label();
            this.armorLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.monsterListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayMonsterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // displayMonsterBox
            // 
            this.displayMonsterBox.BackgroundImage = global::Beckman_Homework7_2.Properties.Resources.whatIsit;
            this.displayMonsterBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayMonsterBox.Location = new System.Drawing.Point(12, 37);
            this.displayMonsterBox.Name = "displayMonsterBox";
            this.displayMonsterBox.Size = new System.Drawing.Size(222, 213);
            this.displayMonsterBox.TabIndex = 0;
            this.displayMonsterBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Health";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(211, 271);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // monsterNameLabel
            // 
            this.monsterNameLabel.AutoSize = true;
            this.monsterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterNameLabel.Location = new System.Drawing.Point(12, 14);
            this.monsterNameLabel.Name = "monsterNameLabel";
            this.monsterNameLabel.Size = new System.Drawing.Size(113, 20);
            this.monsterNameLabel.TabIndex = 3;
            this.monsterNameLabel.Text = "Monster Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stamina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Armor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Strength";
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(114, 271);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 8;
            this.leftButton.Text = "Back";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // healthLabel
            // 
            this.healthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.healthLabel.Location = new System.Drawing.Point(309, 28);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(73, 22);
            this.healthLabel.TabIndex = 9;
            // 
            // staminaLabel
            // 
            this.staminaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.staminaLabel.Location = new System.Drawing.Point(309, 62);
            this.staminaLabel.Name = "staminaLabel";
            this.staminaLabel.Size = new System.Drawing.Size(73, 22);
            this.staminaLabel.TabIndex = 10;
            // 
            // manaLabel
            // 
            this.manaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manaLabel.Location = new System.Drawing.Point(309, 97);
            this.manaLabel.Name = "manaLabel";
            this.manaLabel.Size = new System.Drawing.Size(73, 22);
            this.manaLabel.TabIndex = 11;
            // 
            // armorLabel
            // 
            this.armorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.armorLabel.Location = new System.Drawing.Point(309, 128);
            this.armorLabel.Name = "armorLabel";
            this.armorLabel.Size = new System.Drawing.Size(73, 22);
            this.armorLabel.TabIndex = 12;
            // 
            // strengthLabel
            // 
            this.strengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.strengthLabel.Location = new System.Drawing.Point(309, 163);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(73, 22);
            this.strengthLabel.TabIndex = 13;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(159, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // monsterListBox
            // 
            this.monsterListBox.FormattingEnabled = true;
            this.monsterListBox.Location = new System.Drawing.Point(292, 248);
            this.monsterListBox.Name = "monsterListBox";
            this.monsterListBox.Size = new System.Drawing.Size(120, 95);
            this.monsterListBox.TabIndex = 15;
            this.monsterListBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Intelligence";
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.intelligenceLabel.Location = new System.Drawing.Point(309, 193);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(73, 22);
            this.intelligenceLabel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 339);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monsterListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.armorLabel);
            this.Controls.Add(this.manaLabel);
            this.Controls.Add(this.staminaLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monsterNameLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayMonsterBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayMonsterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox displayMonsterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label monsterNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label staminaLabel;
        private System.Windows.Forms.Label manaLabel;
        private System.Windows.Forms.Label armorLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox monsterListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label intelligenceLabel;
    }
}

