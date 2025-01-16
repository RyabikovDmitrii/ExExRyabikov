
namespace ExExRyabikov
{
    partial class CAPTCHA
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
            this.cLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.authBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cLB
            // 
            this.cLB.AutoSize = true;
            this.cLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cLB.Location = new System.Drawing.Point(102, 36);
            this.cLB.Name = "cLB";
            this.cLB.Size = new System.Drawing.Size(160, 33);
            this.cLB.TabIndex = 0;
            this.cLB.Text = "CAPTCHA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 149);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // authBtn
            // 
            this.authBtn.BackColor = System.Drawing.Color.White;
            this.authBtn.Location = new System.Drawing.Point(55, 262);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(262, 52);
            this.authBtn.TabIndex = 6;
            this.authBtn.Text = "Создать новую CAPTCHA";
            this.authBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(55, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CAPTCHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(372, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 486);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 486);
            this.Name = "CAPTCHA";
            this.Text = "CAPTCHA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Button button1;
    }
}