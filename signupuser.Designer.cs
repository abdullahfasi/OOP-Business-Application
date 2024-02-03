
namespace final
{
    partial class signupuser
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
            System.Windows.Forms.Button button2;
            this.signinpanel = new System.Windows.Forms.Panel();
            this.numbertext = new System.Windows.Forms.TextBox();
            this.numberbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.passwordbutton = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.namebutton = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.signinpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.SystemColors.Window;
            button2.Location = new System.Drawing.Point(3, 12);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(274, 59);
            button2.TabIndex = 3;
            button2.Text = "  Sign Up As User ";
            button2.UseVisualStyleBackColor = false;
            // 
            // signinpanel
            // 
            this.signinpanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.signinpanel.Controls.Add(this.numbertext);
            this.signinpanel.Controls.Add(this.numberbutton);
            this.signinpanel.Controls.Add(this.nextbutton);
            this.signinpanel.Controls.Add(this.backbutton);
            this.signinpanel.Controls.Add(this.passwordtxt);
            this.signinpanel.Controls.Add(this.passwordbutton);
            this.signinpanel.Controls.Add(this.nametxt);
            this.signinpanel.Controls.Add(this.namebutton);
            this.signinpanel.Controls.Add(button2);
            this.signinpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.signinpanel.Location = new System.Drawing.Point(0, 0);
            this.signinpanel.Name = "signinpanel";
            this.signinpanel.Size = new System.Drawing.Size(280, 450);
            this.signinpanel.TabIndex = 2;
            // 
            // numbertext
            // 
            this.numbertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbertext.Location = new System.Drawing.Point(3, 255);
            this.numbertext.Name = "numbertext";
            this.numbertext.Size = new System.Drawing.Size(280, 31);
            this.numbertext.TabIndex = 14;
            this.numbertext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numbertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbertext_KeyPress);
            // 
            // numberbutton
            // 
            this.numberbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numberbutton.FlatAppearance.BorderSize = 0;
            this.numberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numberbutton.Location = new System.Drawing.Point(0, 214);
            this.numberbutton.Name = "numberbutton";
            this.numberbutton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.numberbutton.Size = new System.Drawing.Size(277, 35);
            this.numberbutton.TabIndex = 13;
            this.numberbutton.Text = "Phone Number";
            this.numberbutton.UseVisualStyleBackColor = false;
            // 
            // nextbutton
            // 
            this.nextbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nextbutton.FlatAppearance.BorderSize = 0;
            this.nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.nextbutton.Location = new System.Drawing.Point(168, 351);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(100, 35);
            this.nextbutton.TabIndex = 10;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = false;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.backbutton.Location = new System.Drawing.Point(12, 351);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(100, 35);
            this.backbutton.TabIndex = 9;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(3, 177);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(280, 31);
            this.passwordtxt.TabIndex = 8;
            this.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordbutton
            // 
            this.passwordbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordbutton.FlatAppearance.BorderSize = 0;
            this.passwordbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passwordbutton.Location = new System.Drawing.Point(0, 145);
            this.passwordbutton.Name = "passwordbutton";
            this.passwordbutton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.passwordbutton.Size = new System.Drawing.Size(277, 26);
            this.passwordbutton.TabIndex = 7;
            this.passwordbutton.Text = "Password";
            this.passwordbutton.UseVisualStyleBackColor = false;
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.SystemColors.Window;
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(3, 108);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(280, 31);
            this.nametxt.TabIndex = 6;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // namebutton
            // 
            this.namebutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.namebutton.FlatAppearance.BorderSize = 0;
            this.namebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.namebutton.Location = new System.Drawing.Point(3, 77);
            this.namebutton.Name = "namebutton";
            this.namebutton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.namebutton.Size = new System.Drawing.Size(277, 25);
            this.namebutton.TabIndex = 4;
            this.namebutton.Text = "Name";
            this.namebutton.UseVisualStyleBackColor = false;
            // 
            // signupuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::final.Properties.Resources.uper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signinpanel);
            this.Name = "signupuser";
            this.Text = "signupuser";
            this.signinpanel.ResumeLayout(false);
            this.signinpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signinpanel;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button passwordbutton;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button namebutton;
        private System.Windows.Forms.TextBox numbertext;
        private System.Windows.Forms.Button numberbutton;
    }
}