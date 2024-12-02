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
            this.StartBox = new System.Windows.Forms.PictureBox();
            this.GameBoard = new System.Windows.Forms.Panel();
            this.info1 = new System.Windows.Forms.Button();
            this.info2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).BeginInit();
            this.GameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBox
            // 
            this.StartBox.Image = global::my_game.Properties.Resources.start;
            this.StartBox.Location = new System.Drawing.Point(6, 13);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(155, 648);
            this.StartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartBox.TabIndex = 0;
            this.StartBox.TabStop = false;
            this.StartBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GameBoard
            // 
            this.GameBoard.Controls.Add(this.info1);
            this.GameBoard.Controls.Add(this.info2);
            this.GameBoard.Location = new System.Drawing.Point(167, 13);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(906, 647);
            this.GameBoard.TabIndex = 2;
            // 
            // info1
            // 
            this.info1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.Location = new System.Drawing.Point(29, 20);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(853, 416);
            this.info1.TabIndex = 3;
            this.info1.Text = "Hello challenger! You need to make your way across the board completing challenge" +
    "s as you go to eventually reach the finish line and become victorious!";
            this.info1.UseVisualStyleBackColor = true;
            // 
            // info2
            // 
            this.info2.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.Location = new System.Drawing.Point(29, 455);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(853, 146);
            this.info2.TabIndex = 2;
            this.info2.Text = "<--  Click start to begin you challenge! ";
            this.info2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::my_game.Properties.Resources.finishproper;
            this.pictureBox2.Location = new System.Drawing.Point(1077, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 647);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 744);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.StartBox);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).EndInit();
            this.GameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartBox;
        private System.Windows.Forms.Panel GameBoard;
        private System.Windows.Forms.Button info1;
        private System.Windows.Forms.Button info2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

