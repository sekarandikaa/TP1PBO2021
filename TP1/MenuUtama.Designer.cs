
namespace TP1
{
    partial class MenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCari = new System.Windows.Forms.Button();
            this.cbxRange = new System.Windows.Forms.ComboBox();
            this.cbxJenis = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnWebCatalog = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flCatalog = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCari);
            this.panel1.Controls.Add(this.cbxRange);
            this.panel1.Controls.Add(this.cbxJenis);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 526);
            this.panel1.TabIndex = 0;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.Black;
            this.btnCari.Location = new System.Drawing.Point(64, 261);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(71, 25);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cbxRange
            // 
            this.cbxRange.BackColor = System.Drawing.Color.SteelBlue;
            this.cbxRange.DropDownHeight = 100;
            this.cbxRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRange.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRange.ForeColor = System.Drawing.Color.White;
            this.cbxRange.FormattingEnabled = true;
            this.cbxRange.IntegralHeight = false;
            this.cbxRange.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.cbxRange.Location = new System.Drawing.Point(12, 223);
            this.cbxRange.MaxDropDownItems = 5;
            this.cbxRange.Name = "cbxRange";
            this.cbxRange.Size = new System.Drawing.Size(176, 21);
            this.cbxRange.TabIndex = 5;
            // 
            // cbxJenis
            // 
            this.cbxJenis.BackColor = System.Drawing.Color.SteelBlue;
            this.cbxJenis.DropDownHeight = 100;
            this.cbxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxJenis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxJenis.ForeColor = System.Drawing.Color.White;
            this.cbxJenis.FormattingEnabled = true;
            this.cbxJenis.IntegralHeight = false;
            this.cbxJenis.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.cbxJenis.Location = new System.Drawing.Point(12, 186);
            this.cbxJenis.MaxDropDownItems = 5;
            this.cbxJenis.Name = "cbxJenis";
            this.cbxJenis.Size = new System.Drawing.Size(176, 21);
            this.cbxJenis.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 49);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sekar Andika Putri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "1903970";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(214, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnWebCatalog
            // 
            this.btnWebCatalog.BackColor = System.Drawing.Color.SteelBlue;
            this.btnWebCatalog.FlatAppearance.BorderSize = 0;
            this.btnWebCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebCatalog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWebCatalog.ForeColor = System.Drawing.Color.White;
            this.btnWebCatalog.Image = ((System.Drawing.Image)(resources.GetObject("btnWebCatalog.Image")));
            this.btnWebCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebCatalog.Location = new System.Drawing.Point(307, 12);
            this.btnWebCatalog.Name = "btnWebCatalog";
            this.btnWebCatalog.Size = new System.Drawing.Size(145, 40);
            this.btnWebCatalog.TabIndex = 2;
            this.btnWebCatalog.Text = "WEB CATALOG";
            this.btnWebCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWebCatalog.UseVisualStyleBackColor = false;
            this.btnWebCatalog.Click += new System.EventHandler(this.btnWebCatalog_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(458, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(2);
            this.btnLogout.Size = new System.Drawing.Size(107, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // flCatalog
            // 
            this.flCatalog.Location = new System.Drawing.Point(216, 84);
            this.flCatalog.Name = "flCatalog";
            this.flCatalog.Size = new System.Drawing.Size(643, 429);
            this.flCatalog.TabIndex = 4;
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(873, 526);
            this.Controls.Add(this.flCatalog);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnWebCatalog);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel1);
            this.Name = "MenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuUtama";
            this.Load += new System.EventHandler(this.MenuUtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWebCatalog;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cbxRange;
        private System.Windows.Forms.ComboBox cbxJenis;
        private System.Windows.Forms.Button btnCari;
        public System.Windows.Forms.FlowLayoutPanel flCatalog;
    }
}