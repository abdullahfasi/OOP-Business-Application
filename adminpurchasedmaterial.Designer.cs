
namespace final
{
    partial class adminpurchasedmaterial
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
            this.materialGV = new System.Windows.Forms.DataGridView();
            this.viewbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialGV)).BeginInit();
            this.SuspendLayout();
            // 
            // materialGV
            // 
            this.materialGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGV.Location = new System.Drawing.Point(135, 73);
            this.materialGV.Name = "materialGV";
            this.materialGV.Size = new System.Drawing.Size(536, 289);
            this.materialGV.TabIndex = 0;
            // 
            // viewbutton
            // 
            this.viewbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbutton.Location = new System.Drawing.Point(135, 386);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(142, 34);
            this.viewbutton.TabIndex = 4;
            this.viewbutton.Text = "View Record";
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(545, 386);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(126, 34);
            this.backbutton.TabIndex = 5;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // adminpurchasedmaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.viewbutton);
            this.Controls.Add(this.materialGV);
            this.Name = "adminpurchasedmaterial";
            this.Text = "adminpurchasedmaterial";
            this.Load += new System.EventHandler(this.adminpurchasedmaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView materialGV;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.Button backbutton;
    }
}