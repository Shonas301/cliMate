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
            this.brushSizeBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempPicBox)).BeginInit();
            this.drawingPanel.SuspendLayout();
            this.toolboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBox)).BeginInit();
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
            this.drawingPanel.Size = new System.Drawing.Size(689, 592);
            this.drawingPanel.TabIndex = 1;
            // 
            // toolboxPanel
            // 
            this.toolboxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolboxPanel.Controls.Add(this.label1);
            this.toolboxPanel.Controls.Add(this.brushSizeBox);
            this.toolboxPanel.Location = new System.Drawing.Point(707, 15);
            this.toolboxPanel.Name = "toolboxPanel";
            this.toolboxPanel.Size = new System.Drawing.Size(132, 589);
            this.toolboxPanel.TabIndex = 2;
            // 
            // brushSizeBox
            // 
            this.brushSizeBox.Location = new System.Drawing.Point(5, 42);
            this.brushSizeBox.Name = "brushSizeBox";
            this.brushSizeBox.Size = new System.Drawing.Size(120, 22);
            this.brushSizeBox.TabIndex = 1;
            this.brushSizeBox.ValueChanged += new System.EventHandler(this.brushSizeBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brush size";
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
            this.toolboxPanel.ResumeLayout(false);
            this.toolboxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tempPicBox;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel toolboxPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown brushSizeBox;
    }
}