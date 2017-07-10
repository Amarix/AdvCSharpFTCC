namespace AllieBeckman_8._1
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
            this.countButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.letterCountLabel = new System.Windows.Forms.Label();
            this.cappedSentenceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count Words and Letters";
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(46, 279);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 39);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(50, 37);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(246, 20);
            this.userTextBox.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(226, 279);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCountLabel.Location = new System.Drawing.Point(185, 74);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(100, 56);
            this.wordCountLabel.TabIndex = 4;
            this.wordCountLabel.Text = "0";
            this.wordCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letterCountLabel
            // 
            this.letterCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.letterCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterCountLabel.Location = new System.Drawing.Point(185, 140);
            this.letterCountLabel.Name = "letterCountLabel";
            this.letterCountLabel.Size = new System.Drawing.Size(100, 56);
            this.letterCountLabel.TabIndex = 5;
            this.letterCountLabel.Text = "0";
            this.letterCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cappedSentenceLabel
            // 
            this.cappedSentenceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cappedSentenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cappedSentenceLabel.Location = new System.Drawing.Point(46, 209);
            this.cappedSentenceLabel.Name = "cappedSentenceLabel";
            this.cappedSentenceLabel.Size = new System.Drawing.Size(255, 55);
            this.cappedSentenceLabel.TabIndex = 6;
            this.cappedSentenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Word count: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Letter count: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cappedSentenceLabel);
            this.Controls.Add(this.letterCountLabel);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Label letterCountLabel;
        private System.Windows.Forms.Label cappedSentenceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

