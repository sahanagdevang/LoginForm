
namespace LoginForm
{
    partial class RegisterPage
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
            this.regnumtxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.usernametxt = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.Label();
            this.fullnametxt = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // regnumtxt
            // 
            this.regnumtxt.AutoSize = true;
            this.regnumtxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regnumtxt.Location = new System.Drawing.Point(136, 58);
            this.regnumtxt.Name = "regnumtxt";
            this.regnumtxt.Size = new System.Drawing.Size(121, 20);
            this.regnumtxt.TabIndex = 0;
            this.regnumtxt.Text = "Register Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 27);
            this.textBox1.TabIndex = 1;
            // 
            // registerbtn
            // 
            this.registerbtn.AutoSize = true;
            this.registerbtn.BackColor = System.Drawing.Color.Chartreuse;
            this.registerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.registerbtn.ForeColor = System.Drawing.Color.Black;
            this.registerbtn.Location = new System.Drawing.Point(248, 300);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(94, 32);
            this.registerbtn.TabIndex = 2;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.AutoSize = true;
            this.usernametxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernametxt.Location = new System.Drawing.Point(136, 158);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(82, 20);
            this.usernametxt.TabIndex = 3;
            this.usernametxt.Text = "User Name";
            // 
            // passwordtxt
            // 
            this.passwordtxt.AutoSize = true;
            this.passwordtxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordtxt.Location = new System.Drawing.Point(136, 213);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(70, 20);
            this.passwordtxt.TabIndex = 4;
            this.passwordtxt.Text = "Password";
            // 
            // fullnametxt
            // 
            this.fullnametxt.AutoSize = true;
            this.fullnametxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fullnametxt.Location = new System.Drawing.Point(138, 112);
            this.fullnametxt.Name = "fullnametxt";
            this.fullnametxt.Size = new System.Drawing.Size(76, 20);
            this.fullnametxt.TabIndex = 5;
            this.fullnametxt.Text = "Full Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 27);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(315, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 27);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(315, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 27);
            this.textBox4.TabIndex = 8;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 375);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.fullnametxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.regnumtxt);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regnumtxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label usernametxt;
        private System.Windows.Forms.Label passwordtxt;
        private System.Windows.Forms.Label fullnametxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}