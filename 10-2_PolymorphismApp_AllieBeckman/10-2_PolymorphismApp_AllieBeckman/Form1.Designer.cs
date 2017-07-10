namespace _10_2_PolymorphismApp_AllieBeckman
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
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.createDogButton = new System.Windows.Forms.Button();
            this.createCatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(12, 12);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(93, 75);
            this.createAnimalButton.TabIndex = 0;
            this.createAnimalButton.Text = "Create an Animal";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createDogButton
            // 
            this.createDogButton.Location = new System.Drawing.Point(111, 12);
            this.createDogButton.Name = "createDogButton";
            this.createDogButton.Size = new System.Drawing.Size(93, 75);
            this.createDogButton.TabIndex = 1;
            this.createDogButton.Text = "Create a Dog";
            this.createDogButton.UseVisualStyleBackColor = true;
            this.createDogButton.Click += new System.EventHandler(this.createDogButton_Click);
            // 
            // createCatButton
            // 
            this.createCatButton.Location = new System.Drawing.Point(210, 12);
            this.createCatButton.Name = "createCatButton";
            this.createCatButton.Size = new System.Drawing.Size(93, 75);
            this.createCatButton.TabIndex = 2;
            this.createCatButton.Text = "Create a Cat";
            this.createCatButton.UseVisualStyleBackColor = true;
            this.createCatButton.Click += new System.EventHandler(this.createCatButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(111, 93);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 75);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 177);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createCatButton);
            this.Controls.Add(this.createDogButton);
            this.Controls.Add(this.createAnimalButton);
            this.Name = "Form1";
            this.Text = "Polymorphism Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button createDogButton;
        private System.Windows.Forms.Button createCatButton;
        private System.Windows.Forms.Button exitButton;
    }
}

