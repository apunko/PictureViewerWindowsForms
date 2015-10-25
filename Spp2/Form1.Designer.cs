namespace Spp2
{
    partial class pictureViewerForm
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
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.resizeTrackBar = new System.Windows.Forms.TrackBar();
            this.panelWithPictureBox = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.thicknessTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastButton = new System.Windows.Forms.Button();
            this.brightnessButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.resizeButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTrackBar)).BeginInit();
            this.panelWithPictureBox.SuspendLayout();
            this.DrawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.FileName = "openFileDialog1";
            this.openImageFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openImageFileDialog.Title = "Select picture";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.DereferenceLinks = false;
            this.saveImageDialog.FileName = "pic.jpg";
            this.saveImageDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(49, 97);
            this.brightnessTrackBar.Maximum = 100;
            this.brightnessTrackBar.Minimum = -100;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(104, 45);
            this.brightnessTrackBar.TabIndex = 6;
            this.brightnessTrackBar.Visible = false;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // resizeTrackBar
            // 
            this.resizeTrackBar.Location = new System.Drawing.Point(49, 51);
            this.resizeTrackBar.Maximum = 100;
            this.resizeTrackBar.Minimum = 1;
            this.resizeTrackBar.Name = "resizeTrackBar";
            this.resizeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.resizeTrackBar.TabIndex = 7;
            this.resizeTrackBar.Value = 10;
            this.resizeTrackBar.Visible = false;
            this.resizeTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panelWithPictureBox
            // 
            this.panelWithPictureBox.Controls.Add(this.pictureBox);
            this.panelWithPictureBox.Location = new System.Drawing.Point(174, 12);
            this.panelWithPictureBox.Name = "panelWithPictureBox";
            this.panelWithPictureBox.Size = new System.Drawing.Size(700, 426);
            this.panelWithPictureBox.TabIndex = 12;
            // 
            // DrawPanel
            // 
            this.DrawPanel.Controls.Add(this.thicknessTrackBar);
            this.DrawPanel.Controls.Add(this.contrastButton);
            this.DrawPanel.Controls.Add(this.contrastTrackBar);
            this.DrawPanel.Controls.Add(this.brightnessButton);
            this.DrawPanel.Controls.Add(this.button3);
            this.DrawPanel.Controls.Add(this.brightnessTrackBar);
            this.DrawPanel.Controls.Add(this.DrawButton);
            this.DrawPanel.Controls.Add(this.button4);
            this.DrawPanel.Controls.Add(this.saveButton);
            this.DrawPanel.Controls.Add(this.resizeButton);
            this.DrawPanel.Controls.Add(this.resizeTrackBar);
            this.DrawPanel.Location = new System.Drawing.Point(12, 58);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(156, 324);
            this.DrawPanel.TabIndex = 13;
            // 
            // thicknessTrackBar
            // 
            this.thicknessTrackBar.Location = new System.Drawing.Point(19, 259);
            this.thicknessTrackBar.Name = "thicknessTrackBar";
            this.thicknessTrackBar.Size = new System.Drawing.Size(104, 45);
            this.thicknessTrackBar.TabIndex = 17;
            this.thicknessTrackBar.Visible = false;
            this.thicknessTrackBar.Scroll += new System.EventHandler(this.thicknessTrackBar_Scroll);
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(49, 149);
            this.contrastTrackBar.Maximum = 9;
            this.contrastTrackBar.Minimum = 1;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(104, 45);
            this.contrastTrackBar.TabIndex = 14;
            this.contrastTrackBar.Value = 1;
            this.contrastTrackBar.Visible = false;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // contrastButton
            // 
            this.contrastButton.Image = global::Spp2.Properties.Resources.Contrast__1_;
            this.contrastButton.Location = new System.Drawing.Point(3, 148);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(40, 46);
            this.contrastButton.TabIndex = 15;
            this.contrastButton.UseVisualStyleBackColor = true;
            this.contrastButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // brightnessButton
            // 
            this.brightnessButton.Image = global::Spp2.Properties.Resources.filter_brightness_contrast;
            this.brightnessButton.Location = new System.Drawing.Point(3, 98);
            this.brightnessButton.Name = "brightnessButton";
            this.brightnessButton.Size = new System.Drawing.Size(40, 44);
            this.brightnessButton.TabIndex = 14;
            this.brightnessButton.UseVisualStyleBackColor = true;
            this.brightnessButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Spp2.Properties.Resources.arrow_circular_arrow_turn_rotation_rotate_360_1281;
            this.button3.Location = new System.Drawing.Point(52, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 43);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Image = global::Spp2.Properties.Resources.Edit_write_pencil_pen_page_vector_text_symbol_simple_pictogram;
            this.DrawButton.Location = new System.Drawing.Point(3, 200);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(134, 53);
            this.DrawButton.TabIndex = 11;
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Spp2.Properties.Resources.arrow_circular_arrow_turn_rotation_rotate_180_1281;
            this.button4.Location = new System.Drawing.Point(100, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 43);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::Spp2.Properties.Resources.save;
            this.saveButton.Location = new System.Drawing.Point(3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(40, 41);
            this.saveButton.TabIndex = 2;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // resizeButton
            // 
            this.resizeButton.Image = global::Spp2.Properties.Resources.lupa;
            this.resizeButton.Location = new System.Drawing.Point(3, 51);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(40, 41);
            this.resizeButton.TabIndex = 8;
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(208, 247);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.panelWithPictureBox);
            this.Controls.Add(this.openButton);
            this.Name = "pictureViewerForm";
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTrackBar)).EndInit();
            this.panelWithPictureBox.ResumeLayout(false);
            this.DrawPanel.ResumeLayout(false);
            this.DrawPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TrackBar resizeTrackBar;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Panel panelWithPictureBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button brightnessButton;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.Button contrastButton;
        private System.Windows.Forms.TrackBar thicknessTrackBar;
    }
}

