
namespace final
{
    partial class userprofile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.locationbutton = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.registrationbutton = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numbertxt = new System.Windows.Forms.TextBox();
            this.rolebutton = new System.Windows.Forms.Button();
            this.roletxt = new System.Windows.Forms.TextBox();
            this.profileGV = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 109);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(221, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "AF Real Estate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.exitbutton);
            this.panel2.Controls.Add(this.deletebutton);
            this.panel2.Controls.Add(this.updatebutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 33);
            this.panel2.TabIndex = 5;
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.exitbutton.Location = new System.Drawing.Point(557, 0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(121, 27);
            this.exitbutton.TabIndex = 6;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deletebutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.deletebutton.FlatAppearance.BorderSize = 0;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.deletebutton.Location = new System.Drawing.Point(285, 0);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(214, 30);
            this.deletebutton.TabIndex = 3;
            this.deletebutton.Text = "DELETE ACCOUNT";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updatebutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.updatebutton.FlatAppearance.BorderSize = 0;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.updatebutton.Location = new System.Drawing.Point(85, 3);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(121, 30);
            this.updatebutton.TabIndex = 2;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // locationbutton
            // 
            this.locationbutton.FlatAppearance.BorderSize = 0;
            this.locationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationbutton.Location = new System.Drawing.Point(32, 118);
            this.locationbutton.Name = "locationbutton";
            this.locationbutton.Size = new System.Drawing.Size(174, 32);
            this.locationbutton.TabIndex = 7;
            this.locationbutton.Text = "Name";
            this.locationbutton.UseVisualStyleBackColor = true;
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(32, 156);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(174, 31);
            this.nametxt.TabIndex = 8;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registrationbutton
            // 
            this.registrationbutton.FlatAppearance.BorderSize = 0;
            this.registrationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationbutton.Location = new System.Drawing.Point(32, 193);
            this.registrationbutton.Name = "registrationbutton";
            this.registrationbutton.Size = new System.Drawing.Size(174, 32);
            this.registrationbutton.TabIndex = 9;
            this.registrationbutton.Text = "Password";
            this.registrationbutton.UseVisualStyleBackColor = true;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(32, 231);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(174, 31);
            this.passwordtxt.TabIndex = 10;
            this.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Phone Number";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numbertxt
            // 
            this.numbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbertxt.Location = new System.Drawing.Point(32, 380);
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(174, 31);
            this.numbertxt.TabIndex = 12;
            this.numbertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numbertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbertxt_KeyPress);
            // 
            // rolebutton
            // 
            this.rolebutton.FlatAppearance.BorderSize = 0;
            this.rolebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolebutton.Location = new System.Drawing.Point(32, 268);
            this.rolebutton.Name = "rolebutton";
            this.rolebutton.Size = new System.Drawing.Size(174, 32);
            this.rolebutton.TabIndex = 13;
            this.rolebutton.Text = "Role";
            this.rolebutton.UseVisualStyleBackColor = true;
            // 
            // roletxt
            // 
            this.roletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roletxt.Location = new System.Drawing.Point(32, 306);
            this.roletxt.Name = "roletxt";
            this.roletxt.Size = new System.Drawing.Size(174, 31);
            this.roletxt.TabIndex = 14;
            this.roletxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profileGV
            // 
            this.profileGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.profileGV.Location = new System.Drawing.Point(253, 156);
            this.profileGV.Name = "profileGV";
            this.profileGV.Size = new System.Drawing.Size(474, 158);
            this.profileGV.TabIndex = 15;
            this.profileGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.profileGV_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // userprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.profileGV);
            this.Controls.Add(this.roletxt);
            this.Controls.Add(this.rolebutton);
            this.Controls.Add(this.numbertxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.registrationbutton);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.locationbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "userprofile";
            this.Text = "userprofile";
            this.Load += new System.EventHandler(this.userprofile_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button locationbutton;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button registrationbutton;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox numbertxt;
        private System.Windows.Forms.Button rolebutton;
        private System.Windows.Forms.TextBox roletxt;
        private System.Windows.Forms.DataGridView profileGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Select;
    }
}