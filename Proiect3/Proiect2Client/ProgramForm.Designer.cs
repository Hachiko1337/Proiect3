namespace Proiect2Client
{
    partial class ProgramForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLandscapeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlaceNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.MediaTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.VideoRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageRadioButton = new System.Windows.Forms.RadioButton();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImageGridView = new System.Windows.Forms.DataGridView();
            this.deleteImageVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.MediaTypeGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImageVideoToolStripMenuItem,
            this.deleteImageVideoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addImageVideoToolStripMenuItem
            // 
            this.addImageVideoToolStripMenuItem.Name = "addImageVideoToolStripMenuItem";
            this.addImageVideoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addImageVideoToolStripMenuItem.Text = "Add Image/Video";
            this.addImageVideoToolStripMenuItem.Click += new System.EventHandler(this.addImageVideoToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventNameToolStripMenuItem,
            this.addPersonNameToolStripMenuItem,
            this.addLandscapeNameToolStripMenuItem,
            this.addPlaceNameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addEventNameToolStripMenuItem
            // 
            this.addEventNameToolStripMenuItem.Name = "addEventNameToolStripMenuItem";
            this.addEventNameToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addEventNameToolStripMenuItem.Text = "Add Event Name";
            // 
            // addPersonNameToolStripMenuItem
            // 
            this.addPersonNameToolStripMenuItem.Name = "addPersonNameToolStripMenuItem";
            this.addPersonNameToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addPersonNameToolStripMenuItem.Text = "Add Person Name";
            // 
            // addLandscapeNameToolStripMenuItem
            // 
            this.addLandscapeNameToolStripMenuItem.Name = "addLandscapeNameToolStripMenuItem";
            this.addLandscapeNameToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addLandscapeNameToolStripMenuItem.Text = "Add Landscape Name";
            // 
            // addPlaceNameToolStripMenuItem
            // 
            this.addPlaceNameToolStripMenuItem.Name = "addPlaceNameToolStripMenuItem";
            this.addPlaceNameToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addPlaceNameToolStripMenuItem.Text = "Add Place Name";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.FilterButton);
            this.OptionsPanel.Controls.Add(this.FilterTextBox);
            this.OptionsPanel.Controls.Add(this.MediaTypeGroupBox);
            this.OptionsPanel.Controls.Add(this.FilterComboBox);
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OptionsPanel.Location = new System.Drawing.Point(0, 24);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(200, 426);
            this.OptionsPanel.TabIndex = 1;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(119, 42);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 20);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(3, 42);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(110, 20);
            this.FilterTextBox.TabIndex = 2;
            // 
            // MediaTypeGroupBox
            // 
            this.MediaTypeGroupBox.Controls.Add(this.VideoRadioButton);
            this.MediaTypeGroupBox.Controls.Add(this.ImageRadioButton);
            this.MediaTypeGroupBox.Location = new System.Drawing.Point(3, 71);
            this.MediaTypeGroupBox.Name = "MediaTypeGroupBox";
            this.MediaTypeGroupBox.Size = new System.Drawing.Size(197, 100);
            this.MediaTypeGroupBox.TabIndex = 1;
            this.MediaTypeGroupBox.TabStop = false;
            this.MediaTypeGroupBox.Text = "Media Type";
            this.MediaTypeGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // VideoRadioButton
            // 
            this.VideoRadioButton.AutoSize = true;
            this.VideoRadioButton.Location = new System.Drawing.Point(10, 55);
            this.VideoRadioButton.Name = "VideoRadioButton";
            this.VideoRadioButton.Size = new System.Drawing.Size(52, 17);
            this.VideoRadioButton.TabIndex = 1;
            this.VideoRadioButton.Text = "Video";
            this.VideoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImageRadioButton
            // 
            this.ImageRadioButton.AutoSize = true;
            this.ImageRadioButton.Checked = true;
            this.ImageRadioButton.Location = new System.Drawing.Point(10, 31);
            this.ImageRadioButton.Name = "ImageRadioButton";
            this.ImageRadioButton.Size = new System.Drawing.Size(54, 17);
            this.ImageRadioButton.TabIndex = 0;
            this.ImageRadioButton.TabStop = true;
            this.ImageRadioButton.Text = "Image";
            this.ImageRadioButton.UseVisualStyleBackColor = true;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Event",
            "Place",
            "Landmark",
            "Person",
            "Date"});
            this.FilterComboBox.Location = new System.Drawing.Point(3, 3);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(191, 21);
            this.FilterComboBox.TabIndex = 0;
            this.FilterComboBox.Text = "Filter By";
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ImageGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 426);
            this.panel2.TabIndex = 2;
            // 
            // ImageGridView
            // 
            this.ImageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImageGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageGridView.Location = new System.Drawing.Point(0, 0);
            this.ImageGridView.Name = "ImageGridView";
            this.ImageGridView.Size = new System.Drawing.Size(600, 426);
            this.ImageGridView.TabIndex = 0;
            // 
            // deleteImageVideoToolStripMenuItem
            // 
            this.deleteImageVideoToolStripMenuItem.Name = "deleteImageVideoToolStripMenuItem";
            this.deleteImageVideoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteImageVideoToolStripMenuItem.Text = "Delete Image/Video";
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "ProgramForm";
            this.Text = "Media Gallery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.MediaTypeGroupBox.ResumeLayout(false);
            this.MediaTypeGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addImageVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox MediaTypeGroupBox;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.RadioButton VideoRadioButton;
        private System.Windows.Forms.RadioButton ImageRadioButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.DataGridView ImageGridView;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLandscapeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlaceNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteImageVideoToolStripMenuItem;
    }
}

