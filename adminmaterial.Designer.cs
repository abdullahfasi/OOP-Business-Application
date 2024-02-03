
namespace final
{
    partial class adminmaterial
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
            this.namebutton = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.pricebutton = new System.Windows.Forms.Button();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.materialGV = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.quantitytxt = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(800, 100);
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
            // namebutton
            // 
            this.namebutton.FlatAppearance.BorderSize = 0;
            this.namebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebutton.Location = new System.Drawing.Point(28, 125);
            this.namebutton.Name = "namebutton";
            this.namebutton.Size = new System.Drawing.Size(174, 32);
            this.namebutton.TabIndex = 5;
            this.namebutton.Text = "Material Name";
            this.namebutton.UseVisualStyleBackColor = true;
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(28, 163);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(174, 31);
            this.nametxt.TabIndex = 6;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pricebutton
            // 
            this.pricebutton.FlatAppearance.BorderSize = 0;
            this.pricebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pricebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebutton.Location = new System.Drawing.Point(28, 200);
            this.pricebutton.Name = "pricebutton";
            this.pricebutton.Size = new System.Drawing.Size(174, 32);
            this.pricebutton.TabIndex = 7;
            this.pricebutton.Text = "Material Price";
            this.pricebutton.UseVisualStyleBackColor = true;
            // 
            // pricetxt
            // 
            this.pricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(28, 238);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(174, 31);
            this.pricetxt.TabIndex = 8;
            this.pricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricetxt_KeyPress);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Material Quantity";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.exitbutton);
            this.panel2.Controls.Add(this.deletebutton);
            this.panel2.Controls.Add(this.updatebutton);
            this.panel2.Controls.Add(this.addbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 41);
            this.panel2.TabIndex = 11;
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.exitbutton.Location = new System.Drawing.Point(610, 0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(121, 38);
            this.exitbutton.TabIndex = 3;
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
            this.deletebutton.Location = new System.Drawing.Point(433, 3);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(121, 38);
            this.deletebutton.TabIndex = 2;
            this.deletebutton.Text = "DELETE";
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
            this.updatebutton.Location = new System.Drawing.Point(221, 3);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(121, 38);
            this.updatebutton.TabIndex = 1;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addbutton.FlatAppearance.BorderSize = 0;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.addbutton.Location = new System.Drawing.Point(31, 3);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(121, 38);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // materialGV
            // 
            this.materialGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.materialGV.Location = new System.Drawing.Point(268, 142);
            this.materialGV.Name = "materialGV";
            this.materialGV.Size = new System.Drawing.Size(463, 211);
            this.materialGV.TabIndex = 12;
            this.materialGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialGV_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytxt.Location = new System.Drawing.Point(28, 322);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(174, 31);
            this.quantitytxt.TabIndex = 10;
            this.quantitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantitytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitytxt_KeyPress);
            // 
            // adminmaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.pricebutton);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.namebutton);
            this.Controls.Add(this.panel1);
            this.Name = "adminmaterial";
            this.Text = "adminmaterial";
            this.Load += new System.EventHandler(this.adminmaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button namebutton;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button pricebutton;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.DataGridView materialGV;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.TextBox quantitytxt;
    }
}