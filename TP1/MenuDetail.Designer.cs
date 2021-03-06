
namespace TP1
{
    partial class MenuDetail
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.flDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 40);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(93, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detail Produk";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKembali.FlatAppearance.BorderSize = 0;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(128, 358);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(94, 24);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // flDetail
            // 
            this.flDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flDetail.Location = new System.Drawing.Point(75, 130);
            this.flDetail.Name = "flDetail";
            this.flDetail.Size = new System.Drawing.Size(200, 200);
            this.flDetail.TabIndex = 7;
            // 
            // MenuDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.flDetail);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "MenuDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuDetail";
            this.Load += new System.EventHandler(this.MenuDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.FlowLayoutPanel flDetail;
    }
}