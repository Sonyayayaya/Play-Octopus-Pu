namespace Игра_про_осьминога
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.BackToMenuButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.volumeTrack = new System.Windows.Forms.TrackBar();
            this.buttonVolume = new System.Windows.Forms.Button();
            this.buttonScale = new System.Windows.Forms.Button();
            this.comboBoxScales = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.BackColor = System.Drawing.Color.Lime;
            this.BackToMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackToMenuButton.BackgroundImage")));
            this.BackToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMenuButton.Location = new System.Drawing.Point(1, 1);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(52, 24);
            this.BackToMenuButton.TabIndex = 8;
            this.BackToMenuButton.TabStop = false;
            this.BackToMenuButton.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(749, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(52, 24);
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseBbutton_Click);
            // 
            // volumeTrack
            // 
            this.volumeTrack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.volumeTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeTrack.Location = new System.Drawing.Point(344, 127);
            this.volumeTrack.Name = "volumeTrack";
            this.volumeTrack.Size = new System.Drawing.Size(292, 56);
            this.volumeTrack.TabIndex = 10;
            // 
            // buttonVolume
            // 
            this.buttonVolume.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonVolume.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonVolume.FlatAppearance.BorderSize = 0;
            this.buttonVolume.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVolume.Location = new System.Drawing.Point(121, 139);
            this.buttonVolume.Name = "buttonVolume";
            this.buttonVolume.Size = new System.Drawing.Size(99, 35);
            this.buttonVolume.TabIndex = 11;
            this.buttonVolume.Text = "Volume";
            this.buttonVolume.UseVisualStyleBackColor = false;
            // 
            // buttonScale
            // 
            this.buttonScale.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonScale.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScale.Location = new System.Drawing.Point(121, 277);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(139, 31);
            this.buttonScale.TabIndex = 12;
            this.buttonScale.Text = "Display scale";
            this.buttonScale.UseVisualStyleBackColor = false;
            // 
            // comboBoxScales
            // 
            this.comboBoxScales.BackColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxScales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxScales.FormattingEnabled = true;
            this.comboBoxScales.Items.AddRange(new object[] {
            "1200/800",
            "1024/768",
            "800/600"});
            this.comboBoxScales.Location = new System.Drawing.Point(344, 282);
            this.comboBoxScales.Name = "comboBoxScales";
            this.comboBoxScales.Size = new System.Drawing.Size(121, 28);
            this.comboBoxScales.TabIndex = 13;
            this.comboBoxScales.Text = "Scales";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxScales);
            this.Controls.Add(this.buttonScale);
            this.Controls.Add(this.buttonVolume);
            this.Controls.Add(this.volumeTrack);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.BackToMenuButton);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.BackToMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BackToMenuButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.TrackBar volumeTrack;
        private System.Windows.Forms.Button buttonVolume;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.ComboBox comboBoxScales;
    }
}