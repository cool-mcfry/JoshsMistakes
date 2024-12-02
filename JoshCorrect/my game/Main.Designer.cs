namespace my_game
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartBox = new System.Windows.Forms.PictureBox();
            this.GameBoard = new System.Windows.Forms.Panel();
            this.info1 = new System.Windows.Forms.Button();
            this.info2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).BeginInit();
            this.GameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::my_game.Properties.Resources.finishproper;
            this.pictureBox1.Location = new System.Drawing.Point(3723, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 1545);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StartBox
            // 
            this.StartBox.Image = global::my_game.Properties.Resources.start;
            this.StartBox.Location = new System.Drawing.Point(17, 31);
            this.StartBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(413, 1545);
            this.StartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartBox.TabIndex = 0;
            this.StartBox.TabStop = false;
            this.StartBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GameBoard
            // 
            this.GameBoard.Controls.Add(this.info1);
            this.GameBoard.Controls.Add(this.info2);
            this.GameBoard.Location = new System.Drawing.Point(446, 31);
            this.GameBoard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(2415, 1543);
            this.GameBoard.TabIndex = 2;
            // 
            // info1
            // 
            this.info1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.Location = new System.Drawing.Point(77, 48);
            this.info1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(2275, 992);
            this.info1.TabIndex = 3;
            this.info1.Text = "Hello challenger! You need to make your way across the board completing challenge" +
    "s as you go to eventually reach the finish line and become victorious!";
            this.info1.UseVisualStyleBackColor = true;
            // 
            // info2
            // 
            this.info2.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.Location = new System.Drawing.Point(77, 1086);
            this.info2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(2275, 348);
            this.info2.TabIndex = 2;
            this.info2.Text = "<--  Click start to begin you challenge! ";
            this.info2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::my_game.Properties.Resources.finishproper;
            this.pictureBox2.Location = new System.Drawing.Point(2872, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 1543);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3204, 1650);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartBox);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).EndInit();
            this.GameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel GameBoard;
        private System.Windows.Forms.Button info1;
        private System.Windows.Forms.Button info2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

