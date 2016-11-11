namespace CliMate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightmapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.climatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBiomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateNewMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.augmentExistingMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.noteButton = new System.Windows.Forms.Button();
            this.toolsLabel = new System.Windows.Forms.Label();
            this.brushPointerToggle = new System.Windows.Forms.Button();
            this.regularPointerToggle = new System.Windows.Forms.Button();
            this.openTKPanel = new System.Windows.Forms.PictureBox();
            this.outerPanel = new System.Windows.Forms.Panel();
            this.disableEnableToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openTKPanel)).BeginInit();
            this.outerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.openRecentToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heightmapToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // heightmapToolStripMenuItem1
            // 
            this.heightmapToolStripMenuItem1.Name = "heightmapToolStripMenuItem1";
            this.heightmapToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.heightmapToolStripMenuItem1.Text = "Heightmap";
            this.heightmapToolStripMenuItem1.Click += new System.EventHandler(this.heightmapToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openRecentToolStripMenuItem
            // 
            this.openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            this.openRecentToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openRecentToolStripMenuItem.Text = "Open Recent";
            this.openRecentToolStripMenuItem.Click += new System.EventHandler(this.openRecentToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperatureToolStripMenuItem,
            this.climatesToolStripMenuItem,
            this.nodeMapToolStripMenuItem,
            this.disableEnableToolbarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.temperatureToolStripMenuItem.Text = "Height Map";
            // 
            // climatesToolStripMenuItem
            // 
            this.climatesToolStripMenuItem.Name = "climatesToolStripMenuItem";
            this.climatesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.climatesToolStripMenuItem.Text = "Climates";
            // 
            // nodeMapToolStripMenuItem
            // 
            this.nodeMapToolStripMenuItem.Name = "nodeMapToolStripMenuItem";
            this.nodeMapToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.nodeMapToolStripMenuItem.Text = "Node Map";
            this.nodeMapToolStripMenuItem.Click += new System.EventHandler(this.nodeMapToolStripMenuItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBiomesToolStripMenuItem,
            this.heightmapToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // createBiomesToolStripMenuItem
            // 
            this.createBiomesToolStripMenuItem.Name = "createBiomesToolStripMenuItem";
            this.createBiomesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.createBiomesToolStripMenuItem.Text = "Create Biomes";
            // 
            // heightmapToolStripMenuItem
            // 
            this.heightmapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateNewMapToolStripMenuItem,
            this.augmentExistingMapToolStripMenuItem});
            this.heightmapToolStripMenuItem.Name = "heightmapToolStripMenuItem";
            this.heightmapToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.heightmapToolStripMenuItem.Text = "Heightmap";
            // 
            // generateNewMapToolStripMenuItem
            // 
            this.generateNewMapToolStripMenuItem.Name = "generateNewMapToolStripMenuItem";
            this.generateNewMapToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.generateNewMapToolStripMenuItem.Text = "Generate new map";
            this.generateNewMapToolStripMenuItem.Click += new System.EventHandler(this.generateNewMapToolStripMenuItem_Click);
            // 
            // augmentExistingMapToolStripMenuItem
            // 
            this.augmentExistingMapToolStripMenuItem.Name = "augmentExistingMapToolStripMenuItem";
            this.augmentExistingMapToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.augmentExistingMapToolStripMenuItem.Text = "Augment existing map";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolPanel.Controls.Add(this.noteButton);
            this.toolPanel.Controls.Add(this.toolsLabel);
            this.toolPanel.Controls.Add(this.brushPointerToggle);
            this.toolPanel.Controls.Add(this.regularPointerToggle);
            this.toolPanel.Location = new System.Drawing.Point(0, 24);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(130, 576);
            this.toolPanel.TabIndex = 1;
            // 
            // noteButton
            // 
            this.noteButton.BackColor = System.Drawing.Color.DarkGray;
            this.noteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteButton.ForeColor = System.Drawing.Color.Gray;
            this.noteButton.Image = ((System.Drawing.Image)(resources.GetObject("noteButton.Image")));
            this.noteButton.Location = new System.Drawing.Point(10, 90);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(50, 50);
            this.noteButton.TabIndex = 3;
            this.noteButton.UseVisualStyleBackColor = false;
            this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // toolsLabel
            // 
            this.toolsLabel.AutoSize = true;
            this.toolsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsLabel.ForeColor = System.Drawing.Color.Silver;
            this.toolsLabel.Location = new System.Drawing.Point(4, 4);
            this.toolsLabel.Name = "toolsLabel";
            this.toolsLabel.Size = new System.Drawing.Size(49, 23);
            this.toolsLabel.TabIndex = 2;
            this.toolsLabel.Text = "Tools";
            // 
            // brushPointerToggle
            // 
            this.brushPointerToggle.BackColor = System.Drawing.Color.DarkGray;
            this.brushPointerToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushPointerToggle.ForeColor = System.Drawing.Color.Gray;
            this.brushPointerToggle.Image = ((System.Drawing.Image)(resources.GetObject("brushPointerToggle.Image")));
            this.brushPointerToggle.Location = new System.Drawing.Point(70, 30);
            this.brushPointerToggle.Name = "brushPointerToggle";
            this.brushPointerToggle.Size = new System.Drawing.Size(50, 50);
            this.brushPointerToggle.TabIndex = 1;
            this.brushPointerToggle.UseVisualStyleBackColor = false;
            // 
            // regularPointerToggle
            // 
            this.regularPointerToggle.BackColor = System.Drawing.Color.DarkGray;
            this.regularPointerToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regularPointerToggle.ForeColor = System.Drawing.Color.Gray;
            this.regularPointerToggle.Image = ((System.Drawing.Image)(resources.GetObject("regularPointerToggle.Image")));
            this.regularPointerToggle.Location = new System.Drawing.Point(10, 30);
            this.regularPointerToggle.Name = "regularPointerToggle";
            this.regularPointerToggle.Size = new System.Drawing.Size(50, 50);
            this.regularPointerToggle.TabIndex = 0;
            this.regularPointerToggle.UseVisualStyleBackColor = false;
            // 
            // openTKPanel
            // 
            this.openTKPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openTKPanel.BackgroundImage")));
            this.openTKPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openTKPanel.Location = new System.Drawing.Point(3, 0);
            this.openTKPanel.Name = "openTKPanel";
            this.openTKPanel.Size = new System.Drawing.Size(1070, 576);
            this.openTKPanel.TabIndex = 2;
            this.openTKPanel.TabStop = false;
            // 
            // outerPanel
            // 
            this.outerPanel.AutoScroll = true;
            this.outerPanel.Controls.Add(this.openTKPanel);
            this.outerPanel.Location = new System.Drawing.Point(127, 24);
            this.outerPanel.Name = "outerPanel";
            this.outerPanel.Size = new System.Drawing.Size(1073, 576);
            this.outerPanel.TabIndex = 3;
            this.outerPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.outerPanel_MouseWheel);
            // 
            // disableEnableToolbarToolStripMenuItem
            // 
            this.disableEnableToolbarToolStripMenuItem.Name = "disableEnableToolbarToolStripMenuItem";
            this.disableEnableToolbarToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.disableEnableToolbarToolStripMenuItem.Text = "Disable/Enable Toolbar";
            this.disableEnableToolbarToolStripMenuItem.Click += new System.EventHandler(this.disableEnableToolbarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.outerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CliMate";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openTKPanel)).EndInit();
            this.outerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem climatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBiomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button regularPointerToggle;
        private System.Windows.Forms.Label toolsLabel;
        private System.Windows.Forms.Button brushPointerToggle;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateNewMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem augmentExistingMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightmapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nodeMapToolStripMenuItem;
        private System.Windows.Forms.Button noteButton;
        private System.Windows.Forms.PictureBox openTKPanel;
        private System.Windows.Forms.Panel outerPanel;
        private System.Windows.Forms.ToolStripMenuItem disableEnableToolbarToolStripMenuItem;
    }
}

