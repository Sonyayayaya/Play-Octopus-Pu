namespace Игра_про_осьминога
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.GoUpTimer = new System.Windows.Forms.Timer(this.components);
            this.GoDownTimer = new System.Windows.Forms.Timer(this.components);
            this.GoLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.GoRightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.Color.Chartreuse;
            this.backToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenuButton.Location = new System.Drawing.Point(-1, 1);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(52, 24);
            this.backToMenuButton.TabIndex = 0;
            this.backToMenuButton.Text = "←";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(1248, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(52, 24);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.Image = ((System.Drawing.Image)(resources.GetObject("mainPlayer.Image")));
            this.mainPlayer.Location = new System.Drawing.Point(364, 210);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(136, 128);
            this.mainPlayer.TabIndex = 2;
            this.mainPlayer.TabStop = false;
            // 
            // GoUpTimer
            // 
            this.GoUpTimer.Interval = 10;
            this.GoUpTimer.Tick += new System.EventHandler(this.GoUpTimer_Tick);
            // 
            // GoDownTimer
            // 
            this.GoDownTimer.Interval = 10;
            this.GoDownTimer.Tick += new System.EventHandler(this.GoDownTimer_Tick);
            // 
            // GoLeftTimer
            // 
            this.GoLeftTimer.Interval = 10;
            this.GoLeftTimer.Tick += new System.EventHandler(this.GoLeftTimer_Tick);
            // 
            // GoRightTimer
            // 
            this.GoRightTimer.Interval = 10;
            this.GoRightTimer.Tick += new System.EventHandler(this.GoRightTimer_Tick);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1302, 713);
            this.Controls.Add(this.mainPlayer);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.backToMenuButton);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer GoUpTimer;
        private System.Windows.Forms.Timer GoDownTimer;
        private System.Windows.Forms.Timer GoLeftTimer;
        private System.Windows.Forms.Timer GoRightTimer;
    }
}