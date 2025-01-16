
namespace ExExRyabikov
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
            this.wLB = new System.Windows.Forms.Label();
            this.loginLB = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwdTB = new System.Windows.Forms.TextBox();
            this.passwdLB = new System.Windows.Forms.Label();
            this.authBtn = new System.Windows.Forms.Button();
            this.showPasswdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wLB
            // 
            this.wLB.AutoSize = true;
            this.wLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wLB.Location = new System.Drawing.Point(24, 43);
            this.wLB.Name = "wLB";
            this.wLB.Size = new System.Drawing.Size(336, 25);
            this.wLB.TabIndex = 0;
            this.wLB.Text = "Агентство недвижимости \"Циан\"";
            // 
            // loginLB
            // 
            this.loginLB.AutoSize = true;
            this.loginLB.Location = new System.Drawing.Point(46, 149);
            this.loginLB.Name = "loginLB";
            this.loginLB.Size = new System.Drawing.Size(64, 24);
            this.loginLB.TabIndex = 1;
            this.loginLB.Text = "Логин";
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.Location = new System.Drawing.Point(50, 186);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(262, 38);
            this.loginTB.TabIndex = 2;
            // 
            // passwdTB
            // 
            this.passwdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwdTB.Location = new System.Drawing.Point(50, 265);
            this.passwdTB.Name = "passwdTB";
            this.passwdTB.PasswordChar = '*';
            this.passwdTB.Size = new System.Drawing.Size(262, 38);
            this.passwdTB.TabIndex = 4;
            // 
            // passwdLB
            // 
            this.passwdLB.AutoSize = true;
            this.passwdLB.Location = new System.Drawing.Point(46, 228);
            this.passwdLB.Name = "passwdLB";
            this.passwdLB.Size = new System.Drawing.Size(76, 24);
            this.passwdLB.TabIndex = 3;
            this.passwdLB.Text = "Пароль";
            // 
            // authBtn
            // 
            this.authBtn.BackColor = System.Drawing.Color.White;
            this.authBtn.Location = new System.Drawing.Point(50, 320);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(262, 52);
            this.authBtn.TabIndex = 5;
            this.authBtn.Text = "Войти";
            this.authBtn.UseVisualStyleBackColor = false;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // showPasswdBtn
            // 
            this.showPasswdBtn.BackColor = System.Drawing.Color.White;
            this.showPasswdBtn.Location = new System.Drawing.Point(320, 265);
            this.showPasswdBtn.Name = "showPasswdBtn";
            this.showPasswdBtn.Size = new System.Drawing.Size(40, 40);
            this.showPasswdBtn.TabIndex = 6;
            this.showPasswdBtn.Text = "`";
            this.showPasswdBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(372, 447);
            this.Controls.Add(this.showPasswdBtn);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.passwdTB);
            this.Controls.Add(this.passwdLB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.loginLB);
            this.Controls.Add(this.wLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 486);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 486);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wLB;
        private System.Windows.Forms.Label loginLB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwdTB;
        private System.Windows.Forms.Label passwdLB;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Button showPasswdBtn;
    }
}

