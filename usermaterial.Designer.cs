
namespace final
{
    partial class usermaterial
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
            this.buybutton = new System.Windows.Forms.Button();
            this.namebutton = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.pricebutton = new System.Windows.Forms.Button();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.materialGV = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 107);
            this.panel1.TabIndex = 5;
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
            this.panel2.Controls.Add(this.buybutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 38);
            this.panel2.TabIndex = 6;
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.exitbutton.Location = new System.Drawing.Point(447, 0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(121, 38);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // buybutton
            // 
            this.buybutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buybutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buybutton.FlatAppearance.BorderSize = 0;
            this.buybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buybutton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buybutton.Location = new System.Drawing.Point(208, 0);
            this.buybutton.Name = "buybutton";
            this.buybutton.Size = new System.Drawing.Size(121, 38);
            this.buybutton.TabIndex = 1;
            this.buybutton.Text = "Buy";
            this.buybutton.UseVisualStyleBackColor = false;
            this.buybutton.Click += new System.EventHandler(this.buybutton_Click);
            // 
            // namebutton
            // 
            this.namebutton.FlatAppearance.BorderSize = 0;
            this.namebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebutton.Location = new System.Drawing.Point(49, 128);
            this.namebutton.Name = "namebutton";
            this.namebutton.Size = new System.Drawing.Size(174, 32);
            this.namebutton.TabIndex = 6;
            this.namebutton.Text = "Material Name";
            this.namebutton.UseVisualStyleBackColor = true;
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(49, 166);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(174, 31);
            this.nametxt.TabIndex = 7;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pricebutton
            // 
            this.pricebutton.FlatAppearance.BorderSize = 0;
            this.pricebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pricebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebutton.Location = new System.Drawing.Point(49, 212);
            this.pricebutton.Name = "pricebutton";
            this.pricebutton.Size = new System.Drawing.Size(174, 32);
            this.pricebutton.TabIndex = 8;
            this.pricebutton.Text = "Material Price";
            this.pricebutton.UseVisualStyleBackColor = true;
            // 
            // pricetxt
            // 
            this.pricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(49, 250);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(174, 31);
            this.pricetxt.TabIndex = 9;
            this.pricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricetxt_KeyPress);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(49, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Material Quantity";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytxt.Location = new System.Drawing.Point(49, 335);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(174, 31);
            this.quantitytxt.TabIndex = 11;
            this.quantitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantitytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitytxt_KeyPress);
            // 
            // materialGV
            // 
            this.materialGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.materialGV.Location = new System.Drawing.Point(277, 155);
            this.materialGV.Name = "materialGV";
            this.materialGV.Size = new System.Drawing.Size(463, 211);
            this.materialGV.TabIndex = 13;
            this.materialGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialGV_CellContentClick_1);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // usermaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialGV);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.pricebutton);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.namebutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "usermaterial";
            this.Text = "usermaterial";
            this.Load += new System.EventHandler(this.usermaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buybutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button namebutton;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button pricebutton;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.DataGridView materialGV;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
    }
}