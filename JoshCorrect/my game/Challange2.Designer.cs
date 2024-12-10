namespace my_game
{
    partial class Challange2
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
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.BigPic = new System.Windows.Forms.PictureBox();
            this.BigPic2 = new System.Windows.Forms.PictureBox();
            this.CloseForm = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPic2)).BeginInit();
            this.SuspendLayout();
            // 
            // Scissors
            // 
            this.Scissors.Image = global::my_game.Properties.Resources.scissors;
            this.Scissors.Location = new System.Drawing.Point(1147, 79);
            this.Scissors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(211, 172);
            this.Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Scissors.TabIndex = 2;
            this.Scissors.TabStop = false;
            // 
            // Paper
            // 
            this.Paper.Image = global::my_game.Properties.Resources.paper;
            this.Paper.Location = new System.Drawing.Point(835, 79);
            this.Paper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(211, 172);
            this.Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paper.TabIndex = 1;
            this.Paper.TabStop = false;
            // 
            // Rock
            // 
            this.Rock.Image = global::my_game.Properties.Resources.rock;
            this.Rock.Location = new System.Drawing.Point(515, 79);
            this.Rock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(211, 172);
            this.Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rock.TabIndex = 0;
            this.Rock.TabStop = false;
            // 
            // BigPic
            // 
            this.BigPic.Location = new System.Drawing.Point(515, 308);
            this.BigPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BigPic.Name = "BigPic";
            this.BigPic.Size = new System.Drawing.Size(843, 715);
            this.BigPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BigPic.TabIndex = 3;
            this.BigPic.TabStop = false;
            // 
            // BigPic2
            // 
            this.BigPic2.Location = new System.Drawing.Point(1891, 308);
            this.BigPic2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BigPic2.Name = "BigPic2";
            this.BigPic2.Size = new System.Drawing.Size(843, 715);
            this.BigPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BigPic2.TabIndex = 4;
            this.BigPic2.TabStop = false;
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(40, 79);
            this.CloseForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(261, 172);
            this.CloseForm.TabIndex = 5;
            this.CloseForm.Text = "Close Form";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(40, 308);
            this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(416, 339);
            this.start.TabIndex = 6;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(40, 662);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(392, 230);
            this.result.TabIndex = 7;
            // 
            // Challange2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3160, 1443);
            this.Controls.Add(this.result);
            this.Controls.Add(this.start);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.BigPic2);
            this.Controls.Add(this.BigPic);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Challange2";
            this.Text = "Challange2";
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.PictureBox Scissors;
        private System.Windows.Forms.PictureBox BigPic;
        private System.Windows.Forms.PictureBox BigPic2;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox result;
    }
}