namespace CliMate
{
    partial class GeneratePerlinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePerlinForm));
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.dimensionGroupBox = new System.Windows.Forms.GroupBox();
            this.seedGroupBox = new System.Windows.Forms.GroupBox();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.dimensionGroupBox.SuspendLayout();
            this.seedGroupBox.SuspendLayout();
            this.previewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(9, 21);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 0;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(146, 45);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(36, 13);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "height";
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(8, 45);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(32, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "width";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(122, 24);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(12, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "x";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(147, 21);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 1;
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(9, 19);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(238, 20);
            this.seedBox.TabIndex = 2;
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(10, 19);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(148, 140);
            this.previewBox.TabIndex = 5;
            this.previewBox.TabStop = false;
            // 
            // OKButton
            // 
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(12, 348);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(194, 348);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(101, 144);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // dimensionGroupBox
            // 
            this.dimensionGroupBox.Controls.Add(this.heightBox);
            this.dimensionGroupBox.Controls.Add(this.widthBox);
            this.dimensionGroupBox.Controls.Add(this.heightLabel);
            this.dimensionGroupBox.Controls.Add(this.widthLabel);
            this.dimensionGroupBox.Controls.Add(this.xLabel);
            this.dimensionGroupBox.Location = new System.Drawing.Point(12, 8);
            this.dimensionGroupBox.Name = "dimensionGroupBox";
            this.dimensionGroupBox.Size = new System.Drawing.Size(257, 68);
            this.dimensionGroupBox.TabIndex = 10;
            this.dimensionGroupBox.TabStop = false;
            this.dimensionGroupBox.Text = "Dimensions";
            // 
            // seedGroupBox
            // 
            this.seedGroupBox.Controls.Add(this.seedBox);
            this.seedGroupBox.Location = new System.Drawing.Point(12, 82);
            this.seedGroupBox.Name = "seedGroupBox";
            this.seedGroupBox.Size = new System.Drawing.Size(257, 54);
            this.seedGroupBox.TabIndex = 11;
            this.seedGroupBox.TabStop = false;
            this.seedGroupBox.Text = "Seed";
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Controls.Add(this.previewBox);
            this.previewGroupBox.Location = new System.Drawing.Point(12, 171);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(257, 171);
            this.previewGroupBox.TabIndex = 12;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview";
            // 
            // GeneratePerlinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 383);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.seedGroupBox);
            this.Controls.Add(this.dimensionGroupBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneratePerlinForm";
            this.Text = "GeneratePerlinForm";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.dimensionGroupBox.ResumeLayout(false);
            this.dimensionGroupBox.PerformLayout();
            this.seedGroupBox.ResumeLayout(false);
            this.seedGroupBox.PerformLayout();
            this.previewGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.GroupBox dimensionGroupBox;
        private System.Windows.Forms.GroupBox seedGroupBox;
        private System.Windows.Forms.GroupBox previewGroupBox;
    }
}