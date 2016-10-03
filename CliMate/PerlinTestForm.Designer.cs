namespace CliMate
{
    partial class PerlinTestForm
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
            this.seedBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.seedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(57, 60);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(120, 22);
            this.seedBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "seed";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(15, 88);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(77, 34);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(57, 175);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(273, 200);
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // PerlinTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 449);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seedBox);
            this.Name = "PerlinTestForm";
            this.Text = "PerlinTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.seedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown seedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.PictureBox picBox;
    }
}