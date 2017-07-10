namespace Beckman_Homework7_1
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
            this.calculateTotalSales = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.highestSaleLabel = new System.Windows.Forms.Label();
            this.lowestSaleLabel = new System.Windows.Forms.Label();
            this.averageSaleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateTotalSales
            // 
            this.calculateTotalSales.Location = new System.Drawing.Point(97, 163);
            this.calculateTotalSales.Name = "calculateTotalSales";
            this.calculateTotalSales.Size = new System.Drawing.Size(59, 44);
            this.calculateTotalSales.TabIndex = 0;
            this.calculateTotalSales.Text = "Calculate Total";
            this.calculateTotalSales.UseVisualStyleBackColor = true;
            this.calculateTotalSales.Click += new System.EventHandler(this.calculateTotalSales_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 163);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 44);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // salesListBox
            // 
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.Location = new System.Drawing.Point(1, 37);
            this.salesListBox.Name = "salesListBox";
            this.salesListBox.Size = new System.Drawing.Size(155, 95);
            this.salesListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Sales: ";
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSalesLabel.Location = new System.Drawing.Point(270, 112);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(58, 25);
            this.totalSalesLabel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Highest Sales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lowest Sales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Average Sales:";
            // 
            // highestSaleLabel
            // 
            this.highestSaleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.highestSaleLabel.Location = new System.Drawing.Point(270, 25);
            this.highestSaleLabel.Name = "highestSaleLabel";
            this.highestSaleLabel.Size = new System.Drawing.Size(58, 25);
            this.highestSaleLabel.TabIndex = 9;
            // 
            // lowestSaleLabel
            // 
            this.lowestSaleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lowestSaleLabel.Location = new System.Drawing.Point(270, 56);
            this.lowestSaleLabel.Name = "lowestSaleLabel";
            this.lowestSaleLabel.Size = new System.Drawing.Size(58, 25);
            this.lowestSaleLabel.TabIndex = 10;
            // 
            // averageSaleLabel
            // 
            this.averageSaleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageSaleLabel.Location = new System.Drawing.Point(270, 85);
            this.averageSaleLabel.Name = "averageSaleLabel";
            this.averageSaleLabel.Size = new System.Drawing.Size(58, 25);
            this.averageSaleLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 213);
            this.Controls.Add(this.averageSaleLabel);
            this.Controls.Add(this.lowestSaleLabel);
            this.Controls.Add(this.highestSaleLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateTotalSales);
            this.Name = "Form1";
            this.Text = "Total Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateTotalSales;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox salesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label highestSaleLabel;
        private System.Windows.Forms.Label lowestSaleLabel;
        private System.Windows.Forms.Label averageSaleLabel;
    }
}

