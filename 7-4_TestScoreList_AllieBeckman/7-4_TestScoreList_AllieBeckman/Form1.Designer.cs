namespace _7_4_TestScoreList_AllieBeckman
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
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.averageLabel1 = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.belowAverageLabel1 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.Location = new System.Drawing.Point(12, 22);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(120, 95);
            this.testScoresListBox.TabIndex = 0;
            // 
            // averageLabel1
            // 
            this.averageLabel1.AutoSize = true;
            this.averageLabel1.Location = new System.Drawing.Point(248, 34);
            this.averageLabel1.Name = "averageLabel1";
            this.averageLabel1.Size = new System.Drawing.Size(81, 13);
            this.averageLabel1.TabIndex = 1;
            this.averageLabel1.Text = "Average Score:";
            this.averageLabel1.Click += new System.EventHandler(this.averageLabel_Click);
            // 
            // getScoresButton
            // 
            this.getScoresButton.Location = new System.Drawing.Point(160, 164);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(75, 23);
            this.getScoresButton.TabIndex = 2;
            this.getScoresButton.Text = "Get Scores";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Scores Above Average:";
            // 
            // belowAverageLabel1
            // 
            this.belowAverageLabel1.AutoSize = true;
            this.belowAverageLabel1.Location = new System.Drawing.Point(159, 104);
            this.belowAverageLabel1.Name = "belowAverageLabel1";
            this.belowAverageLabel1.Size = new System.Drawing.Size(170, 13);
            this.belowAverageLabel1.TabIndex = 4;
            this.belowAverageLabel1.Text = "Number of Scores Below Average:";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageLabel.Location = new System.Drawing.Point(350, 22);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(127, 25);
            this.averageLabel.TabIndex = 5;
            this.averageLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(251, 164);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboveAverageLabel
            // 
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aboveAverageLabel.Location = new System.Drawing.Point(350, 58);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(127, 25);
            this.aboveAverageLabel.TabIndex = 7;
            // 
            // belowAverageLabel
            // 
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.belowAverageLabel.Location = new System.Drawing.Point(350, 93);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(127, 25);
            this.belowAverageLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(493, 201);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.belowAverageLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averageLabel1);
            this.Controls.Add(this.testScoresListBox);
            this.Name = "Form1";
            this.Text = "Test Score List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label averageLabel1;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label belowAverageLabel1;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
    }
}

