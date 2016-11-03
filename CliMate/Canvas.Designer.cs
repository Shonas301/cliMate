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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.toolboxPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tempPicBox)).BeginInit();
            this.drawingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempPicBox
            // 
            this.tempPicBox.Location = new System.Drawing.Point(3, 3);
            this.tempPicBox.Name = "tempPicBox";
            this.tempPicBox.Size = new System.Drawing.Size(579, 445);
            this.tempPicBox.TabIndex = 0;
            this.tempPicBox.TabStop = false;
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 10;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // drawingPanel
            // 
            this.drawingPanel.AutoScroll = true;
            this.drawingPanel.Controls.Add(this.tempPicBox);
            this.drawingPanel.Location = new System.Drawing.Point(12, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(608, 472);
            this.drawingPanel.TabIndex = 1;
            // 
            // toolboxPanel
            // 
            this.toolboxPanel.Location = new System.Drawing.Point(707, 15);
            this.toolboxPanel.Name = "toolboxPanel";
            this.toolboxPanel.Size = new System.Drawing.Size(132, 100);
            this.toolboxPanel.TabIndex = 2;
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 616);
            this.Controls.Add(this.toolboxPanel);
            this.Controls.Add(this.drawingPanel);
            this.Name = "Canvas";
            this.Text = "Canvas";
            this.Load += new System.EventHandler(this.Canvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempPicBox)).EndInit();
            this.drawingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tempPicBox;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel toolboxPanel;
    }
}