namespace Игра_про_осьминога
{
    partial class RulesForm
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
            this.CloseBbutton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseBbutton
            // 
            this.CloseBbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseBbutton.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBbutton.Location = new System.Drawing.Point(540, 401);
            this.CloseBbutton.Name = "CloseBbutton";
            this.CloseBbutton.Size = new System.Drawing.Size(248, 37);
            this.CloseBbutton.TabIndex = 5;
            this.CloseBbutton.Text = "Close";
            this.CloseBbutton.UseVisualStyleBackColor = false;
            this.CloseBbutton.Click += new System.EventHandler(this.CloseBbutton_Click);
            this.CloseBbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseBbutton_MouseMove);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBack.Location = new System.Drawing.Point(12, 401);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(217, 37);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.CloseBbutton);
            this.Name = "RulesForm";
            this.Text = "RulesForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RulesForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RulesForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBbutton;
        private System.Windows.Forms.Button buttonBack;
    }
}