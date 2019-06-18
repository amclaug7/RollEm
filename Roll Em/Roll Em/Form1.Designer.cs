namespace Roll_Em
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.pbxDie1 = new System.Windows.Forms.PictureBox();
            this.pbxDie2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(13, 119);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(226, 23);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Em";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // pbxDie1
            // 
            this.pbxDie1.Location = new System.Drawing.Point(13, 13);
            this.pbxDie1.Name = "pbxDie1";
            this.pbxDie1.Size = new System.Drawing.Size(100, 100);
            this.pbxDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDie1.TabIndex = 1;
            this.pbxDie1.TabStop = false;
            // 
            // pbxDie2
            // 
            this.pbxDie2.Location = new System.Drawing.Point(139, 13);
            this.pbxDie2.Name = "pbxDie2";
            this.pbxDie2.Size = new System.Drawing.Size(100, 100);
            this.pbxDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDie2.TabIndex = 2;
            this.pbxDie2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 158);
            this.Controls.Add(this.pbxDie2);
            this.Controls.Add(this.pbxDie1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Form1";
            this.Text = "Crap Table";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.PictureBox pbxDie1;
        private System.Windows.Forms.PictureBox pbxDie2;
    }
}

