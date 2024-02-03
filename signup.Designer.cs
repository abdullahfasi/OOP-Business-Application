
namespace final
{
    partial class signup
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
            this.userradio = new System.Windows.Forms.RadioButton();
            this.adminradio = new System.Windows.Forms.RadioButton();
            this.nextbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.signinpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.InfoText;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.SystemColors.Window;
            button2.Location = new System.Drawing.Point(3, 22);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(274, 53);
            button2.TabIndex = 3;
            button2.Text = "  Sign Up ";
            button2.UseVisualStyleBackColor = false;
            // 
            // signinpanel
            // 
            this.signinpanel.BackColor = System.Drawing.SystemColors.InfoText;
            this.signinpanel.Controls.Add(this.userradio);
            this.signinpanel.Controls.Add(this.adminradio);
            this.signinpanel.Controls.Add(this.nextbutton);
            this.signinpanel.Controls.Add(this.backbutton);
            this.signinpanel.Controls.Add(button2);
            this.signinpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.signinpanel.Location = new System.Drawing.Point(0, 0);
            this.signinpanel.Name = "signinpanel";
            this.signinpanel.Size = new System.Drawing.Size(280, 450);
            this.signinpanel.TabIndex = 1;
            // 
            // userradio
            // 
            this.userradio.AutoSize = true;
            this.userradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userradio.ForeColor = System.Drawing.SystemColors.Window;
            this.userradio.Location = new System.Drawing.Point(64, 176);
            this.userradio.Name = "userradio";
            this.userradio.Size = new System.Drawing.Size(92, 26);
            this.userradio.TabIndex = 14;
            this.userradio.TabStop = true;
            this.userradio.Text = "As User";
            this.userradio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userradio.UseVisualStyleBackColor = true;
            // 
            // adminradio
            // 
            this.adminradio.AutoSize = true;
            this.adminradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminradio.ForeColor = System.Drawing.SystemColors.Window;
            this.adminradio.Location = new System.Drawing.Point(64, 119);
            this.adminradio.Name = "adminradio";
            this.adminradio.Size = new System.Drawing.Size(104, 26);
            this.adminradio.TabIndex = 13;
            this.adminradio.TabStop = true;
            this.adminradio.Text = "As Admin";
            this.adminradio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminradio.UseVisualStyleBackColor = true;
            // 
            // nextbutton
            // 
            this.nextbutton.BackColor = System.Drawing.SystemColors.InfoText;
            this.nextbutton.FlatAppearance.BorderSize = 0;
            this.nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.nextbutton.Location = new System.Drawing.Point(161, 279);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(100, 35);
            this.nextbutton.TabIndex = 10;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = false;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.InfoText;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.backbutton.Location = new System.Drawing.Point(12, 279);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(100, 35);
            this.backbutton.TabIndex = 9;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::final.Properties.Resources.lower;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signinpanel);
            this.DoubleBuffered = true;
            this.Name = "signup";
            this.Text = "signup";
            this.signinpanel.ResumeLayout(false);
            this.signinpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signinpanel;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.RadioButton userradio;
        private System.Windows.Forms.RadioButton adminradio;
    }
}