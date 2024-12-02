namespace my_game
{
    partial class memory
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
            this.Start = new System.Windows.Forms.Button();
            this.MemoryBoard = new System.Windows.Forms.Panel();
            this.Ready = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(32, 29);
            this.Start.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(1291, 596);
            this.Start.TabIndex = 0;
            this.Start.Text = "START!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MemoryBoard
            // 
            this.MemoryBoard.Location = new System.Drawing.Point(1477, 29);
            this.MemoryBoard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MemoryBoard.Name = "MemoryBoard";
            this.MemoryBoard.Size = new System.Drawing.Size(2011, 1486);
            this.MemoryBoard.TabIndex = 1;
            // 
            // Ready
            // 
            this.Ready.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ready.Location = new System.Drawing.Point(32, 952);
            this.Ready.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Ready.Name = "Ready";
            this.Ready.Size = new System.Drawing.Size(1291, 575);
            this.Ready.TabIndex = 2;
            this.Ready.Text = "READY!";
            this.Ready.UseVisualStyleBackColor = true;
            this.Ready.Click += new System.EventHandler(this.Ready_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(32, 652);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(400, 271);
            this.CloseForm.TabIndex = 3;
            this.CloseForm.Text = "Close form";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(918, 652);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(404, 271);
            this.Right.TabIndex = 4;
            this.Right.UseVisualStyleBackColor = true;
            // 
            // memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3204, 1543);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.Ready);
            this.Controls.Add(this.MemoryBoard);
            this.Controls.Add(this.Start);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "memory";
            this.Text = "memory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel MemoryBoard;
        private System.Windows.Forms.Button Ready;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button Right;
    }
}