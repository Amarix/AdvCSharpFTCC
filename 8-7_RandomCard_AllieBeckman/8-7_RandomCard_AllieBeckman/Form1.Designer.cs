namespace _8_7_RandomCard_AllieBeckman
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRandCard = new System.Windows.Forms.Button();
            this.cardImageList = new System.Windows.Forms.ImageList(this.components);
            this.cardPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandCard
            // 
            this.btnRandCard.Location = new System.Drawing.Point(12, 161);
            this.btnRandCard.Name = "btnRandCard";
            this.btnRandCard.Size = new System.Drawing.Size(110, 34);
            this.btnRandCard.TabIndex = 0;
            this.btnRandCard.Text = "Get Random Card";
            this.btnRandCard.UseVisualStyleBackColor = true;
            this.btnRandCard.Click += new System.EventHandler(this.btnRandCard_Click);
            // 
            // cardImageList
            // 
            this.cardImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cardImageList.ImageStream")));
            this.cardImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.cardImageList.Images.SetKeyName(0, "1.jpg");
            this.cardImageList.Images.SetKeyName(1, "2.jpg");
            this.cardImageList.Images.SetKeyName(2, "3.jpg");
            this.cardImageList.Images.SetKeyName(3, "4.jpg");
            this.cardImageList.Images.SetKeyName(4, "5.jpg");
            this.cardImageList.Images.SetKeyName(5, "6.jpg");
            this.cardImageList.Images.SetKeyName(6, "7.jpg");
            this.cardImageList.Images.SetKeyName(7, "8.jpg");
            this.cardImageList.Images.SetKeyName(8, "9.jpg");
            this.cardImageList.Images.SetKeyName(9, "10.jpg");
            this.cardImageList.Images.SetKeyName(10, "11.jpg");
            this.cardImageList.Images.SetKeyName(11, "12.jpg");
            this.cardImageList.Images.SetKeyName(12, "13.jpg");
            this.cardImageList.Images.SetKeyName(13, "14.jpg");
            this.cardImageList.Images.SetKeyName(14, "15.jpg");
            this.cardImageList.Images.SetKeyName(15, "16.jpg");
            this.cardImageList.Images.SetKeyName(16, "17.jpg");
            this.cardImageList.Images.SetKeyName(17, "18.jpg");
            this.cardImageList.Images.SetKeyName(18, "19.jpg");
            this.cardImageList.Images.SetKeyName(19, "20.jpg");
            this.cardImageList.Images.SetKeyName(20, "21.jpg");
            this.cardImageList.Images.SetKeyName(21, "22.jpg");
            this.cardImageList.Images.SetKeyName(22, "23.jpg");
            this.cardImageList.Images.SetKeyName(23, "24.jpg");
            this.cardImageList.Images.SetKeyName(24, "25.jpg");
            this.cardImageList.Images.SetKeyName(25, "26.jpg");
            this.cardImageList.Images.SetKeyName(26, "27.jpg");
            this.cardImageList.Images.SetKeyName(27, "28.jpg");
            this.cardImageList.Images.SetKeyName(28, "29.jpg");
            this.cardImageList.Images.SetKeyName(29, "30.jpg");
            this.cardImageList.Images.SetKeyName(30, "31.jpg");
            this.cardImageList.Images.SetKeyName(31, "32.jpg");
            this.cardImageList.Images.SetKeyName(32, "33.jpg");
            this.cardImageList.Images.SetKeyName(33, "34.jpg");
            this.cardImageList.Images.SetKeyName(34, "35.jpg");
            this.cardImageList.Images.SetKeyName(35, "36.jpg");
            this.cardImageList.Images.SetKeyName(36, "37.jpg");
            this.cardImageList.Images.SetKeyName(37, "38.jpg");
            this.cardImageList.Images.SetKeyName(38, "39.jpg");
            this.cardImageList.Images.SetKeyName(39, "40.jpg");
            this.cardImageList.Images.SetKeyName(40, "41.jpg");
            this.cardImageList.Images.SetKeyName(41, "42.jpg");
            this.cardImageList.Images.SetKeyName(42, "43.jpg");
            this.cardImageList.Images.SetKeyName(43, "44.jpg");
            this.cardImageList.Images.SetKeyName(44, "45.jpg");
            this.cardImageList.Images.SetKeyName(45, "46.jpg");
            this.cardImageList.Images.SetKeyName(46, "47.jpg");
            this.cardImageList.Images.SetKeyName(47, "48.jpg");
            this.cardImageList.Images.SetKeyName(48, "49.jpg");
            this.cardImageList.Images.SetKeyName(49, "50.jpg");
            // 
            // cardPictureBox
            // 
            this.cardPictureBox.BackgroundImage = global::_8_7_RandomCard_AllieBeckman.Properties.Resources.tumblr_nqw5ltp9b81uz2252o1_1280;
            this.cardPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardPictureBox.Location = new System.Drawing.Point(12, 12);
            this.cardPictureBox.Name = "cardPictureBox";
            this.cardPictureBox.Size = new System.Drawing.Size(110, 143);
            this.cardPictureBox.TabIndex = 1;
            this.cardPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 207);
            this.Controls.Add(this.cardPictureBox);
            this.Controls.Add(this.btnRandCard);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandCard;
        private System.Windows.Forms.ImageList cardImageList;
        private System.Windows.Forms.PictureBox cardPictureBox;
    }
}

