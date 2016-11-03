namespace CliMate
{
    partial class Canvas
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
            this.tempPicBox = new System.Windows.Forms.PictureBox();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tempPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tempPicBox
            // 
            this.tempPicBox.Location = new System.Drawing.Point(13, 13);
            this.tempPicBox.Name = "tempPicBox";
            this.tempPicBox.Size = new System.Drawing.Size(826, 591);
            this.tempPicBox.TabIndex = 0;
            this.tempPicBox.TabStop = false;
            // 
            // tickTimer
            // 
            this.tickTimer.Enabled = true;
            this.tickTimer.Interval = 10;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 616);
            this.Controls.Add(this.tempPicBox);
            this.Name = "Canvas";
            this.Text = "Canvas";
            ((System.ComponentModel.ISupportInitialize)(this.tempPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tempPicBox;
        private System.Windows.Forms.Timer tickTimer;
    }
}