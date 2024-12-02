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
            this.Scissors.Location = new System.Drawing.Point(430, 33);
            this.Scissors.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(79, 72);
            this.Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Scissors.TabIndex = 2;
            this.Scissors.TabStop = false;
            // 
            // Paper
            // 
            this.Paper.Image = global::my_game.Properties.Resources.paper;
            this.Paper.Location = new System.Drawing.Point(313, 33);
            this.Paper.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(79, 72);
            this.Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paper.TabIndex = 1;
            this.Paper.TabStop = false;
            // 
            // Rock
            // 
            this.Rock.Image = global::my_game.Properties.Resources.rock;
            this.Rock.Location = new System.Drawing.Point(193, 33);
            this.Rock.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(79, 72);
            this.Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rock.TabIndex = 0;
            this.Rock.TabStop = false;
            // 
            // BigPic
            // 
            this.BigPic.Location = new System.Drawing.Point(193, 129);
            this.BigPic.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BigPic.Name = "BigPic";
            this.BigPic.Size = new System.Drawing.Size(316, 300);
            this.BigPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BigPic.TabIndex = 3;
            this.BigPic.TabStop = false;
            // 
            // BigPic2
            // 
            this.BigPic2.Location = new System.Drawing.Point(709, 129);
            this.BigPic2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BigPic2.Name = "BigPic2";
            this.BigPic2.Size = new System.Drawing.Size(316, 300);
            this.BigPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BigPic2.TabIndex = 4;
            this.BigPic2.TabStop = false;
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(15, 33);
            this.CloseForm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(98, 72);
            this.CloseForm.TabIndex = 5;
            this.CloseForm.Text = "Close Form";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(15, 129);
            this.start.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(156, 142);
            this.start.TabIndex = 6;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Challange2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 605);
            this.Controls.Add(this.start);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.BigPic2);
            this.Controls.Add(this.BigPic);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Challange2";
            this.Text = "Challange2";
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.PictureBox Scissors;
        private System.Windows.Forms.PictureBox BigPic;
        private System.Windows.Forms.PictureBox BigPic2;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button start;
    }
}