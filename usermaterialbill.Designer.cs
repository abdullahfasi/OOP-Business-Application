
namespace final
{
    partial class usermaterialbill
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
            this.billGV = new System.Windows.Forms.DataGridView();
            this.backbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.viewbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billGV)).BeginInit();
            this.SuspendLayout();
            // 
            // billGV
            // 
            this.billGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billGV.Location = new System.Drawing.Point(106, 71);
            this.billGV.Name = "billGV";
            this.billGV.Size = new System.Drawing.Size(539, 258);
            this.billGV.TabIndex = 0;
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(522, 381);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(126, 34);
            this.backbutton.TabIndex = 1;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // viewbutton
            // 
            this.viewbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbutton.Location = new System.Drawing.Point(106, 381);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(126, 34);
            this.viewbutton.TabIndex = 3;
            this.viewbutton.Text = "View Bill";
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // usermaterialbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.billGV);
            this.Name = "usermaterialbill";
            this.Text = "userbill";
            ((System.ComponentModel.ISupportInitialize)(this.billGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView billGV;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button viewbutton;
    }
}