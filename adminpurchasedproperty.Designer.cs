
namespace final
{
    partial class adminpurchasedproperty
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
            this.propertyGV = new System.Windows.Forms.DataGridView();
            this.viewbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGV)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGV
            // 
            this.propertyGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.propertyGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyGV.Location = new System.Drawing.Point(132, 81);
            this.propertyGV.Name = "propertyGV";
            this.propertyGV.Size = new System.Drawing.Size(536, 289);
            this.propertyGV.TabIndex = 1;
            // 
            // viewbutton
            // 
            this.viewbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbutton.Location = new System.Drawing.Point(132, 394);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(147, 34);
            this.viewbutton.TabIndex = 5;
            this.viewbutton.Text = "View Record";
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(542, 394);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(126, 34);
            this.backbutton.TabIndex = 6;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // adminpurchasedproperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.viewbutton);
            this.Controls.Add(this.propertyGV);
            this.Name = "adminpurchasedproperty";
            this.Text = "adminpurchasedproperty";
            ((System.ComponentModel.ISupportInitialize)(this.propertyGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView propertyGV;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.Button backbutton;
    }
}