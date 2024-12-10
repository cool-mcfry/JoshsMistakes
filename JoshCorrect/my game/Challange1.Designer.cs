namespace my_game
{
    partial class Challange1
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
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.submit = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Finish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(1699, 29);
            this.PicBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(1355, 644);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(35, 31);
            this.submit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(872, 446);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(32, 1259);
            this.Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(1727, 272);
            this.Label.TabIndex = 2;
            this.Label.Text = "Guess the film!";
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(35, 504);
            this.TextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(1384, 643);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "Write your answer here.";
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(968, 29);
            this.Finish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(317, 196);
            this.Finish.TabIndex = 4;
            this.Finish.Text = "close form";
            this.Finish.UseVisualStyleBackColor = true;
            // 
            // Challange1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2517, 1524);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.PicBox);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Challange1";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Finish;
    }
}